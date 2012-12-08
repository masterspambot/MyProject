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
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tree = new Aga.Controls.Tree.TreeViewAdv();
            this.name = new Aga.Controls.Tree.TreeColumn();
            this.duration = new Aga.Controls.Tree.TreeColumn();
            this.start = new Aga.Controls.Tree.TreeColumn();
            this.end = new Aga.Controls.Tree.TreeColumn();
            this.ok = new Aga.Controls.Tree.TreeColumn();
            this.progress = new Aga.Controls.Tree.TreeColumn();
            this.priority = new Aga.Controls.Tree.TreeColumn();
            this.assigned = new Aga.Controls.Tree.TreeColumn();
            this.description = new Aga.Controls.Tree.TreeColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.nchOk = new Aga.Controls.Tree.NodeControls.NodeCheckBox();
            this.nitxtDuration = new Aga.Controls.Tree.NodeControls.NodeIntegerTextBox();
            this.ntxtStart = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntxtEnd = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nitxtProgress = new Aga.Controls.Tree.NodeControls.NodeIntegerTextBox();
            this.txtPriority = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntxtDescription = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntxtName = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.ntxtAssigned = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbNewProject = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenProject = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbSaveProject = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAs = new System.Windows.Forms.ToolStripButton();
            this.tsbExportImage = new System.Windows.Forms.ToolStripButton();
            this.tsbTaskAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbTaskEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbTaskDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveRight = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveDown = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbAddProject = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteProj = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectProjectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProjectProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1013, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 395);
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
            this.tree.Columns.Add(this.assigned);
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
            this.tree.NodeControls.Add(this.ntxtAssigned);
            this.tree.SelectedNode = null;
            this.tree.ShowNodeToolTips = true;
            this.tree.Size = new System.Drawing.Size(1013, 395);
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
            this.ok.Header = "Completed";
            this.ok.SortOrder = System.Windows.Forms.SortOrder.None;
            this.ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ok.TooltipText = null;
            this.ok.Width = 80;
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
            // assigned
            // 
            this.assigned.Header = "Assigned";
            this.assigned.SortOrder = System.Windows.Forms.SortOrder.None;
            this.assigned.TooltipText = null;
            this.assigned.Width = 150;
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
            this.toolStripSeparator6});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 170);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(253, 6);
            // 
            // nchOk
            // 
            this.nchOk.DataPropertyName = "Completed";
            this.nchOk.LeftMargin = 35;
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
            // ntxtAssigned
            // 
            this.ntxtAssigned.DataPropertyName = "Assigned";
            this.ntxtAssigned.IncrementalSearchEnabled = true;
            this.ntxtAssigned.LeftMargin = 3;
            this.ntxtAssigned.ParentColumn = this.assigned;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1013, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.projectToolStripMenuItem,
            this.taskToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskToolStripMenuItem,
            this.editTaskToolStripMenuItem,
            this.removeTaskToolStripMenuItem,
            this.toolStripSeparator7,
            this.moveRightToolStripMenuItem,
            this.moveLeftToolStripMenuItem,
            this.toolStripSeparator9,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem});
            this.taskToolStripMenuItem.Image = global::MyProject.Properties.Resources.box;
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::MyProject.Properties.Resources.box_add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.ShortcutKeyDisplayString = "Insert";
            this.toolStripButton1.Size = new System.Drawing.Size(174, 22);
            this.toolStripButton1.Text = "Add Task";
            this.toolStripButton1.ToolTipText = "Add Task (Insert)";
            this.toolStripButton1.Click += new System.EventHandler(this.TsbTaskAddClick);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::MyProject.Properties.Resources.box_edit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.ShortcutKeyDisplayString = "F2";
            this.toolStripButton2.Size = new System.Drawing.Size(174, 22);
            this.toolStripButton2.Text = "Task Edit";
            this.toolStripButton2.ToolTipText = "Task Edit (F2)";
            this.toolStripButton2.Click += new System.EventHandler(this.tsbTaskEdit_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::MyProject.Properties.Resources.box_remove;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.ShortcutKeyDisplayString = "Delete";
            this.toolStripButton3.Size = new System.Drawing.Size(174, 22);
            this.toolStripButton3.Text = "Task Delete";
            this.toolStripButton3.ToolTipText = "Task Delete (Delete)";
            this.toolStripButton3.Click += new System.EventHandler(this.TsbTaskDeleteClick);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::MyProject.Properties.Resources.arrow_medium_right;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(174, 22);
            this.toolStripButton5.Text = "Move Left";
            this.toolStripButton5.Click += new System.EventHandler(this.tsbMoveLeft_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::MyProject.Properties.Resources.arrow_medium_left;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(174, 22);
            this.toolStripButton6.Text = "Move Right";
            this.toolStripButton6.Click += new System.EventHandler(this.tsbMoveRight_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::MyProject.Properties.Resources.arrow_medium_down;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(174, 22);
            this.toolStripButton7.Text = "Move Up";
            this.toolStripButton7.Click += new System.EventHandler(this.tsbMoveUp_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::MyProject.Properties.Resources.arrow_medium_up;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(174, 22);
            this.toolStripButton8.Text = "Move Down";
            this.toolStripButton8.Click += new System.EventHandler(this.tsbMoveDown_Click);
            // 
            // tsbNewProject
            // 
            this.tsbNewProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewProject.Image = global::MyProject.Properties.Resources.hcard_new;
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
            this.tsbOpenProject.Image = global::MyProject.Properties.Resources.folder_classic_opened;
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
            // tsbTaskAdd
            // 
            this.tsbTaskAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTaskAdd.Image = global::MyProject.Properties.Resources.box_add;
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
            this.tsbTaskEdit.Image = global::MyProject.Properties.Resources.box_edit;
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
            this.tsbTaskDelete.Image = global::MyProject.Properties.Resources.box_remove;
            this.tsbTaskDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTaskDelete.Name = "tsbTaskDelete";
            this.tsbTaskDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbTaskDelete.Text = "Task Delete";
            this.tsbTaskDelete.ToolTipText = "Task Delete (Delete)";
            this.tsbTaskDelete.Click += new System.EventHandler(this.TsbTaskDeleteClick);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::MyProject.Properties.Resources.refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.ToolTipText = "Refresh (F5)";
            this.tsbRefresh.Click += new System.EventHandler(this.RefreshTreeClick);
            // 
            // tsbMoveLeft
            // 
            this.tsbMoveLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveLeft.Image = global::MyProject.Properties.Resources.arrow_medium_left;
            this.tsbMoveLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveLeft.Name = "tsbMoveLeft";
            this.tsbMoveLeft.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveLeft.Text = "Move Left";
            this.tsbMoveLeft.Click += new System.EventHandler(this.tsbMoveLeft_Click);
            // 
            // tsbMoveRight
            // 
            this.tsbMoveRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveRight.Image = global::MyProject.Properties.Resources.arrow_medium_right;
            this.tsbMoveRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveRight.Name = "tsbMoveRight";
            this.tsbMoveRight.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveRight.Text = "Move Right";
            this.tsbMoveRight.Click += new System.EventHandler(this.tsbMoveRight_Click);
            // 
            // tsbMoveUp
            // 
            this.tsbMoveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveUp.Image = global::MyProject.Properties.Resources.arrow_medium_up;
            this.tsbMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveUp.Name = "tsbMoveUp";
            this.tsbMoveUp.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveUp.Text = "Move Up";
            this.tsbMoveUp.Click += new System.EventHandler(this.tsbMoveUp_Click);
            // 
            // tsbMoveDown
            // 
            this.tsbMoveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveDown.Image = global::MyProject.Properties.Resources.arrow_medium_down;
            this.tsbMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveDown.Name = "tsbMoveDown";
            this.tsbMoveDown.Size = new System.Drawing.Size(23, 22);
            this.tsbMoveDown.Text = "Move Down";
            this.tsbMoveDown.Click += new System.EventHandler(this.tsbMoveDown_Click);
            // 
            // tsbImport
            // 
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImport.Image = global::MyProject.Properties.Resources.document_letter_download;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(23, 22);
            this.tsbImport.Text = "Import Project";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Image = global::MyProject.Properties.Resources.document_letter_upload;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(23, 22);
            this.tsbExport.Text = "Export Task as Project (Save to file)";
            this.tsbExport.Click += new System.EventHandler(this.tsbExport_Click);
            // 
            // tsbPrintPreview
            // 
            this.tsbPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrintPreview.Image = global::MyProject.Properties.Resources.printer;
            this.tsbPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintPreview.Name = "tsbPrintPreview";
            this.tsbPrintPreview.Size = new System.Drawing.Size(23, 22);
            this.tsbPrintPreview.Text = "Print Preview";
            this.tsbPrintPreview.Click += new System.EventHandler(this.tsbPrintPreview_Click);
            // 
            // tsbAddProject
            // 
            this.tsbAddProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddProject.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddProject.Image")));
            this.tsbAddProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddProject.Name = "tsbAddProject";
            this.tsbAddProject.Size = new System.Drawing.Size(23, 22);
            this.tsbAddProject.Text = "Add project";
            this.tsbAddProject.Click += new System.EventHandler(this.tsbAddProject_Click);
            // 
            // tsbDeleteProj
            // 
            this.tsbDeleteProj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteProj.Image = global::MyProject.Properties.Resources.application_osx_remove;
            this.tsbDeleteProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteProj.Name = "tsbDeleteProj";
            this.tsbDeleteProj.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteProj.Text = "Delete project";
            this.tsbDeleteProj.Click += new System.EventHandler(this.tsbDeleteProj_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsProjectToolStripMenuItem,
            this.importProjectToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::MyProject.Properties.Resources.document_letter_blank;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::MyProject.Properties.Resources.folder_classic_opened;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::MyProject.Properties.Resources.document_a4_new;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsProjectToolStripMenuItem
            // 
            this.saveAsProjectToolStripMenuItem.Image = global::MyProject.Properties.Resources.documents_new;
            this.saveAsProjectToolStripMenuItem.Name = "saveAsProjectToolStripMenuItem";
            this.saveAsProjectToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.saveAsProjectToolStripMenuItem.Text = "Save As ";
            this.saveAsProjectToolStripMenuItem.Click += new System.EventHandler(this.saveAstProjectToolStripMenuItem_Click);
            // 
            // importProjectToolStripMenuItem
            // 
            this.importProjectToolStripMenuItem.Image = global::MyProject.Properties.Resources.document_letter_download;
            this.importProjectToolStripMenuItem.Name = "importProjectToolStripMenuItem";
            this.importProjectToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.importProjectToolStripMenuItem.Text = "Import";
            this.importProjectToolStripMenuItem.Click += new System.EventHandler(this.importProjectToolStripMenuItem_Click_1);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::MyProject.Properties.Resources.document_letter_upload;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectProjectFileToolStripMenuItem,
            this.removeProjectProjectToolStripMenuItem,
            this.addProjectFileToolStripMenuItem1,
            this.toolStripSeparator8,
            this.refreshToolStripMenuItem1,
            this.printToolStripMenuItem2});
            this.projectToolStripMenuItem.Image = global::MyProject.Properties.Resources.application_osx;
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // addProjectProjectFileToolStripMenuItem
            // 
            this.addProjectProjectFileToolStripMenuItem.Image = global::MyProject.Properties.Resources.application_osx_add;
            this.addProjectProjectFileToolStripMenuItem.Name = "addProjectProjectFileToolStripMenuItem";
            this.addProjectProjectFileToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addProjectProjectFileToolStripMenuItem.Text = "Add project";
            this.addProjectProjectFileToolStripMenuItem.Click += new System.EventHandler(this.addProjectProjectFileToolStripMenuItem_Click);
            // 
            // removeProjectProjectToolStripMenuItem
            // 
            this.removeProjectProjectToolStripMenuItem.Image = global::MyProject.Properties.Resources.application_osx_remove;
            this.removeProjectProjectToolStripMenuItem.Name = "removeProjectProjectToolStripMenuItem";
            this.removeProjectProjectToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.removeProjectProjectToolStripMenuItem.Text = "Remove project";
            this.removeProjectProjectToolStripMenuItem.Click += new System.EventHandler(this.removeProjectProjectToolStripMenuItem_Click);
            // 
            // addProjectFileToolStripMenuItem1
            // 
            this.addProjectFileToolStripMenuItem1.Image = global::MyProject.Properties.Resources.hcard_new;
            this.addProjectFileToolStripMenuItem1.Name = "addProjectFileToolStripMenuItem1";
            this.addProjectFileToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.addProjectFileToolStripMenuItem1.Text = "Add project file";
            this.addProjectFileToolStripMenuItem1.Click += new System.EventHandler(this.addProjectFileToolStripMenuItem1_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(154, 6);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Image = global::MyProject.Properties.Resources.refresh;
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // printToolStripMenuItem2
            // 
            this.printToolStripMenuItem2.Image = global::MyProject.Properties.Resources.printer;
            this.printToolStripMenuItem2.Name = "printToolStripMenuItem2";
            this.printToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.printToolStripMenuItem2.Text = "Print";
            this.printToolStripMenuItem2.Click += new System.EventHandler(this.printToolStripMenuItem2_Click);
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Image = global::MyProject.Properties.Resources.box_add;
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addTaskToolStripMenuItem.Text = "Add task";
            this.addTaskToolStripMenuItem.Click += new System.EventHandler(this.addTaskToolStripMenuItem_Click);
            // 
            // editTaskToolStripMenuItem
            // 
            this.editTaskToolStripMenuItem.Image = global::MyProject.Properties.Resources.box_edit;
            this.editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            this.editTaskToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.editTaskToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.editTaskToolStripMenuItem.Text = "Edit task";
            this.editTaskToolStripMenuItem.Click += new System.EventHandler(this.editTaskToolStripMenuItem_Click);
            // 
            // removeTaskToolStripMenuItem
            // 
            this.removeTaskToolStripMenuItem.Image = global::MyProject.Properties.Resources.box_remove;
            this.removeTaskToolStripMenuItem.Name = "removeTaskToolStripMenuItem";
            this.removeTaskToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeTaskToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeTaskToolStripMenuItem.Text = "Remove task";
            this.removeTaskToolStripMenuItem.Click += new System.EventHandler(this.removeTaskToolStripMenuItem_Click);
            // 
            // moveRightToolStripMenuItem
            // 
            this.moveRightToolStripMenuItem.Image = global::MyProject.Properties.Resources.arrow_medium_right;
            this.moveRightToolStripMenuItem.Name = "moveRightToolStripMenuItem";
            this.moveRightToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.moveRightToolStripMenuItem.Text = "Move right";
            this.moveRightToolStripMenuItem.Click += new System.EventHandler(this.moveRightToolStripMenuItem_Click);
            // 
            // moveLeftToolStripMenuItem
            // 
            this.moveLeftToolStripMenuItem.Image = global::MyProject.Properties.Resources.arrow_medium_left;
            this.moveLeftToolStripMenuItem.Name = "moveLeftToolStripMenuItem";
            this.moveLeftToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.moveLeftToolStripMenuItem.Text = "Move left";
            this.moveLeftToolStripMenuItem.Click += new System.EventHandler(this.moveLeftToolStripMenuItem_Click);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Image = global::MyProject.Properties.Resources.arrow_medium_up;
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.moveUpToolStripMenuItem.Text = "Move up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Image = global::MyProject.Properties.Resources.arrow_medium_down;
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.moveDownToolStripMenuItem.Text = "Move down";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyProject";
            this.Load += new System.EventHandler(this.ProjectFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProjectForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripSplitButton tsbOpenProject;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntxtName;
        private System.Windows.Forms.ToolStripButton tsbAddProject;
        private System.Windows.Forms.ToolStripButton tsbDeleteProj;
        private Aga.Controls.Tree.TreeColumn assigned;
        private Aga.Controls.Tree.NodeControls.NodeTextBox ntxtAssigned;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectProjectFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProjectProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem moveRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    }
}