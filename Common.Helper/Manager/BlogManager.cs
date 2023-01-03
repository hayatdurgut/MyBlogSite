using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper.Manager
{
   public  class BlogManager
    {
        public List<Blog> GetAllBlogs()
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    //return context.Blogs.Where(x => x.IsDelete == false).OrderByDescending(x => x.Id).ToList();
                    return context.Blogs.Where(x => x.IsDelete == false).OrderByDescending(x => x.Id).ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Blog>();
            }
        }

        public List<Blog> GetBlogById(int Id)
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    return context.Blogs.Where(x => x.IsDelete == false && x.Id== Id).OrderByDescending(x => x.Id).ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Blog>();
            }
        }
    }
}
