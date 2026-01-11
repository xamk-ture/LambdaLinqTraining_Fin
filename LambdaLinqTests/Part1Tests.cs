using LambdaLinqExercises;
using Xunit;

namespace LambdaLinqTests
{
    public class Part1Tests
    {
        [Fact]
        public void Test_1_1_CreateConstantFunction_Returns42()
        {
            // Arrange & Act
            var func = Part1_LambdaBasics.CreateConstantFunction();
            var result = func();

            // Assert
            Assert.Equal(42, result);
        }

        [Theory]
        [InlineData(5, 10)]
        [InlineData(0, 0)]
        [InlineData(-3, -6)]
        [InlineData(100, 200)]
        public void Test_1_2_CreateDoubleFunction_DoublesTheNumber(int input, int expected)
        {
            // Arrange & Act
            var func = Part1_LambdaBasics.CreateDoubleFunction();
            var result = func(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-5, 10, 5)]
        [InlineData(100, 200, 300)]
        public void Test_1_3_CreateAddFunction_AddsTwoNumbers(int a, int b, int expected)
        {
            // Arrange & Act
            var func = Part1_LambdaBasics.CreateAddFunction();
            var result = func(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 25)]
        [InlineData(0, 0)]
        [InlineData(-3, 9)]
        [InlineData(10, 100)]
        public void Test_1_4_CreateSquareFunction_ReturnsSquare(int input, int expected)
        {
            // Arrange & Act
            var func = Part1_LambdaBasics.CreateSquareFunction();
            var result = func(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Alice")]
        [InlineData("Bob")]
        [InlineData("World")]
        public void Test_1_5_CreateGreetingAction_PrintsCorrectMessage(string name)
        {
            // Arrange
            var action = Part1_LambdaBasics.CreateGreetingAction();
            var expectedOutput = $"Hello, {name}!";

            // Capture console output
            var originalOut = Console.Out;
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            action(name);

            // Reset console
            Console.SetOut(originalOut);

            // Assert
            var output = stringWriter.ToString().Trim();
            Assert.Equal(expectedOutput, output);
        }

        [Theory]
        [InlineData(5, true)]
        [InlineData(0, false)]
        [InlineData(-3, false)]
        [InlineData(100, true)]
        [InlineData(1, true)]
        public void Test_1_6_CreateIsPositivePredicate_ChecksIfPositive(int input, bool expected)
        {
            // Arrange & Act
            var predicate = Part1_LambdaBasics.CreateIsPositivePredicate();
            var result = predicate(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("hello", "HELLO")]
        [InlineData("World", "WORLD")]
        [InlineData("C#", "C#")]
        [InlineData("lambda", "LAMBDA")]
        public void Test_1_7_CreateToUpperFunction_ConvertsToUpperCase(string input, string expected)
        {
            // Arrange & Act
            var func = Part1_LambdaBasics.CreateToUpperFunction();
            var result = func(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, 4, 24)]
        [InlineData(5, 2, 10, 100)]
        [InlineData(1, 1, 1, 1)]
        [InlineData(0, 5, 10, 0)]
        [InlineData(-2, 3, 4, -24)]
        public void Test_1_8_CreateMultiplyThreeFunction_MultipliesThreeNumbers(int a, int b, int c, int expected)
        {
            // Arrange & Act
            var func = Part1_LambdaBasics.CreateMultiplyThreeFunction();
            var result = func(a, b, c);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

