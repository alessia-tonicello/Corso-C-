using System;
using System.Collections.Generic;

namespace Array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            List<int> numeri = new List<int>();
            numeri.Add(1);
            numeri.Add(2);
            numeri.Add(3);
            
            for (int i = 0; i < numeri.Count; i++)
            {
                Console.WriteLine(numeri[i]);
            }

            foreach (int i in numeri)
            {
                Console.WriteLine(i);
            }
            
            numeri.Remove(1);

            if (numeri.Contains(1))
            {
                Console.WriteLine("Il numero esiste");
            }
            
            List<int> numeri = new List<int>();
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Inserisci un numero ");
                int numero = int.Parse( Console.ReadLine());
                numeri.Add(numero);
            }
            Console.WriteLine("NUMERI INSERITI: ");
            
            foreach (int num in numeri)
            {
                Console.WriteLine(num);
            }*/
            
            
            //Esercizio 1: crea una List<Persona>. Implementa un menu per:
            //- aggiungere una persona
            //-visualizzare tutti
            //-cercare per nome
            //- rimuovere un contatto
            List<string> persona = new List<string>();
            
            int scelta;
            
            do
            {
                Console.WriteLine("1. Aggiungi persona");
                Console.WriteLine("2. Visualizza tutti");
                Console.WriteLine("3. Cerca per nome");
                Console.WriteLine("4. Rimuovere un contatto");
                Console.WriteLine("5. Esci");
                Console.Write("Scegli un'opzione: ");

                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserisci nome: ");
                        string nuovoNome = Console.ReadLine();
                        persona.Add(nuovoNome);
                        Console.WriteLine("Persona aggiunta");
                        break;
                    
                    case 2:
                        Console.WriteLine("Elenco Contatti:");
                        if (persona.Count == 0) Console.WriteLine("La lista è vuota.");
                        foreach (string p in persona)
                        {
                            Console.WriteLine("- " + p);
                        }
                        break;
                    
                    case 3:
                        Console.WriteLine("Inserisci il nome da cercare: ");
                        string cerca = Console.ReadLine();
                        if (persona.Contains(cerca)) 
                            Console.WriteLine("Trovato!");
                        else 
                            Console.WriteLine("Contatto non presente.");
                        break;
                    
                    case 4:
                        Console.Write("Inserisci il nome da rimuovere: ");
                        string daRimuovere = Console.ReadLine();

                        if (persona.Contains(daRimuovere))
                        {
                            persona.Remove(daRimuovere);
                            Console.WriteLine("Contatto Rimosso");
                        }
                        else
                        {
                            Console.WriteLine("Nome non trovato.");
                        }
                       
                        break;
                    
                    case 5:
                        Console.WriteLine("Esci");
                        break;
                }

            } while (scelta != 5); 
            Console.WriteLine("Salvataggio in corso... Arrivederci!");
        }
    }
}
