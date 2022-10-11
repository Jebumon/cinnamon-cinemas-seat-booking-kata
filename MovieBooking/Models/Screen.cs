using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBooking.Models;

namespace MovieBooking.Models
{
    public class Screen
    {
        SeatList seatList = new SeatList();
        
        public Screen()
        {
        }
        char seatRow = 'A';
        public SeatList CreateScreen(int numberOfRows, int numberOfColumns) 
        {
            for (int j = 1; j <= numberOfColumns; j++)
            {
                for (int i = 1; i <= numberOfRows; i++)
                {
                    Seat seat = new Seat();
                    seat.Seat_No += 1;
                    seat.Seat_Id = i + seatRow.ToString();
                    seat.Is_Vacant = true;
                    seatList.seats.Add(seat);
                }
                seatRow++;
            }
            return seatList; 
        }
    }
}
