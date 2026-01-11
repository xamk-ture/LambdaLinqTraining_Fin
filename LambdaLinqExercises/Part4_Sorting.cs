using LambdaLinqExercises.Models;

namespace LambdaLinqExercises
{
    /// <summary>
    /// OSA 4: Järjestäminen (Sorting) LINQ:llä
    /// 
    /// Tässä osiossa opetellaan järjestämisoperaatioita:
    /// - OrderBy() - järjestä nousevaan järjestykseen
    /// - OrderByDescending() - järjestä laskevaan järjestykseen
    /// - ThenBy() - toinen järjestämisehto
    /// - ThenByDescending() - toinen järjestämisehto laskevana
    /// 
    /// Wiki-materiaali:
    /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#4-järjestäminen-orderby-orderbydescending
    /// </summary>
    public static class Part4_Sorting
    {
        // ============================================================================
        // TEHTÄVÄ 4.1: OrderBy - Järjestä luvut nousevaan järjestykseen
        // ============================================================================
        /// <summary>
        /// Järjestä luvut pienimmästä suurimpaan.
        /// 
        /// LINQ-operaatio: OrderBy()
        /// Syntaksi: collection.OrderBy(x => x).ToList()
        /// 
        /// Vihjeet:
        /// - OrderBy(x => x) järjestää alkiot nousevaan järjestykseen
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [5, 2, 8, 1, 9]
        /// Output: [1, 2, 5, 8, 9]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#4-järjestäminen-orderby-orderbydescending
        /// </summary>
        public static List<int> SortNumbersAscending(List<int>? numbers)
        {
            // TODO: Järjestä luvut nousevaan järjestykseen
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 4.2: OrderByDescending - Järjestä laskevaan järjestykseen
        // ============================================================================
        /// <summary>
        /// Järjestä luvut suurimmasta pienimpään.
        /// 
        /// LINQ-operaatio: OrderByDescending()
        /// Syntaksi: collection.OrderByDescending(x => x).ToList()
        /// 
        /// Vihjeet:
        /// - OrderByDescending järjestää laskevaan järjestykseen
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [5, 2, 8, 1, 9]
        /// Output: [9, 8, 5, 2, 1]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#4-järjestäminen-orderby-orderbydescending
        /// </summary>
        public static List<int> SortNumbersDescending(List<int>? numbers)
        {
            // TODO: Järjestä luvut laskevaan järjestykseen
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 4.3: OrderBy - Järjestä tuotteet hinnan mukaan
        // ============================================================================
        /// <summary>
        /// Järjestä tuotteet hinnan mukaan (halvin ensin).
        /// 
        /// LINQ-operaatio: OrderBy()
        /// Syntaksi: collection.OrderBy(x => x.Property).ToList()
        /// 
        /// Vihjeet:
        /// - Järjestä Product.Price mukaan
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Product(Price: 50), Product(Price: 30), Product(Price: 40)]
        /// Output: [Product(Price: 30), Product(Price: 40), Product(Price: 50)]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-4-järjestäminen-custom-logiikalla
        /// </summary>
        public static List<Product> SortProductsByPrice(List<Product>? products)
        {
            // TODO: Järjestä tuotteet hinnan mukaan
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 4.4: OrderBy - Järjestä nimet aakkos järjestykseen
        // ============================================================================
        /// <summary>
        /// Järjestä nimet aakkosjärjestykseen (A-Z).
        /// 
        /// LINQ-operaatio: OrderBy()
        /// Syntaksi: collection.OrderBy(x => x).ToList()
        /// 
        /// Vihjeet:
        /// - String-järjestys on automaattisesti aakkosjärjestys
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: ["Charlie", "Alice", "Bob"]
        /// Output: ["Alice", "Bob", "Charlie"]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#4-järjestäminen-orderby-orderbydescending
        /// </summary>
        public static List<string> SortNamesAlphabetically(List<string>? names)
        {
            // TODO: Järjestä nimet aakkosjärjestykseen
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 4.5: ThenBy - Moninkertainen järjestäminen
        // ============================================================================
        /// <summary>
        /// Järjestä opiskelijat ensin iän mukaan (nuorin ensin), 
        /// ja jos ikä on sama, niin nimen mukaan aakkosjärjestykseen.
        /// 
        /// LINQ-operaatio: OrderBy() + ThenBy()
        /// Syntaksi: collection.OrderBy(x => x.Property1).ThenBy(x => x.Property2).ToList()
        /// 
        /// Vihjeet:
        /// - OrderBy(s => s.Age) järjestää iän mukaan
        /// - ThenBy(s => s.Name) järjestää nimen mukaan saman iän sisällä
        /// - Voit ketjuttaa useita ThenBy:jä
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Student("Bob", 20), Student("Alice", 20), Student("Charlie", 19)]
        /// Output: [Student("Charlie", 19), Student("Alice", 20), Student("Bob", 20)]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-4-järjestäminen-custom-logiikalla
        /// </summary>
        public static List<Student> SortStudentsByAgeThenName(List<Student>? students)
        {
            // TODO: Järjestä opiskelijat iän mukaan, sitten nimen mukaan
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 4.6: OrderByDescending + ThenBy - Sekoitettu järjestys
        // ============================================================================
        /// <summary>
        /// Järjestä työntekijät ensin palkan mukaan (suurin ensin), 
        /// ja jos palkka on sama, niin nimen mukaan aakkosjärjestykseen.
        /// 
        /// LINQ-operaatio: OrderByDescending() + ThenBy()
        /// Syntaksi: collection.OrderByDescending(x => x.Property1).ThenBy(x => x.Property2).ToList()
        /// 
        /// Vihjeet:
        /// - OrderByDescending(e => e.Salary) järjestää palkan mukaan (suurin ensin)
        /// - ThenBy(e => e.Name) järjestää nimen mukaan saman palkan sisällä
        /// - Voit sekoittaa Ascending ja Descending järjestyksiä
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Employee("Alice", 5000€), Employee("Bob", 5000€), Employee("Charlie", 6000€)]
        /// Output: [Employee("Charlie", 6000€), Employee("Alice", 5000€), Employee("Bob", 5000€)]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-4-järjestäminen-custom-logiikalla
        /// </summary>
        public static List<Employee> SortEmployeesBySalaryDescThenName(List<Employee>? employees)
        {
            // TODO: Järjestä työntekijät palkan mukaan (laskeva), sitten nimen mukaan (nouseva)
            throw new NotImplementedException();
        }
    }
}

