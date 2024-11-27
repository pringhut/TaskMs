using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Models;
using TaskMs.Services;

namespace TaskMs.Controllers
{
    public class TaskController
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)

        {
            _taskService = taskService;
        }

        public List<TaskItem> GetAllTask()
        {
            return _taskService.GetAllTasks();
        }

        public TaskItem GetTaskById(int id)
        {
            return _taskService.GetTaskById(id);
        }

        public void AddTask(string taskName, string taskDescription, string status)
        {
            var taskItem = new TaskItem
            {
                TaskName = taskName,
                TaskDescription = taskDescription,
                Status = status
            };
            _taskService.AddTask(taskItem);
        }

        public void UpdateTask(int id, string taskName, string taskDescription, string status)
        {
            var taskItem = _taskService.GetTaskById(id);
            if (taskItem != null)
            {
                taskItem.TaskName = taskName;
                taskItem.TaskDescription = taskDescription;
                taskItem.Status = status;
                _taskService.UpdateTask(taskItem);
            }
        }

        public void DeleteTask(int id)
        {
            _taskService.DeleteTask(id);
        }
    }
}
