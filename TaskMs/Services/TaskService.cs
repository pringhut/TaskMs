﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaaskMs.DAO;
using TaskManagementSystem.Models;

namespace TaskMs.Services
{
    public class TaskService
    {
        private readonly TaskRepository _taskRepository;
        public TaskService(TaskRepository taskRepository)

        {
            _taskRepository = taskRepository;
        }

        public List<TaskItem> GetAllTasks()
        {
            return _taskRepository.GetAllTask();
        }
        public TaskItem GetTaskById(int id)
        {
            return _taskRepository.GetTaskById(id);
        }
        public void AddTask(TaskItem taskItem)
        {
            _taskRepository.AddTask(taskItem);
        }
        public void DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
        }
        public void UpdateTask(TaskItem taskItem)
        {
            _taskRepository.UpdateTask(taskItem);
        }

    }
}
