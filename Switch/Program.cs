using System;

namespace Switch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            int numero;
            Console.WriteLine("Inserisci un numero da 1 a 3");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Hai scelto il numero 1");
                    break;
                case 2:
                    Console.WriteLine("Hai scelto il numero 2");
                    break;
                case 3:
                    Console.WriteLine("Hai scelto il numero 3");
                    break;
                 */
            
            // --- Esercizio 1: attraverso switch chiedere all'utente di scrivere un numero e
            // restituire l'analogo giorno della settiamana, es: 1-Lunedì ---
            
            /*
            int number;
            Console.WriteLine("Inserisci un numero da 1 a 7");
            number = Convert.ToInt32(Console.ReadLine());
            
            switch (number)
            {
                case 1: 
                    Console.WriteLine("Lunedì");
                    break;
                case 2:
                    Console.WriteLine("Martedì");
                    break;
                case 3:
                    Console.WriteLine("Mercoledì");
                    break;
                case 4:
                    Console.WriteLine("Giovedì");
                    break;
                case 5:
                    Console.WriteLine("Venerdì");
                    break;
                case 6:
                    Console.WriteLine("Sabato");
                    break;
                case 7:
                    Console.WriteLine("Domenica");
                    break;
                    
            }
            
            */
            
            //Esercizio 2: creare una mini-calcolatrice partendo da due variabili numeriche.
            //Attraverso lo switch chiedere all'utene il tipo di operazione e svolgerla.
            
            Console.WriteLine("Inserisci il primo numero:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Che operazione vuoi fare? (1,2,3,4)");
            int n3 = Convert.ToInt32(Console.ReadLine());
            
            switch (n3)
            {
                case 1:
                    int somma = n1 + n2;
                    Console.WriteLine("Somma = " + somma);
                    break;
                
                case 2:
                    int sottrazione  = n1 - n2;
                    Console.WriteLine("Sottrazione = " + sottrazione);
                    break;
                
                case 3:
                    int moltiplicazione = n1 * n2;
                    Console.WriteLine("Moltiplicazione = " + moltiplicazione);
                    break;
                
                case 4:
                    int divisione = n1 / n2;
                    Console.WriteLine("Divisione = " + divisione);
                    break;
                
            }
            
        } 
    }
}