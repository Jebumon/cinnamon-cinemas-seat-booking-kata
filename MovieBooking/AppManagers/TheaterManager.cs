using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooking.AppManagers
{
    public static class TheaterManager
    {
        public static void TheaterManagementLoop() 
        {
            while (true)
            {
                MovieAppManager appManager = new MovieAppManager();

                int seatRowNo = 0;
                int seatColumsNo = 0;
                string? screenName = "No Name";
                string? movieName = "No Name";

                Console.WriteLine("Cinnamon Cinemas Admin menu");
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

                Console.WriteLine($"Please enter 'B' for going back to Main menu OR press any other key to add another Screen");
                string? bForBack = Console.ReadLine();
                if (bForBack =="B") 
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
