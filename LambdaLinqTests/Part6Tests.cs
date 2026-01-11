using LambdaLinqExercises;
using LambdaLinqExercises.Models;
using Xunit;

namespace LambdaLinqTests
{
    public class Part6Tests
    {
        [Fact]
        public void Test_6_1_GroupProductsByCategory_GroupsCorrectly()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Name = "Laptop", Category = "Electronics" },
                new Product { Name = "Shirt", Category = "Clothing" },
                new Product { Name = "Mouse", Category = "Electronics" },
                new Product { Name = "Pants", Category = "Clothing" }
            };

            // Act
            var result = Part6_Grouping.GroupProductsByCategory(products);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.True(result.ContainsKey("Electronics"));
            Assert.True(result.ContainsKey("Clothing"));
            Assert.Equal(2, result["Electronics"].Count);
            Assert.Equal(2, result["Clothing"].Count);
            Assert.Contains(result["Electronics"], p => p.Name == "Laptop");
            Assert.Contains(result["Electronics"], p => p.Name == "Mouse");
        }

        [Fact]
        public void Test_6_1_GroupProductsByCategory_HandlesNull()
        {
            // Act
            var result = Part6_Grouping.GroupProductsByCategory(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_6_2_CountProductsPerCategory_CountsCorrectly()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Category = "Electronics" },
                new Product { Category = "Electronics" },
                new Product { Category = "Clothing" },
                new Product { Category = "Electronics" }
            };

            // Act
            var result = Part6_Grouping.CountProductsPerCategory(products);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal(3, result["Electronics"]);
            Assert.Equal(1, result["Clothing"]);
        }

        [Fact]
        public void Test_6_2_CountProductsPerCategory_HandlesNull()
        {
            // Act
            var result = Part6_Grouping.CountProductsPerCategory(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_6_3_SumPricesPerCategory_SumsCorrectly()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Name = "Laptop", Category = "Electronics", Price = 100.00m },
                new Product { Name = "Mouse", Category = "Electronics", Price = 50.00m },
                new Product { Name = "Shirt", Category = "Clothing", Price = 30.00m },
                new Product { Name = "Pants", Category = "Clothing", Price = 40.00m }
            };

            // Act
            var result = Part6_Grouping.SumPricesPerCategory(products);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal(150.00m, result["Electronics"]);
            Assert.Equal(70.00m, result["Clothing"]);
        }

        [Fact]
        public void Test_6_3_SumPricesPerCategory_HandlesNull()
        {
            // Act
            var result = Part6_Grouping.SumPricesPerCategory(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_6_4_AverageGradePerMajor_CalculatesCorrectly()
        {
            // Arrange
            var students = new List<Student>
            {
                new Student { Name = "Alice", Major = "CS", Grade = 8.0 },
                new Student { Name = "Bob", Major = "CS", Grade = 9.0 },
                new Student { Name = "Charlie", Major = "Math", Grade = 7.0 },
                new Student { Name = "David", Major = "Math", Grade = 9.0 }
            };

            // Act
            var result = Part6_Grouping.AverageGradePerMajor(students);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal(8.5, result["CS"], precision: 2);
            Assert.Equal(8.0, result["Math"], precision: 2);
        }

        [Fact]
        public void Test_6_4_AverageGradePerMajor_HandlesNull()
        {
            // Act
            var result = Part6_Grouping.AverageGradePerMajor(null);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Test_6_5_GroupEmployeesByDepartmentWithStats_CreatesCorrectStats()
        {
            // Arrange
            var employees = new List<Employee>
            {
                new Employee { Name = "Alice", Department = "IT", Salary = 5000 },
                new Employee { Name = "Bob", Department = "IT", Salary = 6000 },
                new Employee { Name = "Charlie", Department = "HR", Salary = 4000 },
                new Employee { Name = "David", Department = "HR", Salary = 4500 }
            };

            // Act
            var result = Part6_Grouping.GroupEmployeesByDepartmentWithStats(employees);

            // Assert
            Assert.Equal(2, result.Count);

            // Check IT department
            dynamic itDept = result.FirstOrDefault(x =>
            {
                dynamic d = x;
                return d.Department == "IT";
            });
            Assert.NotNull(itDept);
            Assert.Equal("IT", itDept.Department);
            Assert.Equal(2, itDept.EmployeeCount);
            Assert.Equal(5500.0, itDept.AverageSalary, precision: 2);

            // Check HR department
            dynamic hrDept = result.FirstOrDefault(x =>
            {
                dynamic d = x;
                return d.Department == "HR";
            });
            Assert.NotNull(hrDept);
            Assert.Equal("HR", hrDept.Department);
            Assert.Equal(2, hrDept.EmployeeCount);
            Assert.Equal(4250.0, hrDept.AverageSalary, precision: 2);
        }

        [Fact]
        public void Test_6_5_GroupEmployeesByDepartmentWithStats_HandlesNull()
        {
            // Act
            var result = Part6_Grouping.GroupEmployeesByDepartmentWithStats(null);

            // Assert
            Assert.Empty(result);
        }
    }
}

