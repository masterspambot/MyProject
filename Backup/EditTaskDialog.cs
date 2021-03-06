using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyProject
{
    public partial class EditTaskDialog : Form
    {
        public EditTaskDialog()
        {
            InitializeComponent();
            this.priorityList.DataSource = new List<string>() { "VERY LOW", "LOW", "MEDIUM", "HIGH", "CRITICAL" };
        }

        public DialogResult ShowEditDialog(Task t) { 
            this.EditedTask = t;
            
            return this.ShowDialog(); }

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
                this.chbComplited.Checked = this.editedTask.Completed;
                this.nudDuration.Value = this.editedTask.Duration;
                this.dtpStart.Value = this.editedTask.Start;
                this.dtpEnd.Value = this.editedTask.End;
                this.nudProgress.Value = this.editedTask.Progress;
                this.priorityList.SelectedIndex = this.priorityList.FindString(this.editedTask.Priority);
            }
        }

        private void EditTaskDialog_Shown(object sender, EventArgs e)
        {
            txtTask.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.editedTask.Name = this.txtTask.Text;
            this.editedTask.Description = this.txtDescription.Text;
            this.editedTask.Completed = this.chbComplited.Checked;
            this.editedTask.Duration = Convert.ToInt32(this.nudDuration.Value);
            this.editedTask.Start = this.dtpStart.Value;
            this.editedTask.End = this.dtpEnd.Value;
            this.editedTask.Progress = Convert.ToInt32(this.nudProgress.Value);
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
            //MessageBox.Show(editedTask.Status.ToString());
        }

        private void priorityList_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void chbComplited_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.chbComplited.Checked)
            {
                this.nudProgress.Value = PERCENT_FULL;
            }
            else
            {
                this.nudProgress.Value = PERCENT_ZERO;
            }
        }
    }
}