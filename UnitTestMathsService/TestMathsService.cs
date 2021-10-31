using MyMathsService.Service;
using System;
using Xunit;

namespace UnitTestMathsService
{
    public class TestMathsService
    {
        private IMathsService _mathsService;
        public TestMathsService() {
            _mathsService = new MathsService();
        }
        [Fact] // attribute [Fact] that will make these method part of unit testing and execute these methods during each test run
        public void Add()
        {
            double x1 = 5;
            double x2 = 8;
            double expected = 13;

            var actual = _mathsService.Add(x1, x2);

            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void Substract()
        {
            double x1 = 10;
            double x2 = 8;
            double expected = 2;

            var actual = _mathsService.Subtract(x1, x2);

            Assert.Equal(expected, actual, 0); // to verify if the test was successful or not.
        }

        [Fact]
        public void Multiply()
        {
            double x1 = 5;
            double x2 = 8;
            double expected = 40;

            var actual = _mathsService.Multiply(x1, x2);

            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void Divide()
        {
            double x1 = 100;
            double x2 = 10;
            double expected = 10;

            var actual = _mathsService.Divide(x1, x2);

            Assert.Equal(expected, actual, 0);
        }
    }
}
