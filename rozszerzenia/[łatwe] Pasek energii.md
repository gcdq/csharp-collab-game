# Pasek energii

**Poziom:** łatwe  
**Zadanie:** 01/19

## Cel

Pokaż energię jako pasek o stałej długości.

## Zakres i zasady

- Pracuj na ukończonej grze, nie na nieuzupełnionym starterze. Wybierz jeden dodatek; nie musisz realizować całego zestawu.
- Zachowaj cztery pokoje, ich połączenia, rozmieszczenie przedmiotów i warunki zwycięstwa. Nie zmieniaj limitu 10 energii.
- Tylko udany ruch lub udana akcja kosztuje 1 energię. Koszt nalicza wyłącznie `ZakonczTure()`, dokładnie raz. Informacje i odmowy są bezpłatne.
- Po zakończeniu gry ruch i akcje nie zmieniają danych. Wygrana ma pierwszeństwo przed przegraną przy zerowej energii.
- Korzystaj z `int`, `bool`, `string`, warunków, pętli oraz funkcji lokalnych. Bez klas, tablic, kolekcji, plików, losowania, MAUI i dodatkowych pakietów.
- Zachowaj istniejące nazwy i parametry funkcji. Nowe zmienne zadeklaruj i zainicjalizuj przed pierwszym `Start()`. Funkcjom korzystającym ze wspólnego stanu nie dodawaj `static`.
- Uzgodnij zmiany wspólnych zmiennych i sekcji 0 z zespołem. Jeden autor edytuje dany wspólny fragment; nie przeformatowuj całego pliku.

## Co należy wykonać

1. Napisz funkcję string PasekEnergii(). Zwraca tekst, nie wypisuje go i nie zmienia energii.
2. Za pomocą for zbuduj dokładnie MAKS_ENERGIA znaków: # dla dostępnej energii, . dla zużytej.
3. Wyświetl wynik w Status(). Nie wpisuj liczby 10 na sztywno w pętli.

## Miejsce zmian

Sekcja A: nowa funkcja; uzgodniona zmiana w Status().

## Przykład techniki — nie rozwiązanie zadania

Poniższy listing jest kompletnym, osobnym programem. Uruchom go w projekcie prób, zastępując jego `Program.cs`. Nie wklejaj go do gry ani nie dodawaj drugiego pliku z instrukcjami najwyższego poziomu w projekcie gry.

```csharp
string tekst = "";
for (int numer = 1; numer <= 4; numer = numer + 1)
{
    tekst = tekst + numer;
}
Console.WriteLine(tekst);
```

**Oczekiwany wynik:**

```text
1234
```

Przykład buduje napis w pętli. Nie wybiera symboli na podstawie energii i nie implementuje paska.

## Próby odbiorowe

W sekwencjach konsolowych wpisuj każdą komendę osobno i zatwierdzaj Enterem. Każdy niezależny scenariusz zaczynaj od `start`, chyba że opis dotyczy pojedynczej funkcji lub kontynuacji wcześniejszej próby.

| Próba | Oczekiwany wynik |
|---|---|
| start, status | Pasek ##########; energia 10. |
| start, prawo, status | Pasek #########.; energia 9. |
| start; pięć razy prawo, lewo; status | Pasek ..........; energia 0. |
| status dwa razy | Identyczny stan gry przed odczytami i po nich. |

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
