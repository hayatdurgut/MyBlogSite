using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Models
{
    public partial class Blog
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Detail { get; set; }
        public int CategoryId { get; set; }
        public string CoverPhoto { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Category Category { get; set; }
    }
}
