using LambdaLinqExercises.Models;

namespace LambdaLinqExercises
{
    /// <summary>
    /// OSA 1: Lambda-syntaksin perusteet
    /// 
    /// Tässä osiossa opetellaan lambda-lausekkeiden syntaksi eri muodoissa.
    /// Lambda-lauseke on lyhyt tapa ilmaista anonyymi funktio.
    /// 
    /// Wiki-materiaali:
    /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Lambda.md
    /// </summary>
    public static class Part1_LambdaBasics
    {
        // ============================================================================
        // TEHTÄVÄ 1.1: Parametritön lambda
        // ============================================================================
        /// <summary>
        /// Luo ja palauta lambda-lauseke, joka palauttaa aina arvon 42.
        /// 
        /// Syntaksi: () => arvo
        /// 
        /// Vihjeet:
        /// - Parametritön lambda alkaa tyhjillä sulkeilla: ()
        /// - Lambda-operaattori on: =>
        /// - Palauta yksinkertaisesti luku 42
        /// 
        /// Esimerkki:
        /// Func<int> getNumber = () => 42;
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Lambda.md#ei-parametreja
        /// </summary>
        public static Func<int> CreateConstantFunction()
        {
            Func<int> getNumber = () => 42;

            // TODO: Palauta lambda joka palauttaa 42
            return getNumber;
        }

        // ============================================================================
        // TEHTÄVÄ 1.2: Yksi parametri
        // ============================================================================
        /// <summary>
        /// Luo ja palauta lambda-lauseke, joka kaksinkertaistaa annetun luvun.
        /// 
        /// Syntaksi: x => x * 2
        /// 
        /// Vihjeet:
        /// - Yhden parametrin tapauksessa sulkeet ovat valinnaisia
        /// - x on parametrin nimi (voit käyttää mitä vaan nimeä)
        /// - Palauta parametri kerrottuna kahdella
        /// 
        /// Esimerkki:
        /// Func<int, int> double = x => x * 2;
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Lambda.md#yksi-parametri
        /// </summary>
        public static Func<int, int> CreateDoubleFunction()
        {
            // TODO: Palauta lambda joka kaksinkertaistaa luvun
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 1.3: Useampi parametri
        // ============================================================================
        /// <summary>
        /// Luo ja palauta lambda-lauseke, joka laskee kahden luvun summan.
        /// 
        /// Syntaksi: (x, y) => x + y
        /// 
        /// Vihjeet:
        /// - Useamman parametrin tapauksessa sulkeet ovat PAKOLLISET
        /// - Parametrit erotetaan pilkulla: (x, y)
        /// - Palauta parametrien summa
        /// 
        /// Esimerkki:
        /// Func&lt;int, int, int&gt; add = (a, b) => a + b;
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Lambda.md#useampi-parametri
        /// </summary>
        public static Func<int, int, int> CreateAddFunction()
        {
            // TODO: Palauta lambda joka laskee kahden luvun summan
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 1.4: Statement lambda (monirivinen)
        // ============================================================================
        /// <summary>
        /// Luo ja palauta lambda-lauseke, joka laskee luvun neliön.
        /// Käytä monirivistä lambda-muotoa (statement lambda).
        /// 
        /// Syntaksi:
        /// x => 
        /// {
        ///     int result = x * x;
        ///     return result;
        /// }
        /// 
        /// Vihjeet:
        /// - Monirivinen lambda käyttää aaltosulkeita { }
        /// - Tarvitset return-avainsanan
        /// - Voit käyttää väliarvomuuttujia
        /// 
        /// Esimerkki:
        /// Func&lt;int, int&gt; calculate = x =>
        /// {
        ///     int doubled = x * 2;
        ///     return doubled + 10;
        /// };
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Lambda.md#statement-lambda-lohko-lambda
        /// </summary>
        public static Func<int, int> CreateSquareFunction()
        {
            // TODO: Palauta monirivinen lambda joka laskee neliön
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 1.5: Action-delegaatti
        // ============================================================================
        /// <summary>
        /// Luo ja palauta Action-delegaatti, joka tulostaa "Hello, [nimi]!"
        /// 
        /// Action vs. Func:
        /// - Action ei palauta arvoa (void)
        /// - Func palauttaa arvon
        /// 
        /// Syntaksi: name => Console.WriteLine($"Hello, {name}!")
        /// 
        /// Vihjeet:
        /// - Action&lt;string&gt; ottaa yhden string-parametrin
        /// - Käytä Console.WriteLine tulostukseen
        /// - Käytä string interpolaatiota: $"Hello, {name}!"
        /// 
        /// Esimerkki:
        /// Action&lt;string&gt; greet = name => Console.WriteLine($"Hi {name}");
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Delegates.md#action-t
        /// </summary>
        public static Action<string> CreateGreetingAction()
        {
            // TODO: Palauta Action joka tulostaa tervehdyksen
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 1.6: Predicate (palautetaan bool)
        // ============================================================================
        /// <summary>
        /// Luo ja palauta Predicate, joka tarkistaa onko luku positiivinen.
        /// 
        /// Predicate:
        /// - Palauttaa aina bool-arvon (true/false)
        /// - Käytetään ehdoissa ja suodatuksessa
        /// 
        /// Syntaksi: x => x > 0
        /// 
        /// Vihjeet:
        /// - Predicate&lt;int&gt; ottaa yhden int-parametrin
        /// - Palauttaa true jos luku > 0, muuten false
        /// - Käytä vertailuoperaattoria >
        /// 
        /// Esimerkki:
        /// Predicate&lt;int&gt; isEven = x => x % 2 == 0;
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Predicate.md
        /// </summary>
        public static Predicate<int> CreateIsPositivePredicate()
        {
            // TODO: Palauta Predicate joka tarkistaa onko luku positiivinen
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 1.7: Lambda string-käsittelyyn
        // ============================================================================
        /// <summary>
        /// Luo ja palauta lambda, joka muuttaa merkkijonon isoiksi kirjaimiksi.
        /// 
        /// Syntaksi: str => str.ToUpper()
        /// 
        /// Vihjeet:
        /// - Käytä string.ToUpper() metodia
        /// - Func&lt;string, string&gt; ottaa string:in ja palauttaa string:in
        /// 
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Lambda.md#esimerkki-1-yksinkertainen-lauseke
        /// </summary>
        public static Func<string, string> CreateToUpperFunction()
        {
            // TODO: Palauta lambda joka muuttaa tekstin isoiksi kirjaimiksi
            throw new NotImplementedException();
        }

        // ============================================================================
        // TEHTÄVÄ 1.8: Lambda kolmella parametrilla
        // ============================================================================
        /// <summary>
        /// Luo ja palauta lambda, joka laskee kolmen luvun tulon.
        /// 
        /// Syntaksi: (x, y, z) => x * y * z
        /// 
        /// Vihjeet:
        /// - Käytä sulkeita kolmelle parametrille: (x, y, z)
        /// - Kerro kaikki kolme lukua keskenään
        /// 
        /// Esimerkki:
        /// Func&lt;int, int, int, int&gt; sum = (a, b, c) => a + b + c;
        /// 
        /// Wiki:
        /// https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Lambda.md#useampi-parametri
        /// </summary>
        public static Func<int, int, int, int> CreateMultiplyThreeFunction()
        {
            // TODO: Palauta lambda joka laskee kolmen luvun tulon
            throw new NotImplementedException();
        }
    }
}

