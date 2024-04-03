using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class ReservationTests
    {
        [Fact]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result=reservation.CanBeCancelledBy(new User { IsAdmin=true});

            //Assert
            Assert.True(result);
        }


        [Fact]
        public void CanBeCancelledBy_SameUserCancelling_ResturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            var user =new User { IsAdmin=false};
            reservation.MadeBy = user;

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();
            var user = new User { IsAdmin = true };

            reservation.MadeBy = user;


            //Act
            var result =reservation.CanBeCancelledBy(new User { IsAdmin=false}  )   ;

            //Assert
            Assert.False(result);   

        }
    }
}