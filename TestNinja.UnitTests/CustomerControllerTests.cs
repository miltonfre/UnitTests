using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class CustomerControllerTests
    {
        [Fact]
        public void GetCustomer_IdZero_ShouldReturnNotFound()
        {
            var controller = new CustomerController();

            var result=controller.GetCustomer(0);


            //
            Assert.IsType<NotFound>( result);


            //NotFound or one of its derivates
            //Assert.IsAssignableFrom<NotFound>(result);
        }
        [Fact]
        public void GetCustomer_IdZero_ShouldReturnOk()
        {
            var controller = new CustomerController();
           var result= controller.GetCustomer(2);

            Assert.IsType<Ok>(result);   
        }
    }
}
