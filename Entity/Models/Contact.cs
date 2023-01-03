using System;
using System.Collections.Generic;

#nullable disable

namespace Entity.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
    }
}
