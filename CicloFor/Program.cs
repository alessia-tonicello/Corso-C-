using System;

namespace CicloFor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Numero " + i);
            }
        } */

            //Esercizio 1: stampare i numeri da 10 a 1 in ordine decrescente
            /*for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine("Numero " + i);
            }
        }*/

            //Esercizio 2: stampare tutti i numeri pari da 1 a 20
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Numero pari " + i);
                }
            }
            
            //Esercizio 3: stampare la tabellina del 5
            for (int t = 5; t <= 50; t++)
            {
                if (t % 5 == 0)
                {
                    Console.WriteLine("Tabellina del 5 " + t);
                }
            }
            
            //Esercizio 4: chiedere all'utente un numero N e calcolare la somma dei numeri da 1 a N
            int numero;
            int somma = 0;
            Console.WriteLine("Inserisci un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                somma += i;
            }
            Console.WriteLine("La somma totale da 1 a " + numero + " è: " + somma);
            
        }

    }
}