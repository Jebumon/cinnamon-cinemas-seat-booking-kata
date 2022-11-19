using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooking.Models
{
    public class Screen
    {
        public string ScreenName { get; set; } = string.Empty;
        public string MovieName { get; set; } = string.Empty;
        public List<Seat>? seats  { get; set; } = new List<Seat>();

    }
}
