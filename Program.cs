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
    switch (numer) {
        case 1: return "Recepcja";
        case 2: return "Magazyn";
        case 3: return "Serwerowania";
        case 4: return "Wyjście";
    }

    return "Nieznane pomieszczenie";
}

void Pomoc()
{
    // TODO A2: wypisz wszystkie komendy oraz koszt czynnosci.
    Console.WriteLine("\nPomoc:");
    Console.WriteLine("\tpomoc          Wyświetla polecenia i zasady rozgrywki");
    Console.WriteLine("\tstatus         Wyświetla dane rozgrywki");
    Console.WriteLine("\tmapa           Wyświetla pokoje i znacznik pozycji");
    Console.WriteLine("\topis           Rozejrzenie się w aktualnym pokoju");
    Console.WriteLine("\tlewo           Ruch o pokój wcześniejszy (E)");
    Console.WriteLine("\tprawo          Ruch o pokój późniejszy (E)");
    Console.WriteLine("\tkarta          Próba zabrania karty (E)");
    Console.WriteLine("\tbezpiecznik    Próba zabrania bezpiecznika (E)");
    Console.WriteLine("\tnapraw         Próba naprawy zasilania (E)");
    Console.WriteLine("\twyjdz          Próba otwarcia drzwi (E)");
    Console.WriteLine("\tstart          Rozpoczęcie nowej rozgrywki");
    Console.WriteLine("\tkoniec         Zamknięcie programu\n");

    Console.WriteLine("\tTylko udany ruch i akcja które są oznaczone jako (E)\n\tspowoduje zabranie energi\n");
}

void Mapa()
{
    Console.WriteLine("");
    for (int numer = 1; numer <= 4; numer++) 
    {
        if (numer == pokoj)
            Console.WriteLine(numer + ". " + NazwaPokoju(numer) + " <-- jestes tutaj");
        else
            Console.WriteLine(numer + ". " + NazwaPokoju(numer));
    }
    Console.WriteLine("");
}

void Rozejrzyj()
{
    Console.WriteLine("\nJestes w: " + NazwaPokoju(pokoj));

    if (pokoj == 1)
        Console.WriteLine("\tKarta jest na biurku tylko przed zabraniem");
    else if (pokoj == 2)
        Console.WriteLine("\tBezpiecznik jest na półce tylko, gdy nie ma go w kieszeni i nie jest zamontowany");
    else if (pokoj == 3)
        Console.WriteLine("\tOpis zależy od zasilania");
    else if (pokoj == 4)
        Console.WriteLine("\tPrzypomnij kartę i prąd");
    else
        Console.WriteLine("\tnie wiem");
    Console.WriteLine("");
}

// SEKCJA B: RUCH. Wlasciciel: osoba B.
void Idz(string kierunek)
{
    // TODO B1: odrzuc ruch po zakonczeniu gry (return).
    // TODO B2: policz nastepnyPokoj, nie zmieniaj jeszcze wspolnego pokoj.
    // TODO B3: odrzuc nieznany kierunek i ruch poza pokoje 1..4.
    // TODO B4: zatwierdz pokoj, wywolaj Rozejrzyj i raz ZakonczTure.
    Console.WriteLine("TODO B: ruch " + kierunek);
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
