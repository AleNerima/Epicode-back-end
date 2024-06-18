// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApplication
{
    class Persona
    {
        // Proprietà automatiche
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        // Costruttore
        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        // Metodi
        public string GetNome()
        {
            return Nome;
        }

        public string GetCognome()
        {
            return Cognome;
        }

        public int GetEta()
        {
            return Eta;
        }

        public string GetDettagli()
        {
            return "Nome: {Nome}, Cognome: {Cognome}, Età: {Eta}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creazione di un oggetto Persona utilizzando il costruttore
            Persona persona = new Persona("Mario", "Rossi", 30);

            // Utilizzo dei metodi per ottenere le proprietà
            Console.WriteLine("Nome: " + persona.GetNome());
            Console.WriteLine("Cognome: " + persona.GetCognome());
            Console.WriteLine("Età: " + persona.GetEta());
            Console.WriteLine("Dettagli: " + persona.GetDettagli());

            // Aspetta input per chiudere
            Console.ReadLine();
        }
    }
}
