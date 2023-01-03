
using Common.Helper.Manager;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogSite.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager();
        public IActionResult Index()
        {
            return View(_blogManager.GetAllBlogs());
       
        }
        public IActionResult BlogDetail(int id)
        {
            return View(_blogManager.GetBlogById(id).FirstOrDefault());
        }
    }
}
