using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBooking.Models;
using FluentAssertions;

namespace MovieBooking.Tests.Models.Tests
{
    internal class ScreenTests
    {
        private ScreenManager Screen;
        [SetUp]
        public void Setup()
        {
            Screen = new ScreenManager();
        }

        

        [Test]
        public void Book_3_seats_should_return_booked_seats()
        {
            //Arrange
            char seatRow = 'A';
            int numberOfRows = 10;
            int numberOfColumns = 10;
            Screen seatList = new Screen();

            for (int j = 1; j <= numberOfColumns; j++)
            {
                for (int i = 1; i <= numberOfRows; i++)
                {
                    Seat seat = new Seat();
                    seat.Seat_No += 1;
                    seat.Seat_Id = seatRow.ToString() + i;
                    seat.Is_Vacant = true;
                    seatList.seats.Add(seat);
                }
                seatRow++;
            }
            Screen expectedSeatList = seatList;
            //Act
            Screen outputSeatList = Screen.CreateScreen(numberOfRows, numberOfColumns);
            //Assert
            Assert.AreEqual(expectedSeatList.seats.Count, outputSeatList.seats.Count);
 
        }
    }
}
