using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstExample.Models
{
    public partial class Passenger
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? TravelDate { get; set; }
    }
}
