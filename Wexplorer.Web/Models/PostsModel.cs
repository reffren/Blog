using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wexplorer.Data.Entities;

namespace Wexplorer.Web.Models
{
    public class PostsModel
    {
        public IEnumerable<Post> Posts { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}