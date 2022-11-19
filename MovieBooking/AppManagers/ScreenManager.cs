using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBooking.Models;

namespace MovieBooking.AppManagers
{
    public class ScreenManager
    {
        
        ScreenList screenList = new ScreenList();

        char seatRow = 'A';
        public Screen CreateScreen(string screenName, string movieName, int numberOfRows, int numberOfColumns)
        {
            int seatNo = 1;
            Screen screen = new Screen();
            screen.MovieName = movieName;
            screen.ScreenName = screenName;
            for (int j = 1; j <= numberOfColumns; j++)
            {
                for (int i = 1; i <= numberOfRows; i++)
                {
                    Seat seat = new Seat();
                    seat.Seat_No = seatNo++;
                    seat.Seat_Id = seatRow.ToString() + i;
                    seat.Is_Vacant = true;
                    screen.seats.Add(seat);
                }
                seatRow++;
            }
            screenList.screens.Add(screen);
            return screen;
        }

        public ScreenList GetScreenList() 
        {
            return screenList; 
        }
    }
}
