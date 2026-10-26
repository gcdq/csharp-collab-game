# Licznik odrzuconych prób ruchu

**Poziom:** średnie  
**Zadanie:** 11/19

## Cel

Zliczaj próby przejścia przez ścianę podczas aktywnej gry.

## Zakres i zasady

- Pracuj na ukończonej grze, nie na nieuzupełnionym starterze. Wybierz jeden dodatek; nie musisz realizować całego zestawu.
- Zachowaj cztery pokoje, ich połączenia, rozmieszczenie przedmiotów i warunki zwycięstwa. Nie zmieniaj limitu 10 energii.
- Tylko udany ruch lub udana akcja kosztuje 1 energię. Koszt nalicza wyłącznie `ZakonczTure()`, dokładnie raz. Informacje i odmowy są bezpłatne.
- Po zakończeniu gry ruch i akcje nie zmieniają danych. Wygrana ma pierwszeństwo przed przegraną przy zerowej energii.
- Korzystaj z `int`, `bool`, `string`, warunków, pętli oraz funkcji lokalnych. Bez klas, tablic, kolekcji, plików, losowania, MAUI i dodatkowych pakietów.
- Zachowaj istniejące nazwy i parametry funkcji. Nowe zmienne zadeklaruj i zainicjalizuj przed pierwszym `Start()`. Funkcjom korzystającym ze wspólnego stanu nie dodawaj `static`.
- Uzgodnij zmiany wspólnych zmiennych i sekcji 0 z zespołem. Jeden autor edytuje dany wspólny fragment; nie przeformatowuj całego pliku.

## Co należy wykonać

1. Dodaj licznik int. Zwiększaj go tylko wtedy, gdy zaplanowany numer pokoju wypada poza 1–4.
2. Nie wliczaj poleceń po zakończeniu gry ani nieznanych kierunków. Komenda gora jest odrzucana przez rozdzielacz, nie przez Idz().
3. Zeruj licznik przy starcie i wyświetlaj w statusie. Nie pobieraj energii za odmowę.

## Miejsce zmian

Wspólne zmienne, Start(), Status(), gałąź kontroli granic w Idz().

## Przykład techniki — nie rozwiązanie zadania

Poniższy listing jest kompletnym, osobnym programem. Uruchom go w projekcie prób, zastępując jego `Program.cs`. Nie wklejaj go do gry ani nie dodawaj drugiego pliku z instrukcjami najwyższego poziomu w projekcie gry.

```csharp
int bledyZakresu = 0;
Sprawdz(0);
Sprawdz(3);
Sprawdz(6);
Console.WriteLine(bledyZakresu);
void Sprawdz(int wartosc)
{
    if (wartosc < 1 || wartosc > 5)
    {
        bledyZakresu = bledyZakresu + 1;
        return;
    }
}
```

**Oczekiwany wynik:**

```text
2
```

Przykład zlicza wyłącznie błędy określonego rodzaju: przekroczenie zakresu.

## Próby odbiorowe

W sekwencjach konsolowych wpisuj każdą komendę osobno i zatwierdzaj Enterem. Każdy niezależny scenariusz zaczynaj od `start`, chyba że opis dotyczy pojedynczej funkcji lub kontynuacji wcześniejszej próby.

| Próba | Oczekiwany wynik |
|---|---|
| start, lewo, lewo, status | 2 odmowy; pokój 1, energia 10. |
| start, gora, status | 0 odmów przejścia przez ścianę. |
| start, prawo, prawo, prawo, prawo, status | 1 odmowa; pokój 4, energia 7. |
| Po przegranej: lewo, status | Licznik i pozostałe dane bez zmian. |

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
