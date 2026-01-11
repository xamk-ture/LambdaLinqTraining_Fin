using LambdaLinqExercises.Models;

namespace LambdaLinqExercises
{
    /// <summary>
    /// OSA 2: Perussuodatus LINQ:llä
    /// 
    /// Tässä osiossa opetellaan yleisimmät LINQ-suodatusoperaatiot:
    /// - Where() - suodata kokoelmasta
    /// - First() / FirstOrDefault() - etsi ensimmäinen
    /// - Any() - tarkista löytyykö
    /// - All() - tarkista täyttävätkö kaikki
    /// 
    /// Wiki-materiaali:
    /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#linq-peruskäsitteet
    /// </summary>
    public static class Part2_BasicFiltering
    {
        // ============================================================================
        // TEHTÄVÄ 2.1: Where - Suodata parilliset luvut
        // ============================================================================
        /// <summary>
        /// Palauta kaikki parilliset luvut listasta.
        /// 
        /// LINQ-operaatio: Where()
        /// Syntaksi: collection.Where(x => ehto).ToList()
        /// 
        /// Vihjeet:
        /// - Luku on parillinen kun x % 2 == 0
        /// - Muista .ToList() lopussa
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [1, 2, 3, 4, 5, 6]
        /// Output: [2, 4, 6]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#1-suodatus-where
        /// </summary>
        public static List<int> FilterEvenNumbers(List<int>? numbers)
        {
            // TODO: Suodata parilliset luvut
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 2.2: Where - Suodata tuotteet hinnan mukaan
        // ============================================================================
        /// <summary>
        /// Palauta kaikki tuotteet, joiden hinta on alle 50€.
        /// 
        /// LINQ-operaatio: Where()
        /// Syntaksi: collection.Where(x => x.Property < value).ToList()
        /// 
        /// Vihjeet:
        /// - Käytä Product.Price ominaisuutta
        /// - Vertaa: Price < 50
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Product("A", 30€), Product("B", 60€), Product("C", 40€)]
        /// Output: [Product("A", 30€), Product("C", 40€)]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-2-tuotteiden-suodattaminen-ja-hinnan-laskeminen
        /// </summary>
        public static List<Product> FilterCheapProducts(List<Product>? products)
        {
            // TODO: Suodata tuotteet joiden hinta < 50
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 2.3: Where - Moninkertainen ehto
        // ============================================================================
        /// <summary>
        /// Palauta kaikki opiskelijat, jotka ovat yli 18-vuotiaita JA joiden arvosana on yli 7.0.
        /// 
        /// LINQ-operaatio: Where()
        /// Syntaksi: collection.Where(x => ehto1 && ehto2).ToList()
        /// 
        /// Vihjeet:
        /// - Käytä AND-operaattoria: &&
        /// - Tarkista Age > 18
        /// - Tarkista Grade > 7.0
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Student("A", 20, 8.0), Student("B", 17, 9.0), Student("C", 19, 6.0)]
        /// Output: [Student("A", 20, 8.0)]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-1-opiskelijoiden-suodattaminen-ja-järjestäminen
        /// </summary>
        public static List<Student> FilterAdultStudentsWithGoodGrades(List<Student>? students)
        {
            // TODO: Suodata opiskelijat jotka ovat > 18v JA Grade > 7.0
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 2.4: First - Etsi ensimmäinen
        // ============================================================================
        /// <summary>
        /// Etsi ja palauta ensimmäinen luku, joka on suurempi kuin 10.
        /// 
        /// LINQ-operaatio: First()
        /// Syntaksi: collection.First(x => ehto)
        /// 
        /// Vihjeet:
        /// - First() palauttaa yhden arvon (ei listaa)
        /// - First() heittää poikkeuksen jos ei löydy -> käytä FirstOrDefault()
        /// - Tarkista ensin onko lista null tai tyhjä
        /// - Palauta 0 jos ei löydy
        /// 
        /// Esimerkki:
        /// Input: [3, 7, 15, 8, 20]
        /// Output: 15
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#7-first-vs-firstordefault
        /// </summary>
        public static int FindFirstNumberGreaterThan10(List<int>? numbers)
        {
            // TODO: Etsi ensimmäinen luku > 10, palauta 0 jos ei löydy
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 2.5: Any - Tarkista löytyykö jotain
        // ============================================================================
        /// <summary>
        /// Tarkista löytyykö listasta yhtään negatiivista lukua.
        /// 
        /// LINQ-operaatio: Any()
        /// Syntaksi: collection.Any(x => ehto)
        /// 
        /// Vihjeet:
        /// - Any() palauttaa bool:n (true/false)
        /// - Tarkista onko jokin luku < 0
        /// - Palauta false jos lista on null tai tyhjä
        /// 
        /// Esimerkki:
        /// Input: [1, 2, -3, 4]
        /// Output: true
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-5-any-all-ja-contains
        /// </summary>
        public static bool HasNegativeNumbers(List<int>? numbers)
        {
            // TODO: Tarkista löytyykö negatiivisia lukuja
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 2.6: All - Tarkista täyttävätkö kaikki
        // ============================================================================
        /// <summary>
        /// Tarkista ovatko kaikki tuotteet varastossa (StockQuantity > 0).
        /// 
        /// LINQ-operaatio: All()
        /// Syntaksi: collection.All(x => ehto)
        /// 
        /// Vihjeet:
        /// - All() palauttaa bool:n
        /// - Tarkista StockQuantity > 0
        /// - Palauta true jos lista on null tai tyhjä (kaikki tyhjän listan alkiot täyttävät ehdon)
        /// 
        /// Esimerkki:
        /// Input: [Product(Stock: 5), Product(Stock: 10), Product(Stock: 0)]
        /// Output: false
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-5-any-all-ja-contains
        /// </summary>
        public static bool AreAllProductsInStock(List<Product>? products)
        {
            // TODO: Tarkista ovatko kaikki tuotteet varastossa
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 2.7: Where - Suodata merkkijonojen mukaan
        // ============================================================================
        /// <summary>
        /// Palauta kaikki nimet, jotka alkavat kirjaimella 'A'.
        /// 
        /// LINQ-operaatio: Where()
        /// Syntaksi: collection.Where(x => x.StartsWith("A")).ToList()
        /// 
        /// Vihjeet:
        /// - Käytä string.StartsWith() metodia
        /// - Huomioi isot ja pienet kirjaimet
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: ["Alice", "Bob", "Anna", "Charlie"]
        /// Output: ["Alice", "Anna"]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#1-suodatus-where
        /// </summary>
        public static List<string> FilterNamesStartingWithA(List<string>? names)
        {
            // TODO: Suodata nimet jotka alkavat A:lla
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 2.8: Where & Any - Yhdistetty haku
        // ============================================================================
        /// <summary>
        /// Palauta kaikki henkilöt, jotka asuvat "Helsinki"-kaupungissa.
        /// Palauta myös tyhjä lista jos input on null.
        /// 
        /// LINQ-operaatio: Where()
        /// 
        /// Vihjeet:
        /// - Vertaa Person.City == "Helsinki"
        /// - Käytä exact match (ei case-insensitive)
        /// 
        /// Esimerkki:
        /// Input: [Person("A", "Helsinki"), Person("B", "Turku"), Person("C", "Helsinki")]
        /// Output: [Person("A", "Helsinki"), Person("C", "Helsinki")]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-1-henkilöiden-suodatus
        /// </summary>
        public static List<Person> FilterPeopleFromHelsinki(List<Person>? people)
        {
            // TODO: Suodata henkilöt jotka asuvat Helsingissä
            throw new NotImplementedException();
        }
    }
}

