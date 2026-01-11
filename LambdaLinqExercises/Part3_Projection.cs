using LambdaLinqExercises.Models;

namespace LambdaLinqExercises
{
    /// <summary>
    /// OSA 3: Projektointi (Projection) LINQ:llä
    /// 
    /// Tässä osiossa opetellaan Select-operaatiota, jolla voidaan:
    /// - Muuntaa kokoelma toiseksi (esim. Product → string)
    /// - Poimia tietty ominaisuus (esim. pelkät nimet)
    /// - Luoda anonyymi tyyppi
    /// - Ketjuttaa Where ja Select
    /// 
    /// Wiki-materiaali:
    /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#2-projektointi-select
    /// </summary>
    public static class Part3_Projection
    {
        // ============================================================================
        // TEHTÄVÄ 3.1: Select - Palauta pelkät nimet
        // ============================================================================
        /// <summary>
        /// Palauta lista tuotteiden nimistä.
        /// 
        /// LINQ-operaatio: Select()
        /// Syntaksi: collection.Select(x => x.Property).ToList()
        /// 
        /// Vihjeet:
        /// - Select muuntaa jokaisen alkion
        /// - Poimii Product.Name ominaisuuden
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Product("Laptop"), Product("Mouse"), Product("Keyboard")]
        /// Output: ["Laptop", "Mouse", "Keyboard"]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-3-pelkät-nimet
        /// </summary>
        public static List<string> GetProductNames(List<Product>? products)
        {
            // TODO: Palauta lista pelkistä tuotteiden nimistä
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 3.2: Select - Muunna numerot neliöiksi
        // ============================================================================
        /// <summary>
        /// Muunna jokainen luku sen neliöksi.
        /// 
        /// LINQ-operaatio: Select()
        /// Syntaksi: collection.Select(x => x * x).ToList()
        /// 
        /// Vihjeet:
        /// - Kerro jokainen luku itsellään
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [1, 2, 3, 4]
        /// Output: [1, 4, 9, 16]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-3-useiden-operaatioiden-ketjuttaminen
        /// </summary>
        public static List<int> ConvertToSquares(List<int>? numbers)
        {
            // TODO: Muunna jokainen luku neliöksi
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 3.3: Select - Luo anonyymi tyyppi
        // ============================================================================
        /// <summary>
        /// Luo jokaiseile opiskelijalle anonyymi objekti, joka sisältää Name ja IsAdult (Age >= 18).
        /// 
        /// LINQ-operaatio: Select()
        /// Syntaksi: collection.Select(x => new { Property1 = x.Value1, Property2 = x.Value2 }).ToList()
        /// 
        /// Vihjeet:
        /// - Käytä `new { }` luodaksesi anonyymi tyyppi
        /// - Name = student.Name
        /// - IsAdult = student.Age >= 18
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Student("Alice", Age: 20), Student("Bob", Age: 16)]
        /// Output: [{ Name: "Alice", IsAdult: true }, { Name: "Bob", IsAdult: false }]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-1-opiskelijoiden-suodattaminen-ja-järjestäminen
        /// </summary>
        public static List<object> ProjectStudentsToAnonymousType(List<Student>? students)
        {
            // TODO: Luo anonyymi tyyppi jokaiselle opiskelijalle
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 3.4: Where + Select - Ketjutus
        // ============================================================================
        /// <summary>
        /// Suodata tuotteet, joiden hinta on alle 100€, ja palauta niiden nimet.
        /// 
        /// LINQ-operaatio: Where() + Select()
        /// Syntaksi: collection.Where(x => ehto).Select(x => x.Property).ToList()
        /// 
        /// Vihjeet:
        /// - Ensin Where: Price < 100
        /// - Sitten Select: Product.Name
        /// - Voit ketjuttaa operaatiot: .Where(...).Select(...)
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Product("A", 50€), Product("B", 150€), Product("C", 75€)]
        /// Output: ["A", "C"]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-3-useiden-operaatioiden-ketjuttaminen
        /// </summary>
        public static List<string> GetNamesOfAffordableProducts(List<Product>? products)
        {
            // TODO: Suodata tuotteet (hinta < 100) ja palauta nimet
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 3.5: Select - Muunna kokonaisluku merkkijonoksi
        // ============================================================================
        /// <summary>
        /// Muunna jokainen luku merkkijonoksi muodossa "Numero: X".
        /// 
        /// LINQ-operaatio: Select()
        /// Syntaksi: collection.Select(x => $"Numero: {x}").ToList()
        /// 
        /// Vihjeet:
        /// - Käytä string interpolaatiota: $"Numero: {x}"
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [1, 2, 3]
        /// Output: ["Numero: 1", "Numero: 2", "Numero: 3"]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#2-projektointi-select
        /// </summary>
        public static List<string> ConvertNumbersToStrings(List<int>? numbers)
        {
            // TODO: Muunna luvut merkkijonoiksi
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 3.6: Select - Luo koko nimi
        // ============================================================================
        /// <summary>
        /// Yhdistä henkilöiden etu- ja sukunimet kokonimiksi.
        /// 
        /// LINQ-operaatio: Select()
        /// Syntaksi: collection.Select(x => $"{x.FirstName} {x.LastName}").ToList()
        /// 
        /// Vihjeet:
        /// - Yhdistä FirstName ja LastName välilyönnillä
        /// - Käytä string interpolaatiota
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Person("John", "Doe"), Person("Jane", "Smith")]
        /// Output: ["John Doe", "Jane Smith"]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#2-projektointi-select
        /// </summary>
        public static List<string> GetFullNames(List<Person>? people)
        {
            // TODO: Yhdistä etu- ja sukunimet
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 3.7: Where + Select - Monimutkainen ketjutus
        // ============================================================================
        /// <summary>
        /// Palauta kirjojen nimet, jotka on julkaistu vuoden 2000 jälkeen.
        /// 
        /// LINQ-operaatio: Where() + Select()
        /// Syntaksi: collection.Where(x => x.Year > 2000).Select(x => x.Title).ToList()
        /// 
        /// Vihjeet:
        /// - Ensin Where: Year > 2000
        /// - Sitten Select: Book.Title
        /// - Palauta tyhjä lista jos input on null
        /// 
        /// Esimerkki:
        /// Input: [Book("Old", 1990), Book("New", 2010), Book("Recent", 2020)]
        /// Output: ["New", "Recent"]
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-3-useiden-operaatioiden-ketjuttaminen
        /// </summary>
        public static List<string> GetRecentBookTitles(List<Book>? books)
        {
            // TODO: Suodata kirjat (Year > 2000) ja palauta otsikot
            throw new NotImplementedException();
        }
    }
}

