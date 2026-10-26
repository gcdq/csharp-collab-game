# Automatyczne próby gry z przywróceniem stanu

**Poziom:** trudne  
**Zadanie:** 19/19

## Cel

Dodaj prosty zestaw automatycznych prób bez instalowania bibliotek testowych.

## Zakres i zasady

- Pracuj na ukończonej grze, nie na nieuzupełnionym starterze. Wybierz jeden dodatek; nie musisz realizować całego zestawu.
- Zachowaj cztery pokoje, ich połączenia, rozmieszczenie przedmiotów i warunki zwycięstwa. Nie zmieniaj limitu 10 energii.
- Tylko udany ruch lub udana akcja kosztuje 1 energię. Koszt nalicza wyłącznie `ZakonczTure()`, dokładnie raz. Informacje i odmowy są bezpłatne.
- Po zakończeniu gry ruch i akcje nie zmieniają danych. Wygrana ma pierwszeństwo przed przegraną przy zerowej energii.
- Korzystaj z `int`, `bool`, `string`, warunków, pętli oraz funkcji lokalnych. Bez klas, tablic, kolekcji, plików, losowania, MAUI i dodatkowych pakietów.
- Zachowaj istniejące nazwy i parametry funkcji. Nowe zmienne zadeklaruj i zainicjalizuj przed pierwszym `Start()`. Funkcjom korzystającym ze wspólnego stanu nie dodawaj `static`.
- Uzgodnij zmiany wspólnych zmiennych i sekcji 0 z zespołem. Jeden autor edytuje dany wspólny fragment; nie przeformatowuj całego pliku.

## Co należy wykonać

1. Dodaj komendę autotest i funkcję Autotest(). Wywołuje ona istniejące funkcje gry oraz sprawdza konkretne wartości po operacjach.
2. Przed próbami zapisz w osobnych zmiennych lokalnych wszystkie zmienne stanu podstawowej gry: pokoj, energia, karta, bezpiecznik, zasilanie, koniec, wygrana. Po próbach przywróć dokładnie te wartości, także po wykryciu niezgodności.
3. Każdy scenariusz zaczynaj od Start(). Wypisuj nazwę sprawdzenia oraz OK lub BLAD. Na końcu podaj liczbę sukcesów i niezgodności. Nie kończ całego zestawu przy pierwszym błędzie.
4. Uwzględnij co najmniej pięć scenariuszy z tabeli poniżej. Sprawdzaj wartości i flagi, a nie tylko obecność komunikatów na ekranie.
5. Do dziesięciu ruchów wykorzystaj for. Bez tablic, kolekcji, klas testowych, pakietów i dodatkowych plików źródłowych.
6. Po przywróceniu stanu nie wywołuj Start(), bo zniszczyłby przywróconą rozgrywkę. Historia tekstu w konsoli nie musi być przywracana.
7. Jeśli łączysz ten dodatek z licznikami lub innymi dodatkowymi zmiennymi, również zapisz i przywróć ich wartości. Przydziel jednego autora zmiany rozdzielacza i Pomoc().

## Miejsce zmian

Nowa funkcja Autotest(), pomocnicze funkcje sprawdzające, rozdzielacz w sekcji 0, Pomoc().

## Przykład techniki — nie rozwiązanie zadania

Poniższy listing jest kompletnym, osobnym programem. Uruchom go w projekcie prób, zastępując jego `Program.cs`. Nie wklejaj go do gry ani nie dodawaj drugiego pliku z instrukcjami najwyższego poziomu w projekcie gry.

```csharp
int punkty = 7;
int zapisanePunkty = punkty;
int zgodne = 0;
int niezgodne = 0;
punkty = 0;
Sprawdz("Zerowanie", punkty == 0);
punkty = punkty + 2;
Sprawdz("Dodanie", punkty == 2);
punkty = zapisanePunkty;
Console.WriteLine("OK: " + zgodne + ", BLAD: " + niezgodne);
Console.WriteLine("Przywrocono: " + punkty);
void Sprawdz(string nazwa, bool warunek)
{
    if (warunek)
    {
        zgodne = zgodne + 1;
        Console.WriteLine(nazwa + ": OK");
    }
    else
    {
        niezgodne = niezgodne + 1;
        Console.WriteLine(nazwa + ": BLAD");
    }
}
```

**Oczekiwany wynik:**

```text
Zerowanie: OK
Dodanie: OK
OK: 2, BLAD: 0
Przywrocono: 7
```

Przykład sprawdza dwie operacje na jednej liczbie i przywraca jej poprzednią wartość. Nie zawiera scenariuszy ani pełnego stanu gry. W zadaniu rozbuduj tę technikę do wielu danych.

## Próby odbiorowe

W sekwencjach konsolowych wpisuj każdą komendę osobno i zatwierdzaj Enterem. Każdy niezależny scenariusz zaczynaj od `start`, chyba że opis dotyczy pojedynczej funkcji lub kontynuacji wcześniejszej próby.

| Próba | Oczekiwany wynik |
|---|---|
| Start(); Idz("lewo") | Pokój 1, energia 10, wszystkie flagi false. |
| Start(); Akcja("karta") dwa razy | Karta true; energia 9; koniec false. |
| Start(); Idz("prawo") dwa razy; Akcja("napraw") | Pokój 3, energia 8, zasilanie false. |
| Start(); zwycięska droga: karta, prawo, bezpiecznik, prawo, napraw, prawo, wyjdz | Pokój 4, energia 3, karta true, bezpiecznik false, zasilanie true, koniec true, wygrana true. |
| Start(); pięć par Idz("prawo"), Idz("lewo"); potem próba ruchu i karty | Pokój 1, energia 0, koniec true, wygrana false; odmowy niczego nie zmieniają. |
| Ręcznie: start, karta, prawo, status, autotest, status | Oba statusy identyczne; wynik prób widoczny osobno. |
| autotest uruchomiony po wygranej i po przegranej | Po testach przywrócony dokładnie wcześniejszy wynik i stan. |

## Warunki zaliczenia

- Projekt kompiluje się i spełnia wszystkie wymagania tego zadania.
- Dotychczasowe próby z `TESTY.md` nadal przechodzą.
- W `TESTY.md` dopisano kroki i rzeczywiste wyniki nowych prób, w tym przypadek graniczny oraz kontrolę niezmienianych danych.
- Nowe dane, jeśli występują, są prawidłowo resetowane.
- Druga osoba przejrzała zmianę; autor potrafi wyjaśnić warunki, dane wejściowe i skutki funkcji.
- Po scaleniu wykonano ponownie kompilację i właściwe próby.

## Weryfikacja przykładu

Listing wyodrębniono z tego pliku, skompilowano jako osobny program konsolowy dla .NET 8 kompilatorem C# z SDK 8.0.408 (ostrzeżenia traktowane jako błędy) i uruchomiono. Wynik zgadza się z blokiem „Oczekiwany wynik”. Weryfikacja dotyczy przykładu techniki, nie nieistniejącego jeszcze rozwiązania ucznia.

## Materiały bazowe

- [README projektu](https://github.com/ukoms/csharp-collab-game/blob/master/README.md) — kontrakt gry i podział pracy.
- [Program.cs](https://github.com/ukoms/csharp-collab-game/blob/master/Program.cs) — starter i funkcje.
- [TESTY.md](https://github.com/ukoms/csharp-collab-game/blob/master/TESTY.md) — próby podstawowej gry.
- `01_Wprowadzenie_CSharp.md` — załączony materiał: konsola, funkcje, warunki i pętle.
