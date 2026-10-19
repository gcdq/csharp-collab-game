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
    Console.WriteLine("\nPomoc:");
    Console.WriteLine("\tpomoc          Wyświetla polecenia i zasady rozgrywki");
    Console.WriteLine("\tstatus         Wyświetla dane rozgrywki");
    Console.WriteLine("\tmapa           Wyświetla pokoje i znacznik pozycji");
    Console.WriteLine("\topis           Rozejrzenie się w aktualnym pokoju");
    Console.WriteLine("\tlewo           Cofnięcie się do poprzedniego pokoju (E)");
    Console.WriteLine("\tprawo          Pójście do następnego pokoju (E)");
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

    if (pokoj == 1 && !karta)
        Console.WriteLine("\tKarta jest na biurku");
    else if (pokoj == 1)
        Console.WriteLine("\tKarta została już podniesiona");
    else if (pokoj == 2 && !bezpiecznik && !zasilanie)
        Console.WriteLine("\tBezpiecznik jest na półce");
    else if (pokoj == 2)
        Console.WriteLine("\tBezpiecznik został już podniesiony");
    else if (pokoj == 3 && !zasilanie)
        Console.WriteLine("\tZasilanie nie zostało podłączone");
    else if (pokoj == 3)
        Console.WriteLine("\tZasilanie zostało podłączone");
    else if (pokoj == 4 && zasilanie && karta)
        Console.WriteLine("\tMasz kartę i zasilanie");
    else if (pokoj == 4 && karta)
        Console.WriteLine("\tMasz kartę ale nie masz zasilania");
    else if (pokoj == 4 && zasilanie)
        Console.WriteLine("\tNie masz karty ale masz zasilanie");
    else if (pokoj == 4)
        Console.WriteLine("\tNie masz ani karty, ani zasilania");
    else
        Console.WriteLine("\tnie wiem");
    Console.WriteLine("");
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
    if(koniec)
    {
        Console.WriteLine("Gra została zakończona.");
        return; 
    }

    if(co == "karta")
    {
        if(pokoj != 1 || karta)
        {
            Console.WriteLine("Tutaj nie ma karty do zebrania.");
            return;
        }
        karta = true;
        Console.WriteLine("Zabierasz karte.");
        ZakonczTure();
        return;
    }
    if(co == "bezpiecznik")
    {
        if(pokoj != 2 || bezpiecznik || zasilanie)
        {
            Console.WriteLine("Tutaj nie ma bezpiecznika do zebrania.");
            return;
        }
        bezpiecznik = true;
        Console.WriteLine("Zabierasz bezpiecznik.");
        ZakonczTure();
        return;
    }
    if(co == "napraw")
    {
        if(pokoj != 3)
        {
            Console.WriteLine("Nie możesz naprawić zasilania w tym pokoju.");
            return;
        }else if(zasilanie)
        {
            Console.WriteLine("Zasilanie jest włączone.");
            return;
        }else if (!bezpiecznik)
        {
            Console.WriteLine("Nie masz bezpiecznika.");
            return;
        }
        bezpiecznik = false;
        zasilanie = true;
        Console.WriteLine("Naprawiasz zasilanie!");
        ZakonczTure();
        return;
    }
    if(co == "wyjdz")
    {
        if(pokoj != 4)
        {
            Console.WriteLine("Nie możesz wyjść z tego pokoju.");
            return;
        }else if (!karta)
        {
            Console.WriteLine("Nie masz karty, nie możesz wyjść.");
            return;
        }else if (!zasilanie)
        {
            Console.WriteLine("Zasilanie jest wyłączone, nie możesz wyjść.");            
            return;
        }
        wygrana = true;
        koniec = true;
        ZakonczTure();
    }
}
