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

## Nasza droga zwycięska
karta -> prawo -> bezpiecznik -> prawo -> napraw -> prawo -> wyjdz

## Znaleziony błąd

- Wersja/commit: 4191b2e208bb85a2fc481251bfbdba06b1027d73
- Kroki od startu: prawo, bezpiecznik, prawo, napraw, prawo, wyjdz
- Oczekiwane: Brak karty; pokój 4, energia 5, koniec False
- Rzeczywiste: Brak karty; pokój 4; energia 7, koniec False
- Poprawka i ponowna próba: Zmiana logiki w if'ie 
