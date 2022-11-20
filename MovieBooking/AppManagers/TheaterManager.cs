using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBooking.Models;

namespace MovieBooking.AppManagers
{
    public static class TheaterManager
    {
        private static ScreenList screenList { get; set; } = new ScreenList();
        private static ScreenManager screenManager = new ScreenManager(screenList);


        public static void TheaterManagementLoop() 
        {
            while (true)
            {
                MovieAppManager appManager = new MovieAppManager(screenList);

                int seatRowNo = 0;
                int seatColumsNo = 0;
                string? screenName = "No Name";
                string? movieName = "No Name";
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("********* Cinnamon Cinemas Admin menu ***********\n");
                Console.WriteLine("Please enter a Screen name to create screen");
                screenName = Console.ReadLine();
                Console.WriteLine("Please enter a Movie name to create screen");
                movieName = Console.ReadLine();
                Console.WriteLine("Please enter no seat rows to create screen");
                bool succsess = Int32.TryParse(Console.ReadLine(), out seatRowNo);
                if (!succsess)
                {
                    while (!succsess)
                    {
                        Console.WriteLine("Please ente a valid Number");
                        succsess = Int32.TryParse(Console.ReadLine(), out seatRowNo);
                    }
                }
                succsess = false;
                Console.WriteLine("Please enter no of seat colums create screen");
                succsess = Int32.TryParse(Console.ReadLine(), out seatColumsNo);
                if (!succsess)
                {
                    while (!succsess)
                    {
                        Console.WriteLine("Please ente a valid Number");
                        succsess = Int32.TryParse(Console.ReadLine(), out seatColumsNo);
                    }
                }

                appManager.AddScreen(screenName, movieName, seatRowNo, seatColumsNo);
                Console.ResetColor();
                Console.WriteLine($"Please enter 'B' for going back to Main menu OR press Enter to add another Screen");
                string? bForBack = Console.ReadLine();
                if (bForBack =="B") 
                {
                    Console.Clear();
                    break;
                }
            }
        }

        public static void TheaterStatus() 
        {
            var screenList = screenManager.GetScreenList();
            DisplayManager.PrintAllStatus(screenList);
        }

        public static void UpdateData() 
        {
            string movieName, screenName = "";
            int requiredSeats = 0;
            Console.WriteLine("Please enter movie name");
            movieName = Console.ReadLine();
            Console.WriteLine("Please enter screen name");
            screenName = Console.ReadLine();
            Console.WriteLine("Please enter no of seats required");
            requiredSeats = Int32.Parse(Console.ReadLine());


            foreach(var screen in screenList.screens) 
            {
                if (screen.MovieName == movieName && screen.ScreenName == screenName) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    
                    Console.WriteLine("Please note the Booked Seat ID's : ");
                    foreach (var seat in screen.seats) 
                    {
                        if(seat.Is_Vacant == true) 
                        {
                            seat.Is_Vacant = false;
                            requiredSeats--;
                            Console.WriteLine($"\t                            -- {seat.Seat_Id}");
                        }

                        if(requiredSeats == 0) 
                        {
                            
                            Console.WriteLine("Seats Booked!! Thank you..\n");
                            Console.ResetColor();

                            return;
                        }
                    }
                }
            }
        }
    }
}
