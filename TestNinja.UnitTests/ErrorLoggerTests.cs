using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestNinja.UnitTests
{
    public class ErrorLoggerTests
    {
        [Fact]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("Error");

            Assert.Equal(logger.LastError, "Error");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
           // logger.Log(error); should use a delegate inside the assert, otherwise this method will fail

            Assert.Throws<ArgumentNullException>(()=> logger.Log(error));
        }
        [Fact]
        //raise event
        public void Log_InvalidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();


            var id=Guid.Empty;
            logger.ErrorLogged += (sender, args) => {
                id = args;
            };
            logger.Log("a");

            Assert.NotEqual(id,Guid.Empty);
        }
    }
}
