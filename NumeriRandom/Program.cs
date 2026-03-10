using System;

namespace NumeriRandom
{
    internal class Program
    {
        public static void Main(string[] args)
        {   /*
            Random random = new Random(); //Random = sintassi, random = per richiamarlo
            //int numero = random.Next(1, 10);
            //Console.WriteLine(numero);

            for (int i = 0; i < 10; i++)
            {
                int numero1 = random.Next(1, 11);  // da 1 a 91 per il gioco della tombola
                Console.WriteLine(numero1);
            }*/
            
            
            //Esercizio 1: simulazione di un dado
            //Creare un programma che simuli il lancio di un dado. Il programma deve:
            //- generare un numero casuale tra 1 e 6 
            //- stampare il risultato del lancio
            //BONUS: possibilità do lanciare anche più dadi con più facce
            
            Random random = new Random(); 
            int numero = random.Next(1, 7); 
            Console.WriteLine("Lanciando il dado è uscito il numero " + numero);
            
            Console.WriteLine("Quanti dadi vuoi lanciare?");
            int quantitaDadi = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Quante facce hanno i dadi? (es. 6, 12, 20)");
            int numeroFacce = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nLancio di {quantitaDadi} dadi a {numeroFacce} facce:");

            int sommaTotale = 0;

            for (int i = 1; i <= quantitaDadi; i++)
            {
                int risultato = random.Next(1, numeroFacce + 1);
    
                Console.WriteLine($"Dado {i}: {risultato}");
                sommaTotale += risultato;
            }
            
            Console.WriteLine("La somma totale dei lanci è: " + sommaTotale);
            
            //Esercizio 2 - indovina il numero (while true finché non indovini il numero)
            //Il computer genera un numero casuale tra 1 e 50. L'utente deve indovinare il numero. Il prog deve dire:
            //- troppo alto 
            //- troppo basso
            //- hai indovinato
            
            
            Random random2 = new Random(); 
            int numero2 = random2.Next(1, 51);
            int tentativo; 
            
            Console.WriteLine("Prova ad indovinare");

            while (true)
            {
                Console.Write("Inserisci il tuo numero: ");
                tentativo = Convert.ToInt32(Console.ReadLine());

                if (tentativo < numero2)
                {
                    Console.Write("Troppo basso!");
                }
                else if (tentativo > numero2)
                {
                    Console.Write("Troppo alto!");
                }
                else
                {
                    Console.Write("Bravo, hai indovinato!");
                    break;
                }
            }
            Console.WriteLine(" Fine del gioco!");
        } 
    }
}
