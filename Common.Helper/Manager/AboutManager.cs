using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper.Manager
{
    public class AboutManager
    {
        public About GetAbout()
        {
            try
            {
                using (ModelContext context = new ModelContext())
                {
                    return context.Abouts.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return new About();
            }
        }
    }
}
