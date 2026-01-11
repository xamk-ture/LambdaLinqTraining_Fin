using LambdaLinqExercises.Models;

namespace LambdaLinqExercises
{
    /// <summary>
    /// OSA 5: Aggregointi LINQ:llä
    /// 
    /// Tässä osiossa opetellaan aggregointioperaatioita:
    /// - Count() - laske määrä
    /// - Sum() - laske summa
    /// - Average() - laske keskiarvo
    /// - Min() / Max() - etsi pienin/suurin
    /// - Ehdollinen aggregointi (esim. Count(x => ehto))
    /// 
    /// Wiki-materiaali:
    /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#5-aggregointi-sum-average-count
    /// </summary>
    public static class Part5_Aggregation
    {
        // ============================================================================
        // TEHTÄVÄ 5.1: Count - Laske määrä
        // ============================================================================
        /// <summary>
        /// Laske kuinka monta alkiota listassa on.
        /// 
        /// LINQ-operaatio: Count()
        /// Syntaksi: collection.Count()
        /// 
        /// Vihjeet:
        /// - Count() palauttaa int:n
        /// - Palauta 0 jos lista on null
        /// 
        /// Esimerkki:
        /// Input: [1, 2, 3, 4, 5]
        /// Output: 5
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-5-aggregointi-ja-laskenta
        /// </summary>
        public static int CountNumbers(List<int>? numbers)
        {
            // TODO: Laske kuinka monta lukua listassa on
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 5.2: Count - Ehdollinen laskenta
        // ============================================================================
        /// <summary>
        /// Laske kuinka monta parillista lukua listassa on.
        /// 
        /// LINQ-operaatio: Count()
        /// Syntaksi: collection.Count(x => ehto)
        /// 
        /// Vihjeet:
        /// - Count(x => x % 2 == 0) laskee vain parilliset
        /// - Palauta 0 jos lista on null
        /// 
        /// Esimerkki:
        /// Input: [1, 2, 3, 4, 5, 6]
        /// Output: 3 (koska 2, 4, 6 ovat parillisia)
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-5-aggregointi-ja-laskenta
        /// </summary>
        public static int CountEvenNumbers(List<int>? numbers)
        {
            // TODO: Laske parilliset luvut
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 5.3: Sum - Laske summa
        // ============================================================================
        /// <summary>
        /// Laske kaikkien lukujen summa.
        /// 
        /// LINQ-operaatio: Sum()
        /// Syntaksi: collection.Sum()
        /// 
        /// Vihjeet:
        /// - Sum() palauttaa summan
        /// - Palauta 0 jos lista on null tai tyhjä
        /// 
        /// Esimerkki:
        /// Input: [1, 2, 3, 4, 5]
        /// Output: 15
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-5-aggregointi-ja-laskenta
        /// </summary>
        public static int SumNumbers(List<int>? numbers)
        {
            // TODO: Laske lukujen summa
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 5.4: Sum - Laske tuotteiden kokonaishinta
        // ============================================================================
        /// <summary>
        /// Laske kaikkien tuotteiden hintojen summa.
        /// 
        /// LINQ-operaatio: Sum()
        /// Syntaksi: collection.Sum(x => x.Property)
        /// 
        /// Vihjeet:
        /// - Sum(p => p.Price) laskee Price-ominaisuuden summan
        /// - Palauta 0 jos lista on null tai tyhjä
        /// 
        /// Esimerkki:
        /// Input: [Product(Price: 10), Product(Price: 20), Product(Price: 30)]
        /// Output: 60
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-2-tuotteiden-suodattaminen-ja-hinnan-laskeminen
        /// </summary>
        public static decimal SumProductPrices(List<Product>? products)
        {
            // TODO: Laske tuotteiden hintojen summa
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 5.5: Average - Laske keskiarvo
        // ============================================================================
        /// <summary>
        /// Laske lukujen keskiarvo.
        /// 
        /// LINQ-operaatio: Average()
        /// Syntaksi: collection.Average()
        /// 
        /// Vihjeet:
        /// - Average() palauttaa double:n
        /// - Palauta 0.0 jos lista on null tai tyhjä
        /// 
        /// Esimerkki:
        /// Input: [1, 2, 3, 4, 5]
        /// Output: 3.0
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-5-aggregointi-ja-laskenta
        /// </summary>
        public static double AverageNumbers(List<int>? numbers)
        {
            // TODO: Laske lukujen keskiarvo
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 5.6: Min ja Max - Etsi pienin ja suurin
        // ============================================================================
        /// <summary>
        /// Etsi pienin luku listasta.
        /// 
        /// LINQ-operaatio: Min()
        /// Syntaksi: collection.Min()
        /// 
        /// Vihjeet:
        /// - Min() palauttaa pienimmän arvon
        /// - Palauta 0 jos lista on null tai tyhjä
        /// 
        /// Esimerkki:
        /// Input: [5, 2, 8, 1, 9]
        /// Output: 1
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-5-aggregointi-ja-laskenta
        /// </summary>
        public static int FindMinNumber(List<int>? numbers)
        {
            // TODO: Etsi pienin luku
            throw new NotImplementedException();
        }

        /// <summary>
        /// Etsi suurin luku listasta.
        /// 
        /// LINQ-operaatio: Max()
        /// Syntaksi: collection.Max()
        /// 
        /// Vihjeet:
        /// - Max() palauttaa suurimman arvon
        /// - Palauta 0 jos lista on null tai tyhjä
        /// 
        /// Esimerkki:
        /// Input: [5, 2, 8, 1, 9]
        /// Output: 9
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-5-aggregointi-ja-laskenta
        /// </summary>
        public static int FindMaxNumber(List<int>? numbers)
        {
            // TODO: Etsi suurin luku
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 5.7: Yhdistetty - Ehdollinen summa
        // ============================================================================
        /// <summary>
        /// Laske kaikkien "Electronics"-kategorian tuotteiden hintojen summa.
        /// 
        /// LINQ-operaatio: Where() + Sum()
        /// Syntaksi: collection.Where(x => ehto).Sum(x => x.Property)
        /// 
        /// Vihjeet:
        /// - Ensin Where(p => p.Category == "Electronics")
        /// - Sitten Sum(p => p.Price)
        /// - Palauta 0 jos lista on null tai ei löydy elektroniikkaa
        /// 
        /// Esimerkki:
        /// Input: [Product("A", "Electronics", 100), Product("B", "Clothing", 50)]
        /// Output: 100
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-2-tuotteiden-suodattaminen-ja-hinnan-laskeminen
        /// </summary>
        public static decimal SumElectronicsPrices(List<Product>? products)
        {
            // TODO: Laske elektroniikan hintojen summa
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 5.8: Average - Opiskelijoiden keskiarvosana
        // ============================================================================
        /// <summary>
        /// Laske kaikkien opiskelijoiden arvosanojen keskiarvo.
        /// 
        /// LINQ-operaatio: Average()
        /// Syntaksi: collection.Average(x => x.Property)
        /// 
        /// Vihjeet:
        /// - Average(s => s.Grade) laskee Grade-ominaisuuden keskiarvon
        /// - Palauta 0.0 jos lista on null tai tyhjä
        /// 
        /// Esimerkki:
        /// Input: [Student(Grade: 8.0), Student(Grade: 9.0), Student(Grade: 7.0)]
        /// Output: 8.0
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md#esimerkki-5-aggregointi-ja-laskenta
        /// </summary>
        public static double AverageStudentGrade(List<Student>? students)
        {
            // TODO: Laske opiskelijoiden keskiarvosana
            throw new NotImplementedException();
        }
    }
}

