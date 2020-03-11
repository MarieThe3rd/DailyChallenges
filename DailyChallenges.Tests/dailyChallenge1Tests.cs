using System;
using System.Collections.Generic;
using System.Globalization;
using Xunit;

namespace DailyChallenges.Tests
{
    public class DailyChallenge1Tests
    {
        [Fact]
        public void AddensDoExistInList()
        {
            //arrange
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(3);
            numbers.Add(7);

            int sum = 17;

            //Act
            bool result = DailyChallenge1.DoAddendsExistInList(numbers, sum);


            //Assert
            Assert.True(result);
        }

        [Fact]
        public void AddensDoNotExistInList()
        {
            //arrange
            List<int> numbers = new List<int>();
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(7);

            int sum = 27;

            //Act
            bool result = DailyChallenge1.DoAddendsExistInList(numbers, sum);


            //Assert
            Assert.False(result);
        }

        [Fact]
        public void AddensDoNotExistInListButSumIsHalf()
        {
            //arrange
            List<int> numbers = new List<int>();
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(7);

            int sum = 14;

            //Act
            bool result = DailyChallenge1.DoAddendsExistInList(numbers, sum);


            //Assert
            Assert.False(result);
        }
    }
}
