// See https://aka.ms/new-console-template for more information
using MovieBooking.Models;
Console.WriteLine("Hello, World!");


SeatList Screen1 = new SeatList();


for (int i = 0; i < 10; i++) 
{
    Seat seat = new Seat();
    seat.Seat_No = i;
    seat.Seat_Id = "A" + i.ToString();
    //seat.Is_Vacant = false;
    Screen1.seats.Add(seat);
}




    foreach (Seat seatt in Screen1.seats)
    {
        Console.WriteLine(seatt.Seat_No + " : " + seatt.Seat_Id+" "+ seatt.Is_Vacant);
    }

