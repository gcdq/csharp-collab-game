using System;

// WSPOLNY KONTRAKT. Wszystkie dane inicjalizujemy przed Start().
const int MAKS_ENERGIA = 10;
int pokoj = 1;
int energia = MAKS_ENERGIA;
bool karta = false;
bool bezpiecznik = false;
bool zasilanie = false;
bool koniec = false;
bool wygrana = false;

// SEKCJA 0: GOTOWY SILNIK NAUCZYCIELA. Nie zmieniaj w zadaniu podstawowym.
Start();
while (true)
{
    Console.Write("> ");
    string? wejscie = Console.ReadLine();
    if (wejscie == null)
    {
        Console.WriteLine("Koniec wejscia. Zamykam program.");
        break;
    }

    string polecenie = wejscie.Trim().ToLowerInvariant();
    if (polecenie == "koniec")
    {
        Console.WriteLine("Do zobaczenia!");
        break;
    }
    if (polecenie == "")
    {
        Console.WriteLine("Wpisz polecenie albo pomoc.");
        continue;
    }

    // Rozdzielacz dziala od poczatku, zeby zespoly mogly testowac niezaleznie.
    switch (polecenie)
    {
        case "start": Start(); break;
        case "pomoc": Pomoc(); break;
        case "status": Status(); break;
        case "mapa": Mapa(); break;
        case "opis": Rozejrzyj(); break;
        case "lewo": Idz("lewo"); break;
        case "prawo": Idz("prawo"); break;
        case "karta": Akcja("karta"); break;
        case "bezpiecznik": Akcja("bezpiecznik"); break;
        case "napraw": Akcja("napraw"); break;
        case "wyjdz": Akcja("wyjdz"); break;
        default: Console.WriteLine("Nieznane polecenie. Wpisz pomoc."); break;
    }
}

void Start()
{
    pokoj = 1;
    energia = MAKS_ENERGIA;
    karta = false;
    bezpiecznik = false;
    zasilanie = false;
    koniec = false;
    wygrana = false;
    Console.WriteLine("UCIECZKA Z SERWEROWNI: PIATEK, 16:59.");
    Console.WriteLine("Administrator napisal: u mnie dziala. Drzwi twierdza inaczej.");
    Console.WriteLine("Masz " + MAKS_ENERGIA + " energii. Wpisz pomoc. Koniec zamyka program.");
    Rozejrzyj();
}

void ZakonczTure()
{
    energia = energia - 1;
    Console.WriteLine("Pozostala energia: " + energia);
    if (wygrana)
    {
        koniec = true;
        Console.WriteLine("WYGRANA! Drzwi otwarte. Weekend uratowany.");
    }
    else if (energia <= 0)
    {
        koniec = true;
        Console.WriteLine("PRZEGRANA. Energia sie skonczyla. Wpisz start albo koniec.");
    }
}

// Status jest gotowy: sluzy do testow, zanim autor mapy skonczy swoja sekcje.
void Status()
{
    Console.WriteLine("Pokoj: " + pokoj);
    Console.WriteLine("Energia: " + energia + "/" + MAKS_ENERGIA);
    Console.WriteLine("Karta: " + karta);
    Console.WriteLine("Bezpiecznik: " + bezpiecznik);
    Console.WriteLine("Zasilanie: " + zasilanie);
    Console.WriteLine("Koniec: " + koniec);
    Console.WriteLine("Wygrana: " + wygrana);
}

// SEKCJA A: INFORMACJE I MAPA. Wlasciciel: osoba A.
string NazwaPokoju(int numer)
{
    // TODO A1: zwroc nazwe dla 1, 2, 3, 4 oraz wartosc dla nieznanego numeru.
    return "Pokoj " + numer;
}

void Pomoc()
{
    // TODO A2: wypisz wszystkie komendy oraz koszt czynnosci.
    Console.WriteLine("TODO A: pomoc, status, mapa, opis, lewo, prawo,");
    Console.WriteLine("karta, bezpiecznik, napraw, wyjdz, start, koniec.");
}

void Mapa()
{
    // TODO A3: petla for, numery 1..4, jeden znacznik aktualnego pokoju.
    Console.WriteLine("TODO A: mapa.");
}

void Rozejrzyj()
{
    Console.WriteLine("Jestes w: " + NazwaPokoju(pokoj));
    // TODO A4: opis zalezy od pokoju oraz obecnosci przedmiotow/zasilania.
    Console.WriteLine("TODO A: opis pokoju.");
}

// SEKCJA B: RUCH. Wlasciciel: osoba B.
void Idz(string kierunek)
{
    if(koniec) return;
    
    int nastepnyPokoj = pokoj;

    if(kierunek == "lewo") nastepnyPokoj--;
    else if(kierunek == "prawo") nastepnyPokoj++;
    else
    {
        Console.WriteLine("Zly kierunek!");
        return;
    }

    if(nastepnyPokoj < 1 || nastepnyPokoj > 4) 
    {
        Console.WriteLine($"Jestes na granicy! Nie możesz isc w {kierunek}");
        return;
    }

    pokoj = nastepnyPokoj;
    Rozejrzyj();
    ZakonczTure();
}

// SEKCJA C: PRZEDMIOTY I WYGRANA. Wlasciciel: osoba C.
void Akcja(string co)
{
    // TODO C1: odrzuc akcje po zakonczeniu gry.
    // TODO C2: obsluz karta, bezpiecznik, napraw, wyjdz zgodnie z kontraktem.
    // TODO C3: przy odmowie wypisz powod i wykonaj return.
    // TODO C4: tylko po udanej akcji wywolaj raz ZakonczTure.
    Console.WriteLine("TODO C: akcja " + co);
}
