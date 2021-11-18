using System;
using Xunit;

namespace FiboTDD.Test
{
    public class FiboTests
    {
        [Fact]
        public void ZeroReturnsZero()
        {
            int result = Fibo.Calculate(0);

            Assert.Equal(0, result);

        }

        [Fact]
        public void OneReturnsOne()
        {
            int result = Fibo.Calculate(1);

            Assert.Equal(1, result);

        }

        [Fact]
        public void TwoReturnsOne()
        {
            int result = Fibo.Calculate(2);

            Assert.Equal(1, result);

        }

        [Fact]
        public void ThreeReturnsTwo()
        {
            int result = Fibo.Calculate(3);

            Assert.Equal(2, result);

        }

        [Fact]
        public void FourReturnsThree()
        {
            int result = Fibo.Calculate(4);

            Assert.Equal(3, result);

        }

        [Fact]
        public void FiveReturnsFive()
        {
            int result = Fibo.Calculate(5);

            Assert.Equal(5, result);

        }

        [Fact]
        public void SixReturnsEight()
        {
            int result = Fibo.Calculate(6);

            Assert.Equal(8, result);

        }

        [Fact]
        public void SevenReturnsThirteen()
        {
            int result = Fibo.Calculate(7);

            Assert.Equal(13, result);

        }

        [Fact]
        public void EightReturnsTwentyOne()
        {
            int result = Fibo.Calculate(8);

            Assert.Equal(21, result);

        }

        [Fact]
        public void NineReturnsThirtyFour()
        {
            int result = Fibo.Calculate(9);

            Assert.Equal(34, result);

        }

    }
}