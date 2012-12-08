using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MyProject
{
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
            dlgEditTask = new EditTaskDialog();
            this.FormClosing += new FormClosingEventHandler(ProjectForm_FormClosing);
            addDrawHandlersToNodes();
        }

        /// <summary>
        /// Funkcja dodaje event handler do zmienia koloru
        /// Uwaga, mogą być problemy z kolumnami które nie dziedziczą po BaseTextControl (jak np. checkboxy )
        /// </summary>
        private void addDrawHandlersToNodes()
        {
            foreach (Aga.Controls.Tree.NodeControls.NodeControl nControl in tree.NodeControls)
            {
                try
                {
                    Aga.Controls.Tree.NodeControls.BaseTextControl btx = (Aga.Controls.Tree.NodeControls.BaseTextControl)nControl;
                    btx.DrawText += new EventHandler<Aga.Controls.Tree.NodeControls.DrawEventArgs>(btx_DrawText);
                }
                catch //(InvalidCastException ice)
                {
                    //Console.WriteLine(ice.Message);
                }
            }
        }

        /// <summary>
        /// Funkcja obsługująca zdarzenie DrawText na NodeControlle. Bierze status Tasku i zmienia kolor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btx_DrawText(object sender, Aga.Controls.Tree.NodeControls.DrawEventArgs e)
        {
            
            Task t = e.Node.Tag as Task;
            e.TextColor = t.getFontColor();
            Task.TaskStatus status = Task.TaskStatus.ERROR;
            if (t != null)
            {
                status = t.Status;
            }
        }

        private Color getColorForTask()
        {
            return Color.RosyBrown;
            //TODO
        }

        void ProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                recentList.Save();
            }
            catch
            {
                if (Properties.Settings.Default.AppLocationExceptionShow)
                {
                    DialogResult r = MessageBox.Show("Project cannot save \"recent.xml\". \nCurrent application's directory is not writable."
                        , "MyProject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Properties.Settings.Default.AppLocationExceptionShow = false;
                    Properties.Settings.Default.Save();
                }
            }
            if (!Saved)
            {
                DialogResult r = MessageBox.Show("Project has been changed. \nSave changes?"
                    , "MyProject", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (r)
                {
                    case DialogResult.Yes:
                        tsbSaveProject.PerformClick();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        RecentList recentList;
        EditTaskDialog dlgEditTask;
        Task project;
        TaskTreeModel model;
        //List<Task> projects;
        string path = string.Empty;

        private bool Saved { get { return !tsbSaveProject.Enabled; } set { tsbSaveProject.Enabled = !value; } }

        string filePath = string.Empty;
        string fileName = string.Empty;

        string fileFullName { get { return string.Format("{0}\\{1}", filePath, fileName); } }

        void ProjectFormLoad(object sender, EventArgs e)
        {
            MkNewProject();
            Saved = false;
            recentList = new RecentList();
            recentList.Load();
        }

        void RenderRecentFileList(object sender, EventArgs e)
        {
            if (!recentList.HasChanges) return;

            tsbOpenProject.DropDownItems.Clear();
            //render the list ,old item at last of the menu
            for (int i = recentList.RecentFileList.Count - 1; i >= 0; i--)
            {
                string fileItem = recentList.RecentFileList[i];
                ToolStripMenuItem item = new ToolStripMenuItem(fileItem);
                item.Tag = fileItem;
                item.Click += new EventHandler(item_Click);
                tsbOpenProject.DropDownItems.Add(item);
            }

            recentList.HasChanges = false;
        }

        void item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            string tempFileName = (string)item.Tag;
            OpenProject(tempFileName);
        }

        void OpenProject(string pFileName)
        {
            if (!Saved)
            {
                DialogResult r = MessageBox.Show("Project has been changed. \nSave changes?"
                    , "MyProject", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (r)
                {
                    case DialogResult.Yes:
                        tsbSaveProject.PerformClick();
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            try
            {
                System.Xml.Serialization.XmlSerializer srl = new System.Xml.Serialization.XmlSerializer(typeof(List<Task>));
                System.IO.FileStream file = System.IO.File.OpenRead(pFileName);
                this.model.projects = (List<Task>)srl.Deserialize(file);
                file.Close(); file.Dispose();
                this.tree.Model = this.model;
                SetNodeState();
                RefreshTree();
                fileName = System.IO.Path.GetFileName(pFileName);
                filePath = System.IO.Path.GetDirectoryName(pFileName);
                this.Text = string.Format("MyProject - {0} ({1})", fileName, filePath);
                Saved = true;
                recentList.AddItem(System.IO.Path.GetFullPath(pFileName));
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        void TsbTaskAddClick(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null || tree.SelectedNode.Tag == null) return;

            Task pt = tree.SelectedNode.Tag as Task;
            Task nt = new Task();
            nt.Level = pt.Level + 1;

            Aga.Controls.Tree.TreeNodeAdv project = tree.SelectedNode;
            while ((project.Tag as Task).Level != 0)
            {
                project = project.Parent;
            }

            if (dlgEditTask.ShowEditDialog(nt, project.Tag as Task) != DialogResult.OK) return; ;
            pt.Tasks.Add(nt);

            RefreshTree();

            tree.SelectedNode = tree.FindNodeByTag(nt);
            Saved = false;
        }

        private void tsbTaskEdit_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null || tree.SelectedNode.Tag == null) return;

            Task t = tree.SelectedNode.Tag as Task;
            Aga.Controls.Tree.TreeNodeAdv project = tree.SelectedNode;
            while ((project.Tag as Task).Level != 0)
            {
                project = project.Parent;
            }
            if (dlgEditTask.ShowEditDialog(t, project.Tag as Task) == DialogResult.OK) Saved = false;
        }

        void TsbTaskDeleteClick(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null) return;
            Task pt = tree.SelectedNode.Parent.Tag as Task;
            if (pt == null) return;
            Task dt = tree.SelectedNode.Tag as Task;
            Task new_sel_task = pt;
            if (pt.Tasks.IndexOf(dt) > 1)
                new_sel_task = pt.Tasks[pt.Tasks.IndexOf(dt) - 1];
            pt.Tasks.Remove(dt);
            tree.SelectedNode = tree.FindNodeByTag(new_sel_task);
            RefreshTree();
            Saved = false;
        }

        void RefreshTree()
        {
            Task t = null;
            if (tree.SelectedNode != null)
            {
                t = tree.SelectedNode.Tag as Task;
            }
            SaveNodesState(this.project);
            tree.Model = null;
            tree.Model = this.model;
            //tree.ExpandAll();
            SetNodeState();
            if (t != null)
            {
                tree.SelectedNode = tree.FindNodeByTag(t);
            }
        }

        void TreeKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Insert:
                    TsbTaskAddClick(sender, e);
                    break;
                case Keys.Delete:
                    TsbTaskDeleteClick(sender, e);
                    break;
                case Keys.F5:
                    RefreshTree();
                    break;
            }
        }

        private void tsbSaveAs_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        void SaveProjectClick(object sender, EventArgs e)
        {
            if (Saved) return;
            SaveProject();
        }

        void SaveProject()
        {
            SaveNodesState();
            if (!DefineSavePath() && (string.IsNullOrEmpty(fileFullName) || fileFullName.Length < 4)) return;
            try
            {
                System.Xml.Serialization.XmlSerializer srl = new System.Xml.Serialization.XmlSerializer(typeof(List<Task>));
                System.IO.File.Delete(fileFullName);
                System.IO.FileStream file = System.IO.File.OpenWrite(fileFullName);
                srl.Serialize(file, this.model.projects);
                Saved = true;
                file.Close(); file.Dispose();
                recentList.AddItem(System.IO.Path.GetFullPath(fileFullName));
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        bool DefineSavePath()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = project.Name;
            dlg.DefaultExt = ".prj";
            dlg.Filter = "MyProject files|*.prj|All files|*";
            if (dlg.ShowDialog() != DialogResult.OK) return false;
            fileName = System.IO.Path.GetFileName(dlg.FileName);
            filePath = System.IO.Path.GetDirectoryName(dlg.FileName);
            this.Text = string.Format("MyProject - {0} ({1})", fileName, filePath);
            return true;
        }

        void SaveNodesState() { SaveNodesState(this.project); }

        void SaveNodesState(Task t)
        {
            Aga.Controls.Tree.TreeNodeAdv n = tree.FindNodeByTag(t);
            if (n != null) t.Expanded = n.IsExpanded;
            foreach (Task t1 in t.Tasks) SaveNodesState(t1);
        }

        void SetNodeState()
        {
            foreach (Aga.Controls.Tree.TreeNodeAdv n in tree.AllNodes)
            {
                Task t = n.Tag as Task;
                if (t == null) continue;
                if (t.Expanded)
                    n.Expand(true);
                else
                    n.Collapse(true);
            }
        }

        void OpenProjectClick(object sender, EventArgs e)
        {
            if (!Saved)
            {
                DialogResult r = MessageBox.Show("Project has been changed. \nSave changes?"
                    , "MyProject", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (r)
                {
                    case DialogResult.Yes:
                        tsbSaveProject.PerformClick();
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".prj";
            dlg.Filter = "MyProject files|*.prj|All files|*";
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                System.Xml.Serialization.XmlSerializer srl = new System.Xml.Serialization.XmlSerializer(typeof(List<Task>));
                System.IO.FileStream file = System.IO.File.OpenRead(dlg.FileName);
                this.model.projects = (List<Task>)srl.Deserialize(file);
                file.Close();
                file.Dispose();
                this.tree.Model = this.model;
                SetNodeState();
                RefreshTree();
                fileName = System.IO.Path.GetFileName(dlg.FileName);
                filePath = System.IO.Path.GetDirectoryName(dlg.FileName);
                this.Text = string.Format("MyProject - {0} ({1})", fileName, filePath);
                Saved = true;
                recentList.AddItem(System.IO.Path.GetFullPath(fileName));
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        void RefreshTreeClick(object sender, EventArgs e)
        {
            RefreshTree();
        }

        private void tsbMoveLeft_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null
                || tree.SelectedNode.Tag == null
                || tree.SelectedNode.Parent == null
                || tree.SelectedNode.Parent.Tag == null
                || tree.SelectedNode.Parent.Parent == null
                || tree.SelectedNode.Parent.Parent.Tag == null)
                return;

            Task t = tree.SelectedNode.Tag as Task;
            Task pt = tree.SelectedNode.Parent.Tag as Task;
            Task ppt = tree.SelectedNode.Parent.Parent.Tag as Task;
            if (t == null || ppt == null) return;
            pt.Tasks.Remove(t);
            ChangeLevel(t, false);
            ppt.Tasks.Insert(ppt.Tasks.IndexOf(pt) + 1, t);
            RefreshTree();
            Saved = false;
        }

        private void ChangeLevel(Task t, bool up)
        {
            if (up)
            {
                foreach (Task tt in t.Tasks)
                {
                    tt.Level++;
                    ChangeLevel(tt, true);
                }
            }
            else
            {
                foreach (Task tt in t.Tasks)
                {
                    tt.Level--;
                    ChangeLevel(tt, false);
                }
            }
        }

        private void tsbMoveRight_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null
                || tree.SelectedNode.Tag == null
                || tree.SelectedNode.Parent == null
                || tree.SelectedNode.Parent.Tag == null)
                return;

            Task t = tree.SelectedNode.Tag as Task;
            Task pt = tree.SelectedNode.Parent.Tag as Task;
            if (t == null || pt == null) return;
            int idx = pt.Tasks.IndexOf(t);
            if (idx < 1) return;
            pt.Tasks.Remove(t);
            idx--;
            Task npt = pt.Tasks[idx];
            ChangeLevel(t, true);
            npt.Tasks.Add(t);
            RefreshTree();
            Saved = false;
        }

        private void tsbMoveUp_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null
                || tree.SelectedNode.Tag == null
                || tree.SelectedNode.Parent == null
                || tree.SelectedNode.Parent.Tag == null)
                return;

            Task t = tree.SelectedNode.Tag as Task;
            Task pt = tree.SelectedNode.Parent.Tag as Task;
            if (t == null || pt == null) return;
            int idx = pt.Tasks.IndexOf(t);
            if (idx < 1) return;
            pt.Tasks.Remove(t);
            idx--;
            pt.Tasks.Insert(idx, t);
            RefreshTree();
            Saved = false;
        }

        private void tsbMoveDown_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null
                || tree.SelectedNode.Tag == null
                || tree.SelectedNode.Parent == null
                || tree.SelectedNode.Parent.Tag == null)
                return;

            Task t = tree.SelectedNode.Tag as Task;
            Task pt = tree.SelectedNode.Parent.Tag as Task;
            if (t == null || pt == null) return;
            int idx = pt.Tasks.IndexOf(t);
            if (pt.Tasks.Count <= (idx + 1)) return;
            pt.Tasks.Remove(t);
            idx++;
            pt.Tasks.Insert(idx, t);
            RefreshTree();
            Saved = false;
        }

        private void tsbImport_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null || tree.SelectedNode.Tag == null) return;
            Task t = tree.SelectedNode.Tag as Task;
            if (t == null) return;
            SaveNodesState();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".tsk";
            dlg.Filter = "Task files|*.tsk|All files|*";
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                System.Xml.Serialization.XmlSerializer srl = new System.Xml.Serialization.XmlSerializer(typeof(Task));
                System.IO.FileStream file = System.IO.File.OpenRead(dlg.FileName);
                Task nt = (Task)srl.Deserialize(file);
                file.Close(); file.Dispose();
                t.Tasks.Add(nt);
                nt.Level = t.Level + 1;
                changeChildLevel(nt);
                SetNodeState();
                RefreshTree();
                Saved = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void changeChildLevel(Task t)
        {
            foreach (Task tt in t.Tasks)
            {
                tt.Level = t.Level + 1;
                changeChildLevel(tt);
            }
        }

        private void tsbExport_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null || tree.SelectedNode.Tag == null) return;
            Task t = tree.SelectedNode.Tag as Task;
            if (t == null) return;
            SaveNodesState(t);
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".prj";
            dlg.Filter = "Task files|*.tsk|All files|*";
            dlg.FileName = t.Name;
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                System.Xml.Serialization.XmlSerializer srl = new System.Xml.Serialization.XmlSerializer(typeof(Task));
                System.IO.FileStream file = System.IO.File.OpenWrite(dlg.FileName);
                srl.Serialize(file, t);
                file.Close(); file.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void ProjectForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.S | Keys.Control:
                    tsbSaveProject.PerformClick();
                    break;
                case Keys.Control | Keys.O:
                    tsbOpenProject.PerformClick();
                    break;
                case Keys.Left | Keys.Control:
                    tsbMoveLeft.PerformClick();
                    break;
                case Keys.Right | Keys.Control:
                    tsbMoveRight.PerformClick();
                    break;
                case Keys.Up | Keys.Control:
                    tsbMoveUp.PerformClick();
                    break;
                case Keys.Down | Keys.Control:
                    tsbMoveDown.PerformClick();
                    break;
                case Keys.F2:
                case Keys.Enter:
                    tsbTaskEdit.PerformClick();
                    break;
            }
        }

        private void tsbExportImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (!(this.fileName == null) || !(this.fileName == ""))
            {
                dlg.FileName = this.fileName;
                dlg.FileName = this.fileName.Replace(".prj", ".bmp");
            }
            dlg.Filter = "Bitmap (*bmp) |*.bmp|All files|*.*";
            try
            {
                if (!(dlg.ShowDialog() == DialogResult.OK)) return;
                System.Drawing.Bitmap bmp = new Bitmap(tree.ClientRectangle.Width, tree.ClientRectangle.Height);
                tree.DrawToBitmap(bmp, new Rectangle(0, 0, tree.ClientRectangle.Width, tree.ClientRectangle.Height));
                bmp.Save(dlg.FileName);
                bmp.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }

        private void tsbPrintPreview_Click(object sender, EventArgs e)
        {
            printTasks = new List<Task>();
            nodeNumber = 0;
            foreach (Aga.Controls.Tree.TreeNodeAdv n in tree.AllNodes)
            {
                nodeNumber++;
                printTasks.Add(n.Tag as Task);
            }
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_PrintPage);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        int nodeNumber = 0;
        List<Task> printTasks = null;
        //int ident = 0;
        int printTaskIndex = 0;
        SolidBrush brush = new SolidBrush(Color.Black);

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (printTaskIndex >= nodeNumber)
            {
                printTaskIndex = 0;
            }
            int linePerPage = Convert.ToInt32(e.PageBounds.Height / tree.Font.Height);
            for (int i = 0; i < linePerPage; i++)
            {
                Task t = printTasks[printTaskIndex];
                pd_PrintTask(t, e, i);
                printTaskIndex++;
                if (printTaskIndex == linePerPage)
                {
                    e.HasMorePages = true;
                    return;
                }
                if (printTaskIndex == nodeNumber)
                {
                    e.HasMorePages = false;
                    return;
                }
            }
            e.HasMorePages = true;
        }

        private void pd_PrintTask(Task t, PrintPageEventArgs e, int i)
        {
            e.Graphics.DrawString(t.Name + "   " + t.Duration + "   " + t.Start + "   " + t.End + "   " + t.Progress + "%   " + t.Priority + "   " + t.Description, tree.Font, brush,
                    new PointF(t.Level * (float)tree.Font.Size, i * (float)tree.Font.Height), StringFormat.GenericTypographic);
        }

        private void tsbNewProject_Click(object sender, EventArgs e)
        {
            if (!Saved)
            {
                DialogResult r = MessageBox.Show("Project has been changed. \nSave changes?"
                    , "MyProject", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (r)
                {
                    case DialogResult.Yes:
                        tsbSaveProject.PerformClick();
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            MkNewProject(); Saved = false;
        }

        private void MkNewProject()
        {
            project = new Task();
            project.Name = "New Project";
            model = new TaskTreeModel(project);
            tree.Model = model;
        }

        private void tree_DoubleClick(object sender, EventArgs e)
        {
            tsbTaskEdit.PerformClick();
        }

        private void tsbAddProject_Click(object sender, EventArgs e)
        {
            Task nt = new Task();
            if (dlgEditTask.ShowEditDialog(nt, nt) != DialogResult.OK) return; ;
            model.AddProject(nt);
            RefreshTree();

            tree.SelectedNode = tree.FindNodeByTag(nt);
            Saved = false;
        }

        private void tsbDeleteProj_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode == null || tree.SelectedNode.Parent.Parent != null)
                return;
            else
            {
                var ind = tree.SelectedNode.Index;
                model.projects.RemoveAt(ind);
                RefreshTree();
                Saved = false;

            }
        }

        private void addProjectProjectFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbAddProject_Click(sender, e);
        }

        private void removeProjectProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbDeleteProj_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved) return;
            SaveProject();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbExport_Click(sender, e);
        }

        private void importProjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tsbImport_Click(sender, e);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tsbPrintPreview_Click(sender, e);
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RefreshTree();
        }

        private void addProjectFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tsbNewProject_Click(sender, e);
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TsbTaskAddClick(sender, e);
        }

        private void editTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbTaskEdit_Click(sender, e);
        }

        private void removeTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TsbTaskDeleteClick(sender, e);
        }

        private void moveRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbMoveRight_Click(sender, e);
        }

        private void moveLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbMoveLeft_Click(sender, e);
        }

        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbMoveUp_Click(sender, e);
        }

        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbMoveDown_Click(sender, e);
        }

        private void saveAstProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProjectClick(sender, e);
        }
    }
}