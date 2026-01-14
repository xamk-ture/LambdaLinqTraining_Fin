# Lambda & LINQ Harjoitustehtävät

Tervetuloa Lambda & LINQ -harjoitustehtäviin! Tämä tehtäväsarja opettaa sinulle lambda-lausekkeiden syntaksin ja yleisimmät LINQ-operaatiot progressiivisesti.

## Tavoitteet

Näiden harjoitusten jälkeen osaat:
- Kirjoittaa lambda-lausekkeita eri muodoissa
- Käyttää yleisimpiä LINQ-operaatioita (Where, Select, OrderBy, jne.)
- Suodattaa, muuntaa ja aggregoida dataa
- Yhdistää useita LINQ-operaatioita

## Harjoitusten rakenne

Harjoitukset on jaettu kuuteen osaan, jotka rakentuvat toistensa päälle:

### 1. Lambda-syntaksin perusteet (Part1_LambdaBasics.cs)
- Parametritön lambda: `() => arvo`
- Yksi parametri: `x => lauseke`
- Useampi parametri: `(x, y) => lauseke`
- Statement lambda (monirivinen): `x => { ... return ...; }`
- Lambda Func<>:n ja Action<>:n kanssa

### 2. Perussuodatus (Part2_BasicFiltering.cs)
- `Where()` - Suodata kokoelmasta
- `First()` / `FirstOrDefault()` - Etsi ensimmäinen
- `Any()` - Tarkista löytyykö
- `All()` - Tarkista täyttävätkö kaikki

### 3. Projektointi (Part3_Projection.cs)
- `Select()` - Muunna alkiot
- Anonyymit tyypit
- Where ja Select yhdessä

### 4. Järjestäminen (Part4_Sorting.cs)
- `OrderBy()` - Järjestä nousevaan järjestykseen
- `OrderByDescending()` - Järjestä laskevaan järjestykseen
- `ThenBy()` / `ThenByDescending()` - Moninkertainen järjestäminen

### 5. Aggregointi (Part5_Aggregation.cs)
- `Count()` - Laske määrä
- `Sum()` - Laske summa
- `Average()` - Laske keskiarvo
- `Min()` / `Max()` - Pienin/Suurin arvo

### 6. Ryhmittely (Part6_Grouping.cs)
- `GroupBy()` - Ryhmittele
- Aggregointi ryhmittäin
- Monimutkainen ryhmittely

## Teoria-kysymykset

Kun olet tehnyt kaikki kooditehtävät, vastaa myös teoria-kysymyksiin:

📝 **[Teoria-kysymykset](Questions.md)**

Tämä tehtävä testaa ymmärrystäsi Lambda-lausekkeista ja LINQ:stä. Vastaa kaikkiin kysymyksiin omilla sanoillasi ja tallenna vastauksesi samaan tiedostoon `Questions.md`.

## Lambda-syntaksin pikaohjeet

### Perussyntaksi
```csharp
// Parametritön lambda
() => 5

// Yksi parametri (sulkeet valinnaisia)
x => x * 2
(x) => x * 2

// Useampi parametri (sulkeet pakolliset)
(x, y) => x + y

// Monirivinen lambda (statement lambda)
x => 
{
    int result = x * 2;
    return result;
}
```

### Delegaatit
```csharp
// Action - ei palautusarvoa
Action<string> print = message => Console.WriteLine(message);

// Func - palauttaa arvon
Func<int, int> square = x => x * x;
Func<int, int, int> add = (a, b) => a + b;

// Predicate - palauttaa bool
Predicate<int> isEven = x => x % 2 == 0;
```

### LINQ-esimerkkejä
```csharp
var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

// Suodatus
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
// Tulos: [2, 4, 6]

// Projektointi
var squared = numbers.Select(n => n * n).ToList();
// Tulos: [1, 4, 9, 16, 25, 36]

// Yhdistetty
var result = numbers
    .Where(n => n > 2)
    .Select(n => n * n)
    .OrderByDescending(n => n)
    .ToList();
// Tulos: [36, 25, 16, 9]
```

## Hyödyllisiä wiki-materiaaleja

Tutustu näihin materiaaleihin ennen harjoitusten aloittamista tai käytä niitä apuna tehtävien ratkaisemisessa:

### Lambda-lausekkeet
- **[Lambda-oppimateriaali](https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Lambda.md)**
  - Lambda-syntaksin perusteet
  - Expression lambda vs. Statement lambda
  - Parametrien käyttö
  - Käytännön esimerkkejä

