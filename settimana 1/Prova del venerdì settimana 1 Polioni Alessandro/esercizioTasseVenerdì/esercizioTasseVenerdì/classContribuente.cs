using System;

public class Contribuente
{
    // Enum per il sesso
    public enum Sesso
    {
        M, 
        F  // Femmina
    }

    // Proprietà per memorizzare le informazioni del contribuente
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public DateTime DataNascita { get; set; }
    public string CodiceFiscale { get; set; }
    public Sesso Genere { get; set; } // Utilizzo dell'enum Sesso 
    public string ComuneResidenza { get; set; }
    public double RedditoAnnuale { get; set; }

    
    // Costruttore per inizializzare un nuovo contribuente con tutte le proprietà
    // Non ritengo necessario l'overloading, dato che tutte le informazioni sono necessarie per inizializzare un nuovo contribuente
    public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, Sesso genere, string comuneResidenza, double redditoAnnuale)
    {
        Nome = nome;
        Cognome = cognome;
        DataNascita = dataNascita;
        CodiceFiscale = codiceFiscale;
        Genere = genere; // Inizializzo con il valore passato come argomento
        ComuneResidenza = comuneResidenza;
        RedditoAnnuale = redditoAnnuale;
    }

    // Metodo per calcolare l'imposta basata sul reddito annuale del contribuente
    public double CalcolaImposta()
    {
        double imposta = 0; // Variabile per memorizzare l'importo dell'imposta

        // Calcolo dell'imposta basato sugli scaglioni di reddito
        // Gestisco i vari casi attraverso un if/else if/else; potevo usare lo switch, ma ritengo l'if più facile da leggere
        if (RedditoAnnuale <= 15000)
        {
            imposta = RedditoAnnuale * 0.23; // Aliquota del 23% per redditi fino a 15000
        }
        else if (RedditoAnnuale <= 28000)
        {
            imposta = 3450 + (RedditoAnnuale - 15000) * 0.27; // Aliquota del 27% per la parte eccedente i 15000 fino a 28000
        }
        else if (RedditoAnnuale <= 55000)
        {
            imposta = 6960 + (RedditoAnnuale - 28000) * 0.38; // Aliquota del 38% per la parte eccedente i 28000 fino a 55000
        }
        else if (RedditoAnnuale <= 75000)
        {
            imposta = 17220 + (RedditoAnnuale - 55000) * 0.41; // Aliquota del 41% per la parte eccedente i 55000 fino a 75000
        }
        else
        {
            imposta = 25420 + (RedditoAnnuale - 75000) * 0.43; // Aliquota del 43% per la parte eccedente i 75000
        }

        // Restituisce l'importo dell'imposta calcolata
        return imposta;
    }
}
