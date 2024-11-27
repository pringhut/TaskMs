using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMs.Controllers;
using TaskMs.Data;
using TaskMs.Services;
using TaaskMs.DAO;


namespace TaskMs.Forms
{
    public partial class AddTaskForm : Form
    {
        private readonly TaskController _taskController;
        public event Action TaskAdded;
        public AddTaskForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var taskRepository = new TaskRepository(context);
            var taskService = new TaskService(taskRepository);
            _taskController = new TaskController(taskService);
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string description = rtxtDescription.Text;
            string status = txtStatus.Text;

            _taskController.AddTask(taskName, description, status);
            MessageBox.Show("Added Successfully", "Information");

            //Raise the event to notify the Main Form
            TaskAdded?.Invoke();
            this.Close();


        }
    }
}

