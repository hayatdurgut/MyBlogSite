using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Models
{
    public partial class Category
    {
        public Category()
        {
            Blogs = new HashSet<Blog>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
