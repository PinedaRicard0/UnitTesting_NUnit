using MainProject.Fundamentals;
using NUnit.Framework;

namespace TestProject;


[TestFixture]
public class ReservationTest
{
    [Test]
    public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    {
        //arreange
        Reservation reservation = new Reservation();

        //act
        var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

        //assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void CanBeCancelledBy_ReservationMadeByUser_ReturnsTrue()
    {
        //arreange
        Reservation reservation = new();
        User user = new();
        reservation.MadeBy = user;
        //act
        var result = reservation.CanBeCancelledBy(user);

        //assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void CanBeCancelledBy_NonAdminUser_ReturnsFalse()
    {
        //arreange
        Reservation reservation = new();
        User user = new() { IsAdmin = false};
        //act
        var result = reservation.CanBeCancelledBy(user);

        //assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void CanBeCancelledBy_NoMadeByUser_ReturnsFalse()
    {
        //arreange
        Reservation reservation = new();
        User user = new() {};
        //act
        var result = reservation.CanBeCancelledBy(user);

        //assert
        Assert.That(result, Is.False);
    }
}
