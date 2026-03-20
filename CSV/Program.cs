using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string path = "studenti.csv";

        List<string> righe = new List<string>(File.ReadAllLines(path));

        Console.WriteLine("1 Inserisci (Nome,Cognome,Eta)");
        Console.WriteLine("2 Visualizza Nome e Cognome");
        Console.WriteLine("3 Filtra Studenti (Eta > 18)");
        Console.WriteLine("4 Ordina per Eta");
        Console.Write("Scelta: ");

        int scelta = int.Parse(Console.ReadLine());

        switch (scelta)
        {
            case 1:

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Cognome: ");
                string cognome = Console.ReadLine();

                righe.Add($"{nome},{cognome}");

                File.WriteAllLines(path, righe);

                break;

            case 2:

                foreach (string r in righe)
                {
                    string[] c = r.Split(',');
                    if (c.Length >= 2) Console.WriteLine($"{c[0]} {c[1]}");
                }

                break;

            case 3:
                foreach (string r in righe)
                {
                    string[] c = r.Split(',');
                    if (c.Length >= 3 && int.TryParse(c[2], out int anni) && anni > 18)
                    {
                        Console.WriteLine($"{c[0]} {c[1]} - Età: {anni}");
                    }
                }
                break;

            case 4:
                var ordinate = righe
                    .Select(r => r.Split(','))
                    .Where(c => c.Length >= 3)
                    .OrderBy(c => int.Parse(c[2]))
                    .ToList();

                foreach (var c in ordinate)
                {
                    Console.WriteLine($"{c[2]} anni: {c[0]} {c[1]}");
                }
                break;
            
        }
    }
}