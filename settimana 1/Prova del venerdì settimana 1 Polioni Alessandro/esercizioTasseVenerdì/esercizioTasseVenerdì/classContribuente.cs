using System;

public class Contribuente
{
    // Proprietà per memorizzare le informazioni del contribuente
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public DateTime DataNascita { get; set; }
    public string CodiceFiscale { get; set; }
    public char Sesso { get; set; }
    public string ComuneResidenza { get; set; }
    public double RedditoAnnuale { get; set; }

    // Costruttore per inizializzare un nuovo contribuente con tutte le proprietà
    // Non ritengo necessario l'overloading, dato che tutte le informazioni sono necessarie per inizializzare un nuovo contribuente
    public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, char sesso, string comuneResidenza, double redditoAnnuale)
    {
        Nome = nome; // Inizializzo la proprietà Nome con il valore passato come argomento
        Cognome = cognome; // Inizializzo la proprietà Cognome con il valore passato come argomento
        DataNascita = dataNascita; // Inizializzo la proprietà DataNascita con il valore passato come argomento
        CodiceFiscale = codiceFiscale; // Inizializzo la proprietà CodiceFiscale con il valore passato come argomento
        Sesso = sesso; // Inizializzo la proprietà Sesso con il valore passato come argomento
        ComuneResidenza = comuneResidenza; // Inizializzo la proprietà ComuneResidenza con il valore passato come argomento
        RedditoAnnuale = redditoAnnuale; // Inizializzo la proprietà RedditoAnnuale con il valore passato come argomento
    }

    // Metodo per calcolare l'imposta basata sul reddito annuale del contribuente
    // Gestisco i vari casi attraverso un if/else if/else; potevo usare lo switch, ma ritengo l'if più facile da leggere
    public double CalcolaImposta()
    {
        double imposta = 0; // Variabile per memorizzare l'importo dell'imposta

        // Calcolo dell'imposta basato sugli scaglioni di reddito
        if (RedditoAnnuale <= 15000)
        {
            // Aliquota del 23% per redditi fino a 15000
            imposta = RedditoAnnuale * 0.23;
        }
        else if (RedditoAnnuale <= 28000)
        {
            // Aliquota del 27% per la parte eccedente i 15000 fino a 28000
            // Imposta base di 3450 per i primi 15000 più il 27% della parte eccedente
            imposta = 3450 + (RedditoAnnuale - 15000) * 0.27;
        }
        else if (RedditoAnnuale <= 55000)
        {
            // Aliquota del 38% per la parte eccedente i 28000 fino a 55000
            // Imposta base di 6960 per i primi 28000 più il 38% della parte eccedente
            imposta = 6960 + (RedditoAnnuale - 28000) * 0.38;
        }
        else if (RedditoAnnuale <= 75000)
        {
            // Aliquota del 41% per la parte eccedente i 55000 fino a 75000
            // Imposta base di 17220 per i primi 55000 più il 41% della parte eccedente
            imposta = 17220 + (RedditoAnnuale - 55000) * 0.41;
        }
        else
        {
            // Aliquota del 43% per la parte eccedente i 75000
            // Imposta base di 25420 per i primi 75000 più il 43% della parte eccedente
            imposta = 25420 + (RedditoAnnuale - 75000) * 0.43;
        }

        // Restituisce l'importo dell'imposta calcolata
        return imposta;
    }
}
