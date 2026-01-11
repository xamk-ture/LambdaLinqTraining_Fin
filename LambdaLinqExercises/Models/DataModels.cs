namespace LambdaLinqExercises.Models
{
    /// <summary>
    /// Tuote-malli
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Category { get; set; } = string.Empty;
        public int StockQuantity { get; set; }
    }

    /// <summary>
    /// Opiskelija-malli
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public double Grade { get; set; }
        public string Major { get; set; } = string.Empty;
    }

    /// <summary>
    /// Tilaus-malli
    /// </summary>
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = string.Empty;
    }

    /// <summary>
    /// Henkilö-malli
    /// </summary>
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string City { get; set; } = string.Empty;
    }

    /// <summary>
    /// Kirja-malli
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Genre { get; set; } = string.Empty;
        public int Pages { get; set; }
    }

    /// <summary>
    /// Työntekijä-malli
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public int YearsOfService { get; set; }
    }
}

