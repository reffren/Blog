using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wexplorer.Data.Abstract;
using Wexplorer.Data.Entities;
using Wexplorer.Web.Models;

namespace Wexplorer.Web.Controllers
{
    public class AdminController : Controller
    {
        private IBlogRepository _repository;
        private AdminModel adminModel;

        
        public AdminController(IBlogRepository blogRepository)
        {
            _repository = blogRepository;
        }
        public ActionResult Index()
        {
            var data = _repository.Posts.ToList();
            return View(data);
        }

        public ViewResult EditPost(int id)
        {
            adminModel = new AdminModel()
            {
                Post = _repository.Posts.FirstOrDefault(f => f.PostID == id),
                Category = _repository.Categories.ToList()

            };
            return View(adminModel);
        }

        [HttpPost]
        public ActionResult EditPost(Post post)
        {
            _repository.SavePost(post);
            return RedirectToAction("Index", "Admin");
        }

        public ActionResult CreatePost()
        {
            adminModel = new AdminModel()
            {
                Category = _repository.Categories.ToList()
            };
            return View("CreatePost", adminModel);
        }
	}
}