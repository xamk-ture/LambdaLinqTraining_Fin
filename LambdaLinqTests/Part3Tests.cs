using LambdaLinqExercises;
using LambdaLinqExercises.Models;
using Xunit;

namespace LambdaLinqTests
{
    public class Part3Tests
    {
        // Helper method to get property value from anonymous type
        private static T? GetPropertyValue<T>(object obj, string propertyName)
        {
            var type = obj.GetType();
            var property = type.GetProperty(propertyName);
            return property != null ? (T?)property.GetValue(obj) : default(T);
        }
        [Fact]
        public void Test_3_1_GetProductNames_ReturnsAllNames()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Name = "Laptop" },
                new Product { Name = "Mouse" },
                new Product { Name = "Keyboard" }
            };

            // Act
            var result = Part3_Projection.GetProductNames(products);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Contains("Laptop", result);
            Assert.Contains("Mouse", result);
            Assert.Contains("Keyboard", result);
        }

        [Fact]
        public void Test_3_1_GetProductNames_HandlesNull()
        {
            // Act
            var result = Part3_Projection.GetProductNames(null);

            // Assert
            Assert.Empty(result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 4, 9, 16 })]
        [InlineData(new int[] { 5, 6 }, new int[] { 25, 36 })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { }, new int[] { })]
        public void Test_3_2_ConvertToSquares_ReturnsSquaredNumbers(int[] input, int[] expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part3_Projection.ConvertToSquares(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_3_2_ConvertToSquares_HandlesNull()
        {
            // Act
            var result = Part3_Projection.ConvertToSquares(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_3_3_ProjectStudentsToAnonymousType_CreatesCorrectObjects()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Alice", Age = 20 },
                new Student { Name = "Bob", Age = 16 },
                new Student { Name = "Charlie", Age = 18 }
            };

            // Act
            var result = Part3_Projection.ProjectStudentsToAnonymousType(students);

            // Assert
            Assert.Equal(3, result.Count);

            // Check first student
            Assert.Equal("Alice", GetPropertyValue<string>(result[0], "Name"));
            Assert.True(GetPropertyValue<bool>(result[0], "IsAdult"));

            // Check second student
            Assert.Equal("Bob", GetPropertyValue<string>(result[1], "Name"));
            Assert.False(GetPropertyValue<bool>(result[1], "IsAdult"));

            // Check third student
            Assert.Equal("Charlie", GetPropertyValue<string>(result[2], "Name"));
            Assert.True(GetPropertyValue<bool>(result[2], "IsAdult"));
        }

        [Fact]
        public void Test_3_3_ProjectStudentsToAnonymousType_HandlesNull()
        {
            // Act
            var result = Part3_Projection.ProjectStudentsToAnonymousType(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_3_4_GetNamesOfAffordableProducts_FiltersAndProjects()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Name = "Cheap1", Price = 50 },
                new Product { Name = "Expensive", Price = 150 },
                new Product { Name = "Cheap2", Price = 75 },
                new Product { Name = "Affordable", Price = 99 }
            };

            // Act
            var result = Part3_Projection.GetNamesOfAffordableProducts(products);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Contains("Cheap1", result);
            Assert.Contains("Cheap2", result);
            Assert.Contains("Affordable", result);
            Assert.DoesNotContain("Expensive", result);
        }

        [Fact]
        public void Test_3_4_GetNamesOfAffordableProducts_HandlesNull()
        {
            // Act
            var result = Part3_Projection.GetNamesOfAffordableProducts(null);

            // Assert
            Assert.Empty(result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new string[] { "Numero: 1", "Numero: 2", "Numero: 3" })]
        [InlineData(new int[] { 10, 20 }, new string[] { "Numero: 10", "Numero: 20" })]
        [InlineData(new int[] { }, new string[] { })]
        public void Test_3_5_ConvertNumbersToStrings_FormatsCorrectly(int[] input, string[] expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part3_Projection.ConvertNumbersToStrings(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_3_5_ConvertNumbersToStrings_HandlesNull()
        {
            // Act
            var result = Part3_Projection.ConvertNumbersToStrings(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_3_6_GetFullNames_CombinesNames()
        {
            // Arrange
            var people = new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe" },
                new Person { FirstName = "Jane", LastName = "Smith" },
                new Person { FirstName = "Alice", LastName = "Johnson" }
            };

            // Act
            var result = Part3_Projection.GetFullNames(people);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Contains("John Doe", result);
            Assert.Contains("Jane Smith", result);
            Assert.Contains("Alice Johnson", result);
        }

        [Fact]
        public void Test_3_6_GetFullNames_HandlesNull()
        {
            // Act
            var result = Part3_Projection.GetFullNames(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_3_7_GetRecentBookTitles_FiltersAndProjects()
        {
            // Arrange
            var books = new List<Book>
            {
                new Book { Title = "Old Book", Year = 1990 },
                new Book { Title = "Millennium Book", Year = 2000 },
                new Book { Title = "New Book", Year = 2010 },
                new Book { Title = "Recent Book", Year = 2020 }
            };

            // Act
            var result = Part3_Projection.GetRecentBookTitles(books);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains("New Book", result);
            Assert.Contains("Recent Book", result);
            Assert.DoesNotContain("Old Book", result);
            Assert.DoesNotContain("Millennium Book", result);
        }

        [Fact]
        public void Test_3_7_GetRecentBookTitles_HandlesNull()
        {
            // Act
            var result = Part3_Projection.GetRecentBookTitles(null);

            // Assert
            Assert.Empty(result);
        }
    }
}

