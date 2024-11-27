using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMs.Controllers;
using TaaskMs.DAO;
using TaskMs.Data;
using TaskManagementSystem.Models;
using TaskMs.Services;



namespace TaskMs.Forms
{
    public partial class UpdateTaskForm : Form
    {
        private TaskItem _task;

        public Action<object> TaskUpdated { get; internal set; }

        public UpdateTaskForm(TaskItem task)
        {
            InitializeComponent();
            _task = task;
            PopulateFormFields();
        }
        private void PopulateFormFields()
        {
                // Assuming the form has TextBox controls named `txtSubject` and `txtDescription`
                txtTaskName.Text = _task.TaskName;
                rtxtDescription.Text = _task.TaskDescription;
                txtStatus.Text = _task.Status;
                // Add more fields as needed
        }
            private void btnSaveTask_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string description = rtxtDescription.Text;
            string status = txtStatus.Text;

            _task.TaskName = taskName;
            _task.TaskDescription = description;
            _task.Status = status;

            TaskUpdated?.Invoke(_task);
            this.Close();
        }
        }
    }

