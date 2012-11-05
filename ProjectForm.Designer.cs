namespace MyProject
{
    partial class ProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewProject = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenProject = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbSaveProject = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tsbExportImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTaskAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbTaskEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbTaskDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMoveLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveRight = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbAddProject = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteProj = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tree = new Aga.Controls.Tree.TreeViewAdv();
            this.name = new Aga.Controls.Tree.TreeColumn();
            this.duration = new Aga.Controls.Tree.TreeColumn();
            this.start = new Aga.Controls.Tree.TreeColumn();
            this.end = new Aga.Controls.Tree.TreeColumn();
            this.ok = new Aga.Controls.Tree.TreeColumn();
            this.progress = new Aga.Controls.Tree.TreeColumn();
            this.priority = new Aga.Controls.Tree.TreeColumn();
            this.description = new Aga.Controls.Tree.TreeColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripMenuItem();
            this.nchOk = new Aga.Controls.Tree.NodeControls.NodeCheckBox();
            this.nitxtDuration = new Aga.Controls.Tree.NodeControls.NodeIntegerTextBox();
            this.ntxtStart = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntxtEnd = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nitxtProgress = new Aga.Controls.Tree.NodeControls.NodeIntegerTextBox();
            this.txtPriority = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntxtDescription = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntxtName = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewProject,
            this.tsbOpenProject,
            this.tsbSaveProject,
            this.tsbSaveAs,
            this.tsbExportImage,
            this.toolStripButton4,
            this.tsbTaskAdd,
            this.tsbTaskEdit,
            this.tsbTaskDelete,
            this.toolStripSeparator1,
            this.tsbRefresh,
            this.toolStripSeparator2,
            this.tsbMoveLeft,
            this.tsbMoveRight,
            this.tsbMoveUp,
            this.tsbMoveDown,
            this.toolStripSeparator3,
            this.tsbImport,
            this.tsbExport,
            this.toolStripSeparator4,
            this.tsbPrintPreview,
            this.tsbAddProject,
            this.tsbDeleteProj});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewProject
            // 
            this.tsbNewProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewProject.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewProject.Image")));
            this.tsbNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewProject.Name = "tsbNewProject";
            this.tsbNewProject.Size = new System.Drawing.Size(23, 22);
            this.tsbNewProject.Text = "New Project File";
            this.tsbNewProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbNewProject.ToolTipText = "New Project File";
            this.tsbNewProject.Click += new System.EventHandler(this.tsbNewProject_Click);
            // 
            // tsbOpenProject
            // 
            this.tsbOpenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenProject.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenProject.Image")));
            this.tsbOpenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenProject.Name = "tsbOpenProject";
            this.tsbOpenProject.Size = new System.Drawing.Size(32, 22);
            this.tsbOpenProject.ButtonClick += new System.EventHandler(this.OpenProjectClick);
            this.tsbOpenProject.DropDownOpening += new System.EventHandler(this.RenderRecentFileList);
            // 
            // tsbSaveProject
            // 
            this.tsbSaveProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveProject.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveProject.Image")));
            this.tsbSaveProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveProject.Name = "tsbSaveProject";
            this.tsbSaveProject.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveProject.Text = "Save Project";
            this.tsbSaveProject.ToolTipText = "Save Project (Ctrl+s)";
            this.tsbSaveProject.Click += new System.EventHandler(this.SaveProjectClick);
            // 
            // tsbSaveAs
            // 
            this.tsbSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAs.Image")));
            this.tsbSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAs.Name = "tsbSaveAs";
            this.tsbSaveAs.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveAs.Text = "Save Project As";
            this.tsbSaveAs.Click += new System.EventHandler(this.tsbSaveAs_Click);
            // 
            // tsbExportImage
            // 
            this.tsbExportImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportImage.Image = ((System.Drawing.Image)(resources.GetObject("tsbExportImage.Image")));
            this.tsbExportImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportImage.Name = "tsbExportImage";
            this.tsbExportImage.Size = new System.Drawing.Size(23, 22);
            this.tsbExportImage.Text = "Export as image";
            this.tsbExportImage.Click += new System.EventHandler(this.tsbExportImage_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbTaskAdd
            // 
            this.tsbTaskAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTaskAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbTaskAdd.Image")));
            this.tsbTaskAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTaskAdd.Name = "tsbTaskAdd";
            this.tsbTaskAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbTaskAdd.Text = "Add Task";
            this.tsbTaskAdd.ToolTipText = "Add Task (Insert)";
            this.tsbTaskAdd.Click += new System.EventHandler(this.TsbTaskAddClick);
            // 
            // tsbTaskEdit
            // 
            this.tsbTaskEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTaskEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbTaskEdit.Image")));
            this.tsbTaskEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTaskEdit.Name = "tsbTaskEdit";
            this.tsbTaskEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbTaskEdit.Text = "Task Edit";
            this.tsbTaskEdit.ToolTipText = "Task Edit (F2)";
            this.tsbTaskEdit.Click += new System.EventHandler(this.tsbTaskEdit_Click);
            // 
            // tsbTaskDelete
            // 
            this.tsbTaskDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTaskDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbTaskDelete.Image")));
            this.tsbTaskDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTaskDelete.Name = "tsbTaskDelete";
            this.tsbTaskDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbTaskDelete.Text = "Task Delete";
            this.tsbTaskDelete.ToolTipText = "Task Delete (Delete)";
            this.tsbTaskDelete.Click += new System.EventHandler(this.TsbTaskDeleteClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.ToolTipText = "Refresh (F5)";
            this.tsbRefresh.Click += new System.EventHandler(this.RefreshTreeClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbMoveLeft
            // 
            this.tsbMoveLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveLeft.Image")));
            this.tsbMoveLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveLeft.Name = "tsbMoveLeft";
            this.tsbMoveLeft.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveLeft.Text = "Move Left";
            this.tsbMoveLeft.Click += new System.EventHandler(this.tsbMoveLeft_Click);
            // 
            // tsbMoveRight
            // 
            this.tsbMoveRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveRight.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveRight.Image")));
            this.tsbMoveRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveRight.Name = "tsbMoveRight";
            this.tsbMoveRight.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveRight.Text = "Move Right";
            this.tsbMoveRight.Click += new System.EventHandler(this.tsbMoveRight_Click);
            // 
            // tsbMoveUp
            // 
            this.tsbMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveUp.Image")));
            this.tsbMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveUp.Name = "tsbMoveUp";
            this.tsbMoveUp.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveUp.Text = "Move Up";
            this.tsbMoveUp.Click += new System.EventHandler(this.tsbMoveUp_Click);
            // 
            // tsbMoveDown
            // 
            this.tsbMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveDown.Image")));
            this.tsbMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveDown.Name = "tsbMoveDown";
            this.tsbMoveDown.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveDown.Text = "Move Down";
            this.tsbMoveDown.Click += new System.EventHandler(this.tsbMoveDown_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbImport
            // 
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImport.Image = ((System.Drawing.Image)(resources.GetObject("tsbImport.Image")));
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(23, 22);
            this.tsbImport.Text = "Import Project";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(23, 22);
            this.tsbExport.Text = "Export Task as Project (Save to file)";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPrintPreview
            // 
            this.tsbPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintPreview.Image")));
            this.tsbPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintPreview.Name = "tsbPrintPreview";
            this.tsbPrintPreview.Size = new System.Drawing.Size(23, 22);
            this.tsbPrintPreview.Text = "Print Preview";
            this.tsbPrintPreview.Click += new System.EventHandler(this.tsbPrintPreview_Click);
            // 
            // tsbAddProject
            // 
            this.tsbAddProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddProject.Image = global::MyProject.Properties.Resources.Image1;
            this.tsbAddProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddProject.Name = "tsbAddProject";
            this.tsbAddProject.Size = new System.Drawing.Size(23, 22);
            this.tsbAddProject.Text = "Add project";
            this.tsbAddProject.Click += new System.EventHandler(this.tsbAddProject_Click);
            // 
            // tsbDeleteProj
            // 
            this.tsbDeleteProj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteProj.Image = global::MyProject.Properties.Resources.delete;
            this.tsbDeleteProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteProj.Name = "tsbDeleteProj";
            this.tsbDeleteProj.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteProj.Text = "Delete project";
            this.tsbDeleteProj.Click += new System.EventHandler(this.tsbDeleteProj_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 426);
            this.panel1.TabIndex = 2;
            // 
            // tree
            // 
            this.tree.AutoRowHeight = true;
            this.tree.BackColor = System.Drawing.SystemColors.Window;
            this.tree.Columns.Add(this.name);
            this.tree.Columns.Add(this.duration);
            this.tree.Columns.Add(this.start);
            this.tree.Columns.Add(this.end);
            this.tree.Columns.Add(this.ok);
            this.tree.Columns.Add(this.progress);
            this.tree.Columns.Add(this.priority);
            this.tree.Columns.Add(this.description);
            this.tree.ContextMenuStrip = this.contextMenuStrip1;
            this.tree.DefaultToolTipProvider = null;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.DragDropMarkColor = System.Drawing.Color.Black;
            this.tree.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tree.FullRowSelect = true;
            this.tree.GridLineStyle = ((Aga.Controls.Tree.GridLineStyle)((Aga.Controls.Tree.GridLineStyle.Horizontal | Aga.Controls.Tree.GridLineStyle.Vertical)));
            this.tree.LineColor = System.Drawing.SystemColors.Control;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Model = null;
            this.tree.Name = "tree";
            this.tree.NodeControls.Add(this.nchOk);
            this.tree.NodeControls.Add(this.nitxtDuration);
            this.tree.NodeControls.Add(this.ntxtStart);
            this.tree.NodeControls.Add(this.ntxtEnd);
            this.tree.NodeControls.Add(this.nitxtProgress);
            this.tree.NodeControls.Add(this.txtPriority);
            this.tree.NodeControls.Add(this.ntxtDescription);
            this.tree.NodeControls.Add(this.ntxtName);
            this.tree.SelectedNode = null;
            this.tree.ShowNodeToolTips = true;
            this.tree.Size = new System.Drawing.Size(797, 426);
            this.tree.TabIndex = 0;
            this.tree.Text = "tree";
            this.tree.UseColumns = true;
            this.tree.DoubleClick += new System.EventHandler(this.tree_DoubleClick);
            this.tree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreeKeyDown);
            // 
            // name
            // 
            this.name.Header = "Project/Task Name";
            this.name.SortOrder = System.Windows.Forms.SortOrder.None;
            this.name.TooltipText = null;
            this.name.Width = 230;
            // 
            // duration
            // 
            this.duration.Header = "Duration";
            this.duration.SortOrder = System.Windows.Forms.SortOrder.None;
            this.duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.duration.TooltipText = null;
            this.duration.Width = 55;
            // 
            // start
            // 
            this.start.Header = "Start";
            this.start.SortOrder = System.Windows.Forms.SortOrder.None;
            this.start.TooltipText = null;
            this.start.Width = 80;
            // 
            // end
            // 
            this.end.Header = "End";
            this.end.SortOrder = System.Windows.Forms.SortOrder.None;
            this.end.TooltipText = null;
            this.end.Width = 80;
            // 
            // ok
            // 
            this.ok.Header = "ok";
            this.ok.SortOrder = System.Windows.Forms.SortOrder.None;
            this.ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ok.TooltipText = null;
            this.ok.Width = 30;
            // 
            // progress
            // 
            this.progress.Header = "Progress";
            this.progress.SortOrder = System.Windows.Forms.SortOrder.None;
            this.progress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.progress.TooltipText = null;
            this.progress.Width = 70;
            // 
            // priority
            // 
            this.priority.Header = "Priority";
            this.priority.SortOrder = System.Windows.Forms.SortOrder.None;
            this.priority.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priority.TooltipText = null;
            this.priority.Width = 80;
            // 
            // description
            // 
            this.description.Header = "Description";
            this.description.SortOrder = System.Windows.Forms.SortOrder.None;
            this.description.TooltipText = null;
            this.description.Width = 500;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator6,
            this.toolStripButton9,
            this.toolStripButton10});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(257, 214);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.ShortcutKeyDisplayString = "Insert";
            this.toolStripButton1.Size = new System.Drawing.Size(256, 22);
            this.toolStripButton1.Text = "Add Task";
            this.toolStripButton1.ToolTipText = "Add Task (Insert)";
            this.toolStripButton1.Click += new System.EventHandler(this.TsbTaskAddClick);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.ShortcutKeyDisplayString = "F2";
            this.toolStripButton2.Size = new System.Drawing.Size(256, 22);
            this.toolStripButton2.Text = "Task Edit";
            this.toolStripButton2.ToolTipText = "Task Edit (F2)";
            this.toolStripButton2.Click += new System.EventHandler(this.tsbTaskEdit_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.ShortcutKeyDisplayString = "Delete";
            this.toolStripButton3.Size = new System.Drawing.Size(256, 22);
            this.toolStripButton3.Text = "Task Delete";
            this.toolStripButton3.ToolTipText = "Task Delete (Delete)";
            this.toolStripButton3.Click += new System.EventHandler(this.TsbTaskDeleteClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(256, 22);
            this.toolStripButton5.Text = "Move Left";
            this.toolStripButton5.Click += new System.EventHandler(this.tsbMoveLeft_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(256, 22);
            this.toolStripButton6.Text = "Move Right";
            this.toolStripButton6.Click += new System.EventHandler(this.tsbMoveRight_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(256, 22);
            this.toolStripButton7.Text = "Move Up";
            this.toolStripButton7.Click += new System.EventHandler(this.tsbMoveUp_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(256, 22);
            this.toolStripButton8.Text = "Move Down";
            this.toolStripButton8.Click += new System.EventHandler(this.tsbMoveDown_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(256, 22);
            this.toolStripButton9.Text = "Import Project";
            this.toolStripButton9.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(256, 22);
            this.toolStripButton10.Text = "Export Task as Project (Seve to file)";
            this.toolStripButton10.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // nchOk
            // 
            this.nchOk.DataPropertyName = "Completed";
            this.nchOk.LeftMargin = 0;
            this.nchOk.ParentColumn = this.ok;
            // 
            // nitxtDuration
            // 
            this.nitxtDuration.AllowNegativeSign = false;
            this.nitxtDuration.DataPropertyName = "Duration";
            this.nitxtDuration.EditEnabled = false;
            this.nitxtDuration.EditOnClick = true;
            this.nitxtDuration.IncrementalSearchEnabled = true;
            this.nitxtDuration.LeftMargin = 3;
            this.nitxtDuration.ParentColumn = this.duration;
            this.nitxtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ntxtStart
            // 
            this.ntxtStart.DataPropertyName = "Start";
            this.ntxtStart.EditEnabled = false;
            this.ntxtStart.IncrementalSearchEnabled = true;
            this.ntxtStart.LeftMargin = 3;
            this.ntxtStart.ParentColumn = this.start;
            this.ntxtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ntxtEnd
            // 
            this.ntxtEnd.DataPropertyName = "End";
            this.ntxtEnd.EditEnabled = false;
            this.ntxtEnd.IncrementalSearchEnabled = true;
            this.ntxtEnd.LeftMargin = 3;
            this.ntxtEnd.ParentColumn = this.end;
            this.ntxtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nitxtProgress
            // 
            this.nitxtProgress.AllowNegativeSign = false;
            this.nitxtProgress.DataPropertyName = "Progress";
            this.nitxtProgress.EditEnabled = false;
            this.nitxtProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nitxtProgress.IncrementalSearchEnabled = true;
            this.nitxtProgress.LeftMargin = 3;
            this.nitxtProgress.ParentColumn = this.progress;
            this.nitxtProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPriority
            // 
            this.txtPriority.DataPropertyName = "Priority";
            this.txtPriority.EditEnabled = false;
            this.txtPriority.IncrementalSearchEnabled = true;
            this.txtPriority.LeftMargin = 3;
            this.txtPriority.ParentColumn = this.priority;
            this.txtPriority.Trimming = System.Drawing.StringTrimming.Word;
            // 
            // ntxtDescription
            // 
            this.ntxtDescription.DataPropertyName = "Description";
            this.ntxtDescription.EditEnabled = false;
            this.ntxtDescription.IncrementalSearchEnabled = true;
            this.ntxtDescription.LeftMargin = 3;
            this.ntxtDescription.ParentColumn = this.description;
            this.ntxtDescription.Trimming = System.Drawing.StringTrimming.Word;
            // 
            // ntxtName
            // 
            this.ntxtName.DataPropertyName = "Name";
            this.ntxtName.IncrementalSearchEnabled = true;
            this.ntxtName.LeftMargin = 3;
            this.ntxtName.ParentColumn = this.name;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyProject";
            this.Load += new System.EventHandler(this.ProjectFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProjectForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private Aga.Controls.Tree.NodeControls.NodeIntegerTextBox nitxtDuration;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbSaveProject;
        private System.Windows.Forms.ToolStripButton tsbNewProject;
        private System.Windows.Forms.ToolStripButton tsbTaskDelete;
        private System.Windows.Forms.ToolStripButton tsbTaskEdit;
        private System.Windows.Forms.ToolStripButton tsbTaskAdd;
        private Aga.Controls.Tree.NodeControls.NodeTextBox txtPriority;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntxtDescription;
        private Aga.Controls.Tree.NodeControls.NodeIntegerTextBox nitxtProgress;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntxtEnd;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntxtStart;
        private Aga.Controls.Tree.NodeControls.NodeCheckBox nchOk;
        private Aga.Controls.Tree.TreeViewAdv tree;
        private Aga.Controls.Tree.TreeColumn description;
        private Aga.Controls.Tree.TreeColumn progress;
        private Aga.Controls.Tree.TreeColumn end;
        private Aga.Controls.Tree.TreeColumn start;
        private Aga.Controls.Tree.TreeColumn duration;
        private Aga.Controls.Tree.TreeColumn name;
        private Aga.Controls.Tree.TreeColumn ok;
        private Aga.Controls.Tree.TreeColumn priority;

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbMoveLeft;
        private System.Windows.Forms.ToolStripButton tsbMoveRight;
        private System.Windows.Forms.ToolStripButton tsbMoveUp;
        private System.Windows.Forms.ToolStripButton tsbMoveDown;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton tsbSaveAs;
        private System.Windows.Forms.ToolStripButton tsbExportImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbPrintPreview;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton6;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton7;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton9;
        private System.Windows.Forms.ToolStripMenuItem toolStripButton10;
        private System.Windows.Forms.ToolStripSplitButton tsbOpenProject;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntxtName;
        private System.Windows.Forms.ToolStripButton tsbAddProject;
        private System.Windows.Forms.ToolStripButton tsbDeleteProj;
    }
}