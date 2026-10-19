# Próby odbiorowe

Każdą próbę zaczynamy od start. Po sekwencji wpisujemy status. Komendy z tabeli wpisujemy osobno, każdą zatwierdzając Enterem. Oczekiwania odnoszą się do limitu 10.

| Nr | Próba i komendy po start | Oczekiwane | Otrzymane / osoba |
|---|---|---|---|
| 1 | mapa, pomoc, opis, status | 4 pokoje, 1 znacznik przy recepcji; energia 10 | … |
| 2 | lewo, gora, pusty Enter | Pokój 1, energia 10 | Piotrek14689 |
| 3 | prawo | Pokój 2, energia 9 | Piotrek14689 |
| 4 | prawo, prawo, prawo, prawo | Pokój 4, energia 7; ostatni ruch odrzucony | Piotrek14689 |
| 5 | karta, karta | Karta True, energia 9 | … |
| 6 | bezpiecznik | Bezpiecznik False, energia 10 | … |
| 7 | prawo, prawo, napraw | Pokój 3, energia 8, zasilanie False | … |
| 8 | karta, prawo, prawo, prawo, wyjdz | Brak zasilania; pokój 4, energia 6, koniec False | … |
| 9 | prawo, bezpiecznik, prawo, napraw, prawo, wyjdz | Brak karty; pokój 4, energia 5, koniec False | … |
| 10 | karta, prawo, bezpiecznik, prawo, napraw, lewo, bezpiecznik | Energia 4, zasilanie True, bezpiecznik False; nie odradza się | … |
| 11 | Znajdźcie drogę zwycięską i zapiszcie ją poniżej | Jedna wygrana, bez jednoczesnej przegranej | … |
| 12 | Pięć razy para prawo, lewo | Pokój 1, energia 0, koniec True, wygrana False | … |
| 13 | Po próbie 12: prawo, karta, status | Stan nie zmienia się; informacje nadal działają | … |
| 14 | Po końcu gry: start, status | Pokój 1, energia 10, wszystkie flagi False | … |
| 15 | Wpisz spacje + PRAWO + spacje | Pokój 2, energia 9; wielkość liter i skrajne spacje nie przeszkadzają | … |
| 16 | koniec | Aplikacja wraca do terminala | … |

## Nasza droga zwycięska

…

## Znaleziony błąd

- Wersja/commit: 4191b2e208bb85a2fc481251bfbdba06b1027d73
- Kroki od startu: prawo, bezpiecznik, prawo, napraw, prawo, wyjdz
- Oczekiwane: Brak karty; pokój 4, energia 5, koniec False
- Rzeczywiste: Brak karty; pokój 4; energia 7, koniec False
- Poprawka i ponowna próba: Zmiana logiki w if'ie 
