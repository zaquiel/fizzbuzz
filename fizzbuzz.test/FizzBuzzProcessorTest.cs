using System;
using Xunit;
using FluentAssertions;
using fizzbuzz.core;

namespace fizzbuzz.test
{    
    public class FizzBuzzProcessorTest
    {        
        [Fact]
        public void ShouldReturnFizz()
        {
            var number = 3;

            var result = FizzBuzzProcessor.GetResultSimple(number);

            result.Should().Be("fizz");
        }

        [Fact]
        public void ShouldReturnBuzz()
        {
            var number = 5;

            var result = FizzBuzzProcessor.GetResultSimple(number);

            result.Should().Be("buzz");
        }

        [Fact]
        public void ShouldReturnFizzBuzz()
        {
            var number = 15;

            var result = FizzBuzzProcessor.GetResultSimple(number);

            result.Should().Be("fizzbuzz");
        }

        [Fact]
        public void ShouldReturnFizzBuzzComplete()
        {
            var number = 15;
            var expected = new string[] {"1","2","fizz","4","buzz","fizz","7","8","fizz","buzz","11","fizz","13","14","fizzbuzz" };
            

            var result = FizzBuzzProcessor.GetResultComplete(number);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
