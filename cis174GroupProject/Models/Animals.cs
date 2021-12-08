using System;
using System.Collections.Generic;

namespace cis174GroupProject.Models
{
    public partial class Animals
    {
        public int AnimalId { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string PetType { get; set; }
        public string Breed { get; set; }
        public DateTime Dob { get; set; }
        public decimal? Rate { get; set; }
    }
}
