# Podpowiedź zależna od sytuacji

**Poziom:** średnie  
**Zadanie:** 08/19

## Cel

Dodaj jedną podpowiedź kolejnego kroku do opisu pokoju.

## Zakres i zasady

- Pracuj na ukończonej grze, nie na nieuzupełnionym starterze. Wybierz jeden dodatek; nie musisz realizować całego zestawu.
- Zachowaj cztery pokoje, ich połączenia, rozmieszczenie przedmiotów i warunki zwycięstwa. Nie zmieniaj limitu 10 energii.
- Tylko udany ruch lub udana akcja kosztuje 1 energię. Koszt nalicza wyłącznie `ZakonczTure()`, dokładnie raz. Informacje i odmowy są bezpłatne.
- Po zakończeniu gry ruch i akcje nie zmieniają danych. Wygrana ma pierwszeństwo przed przegraną przy zerowej energii.
- Korzystaj z `int`, `bool`, `string`, warunków, pętli oraz funkcji lokalnych. Bez klas, tablic, kolekcji, plików, losowania, MAUI i dodatkowych pakietów.
- Zachowaj istniejące nazwy i parametry funkcji. Nowe zmienne zadeklaruj i zainicjalizuj przed pierwszym `Start()`. Funkcjom korzystającym ze wspólnego stanu nie dodawaj `static`.
- Uzgodnij zmiany wspólnych zmiennych i sekcji 0 z zespołem. Jeden autor edytuje dany wspólny fragment; nie przeformatowuj całego pliku.

## Co należy wykonać

1. Ustal priorytety: koniec gry; brak karty; brak zasilania i bezpiecznika; bezpiecznik do zamontowania; gotowość do wyjścia.
2. Gdy gracz jest przy potrzebnym obiekcie, sugeruj akcję. W przeciwnym razie sugeruj jeden krok we właściwym kierunku.
3. Podpowiedź działa również po naprawie wykonanej przed zabraniem karty. Nie wykonuje ruchu i nie gwarantuje wystarczającej energii.
4. Po zakończeniu gry sugeruj start lub koniec, bez dalszych porad ruchu.

## Miejsce zmian

Nowa funkcja informacyjna wywoływana w Rozejrzyj().

## Przykład techniki — nie rozwiązanie zadania

Poniższy listing jest kompletnym, osobnym programem. Uruchom go w projekcie prób, zastępując jego `Program.cs`. Nie wklejaj go do gry ani nie dodawaj drugiego pliku z instrukcjami najwyższego poziomu w projekcie gry.

```csharp
Console.WriteLine(Wskazowka(2, 5));
Console.WriteLine(Wskazowka(5, 2));
Console.WriteLine(Wskazowka(3, 3));
string Wskazowka(int teraz, int cel)
{
    if (teraz < cel) return "Zwieksz numer";
    if (teraz > cel) return "Zmniejsz numer";
    return "Jestes u celu";
}
```

**Oczekiwany wynik:**

```text
Zwieksz numer
Zmniejsz numer
Jestes u celu
```

Przykład porównuje dwie liczby. Nie wybiera celu misji ani kolejności jej etapów.

## Próby odbiorowe

W sekwencjach konsolowych wpisuj każdą komendę osobno i zatwierdzaj Enterem. Każdy niezależny scenariusz zaczynaj od `start`, chyba że opis dotyczy pojedynczej funkcji lub kontynuacji wcześniejszej próby.

| Próba | Oczekiwany wynik |
|---|---|
| start, opis | Sugestia zabrania karty. |
| start, prawo, opis | Sugestia powrotu w lewo po kartę. |
| start, prawo, bezpiecznik, prawo, napraw, opis | Sugestia powrotu po kartę, a nie ponownego bezpiecznika. |
| Po przegranej: opis | Sugestia restartu lub zakończenia aplikacji. |

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
