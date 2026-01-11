using LambdaLinqExercises;
using LambdaLinqExercises.Models;
using Xunit;

namespace LambdaLinqTests
{
    public class Part4Tests
    {
        [Theory]
        [InlineData(new int[] { 5, 2, 8, 1, 9 }, new int[] { 1, 2, 5, 8, 9 })]
        [InlineData(new int[] { 3, 1, 2 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        public void Test_4_1_SortNumbersAscending_SortsCorrectly(int[] input, int[] expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part4_Sorting.SortNumbersAscending(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_4_1_SortNumbersAscending_HandlesNull()
        {
            // Act
            var result = Part4_Sorting.SortNumbersAscending(null);

            // Assert
            Assert.Empty(result);
        }

        [Theory]
        [InlineData(new int[] { 5, 2, 8, 1, 9 }, new int[] { 9, 8, 5, 2, 1 })]
        [InlineData(new int[] { 3, 1, 2 }, new int[] { 3, 2, 1 })]
        [InlineData(new int[] { }, new int[] { })]
        public void Test_4_2_SortNumbersDescending_SortsCorrectly(int[] input, int[] expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part4_Sorting.SortNumbersDescending(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_4_2_SortNumbersDescending_HandlesNull()
        {
            // Act
            var result = Part4_Sorting.SortNumbersDescending(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_4_3_SortProductsByPrice_SortsCorrectly()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Name = "B", Price = 50 },
                new Product { Name = "A", Price = 30 },
                new Product { Name = "C", Price = 40 }
            };

            // Act
            var result = Part4_Sorting.SortProductsByPrice(products);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Equal(30, result[0].Price);
            Assert.Equal(40, result[1].Price);
            Assert.Equal(50, result[2].Price);
        }

        [Fact]
        public void Test_4_3_SortProductsByPrice_HandlesNull()
        {
            // Act
            var result = Part4_Sorting.SortProductsByPrice(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_4_4_SortNamesAlphabetically_SortsCorrectly()
        {
            // Arrange
            var names = new List<string> { "Charlie", "Alice", "Bob", "David" };

            // Act
            var result = Part4_Sorting.SortNamesAlphabetically(names);

            // Assert
            Assert.Equal(new[] { "Alice", "Bob", "Charlie", "David" }, result);
        }

        [Fact]
        public void Test_4_4_SortNamesAlphabetically_HandlesNull()
        {
            // Act
            var result = Part4_Sorting.SortNamesAlphabetically(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_4_5_SortStudentsByAgeThenName_SortsCorrectly()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Bob", Age = 20 },
                new Student { Name = "Alice", Age = 20 },
                new Student { Name = "Charlie", Age = 19 },
                new Student { Name = "David", Age = 21 }
            };

            // Act
            var result = Part4_Sorting.SortStudentsByAgeThenName(students);

            // Assert
            Assert.Equal(4, result.Count);
            Assert.Equal("Charlie", result[0].Name);
            Assert.Equal(19, result[0].Age);
            Assert.Equal("Alice", result[1].Name);
            Assert.Equal(20, result[1].Age);
            Assert.Equal("Bob", result[2].Name);
            Assert.Equal(20, result[2].Age);
            Assert.Equal("David", result[3].Name);
            Assert.Equal(21, result[3].Age);
        }

        [Fact]
        public void Test_4_5_SortStudentsByAgeThenName_HandlesNull()
        {
            // Act
            var result = Part4_Sorting.SortStudentsByAgeThenName(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_4_6_SortEmployeesBySalaryDescThenName_SortsCorrectly()
        {
            // Arrange
            var employees = new List<Employee>
            {
                new Employee { Name = "Bob", Salary = 5000 },
                new Employee { Name = "Alice", Salary = 5000 },
                new Employee { Name = "Charlie", Salary = 6000 },
                new Employee { Name = "David", Salary = 4000 }
            };

            // Act
            var result = Part4_Sorting.SortEmployeesBySalaryDescThenName(employees);

            // Assert
            Assert.Equal(4, result.Count);
            Assert.Equal("Charlie", result[0].Name);
            Assert.Equal(6000, result[0].Salary);
            Assert.Equal("Alice", result[1].Name);
            Assert.Equal(5000, result[1].Salary);
            Assert.Equal("Bob", result[2].Name);
            Assert.Equal(5000, result[2].Salary);
            Assert.Equal("David", result[3].Name);
            Assert.Equal(4000, result[3].Salary);
        }

        [Fact]
        public void Test_4_6_SortEmployeesBySalaryDescThenName_HandlesNull()
        {
            // Act
            var result = Part4_Sorting.SortEmployeesBySalaryDescThenName(null);

            // Assert
            Assert.Empty(result);
        }
    }
}

