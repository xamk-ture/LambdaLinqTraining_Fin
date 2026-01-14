# Lambda & LINQ - Teoria-kysymykset

Tämä tehtävä testaa ymmärrystäsi Lambda-lausekkeista ja LINQ:stä. Vastaa kaikkiin kysymyksiin omilla sanoillasi. Voit käyttää apuna wiki-materiaaleja ja koodiesimerkkejä.

**Ohjeet:**
- Vastaa kaikkiin kysymyksiin selkeästi ja ytimekkäästi
- Käytä omia sanojasi - kopioiminen ei auta oppimisessa
- Jos et ole varma, yritä silti vastata - osittainen vastaus on parempi kuin ei mitään
- Voit käyttää koodiesimerkkejä selventämään vastaustasi

---

## OSA 1: Anonyymi funktio ja Lambda-lauseke

### 1.1 Mikä on anonyymi funktio?
**Vastaa:** Mikä on anonyymi funktio ja miten se eroaa tavallisesta (nimetyistä) funktiosta?

---

### 1.2 Mikä on lambda-lauseke?
**Vastaa:** Mikä on lambda-lauseke C#:ssa? Miten se liittyy anonyymiin funktioon?

---

### 1.3 Lambda-syntaksi
**Vastaa:** Selitä seuraavat lambda-lausekkeet ja mitä ne tekevät:

```csharp
// a)
() => 42

// b)
x => x * 2

// c)
(x, y) => x + y

// d)
name => Console.WriteLine($"Hello, {name}!")
```

---

### 1.4 Expression lambda vs. Statement lambda
**Vastaa:** Mitä eroa on expression lambda:lla ja statement lambda:lla? Anna esimerkki molemmista.

---

## OSA 2: Delegaatit

### 2.1 Mikä on delegaatti?
**Vastaa:** Mikä on delegaatti C#:ssa? Miksi delegaatteja käytetään?

---

### 2.2 Action, Func ja Predicate
**Vastaa:** Mitä eroa on seuraavilla delegaateilla? Anna esimerkki kustakin:

- `Action<T>`
- `Func<T, TResult>`
- `Predicate<T>`

---

### 2.3 Delegaatti vs. Lambda
**Vastaa:** Miten delegaatit ja lambda-lausekkeet liittyvät toisiinsa? Voitko käyttää lambdaa ilman delegaattia?

---

## OSA 3: Predikaatit

### 3.1 Mikä on predikaatti?
**Vastaa:** Mikä on predikaatti ohjelmoinnissa? Miksi predikaatteja käytetään?

---

### 3.2 Predicate<T> vs Func<T, bool>
**Vastaa:** Mitä eroa on `Predicate<T>`:llä ja `Func<T, bool>`:lla? Milloin kannattaa käyttää kumpaakin?

---

### 3.3 Predikaatin käyttö
**Vastaa:** Anna esimerkki tilanteesta, jossa predikaatti on hyödyllinen. Miten käytät sitä koodissa?

---

## OSA 4: LINQ

### 4.1 Mikä on LINQ?
**Vastaa:** Mikä on LINQ ja mitä se tarkoittaa? Miksi LINQ on hyödyllinen?

---

### 4.2 LINQ-operaatiot
**Vastaa:** Selitä mitä seuraavat LINQ-operaatiot tekevät ja anna esimerkki kustakin:

- `Where()`
- `Select()`
- `OrderBy()`
- `Count()`
- `Sum()`
- `GroupBy()`

---

### 4.3 LINQ-ketjutus
**Vastaa:** Mitä tarkoittaa LINQ-operaatioiden ketjuttaminen? Anna esimerkki, jossa käytät useita LINQ-operaatioita peräkkäin.

---

### 4.4 Lazy evaluation
**Vastaa:** Mitä tarkoittaa "lazy evaluation" LINQ:ssa? Miksi `.ToList()` on usein tarpeen?

---

## OSA 5: Käytännön sovellukset

### 5.1 Milloin käyttää Lambdaa?
**Vastaa:** Milloin kannattaa käyttää lambda-lauseketta ja milloin tavallista funktiota? Anna esimerkkejä molemmista.

---

### 5.2 Milloin käyttää LINQ:ä?
**Vastaa:** Milloin kannattaa käyttää LINQ:ä ja milloin perinteisiä silmukoita (for, foreach)? Mitä ovat kummankin hyvät ja huonot puolet?

---

### 5.3 Suorituskyky
**Vastaa:** Onko LINQ nopeampi vai hitaampi kuin perinteiset silmukat? Miksi?

---

## OSA 6: Syntaksi ja yleiset virheet

### 6.1 Sulkeet lambda-lausekkeissa
**Vastaa:** Milloin tarvitset sulkeet lambda-lausekkeen parametreissa? Anna esimerkki molemmista tapauksista.

---

### 6.2 Return-lauseke
**Vastaa:** Milloin tarvitset `return`-lausekkeen lambda-lausekkeessa? Anna esimerkki.

---

### 6.3 Yleisimmät virheet
**Vastaa:** Mitkä ovat yleisimmät virheet, joita opiskelijat tekevät lambda-lausekkeita ja LINQ:ä käyttäessään? Miten näitä virheitä voi välttää?

---

## OSA 7: Syvempi ymmärrys

### 7.1 Closure
**Vastaa:** Mitä tarkoittaa "closure" lambda-lausekkeiden yhteydessä? Anna esimerkki tilanteesta, jossa closure voi aiheuttaa ongelmia.

---

### 7.2 LINQ Method Syntax vs Query Syntax
**Vastaa:** Mitä eroa on LINQ Method Syntax:lla ja Query Syntax:lla? Kumpaa suosittelet ja miksi?

---

### 7.3 Null-turvallisuus
**Vastaa:** Miten käsittelet null-arvot LINQ-operaatioissa? Miksi tämä on tärkeää?

---

## OSA 8: Oma pohdinta

### 8.1 Oma kokemus
**Vastaa:** Mitä olet oppinut lambda-lausekkeista ja LINQ:stä? Mitkä asiat olivat helpoimpia ja mitkä vaikeimpia?

---

### 8.2 Käytännön sovellus
**Vastaa:** Kuvittele tilanne, jossa käyttäisit lambda-lausekkeita ja LINQ:ä oikeassa projektissa. Kuvaile tilannetta ja selitä, miksi nämä tekniikat sopivat siihen.

---

## Vastauksen palautus

Tallenna vastauksesi tähän tiedostoon ja muista pushata muutokset gittiin

**Muista:**
- Vastaa kaikkiin kysymyksiin
- Käytä omia sanojasi
- Voit käyttää koodiesimerkkejä selventämään vastaustasi
- Jos et ole varma jostain, yritä silti vastata

**Hyödyllisiä linkkejä:**
- [Lambda-oppimateriaali](https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Lambda.md)
- [LINQ-oppimateriaali](https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/LINQ.md)
- [Delegaatit-oppimateriaali](https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Delegates.md)
- [Predikaatit-oppimateriaali](https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Predicate.md)
- [Clousures-oppimateriaali](https://github.com/xamk-mire/Xamk-wiki/blob/main/C%23/fin/00-Basics/Closures.md)
