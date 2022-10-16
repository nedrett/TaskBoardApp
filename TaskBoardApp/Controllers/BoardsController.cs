﻿using Microsoft.AspNetCore.Mvc;

namespace TaskBoardApp.Controllers
{
    using Data;
    using Models;
    using Models.Task;

    public class BoardsController : Controller
    {
        private readonly TaskBoardAppDbContext data;

        public BoardsController(TaskBoardAppDbContext context) => this.data = context;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult All()
        {
            var boards = this.data.Boards
                .Select(b => new BoardViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                    Tasks = b.Tasks.Select(t => new TaskViewModel()
                    {
                        Id = t.Id,
                        Title = t.Title,
                        Description = t.Description,
                        Owner = t.Owner.UserName
                    })
                })
                .ToList();

            return View(boards);
        }
    }
}
