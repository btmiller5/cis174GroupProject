using System;
using System.Collections.Generic;

namespace cis174GroupProject.Models
{
    public partial class Owners
    {
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PayMethod { get; set; }
    }
}
