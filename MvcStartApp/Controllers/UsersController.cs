﻿using Microsoft.AspNetCore.Mvc;
using MvcStartApp.Repositories;
using MvcStartApp.Models;
using MvcStartApp.Repositories;

namespace MvcStartApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IBlogRepository _repo;

        public UsersController(IBlogRepository repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            var authors = await _repo.GetUsers();
            return View(authors);
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            await _repo.AddUser(user);
            return View(user);
        }
    }
}
