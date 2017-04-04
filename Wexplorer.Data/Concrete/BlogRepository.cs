using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Wexplorer.Data.Abstract;
using Wexplorer.Data.Entities;

namespace Wexplorer.Data.Concrete
{
    public class BlogRepository : IBlogRepository
    {
        private EFContext context = new EFContext();
        public IQueryable<Category> Categories
        {
            get { return context.Categories; }
        }

        public IQueryable<Post> Posts
        {
            get { return context.Posts; }
        }

        public IQueryable<Comment> Comments
        {
            get { return context.Comments; }
        }

        public void SaveComment(Comment comments)
        {
            if (comments.CommentID == 0)
            {
                context.Comments.Add(comments);
            }
            else
            {
                context.Entry(comments).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void SavePost(Post post)
        {
            if (post.PostID == 0)
            {
                context.Posts.Add(post);
            }
            else
            {
                context.Entry(post).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}