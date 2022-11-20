using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBooking.Models;

namespace MovieBooking.AppManagers
{
    public static class DisplayManager
    {
        
        public static void Visualize(Screen screen) 
        {
            Console.WriteLine($"Screen name : {screen.ScreenName}");
            Console.WriteLine($"Movie name : {screen.MovieName}");
            var seats = screen.seats;
            foreach (var seat in seats) 
            {
                Console.WriteLine($"Seat no : {seat.Seat_No} Seat Id : {seat.Seat_Id} Is vacant : {seat.Is_Vacant}");
            }

        }

        public static void PrintAllStatus(ScreenList screenList) 
        {
            Console.Clear();
            Console.WriteLine("******* All Available Shows in Cinnamon Cinemas ********");
            Console.WriteLine($"Total Entries : { screenList.screens.Count()}");
            if (screenList.screens.Count() == 0) 
            {
                Console.WriteLine("No details!! Please add Theater details by Admin menu");
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            var allDetails = from screen in screenList.screens
                             select new {TheaterName = screen.ScreenName, 
                                 CinemaName = screen.MovieName,
                                 TotalCapasity = screen.seats.Count(), 
                                 TotalAvailable = screen.seats.Where(s=>s.Is_Vacant == true).Count()};
            foreach(var details in allDetails) 
            {if (details.TotalAvailable == 0) 
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                }
                Console.WriteLine($"Screen Name : {details.TheaterName}");
                Console.WriteLine($"\tMovie Name     : {details.CinemaName}");
                Console.WriteLine($"\tTotal Seats    : {details.TotalCapasity}");
                Console.WriteLine($"\tAvailabe Seats : {details.TotalAvailable}");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.ResetColor();
        }
    }
}
