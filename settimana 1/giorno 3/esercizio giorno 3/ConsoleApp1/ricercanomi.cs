using System;

public class RicercaNome
{
    public void CercaNome()
    {
        string[] listanomi = { "francesco", "luigi", "mario", "giulia", "lorenzo" };
        string nome;
        int i;
        bool verifica = false;

        Console.WriteLine("Inserire il nome da ricercare");
        nome = Console.ReadLine();

        for (i = 0; i < listanomi.Length; i++)
        {
            if (listanomi[i] == nome)
            {
                Console.WriteLine("Il nome è nella lista");
                verifica = true;
            }
        }
        if (verifica == false)
        {
            Console.WriteLine("Il nome non è nella lista");
        }

        Console.ReadLine();
    }
}
