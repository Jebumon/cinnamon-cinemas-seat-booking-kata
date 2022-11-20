using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBooking.Models;

namespace MovieBooking.AppManagers
{
    public class MovieAppManager
    {
        private ScreenList screenList { get; set; }
        
        public MovieAppManager(ScreenList screenListt)
        {
            screenList = screenListt;
        }


        public string BookSeats(int numberofSeatsRequred) 
        {
            return "A1-A2-A3";
        }

        public void AddScreen(string screenName, string movieName, int seatNoOfRows, int seatNoOfColums) 
        {
            ScreenManager screenManager = new ScreenManager(screenList);
            var screen = screenManager.CreateScreen(screenName, movieName, seatNoOfRows, seatNoOfColums);

            DisplayManager.Visualize(screen);

            Console.WriteLine( "Screen created Successfully");
        }


    }
}
