using System.Collections.Generic;
using Xunit;

namespace DailyChallenges.Tests
{
    public class DailyChallenge1Tests
    {
        [Fact]
        public void AddendsDoExistInList()
        {
            //arrange
            var numbers = new List<int> {10, 15, 3, 7};

            const int sum = 17;

            //Act
            var result = DailyChallenge1.DoAddendsExistInList(numbers, sum);


            //Assert
            Assert.True(result);
        }

        [Fact]
        public void AddendsDoNotExistInList()
        {
            //arrange
            var numbers = new List<int> {4, 5, 3, 7};

            const int sum = 27;

            //Act
            var result = DailyChallenge1.DoAddendsExistInList(numbers, sum);


            //Assert
            Assert.False(result);
        }

        [Fact]
        public void AddendsDoNotExistInListButSumIsHalf()
        {
            //arrange
            var numbers = new List<int> {4, 5, 3, 7};

            const int sum = 14;

            //Act
            var result = DailyChallenge1.DoAddendsExistInList(numbers, sum);


            //Assert
            Assert.False(result);
        }
    }
}
