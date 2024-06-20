// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    static class Utente
    {
        private static string username;
        private static DateTime loginTime;
        private static List<DateTime> accessHistory = new List<DateTime>();
        private static bool isLoggedIn = false;

        public static bool Login(string user, string password, string confirmPassword)
        {
            if (!string.IsNullOrEmpty(user) && password == confirmPassword)
            {
                username = user;
                loginTime = DateTime.Now;
                accessHistory.Add(loginTime);
                isLoggedIn = true;
                return true;
            }
            return false;
        }

        public static bool Logout()
        {
            if (isLoggedIn)
            {
                isLoggedIn = false;
                username = null;
                return true;
            }
            return false;
        }

        public static DateTime? VerificaLogin()
        {
            if (isLoggedIn)
            {
                return loginTime;
            }
            return null;
        }

        public static List<DateTime> ListaAccessi()
        {
            return new List<DateTime>(accessHistory);
        }

        public static bool IsLoggedIn()
        {
            return isLoggedIn;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1.: Login");
                Console.WriteLine("2.: Logout");
                Console.WriteLine("3.: Verifica ora e data di login");
                Console.WriteLine("4.: Lista degli accessi");
                Console.WriteLine("5.: Esci");
                Console.WriteLine("========================================");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        EffettuaLogin();
                        break;
                    case "2":
                        EffettuaLogout();
                        break;
                    case "3":
                        VerificaLogin();
                        break;
                    case "4":
                        VisualizzaListaAccessi();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Scelta non valida, riprova.");
                        break;
                }
            }
        }

        static void EffettuaLogin()
        {
            Console.Write("Inserisci username: ");
            string username = Console.ReadLine();
            Console.Write("Inserisci password: ");
            string password = Console.ReadLine();
            Console.Write("Conferma password: ");
            string confirmPassword = Console.ReadLine();

            if (Utente.Login(username, password, confirmPassword))
            {
                Console.WriteLine("Login effettuato con successo!");
            }
            else
            {
                Console.WriteLine("Errore nel login. Username o password non validi.");
            }
            Console.ReadLine();
        }

        static void EffettuaLogout()
        {
            if (Utente.Logout())
            {
                Console.WriteLine("Logout effettuato con successo!");
            }
            else
            {
                Console.WriteLine("Errore: Nessun utente è attualmente loggato.");
            }
            Console.ReadLine();
        }

        static void VerificaLogin()
        {
            DateTime? loginTime = Utente.VerificaLogin();
            if (loginTime.HasValue)
            {
                Console.WriteLine($"Ultimo login effettuato il: {loginTime.Value}");
            }
            else
            {
                Console.WriteLine("Errore: Nessun utente è attualmente loggato.");
            }
            Console.ReadLine();
        }

        static void VisualizzaListaAccessi()
        {
            List<DateTime> accessi = Utente.ListaAccessi();
            if (accessi.Count > 0)
            {
                Console.WriteLine("Lista degli accessi:");
                foreach (DateTime accesso in accessi)
                {
                    Console.WriteLine(accesso);
                }
            }
            else
            {
                Console.WriteLine("Nessun accesso registrato.");
            }
            Console.ReadLine();
        }
    }
}
