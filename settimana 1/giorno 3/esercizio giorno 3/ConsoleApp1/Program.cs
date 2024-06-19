// See https://aka.ms/new-console-template for more information

using System;

namespace EserciziCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scegli l'esercizio da eseguire:");
            Console.WriteLine("1. Conto Corrente");
            Console.WriteLine("2. Ricerca Nome");
            Console.WriteLine("3. Somma e Media Array");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    ContoCorrente conto = new ContoCorrente();
                    conto.MenuInizialeStart();
                    break;
                case 2:
                    RicercaNome ricerca = new RicercaNome();
                    ricerca.CercaNome();
                    break;
                case 3:
                    SommaMediaArray sommaMedia = new SommaMediaArray();
                    sommaMedia.CalcolaSommaMedia();
                    break;
                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }
}
