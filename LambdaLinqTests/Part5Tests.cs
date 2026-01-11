using LambdaLinqExercises;
using LambdaLinqExercises.Models;
using Xunit;

namespace LambdaLinqTests
{
    public class Part5Tests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { }, 0)]
        public void Test_5_1_CountNumbers_ReturnsCorrectCount(int[] input, int expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part5_Aggregation.CountNumbers(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_5_1_CountNumbers_HandlesNull()
        {
            // Act
            var result = Part5_Aggregation.CountNumbers(null);

            // Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 3)]
        [InlineData(new int[] { 1, 3, 5 }, 0)]
        [InlineData(new int[] { 2, 4, 6 }, 3)]
        [InlineData(new int[] { }, 0)]
        public void Test_5_2_CountEvenNumbers_ReturnsCorrectCount(int[] input, int expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part5_Aggregation.CountEvenNumbers(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_5_2_CountEvenNumbers_HandlesNull()
        {
            // Act
            var result = Part5_Aggregation.CountEvenNumbers(null);

            // Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [InlineData(new int[] { 10, 20, 30 }, 60)]
        [InlineData(new int[] { }, 0)]
        public void Test_5_3_SumNumbers_ReturnsCorrectSum(int[] input, int expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part5_Aggregation.SumNumbers(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_5_3_SumNumbers_HandlesNull()
        {
            // Act
            var result = Part5_Aggregation.SumNumbers(null);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_5_4_SumProductPrices_ReturnsCorrectSum()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Price = 10.00m },
                new Product { Price = 20.00m },
                new Product { Price = 30.00m }
            };

            // Act
            var result = Part5_Aggregation.SumProductPrices(products);

            // Assert
            Assert.Equal(60.00m, result);
        }

        [Fact]
        public void Test_5_4_SumProductPrices_HandlesNullAndEmpty()
        {
            // Act & Assert
            Assert.Equal(0m, Part5_Aggregation.SumProductPrices(null));
            Assert.Equal(0m, Part5_Aggregation.SumProductPrices(new List<Product>()));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3.0)]
        [InlineData(new int[] { 10, 20, 30 }, 20.0)]
        [InlineData(new int[] { 5 }, 5.0)]
        public void Test_5_5_AverageNumbers_ReturnsCorrectAverage(int[] input, double expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part5_Aggregation.AverageNumbers(numbers);

            // Assert
            Assert.Equal(expected, result, precision: 2);
        }

        [Fact]
        public void Test_5_5_AverageNumbers_HandlesNullAndEmpty()
        {
            // Act & Assert
            Assert.Equal(0.0, Part5_Aggregation.AverageNumbers(null));
            Assert.Equal(0.0, Part5_Aggregation.AverageNumbers(new List<int>()));
        }

        [Theory]
        [InlineData(new int[] { 5, 2, 8, 1, 9 }, 1)]
        [InlineData(new int[] { 10, 20, 30 }, 10)]
        [InlineData(new int[] { -5, -10, -3 }, -10)]
        public void Test_5_6_FindMinNumber_ReturnsSmallest(int[] input, int expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part5_Aggregation.FindMinNumber(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_5_6_FindMinNumber_HandlesNullAndEmpty()
        {
            // Act & Assert
            Assert.Equal(0, Part5_Aggregation.FindMinNumber(null));
            Assert.Equal(0, Part5_Aggregation.FindMinNumber(new List<int>()));
        }

        [Theory]
        [InlineData(new int[] { 5, 2, 8, 1, 9 }, 9)]
        [InlineData(new int[] { 10, 20, 30 }, 30)]
        [InlineData(new int[] { -5, -10, -3 }, -3)]
        public void Test_5_6_FindMaxNumber_ReturnsLargest(int[] input, int expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part5_Aggregation.FindMaxNumber(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_5_6_FindMaxNumber_HandlesNullAndEmpty()
        {
            // Act & Assert
            Assert.Equal(0, Part5_Aggregation.FindMaxNumber(null));
            Assert.Equal(0, Part5_Aggregation.FindMaxNumber(new List<int>()));
        }

        [Fact]
        public void Test_5_7_SumElectronicsPrices_ReturnsCorrectSum()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 100.00m, Category = "Electronics" },
                new Product { Name = "Shirt", Price = 50.00m, Category = "Clothing" },
                new Product { Name = "Mouse", Price = 25.00m, Category = "Electronics" }
            };

            // Act
            var result = Part5_Aggregation.SumElectronicsPrices(products);

            // Assert
            Assert.Equal(125.00m, result);
        }

        [Fact]
        public void Test_5_7_SumElectronicsPrices_HandlesNullAndEmpty()
        {
            // Act & Assert
            Assert.Equal(0m, Part5_Aggregation.SumElectronicsPrices(null));
            Assert.Equal(0m, Part5_Aggregation.SumElectronicsPrices(new List<Product>()));
        }

        [Fact]
        public void Test_5_8_AverageStudentGrade_ReturnsCorrectAverage()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Alice", Grade = 8.0 },
                new Student { Name = "Bob", Grade = 9.0 },
                new Student { Name = "Charlie", Grade = 7.0 }
            };

            // Act
            var result = Part5_Aggregation.AverageStudentGrade(students);

            // Assert
            Assert.Equal(8.0, result, precision: 2);
        }

        [Fact]
        public void Test_5_8_AverageStudentGrade_HandlesNullAndEmpty()
        {
            // Act & Assert
            Assert.Equal(0.0, Part5_Aggregation.AverageStudentGrade(null));
            Assert.Equal(0.0, Part5_Aggregation.AverageStudentGrade(new List<Student>()));
        }
    }
}

