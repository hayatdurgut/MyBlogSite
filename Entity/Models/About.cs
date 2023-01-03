using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Models
{
    public partial class About
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Detail { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
