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
        private ScreenManager screenManager = new ScreenManager();
        private DisplayManager displayManager = new DisplayManager();


        public MovieAppManager()
        {
        }

        public string BookSeats(int numberofSeatsRequred) 
        {
            return "A1-A2-A3";
        }

        public void AddScreen(string screenName, string movieName, int seatNoOfRows, int seatNoOfColums) 
        {
            var screen = screenManager.CreateScreen(screenName, movieName, seatNoOfRows, seatNoOfColums);

            displayManager.Visualize(screen);

            Console.WriteLine( "Screen created Successfully");
        }



        


    }
}
