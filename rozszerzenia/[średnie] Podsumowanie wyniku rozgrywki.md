# Podsumowanie wyniku rozgrywki

**Poziom:** średnie  
**Zadanie:** 14/19

## Cel

Dodaj czytelne określenie wyniku i kosztu zakończonej rozgrywki.

## Zakres i zasady

- Pracuj na ukończonej grze, nie na nieuzupełnionym starterze. Wybierz jeden dodatek; nie musisz realizować całego zestawu.
- Zachowaj cztery pokoje, ich połączenia, rozmieszczenie przedmiotów i warunki zwycięstwa. Nie zmieniaj limitu 10 energii.
- Tylko udany ruch lub udana akcja kosztuje 1 energię. Koszt nalicza wyłącznie `ZakonczTure()`, dokładnie raz. Informacje i odmowy są bezpłatne.
- Po zakończeniu gry ruch i akcje nie zmieniają danych. Wygrana ma pierwszeństwo przed przegraną przy zerowej energii.
- Korzystaj z `int`, `bool`, `string`, warunków, pętli oraz funkcji lokalnych. Bez klas, tablic, kolekcji, plików, losowania, MAUI i dodatkowych pakietów.
- Zachowaj istniejące nazwy i parametry funkcji. Nowe zmienne zadeklaruj i zainicjalizuj przed pierwszym `Start()`. Funkcjom korzystającym ze wspólnego stanu nie dodawaj `static`.
- Uzgodnij zmiany wspólnych zmiennych i sekcji 0 z zespołem. Jeden autor edytuje dany wspólny fragment; nie przeformatowuj całego pliku.

## Co należy wykonać

1. Na podstawie koniec i wygrana pokaż Rozgrywka trwa, Zwycięstwo albo Przegrana.
2. Po zakończeniu wyświetl zużytą energię, obliczoną jako MAKS_ENERGIA - energia. Nie dodawaj zmiennej przechowującej tę samą informację.
3. Nie oceniaj zwycięstwa wyłącznie na podstawie energii. Sam status nie kończy rozgrywki.

## Miejsce zmian

Status() lub wywoływana z niego funkcja informacyjna.

## Przykład techniki — nie rozwiązanie zadania

Poniższy listing jest kompletnym, osobnym programem. Uruchom go w projekcie prób, zastępując jego `Program.cs`. Nie wklejaj go do gry ani nie dodawaj drugiego pliku z instrukcjami najwyższego poziomu w projekcie gry.

```csharp
Console.WriteLine(WynikPrzesylki(false, false));
Console.WriteLine(WynikPrzesylki(true, true));
Console.WriteLine(WynikPrzesylki(true, false));
string WynikPrzesylki(bool zakonczono, bool doreczono)
{
    if (!zakonczono) return "W drodze";
    if (doreczono) return "Doreczona";
    return "Zwrocona";
}
```

**Oczekiwany wynik:**

```text
W drodze
Doreczona
Zwrocona
```

Dwie flagi opisują trzy stany procesu. Kolejność decyzji oddziela trwający proces od jego wyniku.

## Próby odbiorowe

W sekwencjach konsolowych wpisuj każdą komendę osobno i zatwierdzaj Enterem. Każdy niezależny scenariusz zaczynaj od `start`, chyba że opis dotyczy pojedynczej funkcji lub kontynuacji wcześniejszej próby.

| Próba | Oczekiwany wynik |
|---|---|
| start, status | Rozgrywka trwa. |
| start; pięć razy prawo, lewo; status | Przegrana; zużyto 10 energii. |
| Zwycięska sekwencja z zadania 10, status | Zwycięstwo; zużyto 7 energii. |
| Kontrola warunku dla koniec=true, wygrana=true, energia=0 | Wynik Zwycięstwo, nigdy Przegrana. To kontrola izolowana, nie legalny zapis stanu gry. |

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
