using System;
using Xunit;
using Xunit.Abstractions;

namespace LMS.xUnitTestsProject
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(
            ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test1()
        {
            // ARRANGE
            int expectedResult = 60;
            int actualResult;
            int a = 5, b = 10, c =25, d=10, e=10;

            // ACT
            actualResult = a + b + c + d + e;

            _testOutputHelper.WriteLine($"input values are {a} and {b}");
            _testOutputHelper.WriteLine($"expectedResult = {expectedResult}, ActualResult = {actualResult}");

            // ASSERT
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
