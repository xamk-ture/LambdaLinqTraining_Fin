using LambdaLinqExercises.Models;

namespace LambdaLinqExercises
{
    /// <summary>
    /// OSA 6: Ryhmittely (Grouping) LINQ:llä
    /// 
    /// Tässä osiossa opetellaan GroupBy-operaatiota:
    /// - Ryhmittely yhden avaimen mukaan
    /// - Aggregointi ryhmittäin
    /// - Monimutkainen ryhmittely ja projektointi
    /// 
    /// GroupBy palauttaa IGrouping&lt;TKey, TElement&gt;-kokoelman,
    /// jossa jokaisella ryhmällä on Key (ryhmittelyavain) ja Elements (ryhmän alkiot).
    /// 
    /// Wiki-materiaali:
    /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#3-ryhmittely-groupby
    /// </summary>
    public static class Part6_Grouping
    {
        // ============================================================================
        // TEHTÄVÄ 6.1: GroupBy - Ryhmittele tuotteet kategorian mukaan
        // ============================================================================
        /// <summary>
        /// Ryhmittele tuotteet kategorian mukaan ja palauta Dictionary,
        /// jossa avain on kategoria ja arvo on lista tuotteita.
        /// 
        /// LINQ-operaatio: GroupBy() + ToDictionary()
        /// Syntaksi: collection.GroupBy(x => x.Property).ToDictionary(g => g.Key, g => g.ToList())
        /// 
        /// Vihjeet:
        /// - GroupBy(p => p.Category) ryhmittelee kategorian mukaan
        /// - ToDictionary(g => g.Key, g => g.ToList()) muuttaa Dictionary:ksi
        /// - g.Key on ryhmittelyavain (kategoria)
        /// - g.ToList() on ryhmän alkiot listana
        /// - Palauta tyhjä Dictionary jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Product("A", "Electronics"), Product("B", "Clothing"), Product("C", "Electronics")]
        /// Output: { "Electronics": [Product("A"), Product("C")], "Clothing": [Product("B")] }
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#3-ryhmittely-groupby
        /// </summary>
        public static Dictionary<string, List<Product>> GroupProductsByCategory(List<Product>? products)
        {
            // TODO: Ryhmittele tuotteet kategorian mukaan
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 6.2: GroupBy + Count - Laske tuotteita per kategoria
        // ============================================================================
        /// <summary>
        /// Ryhmittele tuotteet kategorian mukaan ja palauta Dictionary,
        /// jossa avain on kategoria ja arvo on tuotteiden määrä kyseisessä kategoriassa.
        /// 
        /// LINQ-operaatio: GroupBy() + ToDictionary() + Count()
        /// Syntaksi: collection.GroupBy(x => x.Property).ToDictionary(g => g.Key, g => g.Count())
        /// 
        /// Vihjeet:
        /// - GroupBy(p => p.Category) ryhmittelee kategorian mukaan
        /// - ToDictionary(g => g.Key, g => g.Count()) laskee määrät
        /// - Palauta tyhjä Dictionary jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Product(Category: "Electronics"), Product(Category: "Electronics"), Product(Category: "Clothing")]
        /// Output: { "Electronics": 2, "Clothing": 1 }
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#3-ryhmittely-groupby
        /// </summary>
        public static Dictionary<string, int> CountProductsPerCategory(List<Product>? products)
        {
            // TODO: Laske tuotteiden määrä per kategoria
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 6.3: GroupBy + Sum - Laske kokonaishinta per kategoria
        // ============================================================================
        /// <summary>
        /// Ryhmittele tuotteet kategorian mukaan ja laske jokaisen kategorian tuotteiden
        /// hintojen summa.
        /// 
        /// LINQ-operaatio: GroupBy() + ToDictionary() + Sum()
        /// Syntaksi: collection.GroupBy(x => x.Property).ToDictionary(g => g.Key, g => g.Sum(x => x.Price))
        /// 
        /// Vihjeet:
        /// - GroupBy(p => p.Category) ryhmittelee kategorian mukaan
        /// - g.Sum(p => p.Price) laskee hintojen summan ryhmästä
        /// - Palauta tyhjä Dictionary jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Product("A", "Electronics", 100€), Product("B", "Electronics", 50€), Product("C", "Clothing", 30€)]
        /// Output: { "Electronics": 150€, "Clothing": 30€ }
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-2-tuotteiden-suodattaminen-ja-hinnan-laskeminen
        /// </summary>
        public static Dictionary<string, decimal> SumPricesPerCategory(List<Product>? products)
        {
            // TODO: Laske hintojen summa per kategoria
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 6.4: GroupBy - Ryhmittele opiskelijat pääaineen mukaan
        // ============================================================================
        /// <summary>
        /// Ryhmittele opiskelijat pääaineen (Major) mukaan ja laske jokaisen pääaineen
        /// opiskelijoiden keskiarvosana.
        /// 
        /// LINQ-operaatio: GroupBy() + ToDictionary() + Average()
        /// Syntaksi: collection.GroupBy(x => x.Property).ToDictionary(g => g.Key, g => g.Average(x => x.Grade))
        /// 
        /// Vihjeet:
        /// - GroupBy(s => s.Major) ryhmittelee pääaineen mukaan
        /// - g.Average(s => s.Grade) laskee keskiarvon ryhmästä
        /// - Palauta tyhjä Dictionary jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Student("A", "CS", Grade: 8), Student("B", "CS", Grade: 9), Student("C", "Math", Grade: 7)]
        /// Output: { "CS": 8.5, "Math": 7.0 }
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-5-aggregointi-ja-laskenta
        /// </summary>
        public static Dictionary<string, double> AverageGradePerMajor(List<Student>? students)
        {
            // TODO: Laske keskiarvosana per pääaine
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 6.5: GroupBy - Monimutkainen ryhmittely ja projektointi
        // ============================================================================
        /// <summary>
        /// Ryhmittele työntekijät osaston mukaan ja luo jokaiselle osastolle anonyymi objekti,
        /// joka sisältää osaston nimen, työntekijöiden määrän ja keskipalkan.
        /// 
        /// LINQ-operaatio: GroupBy() + Select() + ToList()
        /// Syntaksi: 
        /// collection.GroupBy(x => x.Property)
        ///           .Select(g => new { Key = g.Key, Count = g.Count(), Avg = g.Average(...) })
        ///           .ToList()
        /// 
        /// Anonyymi objekti pitää sisältää:
        /// - Department (string): osaston nimi
        /// - EmployeeCount (int): työntekijöiden määrä
        /// - AverageSalary (double): keskipalkka
        /// 
        /// Vihjeet:
        /// - GroupBy(e => e.Department) ryhmittelee osaston mukaan
        /// - Select(g => new { ... }) luo anonyymi objektin jokaiselle ryhmälle
        /// - g.Key on osaston nimi
        /// - g.Count() on työntekijöiden määrä
        /// - g.Average(e => (double)e.Salary) on keskipalkka
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Employee("A", "IT", 5000€), Employee("B", "IT", 6000€), Employee("C", "HR", 4000€)]
        /// Output: [
        ///   { Department: "IT", EmployeeCount: 2, AverageSalary: 5500.0 },
        ///   { Department: "HR", EmployeeCount: 1, AverageSalary: 4000.0 }
        /// ]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#3-ryhmittely-groupby
        /// </summary>
        public static List<object> GroupEmployeesByDepartmentWithStats(List<Employee>? employees)
        {
            // TODO: Ryhmittele työntekijät osaston mukaan ja laske tilastot
            throw new NotImplementedException();
        }
    }
}

