using BlogApp.Data;
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
        private AppDbContext _ctx;

        public HomeController(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index() => View();
        public IActionResult Post() => View();

        [HttpGet]
        public IActionResult Edit() => View(new Post());

        [HttpPost]
        public async Task<IActionResult> Edit(Post post)
        {
            _ctx.Posts.Add(post);
            await _ctx.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
