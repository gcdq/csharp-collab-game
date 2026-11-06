# Próby odbiorowe

Każdą próbę zaczynamy od start. Po sekwencji wpisujemy status. Komendy z tabeli wpisujemy osobno, każdą zatwierdzając Enterem. Oczekiwania odnoszą się do limitu 10.

| Nr | Próba i komendy po start | Oczekiwane | Otrzymane / osoba |
|---|---|---|---|
| 1 | mapa, pomoc, opis, status | 4 pokoje, 1 znacznik przy recepcji; energia 10 | gcdq / Erwin676767 |
| 2 | lewo, gora, pusty Enter | Pokój 1, energia 10 | Piotrek14689 |
| 3 | prawo | Pokój 2, energia 9 | Piotrek14689 |
| 4 | prawo, prawo, prawo, prawo | Pokój 4, energia 7; ostatni ruch odrzucony | Piotrek14689 |
| 5 | karta, karta | Karta True, energia 9 | gcdq / Erwin676767 |
| 6 | bezpiecznik | Bezpiecznik False, energia 10 | gcdq / Erwin676767 |
| 7 | prawo, prawo, napraw | Pokój 3, energia 8, zasilanie False | gcdq / Erwin676767 |
| 8 | karta, prawo, prawo, prawo, wyjdz | Brak zasilania; pokój 4, energia 6, koniec False | gcdq / Erwin676767 |
| 9 | prawo, bezpiecznik, prawo, napraw, prawo, wyjdz | Brak karty; pokój 4, energia 5, koniec False | gcdq / Erwin676767 |
| 10 | karta, prawo, bezpiecznik, prawo, napraw, lewo, bezpiecznik | Energia 4, zasilanie True, bezpiecznik False; nie odradza się | gcdq / Erwin676767 |
| 11 | Znajdźcie drogę zwycięską i zapiszcie ją poniżej | Jedna wygrana, bez jednoczesnej przegranej | gcdq / Erwin676767 |
| 12 | Pięć razy para prawo, lewo | Pokój 1, energia 0, koniec True, wygrana False | gcdq / Erwin676767 |
| 13 | Po próbie 12: prawo, karta, status | Stan nie zmienia się; informacje nadal działają | gcdq / Erwin676767 |
| 14 | Po końcu gry: start, status | Pokój 1, energia 10, wszystkie flagi False | gcdq / Erwin676767 |
| 15 | Wpisz spacje + PRAWO + spacje | Pokój 2, energia 9; wielkość liter i skrajne spacje nie przeszkadzają | gcdq / Erwin676767 |
| 16 | koniec | Aplikacja wraca do terminala | gcdq / Erwin676767 |
| T2.1 | start, odkrycia, mapa, status | Odkryty tylko pokój 1; 1/4; energia 10; jeden znacznik bieżącej pozycji. | Erwin676767 |
| T2.2 | start, prawo, lewo, prawo, odkrycia, status | Odkryte 1 i 2; 2/4; pokój 2; energia 7. Powroty nie zwiększają liczby różnych pokojów. | Erwin676767 |
| T2.3 | start, prawo, prawo, prawo, odkrycia | 4/4; energia 7. Nazwy i znaczniki zgadzają się z pozycją. | Erwin676767 |
| T2.4 | start, lewo, gora, pusty Enter, odkrycia | 1/4; pokój 1; energia 10. | Erwin676767 |
| T2.5 | start, prawo, odkrycia, mapa, opis, status, odkrycia | Nadal 2/4 i energia 9; żadna informacja nie odkrywa nowego pokoju. | Erwin676767 |
| T2.6 | Po T2.3: start, odkrycia | Ponownie tylko pokój 1; energia 10. | Erwin676767 |
| T2.7 | start; pięć razy para prawo, lewo; prawo, odkrycia, status | Przegrana; pokój 1; energia 0; 2/4. Ruch po końcu nie działa, odczyt działa. | Erwin676767 |
| T2.8 | start, karta, prawo, bezpiecznik, prawo, napraw, prawo, wyjdz, odkrycia | Wygrana; energia 3; 4/4; odkrycia nie zmieniają wyniku. | Erwin676767 |
| T2.9 | Osobny test funkcji: nazwy dla 0 i 5; zliczenie pustej bool[] | Nieznane pomieszczenie dla obu numerów; wynik zliczenia 0; bez odwołania poza tablicę. | Erwin676767 |
| T2.10 | start, polecenie ODKRYCIA ze skrajnymi spacjami | Ten sam odczyt co odkrycia; energia 10. | Erwin676767 |
| T2.11 | start, odkrycia | Pasek odkryć: #... | Piotrek14689 | 
| T2.12 | start, prawo, lewo, odkrycia | Pasek odkryć: ##.. | Piotrek14689 |
| T2.13 | start, prawo, prawo,, prawo odkrycia | Pasek odkryć: #### | Piotrek14689 |

## Nasza droga zwycięska
karta -> prawo -> bezpiecznik -> prawo -> napraw -> prawo -> wyjdz

## Znaleziony błąd

- Wersja/commit: 4191b2e208bb85a2fc481251bfbdba06b1027d73
- Kroki od startu: prawo, bezpiecznik, prawo, napraw, prawo, wyjdz
- Oczekiwane: Brak karty; pokój 4, energia 5, koniec False
- Rzeczywiste: Brak karty; pokój 4; energia 7, koniec False
- Poprawka i ponowna próba: Zmiana logiki w if'ie 
