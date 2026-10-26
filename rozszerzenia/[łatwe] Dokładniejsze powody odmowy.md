# Dokładniejsze powody odmowy

**Poziom:** łatwe  
**Zadanie:** 05/19

## Cel

Wyjaśniaj graczowi konkretny powód odrzucenia akcji.

## Zakres i zasady

- Pracuj na ukończonej grze, nie na nieuzupełnionym starterze. Wybierz jeden dodatek; nie musisz realizować całego zestawu.
- Zachowaj cztery pokoje, ich połączenia, rozmieszczenie przedmiotów i warunki zwycięstwa. Nie zmieniaj limitu 10 energii.
- Tylko udany ruch lub udana akcja kosztuje 1 energię. Koszt nalicza wyłącznie `ZakonczTure()`, dokładnie raz. Informacje i odmowy są bezpłatne.
- Po zakończeniu gry ruch i akcje nie zmieniają danych. Wygrana ma pierwszeństwo przed przegraną przy zerowej energii.
- Korzystaj z `int`, `bool`, `string`, warunków, pętli oraz funkcji lokalnych. Bez klas, tablic, kolekcji, plików, losowania, MAUI i dodatkowych pakietów.
- Zachowaj istniejące nazwy i parametry funkcji. Nowe zmienne zadeklaruj i zainicjalizuj przed pierwszym `Start()`. Funkcjom korzystającym ze wspólnego stanu nie dodawaj `static`.
- Uzgodnij zmiany wspólnych zmiennych i sekcji 0 z zespołem. Jeden autor edytuje dany wspólny fragment; nie przeformatowuj całego pliku.

## Co należy wykonać

1. Rozróżnij niewłaściwe pomieszczenie, już zabraną kartę, brak bezpiecznika oraz już naprawione zasilanie.
2. Przy wyjściu rozróżnij brak karty, brak prądu i brak obu. Najpierw obsłuż koniec gry, potem niewłaściwy pokój, następnie pozostałe warunki.
3. Każda odmowa kończy gałąź przed zmianą stanu i wywołaniem ZakonczTure(). Zachowaj dotychczasowe warunki sukcesu.

## Miejsce zmian

Akcja() w sekcji C.

## Przykład techniki — nie rozwiązanie zadania

Poniższy listing jest kompletnym, osobnym programem. Uruchom go w projekcie prób, zastępując jego `Program.cs`. Nie wklejaj go do gry ani nie dodawaj drugiego pliku z instrukcjami najwyższego poziomu w projekcie gry.

```csharp
SprawdzBilet(false, false);
SprawdzBilet(true, false);
SprawdzBilet(true, true);
void SprawdzBilet(bool otwarte, bool bilet)
{
    if (!otwarte) { Console.WriteLine("Kasa zamknieta"); return; }
    if (!bilet) { Console.WriteLine("Brak biletu"); return; }
    Console.WriteLine("Mozesz wejsc");
}
```

**Oczekiwany wynik:**

```text
Kasa zamknieta
Brak biletu
Mozesz wejsc
```

Kilka wcześniejszych return pozwala rozróżnić powody odmowy. To przykład wejścia do kina, nie obsługi akcji gry.

## Próby odbiorowe

W sekwencjach konsolowych wpisuj każdą komendę osobno i zatwierdzaj Enterem. Każdy niezależny scenariusz zaczynaj od `start`, chyba że opis dotyczy pojedynczej funkcji lub kontynuacji wcześniejszej próby.

| Próba | Oczekiwany wynik |
|---|---|
| start, karta, karta | Druga próba: karta już zabrana; energia 9. |
| start, prawo, prawo, napraw | Brak bezpiecznika; energia 8. |
| start, prawo, prawo, prawo, wyjdz | Brak karty i zasilania; energia 7. |
| start, karta, prawo, prawo, prawo, wyjdz | Brak zasilania; energia 6. |

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
