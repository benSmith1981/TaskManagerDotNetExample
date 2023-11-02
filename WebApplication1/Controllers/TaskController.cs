using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class TaskController : Controller
{
    public IActionResult Index()
    {
        // Simulate fetching tasks from a database or other data source
        var tasks = new List<TaskModel>
        {
            new TaskModel { Name = "Task 1", Description = "Description 1", DueDate = DateTime.Now.AddDays(3), Status = "Incomplete" },
            new TaskModel { Name = "Task 2", Description = "Description 2", DueDate = DateTime.Now.AddDays(1), Status = "Incomplete" },
            new TaskModel { Name = "Task 3", Description = "Description 3", DueDate = DateTime.Now.AddDays(7), Status = "Completed" }
        };

        return View(tasks);
    }
}
