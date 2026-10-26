# Opis gotowości do opuszczenia budynku

**Poziom:** średnie  
**Zadanie:** 16/19

## Cel

Oddziel informację o gotowości drzwi od ich faktycznego otwarcia.

## Zakres i zasady

- Pracuj na ukończonej grze, nie na nieuzupełnionym starterze. Wybierz jeden dodatek; nie musisz realizować całego zestawu.
- Zachowaj cztery pokoje, ich połączenia, rozmieszczenie przedmiotów i warunki zwycięstwa. Nie zmieniaj limitu 10 energii.
- Tylko udany ruch lub udana akcja kosztuje 1 energię. Koszt nalicza wyłącznie `ZakonczTure()`, dokładnie raz. Informacje i odmowy są bezpłatne.
- Po zakończeniu gry ruch i akcje nie zmieniają danych. Wygrana ma pierwszeństwo przed przegraną przy zerowej energii.
- Korzystaj z `int`, `bool`, `string`, warunków, pętli oraz funkcji lokalnych. Bez klas, tablic, kolekcji, plików, losowania, MAUI i dodatkowych pakietów.
- Zachowaj istniejące nazwy i parametry funkcji. Nowe zmienne zadeklaruj i zainicjalizuj przed pierwszym `Start()`. Funkcjom korzystającym ze wspólnego stanu nie dodawaj `static`.
- Uzgodnij zmiany wspólnych zmiennych i sekcji 0 z zespołem. Jeden autor edytuje dany wspólny fragment; nie przeformatowuj całego pliku.

## Co należy wykonać

1. Napisz string StanWyjscia(bool maKarte, bool maZasilanie). Obsłuż wszystkie cztery kombinacje argumentów.
2. Zwracaj informację o braku obu wymagań, braku karty, braku zasilania albo gotowości do otwarcia.
3. Wywołaj funkcję w opisie pokoju 4. Nie ustawiaj w niej wygrana ani koniec i nie pobieraj energii.
4. Wyjście nadal wymaga udanej komendy wyjdz w pokoju 4.

## Miejsce zmian

Nowa funkcja lokalna oraz Rozejrzyj().

## Przykład techniki — nie rozwiązanie zadania

Poniższy listing jest kompletnym, osobnym programem. Uruchom go w projekcie prób, zastępując jego `Program.cs`. Nie wklejaj go do gry ani nie dodawaj drugiego pliku z instrukcjami najwyższego poziomu w projekcie gry.

```csharp
Console.WriteLine(CzyMoznaNadac(true, true));
Console.WriteLine(CzyMoznaNadac(true, false));
bool CzyMoznaNadac(bool adres, bool oplacono)
{
    return adres && oplacono;
}
```

**Oczekiwany wynik:**

```text
True
False
```

Funkcja sprawdza warunki nadania paczki, lecz niczego nie nadaje. W zadaniu trzeba dodatkowo rozróżnić powody braku gotowości.

## Próby odbiorowe

W sekwencjach konsolowych wpisuj każdą komendę osobno i zatwierdzaj Enterem. Każdy niezależny scenariusz zaczynaj od `start`, chyba że opis dotyczy pojedynczej funkcji lub kontynuacji wcześniejszej próby.

| Próba | Oczekiwany wynik |
|---|---|
| Funkcja dla false/false, true/false, false/true, true/true | Cztery właściwe komunikaty; gotowość wyłącznie przy true/true. |
| Odczyt opisu przy karcie i zasilaniu | Wygrana nadal false przed wyjdz. |
| start, opis, status | Stan pozostaje początkowy. |

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
