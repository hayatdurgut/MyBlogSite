using Common.Helper.Manager;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogSite.Controllers
{
    public class AboutController : Controller
    {
        AboutManager _aboutManager = new AboutManager();
        public IActionResult Index()
        {
            return View(_aboutManager.GetAbout());
        }
    }
}
