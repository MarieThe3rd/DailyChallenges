using System.Collections.Generic;
using Xunit;

namespace DailyChallenges.Tests
{
    public class DailyChallenge2Tests
    {
        [Fact]
        public void ProductListResultsShouldMatch()
        {
            //arrange
            var numbers = new List<int> {1,2,3,4,5};

            //Act
            var result = DailyChallenge2.ProductCalcluationList(numbers);

            //Assert
            Assert.Equal(5,result.Count);
            Assert.True(result.Contains(120));
            Assert.True(result.Contains(60)); 
            Assert.True(result.Contains(40));
            Assert.True(result.Contains(30));
            Assert.True(result.Contains(24));
            }
    }
}
