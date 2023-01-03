using System;
using System.Collections.Generic;

#nullable disable

namespace Entity
{
    public partial class Blog
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Detail { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDelete { get; set; }
    }
}
