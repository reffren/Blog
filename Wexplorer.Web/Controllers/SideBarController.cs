using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wexplorer.Web.Controllers
{
    public class SideBarController : Controller
    {
        //
        // GET: /SideBar/
        public PartialViewResult Subscription()
        {
            return PartialView();
        }
	}
}