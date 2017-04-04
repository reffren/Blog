using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wexplorer.Data.Entities;

namespace Wexplorer.Web.Models
{
    public class PostModel
    {
        public Post Post { get; set; }
        public Comment Comment { get; set; }
    }
}