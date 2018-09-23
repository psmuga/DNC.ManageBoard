using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNC.ManageBoard.Models;
using Microsoft.Extensions.Logging;

namespace DNC.ManageBoard.Data
{
    public static class DbInitializer
    {

        public static  async void Initialize(ApplicationDbContext context, ILogger<Startup> logger)
        {
            if (context.ToDoItem.Any())
            {
                return; //Db has been seeded
            }
            var todos = new ToDoItem[]
            {
                new ToDoItem{Topic = "Topic 1", Content = "Content 1", IsFinished = false},
                new ToDoItem{Topic = "Topic 2", Content = "Content 2", IsFinished = false},
                new ToDoItem{Topic = "Topic 3", Content = "Content 3", IsFinished = false},
                new ToDoItem{Topic = "Topic 4", Content = "Content 4", IsFinished = false},
                new ToDoItem{Topic = "Topic 5", Content = "Content 5", IsFinished = false},
            };
            foreach (var item in todos)
            {
                await context.ToDoItem.AddAsync(item);
            }
            context.SaveChanges();
            logger.LogInformation("Db was intialized");
        }
    }
}
