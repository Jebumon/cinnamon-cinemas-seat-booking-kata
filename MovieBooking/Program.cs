// See https://aka.ms/new-console-template for more information
using MovieBooking.Models;
using MovieBooking.AppManagers;


while (true)
{
    Console.Title = "Cinamon Cinemas";

    Console.WriteLine("Please enter 'A' for Admin / enter 'T' for Ticket booking");
    string? menuSelecter = Console.ReadLine();
    if (menuSelecter == "A")
    {
        TheaterManager.TheaterManagementLoop();
    }
    else if (menuSelecter == "T")
    {
        Console.WriteLine("Menu is under development");
    }
}