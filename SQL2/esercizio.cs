using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class EsercizioStudenti 
{
    static void Main(string[] args)
    {
        string path = "studenti.txt";
        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\n1 Inserisci");
            Console.WriteLine("2 Visualizza");
            Console.WriteLine("3 Aggiorna");
            Console.WriteLine("4 Elimina");
            Console.WriteLine("5 Conta righe");
            Console.WriteLine("0 Esci");

            if (!int.TryParse(Console.ReadLine(), out int scelta)) continue;

            List<string> righe = new List<string>();
            if (File.Exists(path))
                righe.AddRange(File.ReadAllLines(path));

            switch (scelta)
            {
                case 1:
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Cognome: ");
                    string cognome = Console.ReadLine();
                    Console.Write("Eta: ");
                    string eta = Console.ReadLine();

                    righe.Add($"{nome},{cognome},{eta}");
                    File.WriteAllLines(path, righe);
                    Console.WriteLine("Studente inserito");
                    break;

                case 2:
                    if (righe.Count == 0) Console.WriteLine("File vuoto");
                    for (int i = 0; i < righe.Count; i++)
                        Console.WriteLine($"{i}] {righe[i]}");
                    break;

                case 3:
                    Console.Write("Indice riga da modificare: ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < righe.Count)
                    {
                        Console.Write("Nuova riga (nome,cognome,eta): ");
                        righe[index] = Console.ReadLine();
                        File.WriteAllLines(path, righe);
                        Console.WriteLine("Aggiornato");
                    }
                    break;

                case 4:
                    Console.Write("Indice riga da eliminare: ");
                    if (int.TryParse(Console.ReadLine(), out int delete) && delete >= 0 && delete < righe.Count)
                    {
                        righe.RemoveAt(delete);
                        File.WriteAllLines(path, righe);
                        Console.WriteLine("Eliminato");
                    }
                    break;

                case 5:
                    Console.WriteLine($"Numero totale di righe: {righe.Count}");
                    break;

                case 0:
                    continua = false;
                    break;
            }
        }
    }
}