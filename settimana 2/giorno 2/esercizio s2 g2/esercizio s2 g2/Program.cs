// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CVConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creazione e popolamento delle informazioni personali
            InformazioniPersonali info = new InformazioniPersonali
            {
                Nome = "Mario",
                Cognome = "Rossi",
                Telefono = "1234567890",
                Email = "mario.rossi@example.com"
            };

            // Creazione e popolamento degli studi effettuati
            Studi studi = new Studi
            {
                Qualifica = "Laurea in Informatica",
                Istituto = "Università degli Studi",
                Tipo = "Laurea",
                Dal = new DateTime(2010, 9, 1),
                Al = new DateTime(2013, 7, 15)
            };

            // Creazione e popolamento delle esperienze lavorative
            Esperienza esperienza = new Esperienza
            {
                Azienda = "Tech S.p.A.",
                JobTitle = "Software Developer",
                Dal = new DateTime(2015, 1, 1),
                Al = new DateTime(2020, 12, 31),
                Descrizione = "Sviluppo di applicazioni web",
                Compiti = "Analisi, progettazione, sviluppo e manutenzione di applicazioni"
            };

            List<Esperienza> esperienze = new List<Esperienza> { esperienza };

            Impieghi impieghi = new Impieghi
            {
                Esperienze = esperienze
            };

            // Creazione del CV e popolamento delle proprietà
            CV cv = new CV
            {
                InformazioniPersonali = info,
                StudiEffettuati = studi,
                Impieghi = impieghi
            };

            // Stampa del CV su schermo
            StampaDettagliCVSuSchermo(cv);
        }

        public static void StampaDettagliCVSuSchermo(CV cv)
        {
            Console.WriteLine("================Informazioni Personali==================");
            Console.WriteLine($"Nome: {cv.InformazioniPersonali.Nome}");
            Console.WriteLine($"Cognome: {cv.InformazioniPersonali.Cognome}");
            Console.WriteLine($"Telefono: {cv.InformazioniPersonali.Telefono}");
            Console.WriteLine($"Email: {cv.InformazioniPersonali.Email}");
            Console.WriteLine("==================================");

            Console.WriteLine("=================Studi Effettuati=================");
            Console.WriteLine($"Qualifica: {cv.StudiEffettuati.Qualifica}");
            Console.WriteLine($"Istituto: {cv.StudiEffettuati.Istituto}");
            Console.WriteLine($"Tipo: {cv.StudiEffettuati.Tipo}");
            Console.WriteLine($"Dal: {cv.StudiEffettuati.Dal.ToShortDateString()} Al: {cv.StudiEffettuati.Al.ToShortDateString()}");
            Console.WriteLine("===================================================");

            Console.WriteLine("====================Impieghi========================");
            foreach (var exp in cv.Impieghi.Esperienze)
            {
                Console.WriteLine($"Azienda: {exp.Azienda}");
                Console.WriteLine($"Job Title: {exp.JobTitle}");
                Console.WriteLine($"Dal: {exp.Dal.ToShortDateString()} Al: {exp.Al.ToShortDateString()}");
                Console.WriteLine($"Descrizione: {exp.Descrizione}");
                Console.WriteLine($"Compiti: {exp.Compiti}");
                Console.WriteLine("===============================================");
            }
        }
    }
}
