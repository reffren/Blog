using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wexplorer.Data.Entities;

namespace Wexplorer.Data.Abstract
{
    public interface IBlogRepository
    {
        IQueryable<Category> Categories { get; }
        IQueryable<Post> Posts { get; }
        IQueryable<Comment> Comments { get; }
        void SaveComment(Comment comments);
        void SavePost(Post post);
    }
}
