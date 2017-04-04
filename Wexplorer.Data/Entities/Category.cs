using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wexplorer.Data.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string NameCategory { get; set; }
        public string UrlCategory { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}