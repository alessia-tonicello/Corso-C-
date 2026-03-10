using System;

namespace CicloWhile
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // --- Esempio 1: Contatore semplice ---
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            

            // --- Esercizio 1: Multipli di 3 da 1 a 20 ---
            int num = 1;
            while (num <= 20)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine("Multiplo di 3: " + num);
                }
                
                num++;
            }
            
            //Esercizio 2: chiedere all'utente numeri finché non inserisce 0. Stampare ogni numero inserito
            int numero;
            Console.WriteLine("Inserisci un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            
            while (numero != 0)
                {
                Console.WriteLine("Numero non valido: " + numero);
                
                Console.WriteLine("Inserisci un altro numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("Hai inserito 0, programma terminato!");
            
            
            //Esercizio 3: chiedere numeri all'utente finché inserisce valori positivi.
            //Quando inserisce un numero negativo, il programma termina.
            int number;
            Console.WriteLine("Inserisci un numero");
            number = Convert.ToInt32(Console.ReadLine());
            
            while (number > 0)
            {
                Console.WriteLine("Inserisci un numero");
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Hai inserito un numero negativo, programma terminato!");
            
            
            //Esercizio 4: chiedere 5 numeri all'utente e calcolare la somma totale usando while
            int somma2 = 0;
            int contatore = 1;
            int numeroInserito;
            
            while (contatore <= 5)
            {
                Console.WriteLine("Inserisci un numero");
                numeroInserito = Convert.ToInt32(Console.ReadLine());
                
                somma2 += numeroInserito;
                contatore++;
            }
            Console.WriteLine("La somma totale è: " + somma2);
        }
    }
}