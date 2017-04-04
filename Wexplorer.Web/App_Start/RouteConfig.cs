using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Wexplorer.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,
                "",
                new { controller = "Blog", action = "Posts", page = 1 }
                );

            routes.MapRoute(null,
                "sitemap",
                new { controller = "Blog", action = "SiteMap" }
                );

            routes.MapRoute(null,
                "ob-avtore",
                new { controller = "Blog", action = "AboutMe" }
                );

            routes.MapRoute(null,
                "contacts",
                new { controller = "Blog", action = "Contacts" }
                );

            routes.MapRoute(null,
                "page{page}",
                new { controller = "Blog", action = "Posts" }, new { page = @"\d+" }
                );

            routes.MapRoute(null,
                "admin",
                new { controller = "Admin", action = "Index", page = 1 }
                );

            routes.MapRoute(null,
                "admin/create",
                new { controller = "Admin", action = "CreatePost" }
                );

            routes.MapRoute(null,
                "admin/edit",
                new { controller = "Admin", action = "EditPost" }
                );

            routes.MapRoute(null,
               "{cat}",
               new { controller = "Blog", action = "PostsOfCategory", page = 1 }
               );

            routes.MapRoute(null,
                "{cat}/page{page}",
                new { controller = "Blog", action = "PostsOfCategory" }, new { page = @"\d+" }
                );

            routes.MapRoute(null,
                "{cat}/{title}",
                new { controller = "Blog", action = "Post", cat = (string)null, title = (string)null }
                );

            routes.MapRoute(null, "{controller}/{action}");
            routes.LowercaseUrls = true;
        }
    }
}

