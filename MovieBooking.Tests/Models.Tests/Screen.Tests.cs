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
        private Screen Screen;
        [SetUp]
        public void Setup()
        {
            Screen = new Screen();
        }

        

        [Test]
        public void Book_3_seats_should_return_booked_seats()
        {
            //Arrange
            char seatRow = 'A';
            int numberOfRows = 5;
            int numberOfColumns = 3;
            SeatList seatList = new SeatList();

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
            SeatList expectedSeatList = seatList;
            //Act
            SeatList outputSeatList = Screen.CreateScreen(numberOfRows, numberOfColumns);
            // Assert
            Assert.AreEqual(expectedSeatList.seats.Count, outputSeatList.seats.Count);
 
        }
    }
}
