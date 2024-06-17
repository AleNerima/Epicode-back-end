// See https://aka.ms/new-console-template for more information


using System;

namespace DemoConsoleApp
{
    // Classe Atleta
    public class Atleta
    {
        public string Nome { get; set; }
        public string Sport { get; set; }
        public int Eta { get; set; }

        public Atleta(string nome, string sport, int eta)
        {
            Nome = nome;
            Sport = sport;
            Eta = eta;
        }

        public void StampaDettagli()
        {
            Console.WriteLine($"Atleta: {Nome}, Sport: {Sport}, Età: {Eta}");
        }
    }

    // Classe Dipendendente
    public class Dipendendente
    {
        public string Nome { get; set; }
        public string Posizione { get; set; }
        public double Stipendio { get; set; }

        public Dipendendente(string nome, string posizione, double stipendio)
        {
            Nome = nome;
            Posizione = posizione;
            Stipendio = stipendio;
        }

        public void StampaDettagli()
        {
            Console.WriteLine($"Dipendente: {Nome}, Posizione: {Posizione}, Stipendio: {Stipendio} EUR");
        }
    }

    // Classe Animale
    public class Animale
    {
        public string Nome { get; set; }
        public string Specie { get; set; }
        public int Eta { get; set; }

        public Animale(string nome, string specie, int eta)
        {
            Nome = nome;
            Specie = specie;
            Eta = eta;
        }

        public void StampaDettagli()
        {
            Console.WriteLine($"Animale: {Nome}, Specie: {Specie}, Età: {Eta}");
        }
    }

    // Classe Veicolo
    public class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Anno { get; set; }

        public Veicolo(string marca, string modello, int anno)
        {
            Marca = marca;
            Modello = modello;
            Anno = anno;
        }

        public void StampaDettagli()
        {
            Console.WriteLine($"Veicolo: Marca: {Marca}, Modello: {Modello}, Anno: {Anno}");
        }
    }

    // Classe Program con il metodo Main
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Creare istanze di Atleta
            Atleta atleta1 = new Atleta("Giovanni", "Calcio", 25);
            Atleta atleta2 = new Atleta("Luca", "Tennis", 30);

            // Creare istanze di Dipendente
            Dipendendente dipendente1 = new Dipendendente("Maria", "Manager", 45000);
            Dipendendente dipendente2 = new Dipendendente("Paolo", "Sviluppatore", 35000);

            // Creare istanze di Animale
            Animale animale1 = new Animale("Leo", "Gatto", 3);
            Animale animale2 = new Animale("Max", "Cane", 5);

            // Creare istanze di Veicolo
            Veicolo veicolo1 = new Veicolo("Toyota", "Corolla", 2018);
            Veicolo veicolo2 = new Veicolo("Fiat", "500", 2020);

            // Stampare i dettagli
            atleta1.StampaDettagli();
            atleta2.StampaDettagli();

            dipendente1.StampaDettagli();
            dipendente2.StampaDettagli();

            animale1.StampaDettagli();
            animale2.StampaDettagli();

            veicolo1.StampaDettagli();
            veicolo2.StampaDettagli();
        }
    }
}
