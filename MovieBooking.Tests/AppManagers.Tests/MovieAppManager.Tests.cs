using MovieBooking.AppManagers;
using FluentAssertions;

namespace MovieBooking.Tests.AppManagers.Tests;


public class Tests
{

    private MovieAppManager appManager;
    [SetUp]
    public void Setup()
    {
        appManager = new MovieAppManager();
    }

    [Test]
    public void Book_3_seats_should_return_booked_seats_A1_A2_A3()
    {
        appManager.BookSeats(3).Should().Be("A1-A2-A3");
    }
}