### LINQ
- **[LINQ-oppimateriaali](https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md)**
  - LINQ-peruskäsitteet
  - Suodatus (Where)
  - Projektointi (Select)
  - Järjestäminen (OrderBy)
  - Aggregointi (Count, Sum, Average, jne.)
  - Ryhmittely (GroupBy)

### Predikaatit
- **[Predikaatit-oppimateriaali](https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Predicate.md)**
  - Mikä on predikaatti
  - Predicate<T> vs Func<T, bool>
  - Käytännön esimerkkejä

### Delegaatit
- **[Delegaatit-oppimateriaali](https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Delegates.md)**
  - Action, Func, Predicate
  - Delegaattien käyttö

## Miten testit ajetaan

### Visual Studiossa
1. Avaa `LambdaLinqTraining.sln` Visual Studiossa
2. Buildaa solution (Ctrl+Shift+B)
3. Avaa Test Explorer (Test → Test Explorer)
4. Klikkaa "Run All Tests" tai aja testit yksitellen

### Komentoriviltä
```bash
# Siirry LambdaLinqTraining-kansioon
cd Assigments/LambdaLinqTraining

# Aja kaikki testit
dotnet test

# Aja tietyn tiedoston testit
dotnet test --filter "FullyQualifiedName~Part1Tests"
```

## Yleisiä vinkkejä

### 1. Aloita yksinkertaisesta
Jos tehtävä tuntuu vaikealta, aloita pienin askelin:
```csharp
// Sen sijaan että kirjoitat suoraan:
var result = products.Where(p => p.Price < 50 && p.Category == "Electronics").ToList();

// Voit ensin tehdä näin:
var cheapProducts = products.Where(p => p.Price < 50);
var electronics = cheapProducts.Where(p => p.Category == "Electronics");
var result = electronics.ToList();
```

### 2. Käytä debuggeria
- Aseta breakpoint lambda-lausekkeen sisälle
- Tarkastele muuttujien arvoja
- Seuraa, mitä kukin vaihe tekee

### 3. Kokeile LINQ Pad -työkalua
[LINQPad](https://www.linqpad.net/) on ilmainen työkalu LINQ-kyselyjen testaamiseen.

### 4. Muista ToList() tai ToArray()
LINQ-operaatiot ovat lazy-evaluated (viivästetty evaluointi). Muista kutsua `.ToList()` tai `.ToArray()` lopussa:
```csharp
// ❌ Palauttaa IEnumerable<int> (ei vielä suoritettu)
var numbers = collection.Where(n => n > 0);

// ✅ Palauttaa List<int> (suoritettu)
var numbers = collection.Where(n => n > 0).ToList();
```

### 5. Null-tarkistukset
Muista aina tarkistaa null-arvot:
```csharp
public static List<int> FilterEvenNumbers(List<int> numbers)
{
    if (numbers == null)
        return new List<int>();
    
    return numbers.Where(n => n % 2 == 0).ToList();
}
```

## Yleisimmät virheet

### Virhe 1: Unohtaa sulkeet monen parametrin tapauksessa
```csharp
// ❌ Virhe
Func<int, int, int> add = a, b => a + b;

// ✅ Oikein
Func<int, int, int> add = (a, b) => a + b;
```

### Virhe 2: Unohtaa return statement lambda-lohkossa
```csharp
// ❌ Virhe
Func<int, int> square = x => { x * x; };

// ✅ Oikein
Func<int, int> square = x => { return x * x; };

// ✅ Tai vielä parempi (expression lambda)
Func<int, int> square = x => x * x;
```

### Virhe 3: Ei käytä ToList()
```csharp
// ❌ Palauttaa IEnumerable<int> metodista joka odottaa List<int>
public static List<int> GetEvenNumbers(List<int> numbers)
{
    return numbers.Where(n => n % 2 == 0); // Käännösvirhe!
}

// ✅ Oikein
public static List<int> GetEvenNumbers(List<int> numbers)
{
    return numbers.Where(n => n % 2 == 0).ToList();
}
```

## Tehtävien tekeminen

1. **Lue tehtävänanto huolellisesti** - Jokainen tehtävä sisältää selkeän tavoitteen ja vinkkejä
2. **Tutustu wiki-materiaaleihin** - Linkit löytyvät tehtävien kommenteista
3. **Korvaa `throw new NotImplementedException();` omalla toteutuksella**
4. **Aja testit** ja varmista että ne menevät läpi
5. **Siirry seuraavaan tehtävään** kun testit menevät läpi


## Apua tarvitessa

Jos jäät jumiin:
1. Lue wiki-materiaali aiheesta
2. Tarkista esimerkit tästä README:stä
3. Tarkastele testejä - ne kertovat mitä metodin pitäisi palauttaa
4. Kysy opettajalta tai luokkakaverilta



