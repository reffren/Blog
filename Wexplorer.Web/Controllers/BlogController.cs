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
    public class BlogController : Controller
    {
        IBlogRepository _repository;
        
        PostsModel postsModel;
        PostModel postModel;
        public int PageSize = 3;
        public BlogController(IBlogRepository blogRepository)
        {
            _repository = blogRepository;
        }

        public ViewResult Posts(int page = 1)
        {
            postsModel = new PostsModel();
            postsModel.Posts = _repository.Posts.ToList().OrderBy(p => p.PostID).Skip((page - 1) * PageSize).Take(PageSize);
            postsModel.PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = _repository.Posts.Count() };

            return View(postsModel);
        }

        public ViewResult Post(string title)
        {
            postModel = new PostModel()
            {
                Post = _repository.Posts.FirstOrDefault(f => f.UrlPost == title)
            };
            return View(postModel);
        }

        [HttpPost]
        public ActionResult Post(PostModel _postModel)
        {
            if (ModelState.IsValid)
            {
                _postModel.Comment.PublishedDate = DateTime.Now;
                _repository.SaveComment(_postModel.Comment);
            }
            string urlPost = _repository.Posts.FirstOrDefault(p => p.PostID == _postModel.Comment.PostID).UrlPost;

            return RedirectToAction("Post", new { title = urlPost });
        }

        public ViewResult SiteMap()
        {
            var siteMap = _repository.Categories.ToList();
            return View(siteMap);
        }

        public ViewResult PostsOfCategory(string cat, int page = 1)
        {
            postsModel = new PostsModel();
            postsModel.Posts = _repository.Posts.Where(p => p.Category.UrlCategory == cat).ToList().OrderBy(p => p.PostID).Skip((page - 1) * PageSize).Take(PageSize);
            postsModel.PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = _repository.Posts.Where(p => p.Category.UrlCategory == cat).Count() };

            return View("PostsOfCategory", postsModel);
        }

        public ViewResult AboutMe()
        {
            return View();
        }

        public ViewResult Contacts()
        {
            return View();
        }
    }
}