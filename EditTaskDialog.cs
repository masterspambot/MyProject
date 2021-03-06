using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyProject
{
    public partial class EditTaskDialog : Form
    {
        private bool _taskFontColorChanged;
        public EditTaskDialog()
        {
            InitializeComponent();
            this.priorityList.DataSource = new List<string>() { "VERY LOW", "LOW", "MEDIUM", "HIGH", "CRITICAL" };
        }

        public DialogResult ShowEditDialog(Task t, Task project)
        {
            TaskFontColorBtn.BackColor = t.getFontColor();
            this.EditedTask = t;
            if (t.Tasks.Count > 0)
            {
                if (this.tableLayoutPanel2.Controls.Contains(nudProgress))
                {
                    chbCompleted.Visible = false;
                    this.tableLayoutPanel2.Controls.Remove(nudProgress);
                    this.tableLayoutPanel2.Controls.Add(ProgressLabel, 5, 2);
                }
            }
            else
            {
                if (this.tableLayoutPanel2.Controls.Contains(ProgressLabel))
                {
                    chbCompleted.Visible = true;
                    this.tableLayoutPanel2.Controls.Remove(ProgressLabel);
                    this.tableLayoutPanel2.Controls.Add(nudProgress, 5, 2);
                }
            }
            if (this.editedTask.Level != 0)
            {
                this.peopleList.Visible = false;
                this.comboBox1.Items.Clear();
                foreach (String person in project.PeopleList) 
                {
                    this.comboBox1.Items.Add(person);
                }
                
                // parent = this.parent;
            }
            else
            {
                this.peopleList.Visible = true;
            }
            return this.ShowDialog();
        }

        private Task editedTask;
        private const int PERCENT_FULL = 100;
        private const int PERCENT_ZERO = 0;
        //private Task originalTask;

        public Task EditedTask
        {
            get { return this.editedTask; }
            set
            {
                this.editedTask = value;
                this.txtTask.Text = this.editedTask.Name;
                this.txtDescription.Text = this.editedTask.Description;
                //this.comboBox1.Text = this.editedTask.
                ;
                this.chbCompleted.Checked = this.editedTask.Completed;
                this.nudDuration.Value = this.editedTask.Duration;
                this.dtpStart.Value = this.editedTask.Start;
                this.dtpEnd.Value = this.editedTask.End;
                this.nudProgress.Value = this.editedTask.Progress;
                this.ProgressLabel.Text = this.editedTask.Progress + " % completed";
                this.priorityList.SelectedIndex = this.priorityList.FindString(this.editedTask.Priority);
                this.peopleList.Text = string.Join("\n", this.editedTask.PeopleList.ToArray());
            }
        }

        private void EditTaskDialog_Shown(object sender, EventArgs e)
        {
            txtTask.Focus();
            _taskFontColorChanged = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.editedTask.Name = this.txtTask.Text;
            this.editedTask.Description = this.txtDescription.Text;
            this.editedTask.Assigned = this.comboBox1.Text;
            this.editedTask.Completed = this.chbCompleted.Checked;
            this.editedTask.Duration = Convert.ToInt32(this.nudDuration.Value);
            this.editedTask.Start = this.dtpStart.Value;
            this.editedTask.End = this.dtpEnd.Value;
            this.editedTask.Progress = Convert.ToInt32(this.nudProgress.Value);
            if (Convert.ToInt32(this.nudProgress.Value) == 100)
                this.editedTask.Completed = true;
            switch (this.priorityList.SelectedIndex)
            {
                case 0:
                    this.editedTask.Priority = "VERY LOW";
                    break;
                case 1:
                    this.editedTask.Priority = "LOW";
                    break;
                case 2:
                    this.editedTask.Priority = "MEDIUM";
                    break;
                case 3:
                    this.editedTask.Priority = "HIGH";
                    break;
                case 4:
                    this.editedTask.Priority = "CRITICAL";
                    break;
                default:
                    this.editedTask.Priority = "VERY LOW";
                    break;
            }
            if (this.editedTask.Level == 0)
            {
                this.editedTask.PeopleList.Clear();
                string[] lines = peopleList.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
                foreach (String line in lines)
                {
                    this.editedTask.PeopleList.Add(line);
                }
                peopleList.Text = "";
            }

            if (_taskFontColorChanged)
            {
                changeTaskFontColor(TaskFontColorDialog.Color);
            }
        }

        private void priorityList_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void chbCompleted_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.chbCompleted.Checked)
            {
                this.nudProgress.Enabled = false; 
                this.nudProgress.Value = PERCENT_FULL;
            }
            else
            {
                this.nudProgress.Enabled = true;
            }
        }

        private void TaskFontColorBtn_Click(object sender, EventArgs e)
        {
            TaskFontColorDialog.Color = this.editedTask.getFontColor();
            var result = TaskFontColorDialog.ShowDialog();
            if (result.Equals(System.Windows.Forms.DialogResult.OK))
            {
                TaskFontColorBtn.BackColor = TaskFontColorDialog.Color;
                _taskFontColorChanged = true;
            }
            else return;
        }
        private void changeTaskFontColor(Color newColor)
        {
            this.editedTask.setFontColor(newColor);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}