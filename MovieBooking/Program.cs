// See https://aka.ms/new-console-template for more information
using MovieBooking.Models;
using MovieBooking.AppManagers;

MovieAppManager appManager = new MovieAppManager();

int seatRowNo = 0;
int seatColumsNo = 0;
string? screenName = "No Name";
string? movieName = "No Name";

Console.WriteLine("Welcome to Cinnamon Cinemas");
Console.WriteLine("Please enter a Screen name to create screen");
screenName = Console.ReadLine();
Console.WriteLine("Please enter a Movie name to create screen");
movieName = Console.ReadLine();
Console.WriteLine("Please enter no seat rows to create screen");
bool succsess = Int32.TryParse(Console.ReadLine(),out seatRowNo);
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


//Screen Screen1 = new Screen();


/*for (int i = 0; i < 10; i++) 
{
    Seat seat = new Seat();
    seat.Seat_No = i;
    seat.Seat_Id = "A" + i.ToString();
    //seat.Is_Vacant = false;
    Screen1.seats.Add(seat);
}*/



/*
    foreach (Seat seatt in Screen1.seats)
    {
        Console.WriteLine(seatt.Seat_No + " : " + seatt.Seat_Id+" "+ seatt.Is_Vacant);
    }*/

