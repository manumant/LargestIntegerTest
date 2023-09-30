using System;
using Xunit;

namespace LargestIntegerTest
{
    public class LargestInteger
    {
        [Fact]
        public void GetLargestInteger_ReturnsLargestInteger()
        {
            // Arrange
            int[] numbers = { 3, 30, 34, 5, 9 };
            string expectedLargestInteger = "9534330"; // Expected largest integer

            // Mock any dependencies (if applicable)
            // For example, if GetLargestInteger calls a database or external service,
            // you can mock it using Moq.

            var controller = new ManojLargestIntegerAPI.Controllers.LargestIntegerController();

            // Act
            string result = controller.GetLargestInteger(numbers);

            // Assert
            Assert.Equal(expectedLargestInteger, result);
        }
    }
}
