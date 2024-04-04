using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    public class MathTests
    {
        private Math _math;


        //SetUp
        //TearDown, usuaaly for integration test
       
        public MathTests()
        {
                _math = new Math();
        }
        [Fact]
        public void Add_WhenCall_ReturnSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.Equal(3, result);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 2, 2)]
        public void Max_WhenCall_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void Max_WhenFirstArgumentIsGreater_ReturnFirstArgument()
        {
            var result= _math.Max(2, 1);
            Assert.Equal(2, result);
        }
        [Fact]
        public void Max_WhenSecondArgumentIsGreater_ReturnSecondArgument()
        { 
            var result = _math.Max(1, 2);
            Assert.Equal(2, result);
        }
        [Fact]
        public void Max_WhenBothArgumentAreEqual_ReturnSecondArgument()
        {
            var result = _math.Max(1, 1);
            Assert.Equal(1, result);
        }
    }
}
