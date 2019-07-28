using BlogApp.Data;
using BlogApp.Data.Repository;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index() => View();
        public IActionResult Post() => View();

        [HttpGet]
        public IActionResult Edit() => View(new Post());

        [HttpPost]
        public async Task<IActionResult> Edit(Post post)
        {
            _repository.AddPost(post);

            if (await _repository.SaveChangesAsync())
            {
                return RedirectToAction("Index");
            }

            return View(post);
        }
    }
}
