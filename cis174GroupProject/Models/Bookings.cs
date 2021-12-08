using System;
using System.Collections.Generic;

namespace cis174GroupProject.Models
{
    public partial class Bookings
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PetId { get; set; }
        public string PetName { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
    }
}
