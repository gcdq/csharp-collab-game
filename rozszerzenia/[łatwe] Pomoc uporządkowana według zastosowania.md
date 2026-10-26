# Pomoc uporządkowana według zastosowania

**Poziom:** łatwe  
**Zadanie:** 03/19

## Cel

Ułatw graczowi odnalezienie właściwego polecenia.

## Zakres i zasady

- Pracuj na ukończonej grze, nie na nieuzupełnionym starterze. Wybierz jeden dodatek; nie musisz realizować całego zestawu.
- Zachowaj cztery pokoje, ich połączenia, rozmieszczenie przedmiotów i warunki zwycięstwa. Nie zmieniaj limitu 10 energii.
- Tylko udany ruch lub udana akcja kosztuje 1 energię. Koszt nalicza wyłącznie `ZakonczTure()`, dokładnie raz. Informacje i odmowy są bezpłatne.
- Po zakończeniu gry ruch i akcje nie zmieniają danych. Wygrana ma pierwszeństwo przed przegraną przy zerowej energii.
- Korzystaj z `int`, `bool`, `string`, warunków, pętli oraz funkcji lokalnych. Bez klas, tablic, kolekcji, plików, losowania, MAUI i dodatkowych pakietów.
- Zachowaj istniejące nazwy i parametry funkcji. Nowe zmienne zadeklaruj i zainicjalizuj przed pierwszym `Start()`. Funkcjom korzystającym ze wspólnego stanu nie dodawaj `static`.
- Uzgodnij zmiany wspólnych zmiennych i sekcji 0 z zespołem. Jeden autor edytuje dany wspólny fragment; nie przeformatowuj całego pliku.

## Co należy wykonać

1. Podziel Pomoc() na cztery grupy: informacje; ruch; przedmioty i działania; sterowanie rozgrywką.
2. Uwzględnij wszystkie 12 poleceń: pomoc, status, mapa, opis, lewo, prawo, karta, bezpiecznik, napraw, wyjdz, start, koniec.
3. Wyjaśnij koszty oraz różnice między wyjdz, start i koniec. Po zakończeniu gry dopisz informację o blokadzie ruchu i akcji.

## Miejsce zmian

Pomoc() w sekcji A.

## Przykład techniki — nie rozwiązanie zadania

Poniższy listing jest kompletnym, osobnym programem. Uruchom go w projekcie prób, zastępując jego `Program.cs`. Nie wklejaj go do gry ani nie dodawaj drugiego pliku z instrukcjami najwyższego poziomu w projekcie gry.

```csharp
bool zamkniete = true;
Console.WriteLine("BIBLIOTEKA");
Console.WriteLine("Informacje: katalog, godziny");
if (zamkniete)
{
    Console.WriteLine("Wypozyczanie jest teraz niedostepne.");
}
```

**Oczekiwany wynik:**

```text
BIBLIOTEKA
Informacje: katalog, godziny
Wypozyczanie jest teraz niedostepne.
```

Przykład pokazuje grupowanie komunikatów i dodatkową informację zależną od flagi.

## Próby odbiorowe

W sekwencjach konsolowych wpisuj każdą komendę osobno i zatwierdzaj Enterem. Każdy niezależny scenariusz zaczynaj od `start`, chyba że opis dotyczy pojedynczej funkcji lub kontynuacji wcześniejszej próby.

| Próba | Oczekiwany wynik |
|---|---|
| start, pomoc | Wszystkie polecenia, grupy i koszty; energia 10. |
| Po przegranej: pomoc | Informacja o blokadzie i możliwości restartu. |
| Po wygranej: pomoc, status | Pomoc działa i nie zmienia wyniku. |

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
