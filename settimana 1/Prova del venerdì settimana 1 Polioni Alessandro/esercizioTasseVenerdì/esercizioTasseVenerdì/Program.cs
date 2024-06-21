// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Si richiede all'utente di inserire i suoi dati che vengono memorizzati nelle variabili
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
        char sesso;
        while (!char.TryParse(Console.ReadLine(), out sesso) || (sesso != 'M' && sesso != 'F'))
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

        // Crea un nuovo oggetto Contribuente con i dati inseriti dall'utente
        // Utilizzo l'operatore null-coalescing (??) per garantire che le stringhe non siano null
        Contribuente contribuente = new Contribuente(nome ?? string.Empty, cognome ?? string.Empty, dataNascita, codiceFiscale ?? string.Empty, sesso, comuneResidenza ?? string.Empty, redditoAnnuale);

        // Calcola l'imposta da pagare utilizzando il metodo CalcolaImposta
        double imposta = contribuente.CalcolaImposta();

        // Visualizza il risultato in console
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



