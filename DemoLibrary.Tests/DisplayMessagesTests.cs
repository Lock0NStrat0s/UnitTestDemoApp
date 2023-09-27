using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

// Arrange, Act, Assert
// expected and actual


namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good Morning Mohammad";

            // Act
            string actual = messages.Greeting("Mohammad", 7);
        
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good Afternoon Mohammad";

            // Act
            string actual = messages.Greeting("Mohammad", 14);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Mohammad", 0, "Go to bed Mohammad")]
        [InlineData("Mohammad", 1, "Go to bed Mohammad")]
        [InlineData("Mohammad", 2, "Go to bed Mohammad")]
        [InlineData("Mohammad", 3, "Go to bed Mohammad")]
        [InlineData("Mohammad", 4, "Go to bed Mohammad")]
        [InlineData("Mohammad", 5, "Good Morning Mohammad")]
        [InlineData("Mohammad", 6, "Good Morning Mohammad")]
        [InlineData("Mohammad", 7, "Good Morning Mohammad")]
        [InlineData("Mohammad", 8, "Good Morning Mohammad")]
        [InlineData("Mohammad", 9, "Good Morning Mohammad")]
        [InlineData("Mohammad", 10, "Good Morning Mohammad")]
        [InlineData("Mohammad", 11, "Good Morning Mohammad")]
        [InlineData("Mohammad", 12, "Good Afternoon Mohammad")]
        [InlineData("Mohammad", 13, "Good Afternoon Mohammad")]
        [InlineData("Mohammad", 14, "Good Afternoon Mohammad")]
        [InlineData("Mohammad", 15, "Good Afternoon Mohammad")]
        [InlineData("Mohammad", 16, "Good Afternoon Mohammad")]
        [InlineData("Mohammad", 17, "Good Afternoon Mohammad")]
        [InlineData("Mohammad", 18, "Good Evening Mohammad")]
        [InlineData("Mohammad", 18, "Good Evening Mohammad")]
        [InlineData("Mohammad", 19, "Good Evening Mohammad")]
        [InlineData("Mohammad", 20, "Good Evening Mohammad")]
        [InlineData("Mohammad", 21, "Good Evening Mohammad")]
        [InlineData("Mohammad", 22, "Good Evening Mohammad")]
        [InlineData("Mohammad", 23, "Good Evening Mohammad")]
        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfTheDay,
            string expected)
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();

            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
