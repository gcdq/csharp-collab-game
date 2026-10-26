# Słowna ocena zapasu energii

**Poziom:** łatwe  
**Zadanie:** 02/19

## Cel

Dodaj czytelną ocenę zapasu obok liczby energii.

## Zakres i zasady

- Pracuj na ukończonej grze, nie na nieuzupełnionym starterze. Wybierz jeden dodatek; nie musisz realizować całego zestawu.
- Zachowaj cztery pokoje, ich połączenia, rozmieszczenie przedmiotów i warunki zwycięstwa. Nie zmieniaj limitu 10 energii.
- Tylko udany ruch lub udana akcja kosztuje 1 energię. Koszt nalicza wyłącznie `ZakonczTure()`, dokładnie raz. Informacje i odmowy są bezpłatne.
- Po zakończeniu gry ruch i akcje nie zmieniają danych. Wygrana ma pierwszeństwo przed przegraną przy zerowej energii.
- Korzystaj z `int`, `bool`, `string`, warunków, pętli oraz funkcji lokalnych. Bez klas, tablic, kolekcji, plików, losowania, MAUI i dodatkowych pakietów.
- Zachowaj istniejące nazwy i parametry funkcji. Nowe zmienne zadeklaruj i zainicjalizuj przed pierwszym `Start()`. Funkcjom korzystającym ze wspólnego stanu nie dodawaj `static`.
- Uzgodnij zmiany wspólnych zmiennych i sekcji 0 z zespołem. Jeden autor edytuje dany wspólny fragment; nie przeformatowuj całego pliku.

## Co należy wykonać

1. Napisz string OcenaEnergii(int wartosc). Dla 7–10 zwracaj Duży zapas; dla 4–6 Uważaj na zbędne ruchy; dla 1–3 Niski zapas; dla 0 Brak energii.
2. Dla wartości spoza 0–MAKS_ENERGIA zwróć Nieprawidłowa wartość. Nie zmieniaj poprawnego stanu gry, aby uzyskać taki przypadek — sprawdź samą funkcję.
3. Wywołaj funkcję w Status(). Brak energii nie oznacza automatycznie przegranej: można wygrać ostatnim punktem.

## Miejsce zmian

Nowa funkcja lokalna oraz Status().

## Przykład techniki — nie rozwiązanie zadania

Poniższy listing jest kompletnym, osobnym programem. Uruchom go w projekcie prób, zastępując jego `Program.cs`. Nie wklejaj go do gry ani nie dodawaj drugiego pliku z instrukcjami najwyższego poziomu w projekcie gry.

```csharp
Console.WriteLine(OcenaTemperatury(-2));
Console.WriteLine(OcenaTemperatury(8));
Console.WriteLine(OcenaTemperatury(20));
string OcenaTemperatury(int temperatura)
{
    if (temperatura < 0) return "Mroz";
    if (temperatura < 15) return "Chlodno";
    return "Cieplo";
}
```

**Oczekiwany wynik:**

```text
Mroz
Chlodno
Cieplo
```

Funkcja klasyfikuje temperaturę. Zauważ znaczenie kolejności warunków i return.

## Próby odbiorowe

W sekwencjach konsolowych wpisuj każdą komendę osobno i zatwierdzaj Enterem. Każdy niezależny scenariusz zaczynaj od `start`, chyba że opis dotyczy pojedynczej funkcji lub kontynuacji wcześniejszej próby.

| Próba | Oczekiwany wynik |
|---|---|
| Wywołania dla 0, 1, 3, 4, 6, 7, 10 | Odpowiednie komunikaty na granicach przedziałów. |
| Wywołania dla -1 i 11 | Nieprawidłowa wartość. |
| start, status, status | Energia pozostaje 10. |

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
