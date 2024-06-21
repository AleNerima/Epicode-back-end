// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    // Definizione dell'enum per il sesso
    enum Sesso
    {
        M,
        F
    }

    static void Main()
    {
        Console.WriteLine("Inserisci il nome:");
        string? nome = Console.ReadLine();

        Console.WriteLine("Inserisci il cognome:");
        string? cognome = Console.ReadLine();

        Console.WriteLine("Inserisci la data di nascita (dd/mm/yyyy):");
        DateTime dataNascita;
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascita))
        {
            Console.WriteLine("Formato data non valido. Riprova (dd/mm/yyyy):");
        }

        Console.WriteLine("Inserisci il codice fiscale:");
        string? codiceFiscale = Console.ReadLine();

        Console.WriteLine("Inserisci il sesso (M/F):");
        Sesso sesso;
        while (!Enum.TryParse(Console.ReadLine().ToUpper(), out sesso) || (sesso != Sesso.M && sesso != Sesso.F))
        {
            Console.WriteLine("Inserisci un valore valido per il sesso (M/F):");
        }

        Console.WriteLine("Inserisci il comune di residenza:");
        string? comuneResidenza = Console.ReadLine();

        Console.WriteLine("Inserisci il reddito annuale:");
        double redditoAnnuale;
        while (!double.TryParse(Console.ReadLine(), out redditoAnnuale) || redditoAnnuale < 0)
        {
            Console.WriteLine("Inserisci un valore valido per il reddito annuale:");
        }

        // Creazione dell'oggetto Contribuente con i dati inseriti dall'utente
        Contribuente contribuente = new Contribuente(nome ?? string.Empty, cognome ?? string.Empty, dataNascita, codiceFiscale ?? string.Empty, sesso, comuneResidenza ?? string.Empty, redditoAnnuale);

        // Calcolo dell'imposta utilizzando il metodo CalcolaImposta
        double imposta = contribuente.CalcolaImposta();

        // Visualizzazione dei risultati in console
        Console.WriteLine("==================================================");
        Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
        Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
        Console.WriteLine($"nato il {contribuente.DataNascita:dd/MM/yyyy} ({contribuente.Sesso}),");
        Console.WriteLine($"residente in {contribuente.ComuneResidenza},");
        Console.WriteLine($"codice fiscale: {contribuente.CodiceFiscale}");
        Console.WriteLine($"Reddito dichiarato: {contribuente.RedditoAnnuale:N2}");
        Console.WriteLine($"IMPOSTA DA VERSARE: {imposta:N2}");
    }
}

