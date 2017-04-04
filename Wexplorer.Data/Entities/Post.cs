using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wexplorer.Data.Entities
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }

        [DataType(DataType.MultilineText)]
        public string Title { get; set; }

        [AllowHtml]
        public string Description { get; set; }

        [AllowHtml]
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string UrlPost { get; set; }
        public string Picture { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}