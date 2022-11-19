using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBooking.Models;

namespace MovieBooking.AppManagers
{
    public class DisplayManager
    {
        public void Visualize(Screen screen) 
        {
            Console.WriteLine($"Screen name : {screen.ScreenName}");
            Console.WriteLine($"Movie name : {screen.MovieName}");
            var seats = screen.seats;
            foreach (var seat in seats) 
            {
                Console.WriteLine($"Seat no : {seat.Seat_No} Seat Id : {seat.Seat_Id} Is vacant : {seat.Is_Vacant}");
            }

        }
    }
}
