using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooking.Models
{
    public class Seat
    {
        public int Seat_No { get; set; } = 0;
        public string? Seat_Id { get; set; }
        public bool Is_Vacant { get; set; } = true;
        
    }
}
