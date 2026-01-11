using LambdaLinqExercises;
using LambdaLinqExercises.Models;
using Xunit;

namespace LambdaLinqTests
{
    public class Part2Tests
    {
        [Theory]
        [InlineData(null, new int[] { })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 1, 3, 5 }, new int[] { })]
        [InlineData(new int[] { 2, 4, 6 }, new int[] { 2, 4, 6 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 2, 4, 6 })]
        public void Test_2_1_FilterEvenNumbers_ReturnsOnlyEvenNumbers(int[]? input, int[] expected)
        {
            // Arrange
            var numbers = input?.ToList();

            // Act
            var result = Part2_BasicFiltering.FilterEvenNumbers(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_2_2_FilterCheapProducts_ReturnsProductsUnder50()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Name = "Cheap1", Price = 30 },
                new Product { Name = "Expensive", Price = 60 },
                new Product { Name = "Cheap2", Price = 45 },
                new Product { Name = "VeryCheap", Price = 10 }
            };

            // Act
            var result = Part2_BasicFiltering.FilterCheapProducts(products);

            // Assert
            Assert.Equal(3, result.Count);
            Assert.Contains(result, p => p.Name == "Cheap1");
            Assert.Contains(result, p => p.Name == "Cheap2");
            Assert.Contains(result, p => p.Name == "VeryCheap");
            Assert.DoesNotContain(result, p => p.Name == "Expensive");
        }

        [Fact]
        public void Test_2_2_FilterCheapProducts_HandlesNull()
        {
            // Act
            var result = Part2_BasicFiltering.FilterCheapProducts(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_2_3_FilterAdultStudentsWithGoodGrades_ReturnsCorrectStudents()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Alice", Age = 20, Grade = 8.0 },      // ✓ > 18 and > 7.0
                new Student { Name = "Bob", Age = 17, Grade = 9.0 },        // ✗ age
                new Student { Name = "Charlie", Age = 19, Grade = 6.0 },    // ✗ grade
                new Student { Name = "David", Age = 22, Grade = 7.5 }       // ✓ > 18 and > 7.0
            };

            // Act
            var result = Part2_BasicFiltering.FilterAdultStudentsWithGoodGrades(students);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, s => s.Name == "Alice");
            Assert.Contains(result, s => s.Name == "David");
        }

        [Fact]
        public void Test_2_3_FilterAdultStudentsWithGoodGrades_HandlesNull()
        {
            // Act
            var result = Part2_BasicFiltering.FilterAdultStudentsWithGoodGrades(null);

            // Assert
            Assert.Empty(result);
        }

        [Theory]
        [InlineData(new int[] { 3, 7, 15, 8, 20 }, 15)]
        [InlineData(new int[] { 1, 2, 11, 5, 12 }, 11)]
        [InlineData(new int[] { 20, 15, 11 }, 20)]
        public void Test_2_4_FindFirstNumberGreaterThan10_ReturnsFirstMatch(int[] input, int expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part2_BasicFiltering.FindFirstNumberGreaterThan10(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[] { })]
        [InlineData(new int[] { 1, 2, 3, 5, 10 })]
        public void Test_2_4_FindFirstNumberGreaterThan10_ReturnsZeroWhenNotFound(int[]? input)
        {
            // Arrange
            var numbers = input?.ToList();

            // Act
            var result = Part2_BasicFiltering.FindFirstNumberGreaterThan10(numbers);

            // Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, -3, 4 }, true)]
        [InlineData(new int[] { -1, -2, -3 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 0 }, false)]
        public void Test_2_5_HasNegativeNumbers_ChecksForNegatives(int[] input, bool expected)
        {
            // Arrange
            var numbers = input.ToList();

            // Act
            var result = Part2_BasicFiltering.HasNegativeNumbers(numbers);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_2_5_HasNegativeNumbers_ReturnsFalseForNullOrEmpty()
        {
            // Act & Assert
            Assert.False(Part2_BasicFiltering.HasNegativeNumbers(null));
            Assert.False(Part2_BasicFiltering.HasNegativeNumbers(new List<int>()));
        }

        [Fact]
        public void Test_2_6_AreAllProductsInStock_ReturnsTrue_WhenAllInStock()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Name = "A", StockQuantity = 5 },
                new Product { Name = "B", StockQuantity = 10 },
                new Product { Name = "C", StockQuantity = 1 }
            };

            // Act
            var result = Part2_BasicFiltering.AreAllProductsInStock(products);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Test_2_6_AreAllProductsInStock_ReturnsFalse_WhenSomeOutOfStock()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Name = "A", StockQuantity = 5 },
                new Product { Name = "B", StockQuantity = 0 },
                new Product { Name = "C", StockQuantity = 1 }
            };

            // Act
            var result = Part2_BasicFiltering.AreAllProductsInStock(products);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Test_2_6_AreAllProductsInStock_ReturnsTrueForNullOrEmpty()
        {
            // Act & Assert
            Assert.True(Part2_BasicFiltering.AreAllProductsInStock(null));
            Assert.True(Part2_BasicFiltering.AreAllProductsInStock(new List<Product>()));
        }

        [Theory]
        [MemberData(nameof(GetNamesData))]
        public void Test_2_7_FilterNamesStartingWithA_ReturnsCorrectNames(List<string>? input, string[] expected)
        {
            // Act
            var result = Part2_BasicFiltering.FilterNamesStartingWithA(input);

            // Assert
            Assert.Equal(expected.Length, result.Count);
            foreach (var name in expected)
            {
                Assert.Contains(name, result);
            }
        }

        public static IEnumerable<object?[]> GetNamesData()
        {
            yield return new object?[] { null, Array.Empty<string>() };
            yield return new object[] { new List<string>(), Array.Empty<string>() };
            yield return new object[] { new List<string> { "Alice", "Bob", "Anna", "Charlie" }, new[] { "Alice", "Anna" } };
            yield return new object[] { new List<string> { "andrew", "Bob" }, Array.Empty<string>() }; // lowercase 'a' should not match
            yield return new object[] { new List<string> { "Amber", "Alex", "Aaron" }, new[] { "Amber", "Alex", "Aaron" } };
        }

        [Fact]
        public void Test_2_8_FilterPeopleFromHelsinki_ReturnsCorrectPeople()
        {
            // Arrange
            var people = new List<Person>
            {
                new Person { FirstName = "Alice", City = "Helsinki" },
                new Person { FirstName = "Bob", City = "Turku" },
                new Person { FirstName = "Charlie", City = "Helsinki" },
                new Person { FirstName = "David", City = "Tampere" }
            };

            // Act
            var result = Part2_BasicFiltering.FilterPeopleFromHelsinki(people);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Contains(result, p => p.FirstName == "Alice");
            Assert.Contains(result, p => p.FirstName == "Charlie");
        }

        [Fact]
        public void Test_2_8_FilterPeopleFromHelsinki_HandlesNull()
        {
            // Act
            var result = Part2_BasicFiltering.FilterPeopleFromHelsinki(null);

            // Assert
            Assert.Empty(result);
        }
    }
}

