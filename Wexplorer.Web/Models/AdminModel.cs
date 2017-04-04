using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wexplorer.Data.Entities;

namespace Wexplorer.Web.Models
{
    public class AdminModel
    {
        public List<Category> Category;
        public Post Post { get; set; }
        public IEnumerable<SelectListItem> CategoryItems {
            get { return new SelectList(Category, "CategoryID", "NameCategory"); }
        }
    }
}