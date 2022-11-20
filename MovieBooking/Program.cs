
using MovieBooking.Models;
using MovieBooking.AppManagers;


while (true)
{
    Console.Title = "Cinamon Cinemas";

    Console.WriteLine("Please enter 'A' for Admin /'T' for Ticket booking /'S' for status");
    string? menuSelecter = Console.ReadLine();
    if (menuSelecter == "A")
    {
        TheaterManager.TheaterManagementLoop();
    }
    else if (menuSelecter == "T")
    {
        TheaterManager.UpdateData();
    }
    else if (menuSelecter == "S")
    {
        TheaterManager.TheaterStatus();
    }
}