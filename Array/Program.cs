using System;

namespace Array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            int[] numeri = { 10, 20, 30};  //se abbiamo elementi già noti
            
            
            //non abbiamo elementi precisi da inserire (es: n elementi randomici)
            int[] numeri2 = new int [3];  // array vuoto che può contenere al massimo 3 elementi 
            numeri2[0] = 10;
            numeri2[1] = 20;
            numeri2[2] = 30;
            
            
            //Gli array non sono modificabili (possiamo allungarli o restringerli, ma non possiamo aggiungere tipo con append)

            for (int i = 0; i < numeri.Length; i++)
            {
                Console.WriteLine(numeri[i]);
            }
            
            foreach (int n in numeri2)
            {
                Console.WriteLine(n);
            }
            
            int[] numeri3 = new int[5];
            for (int i =  0; i < numeri3.Length; i++)
            {
                Console.WriteLine("Inserisci numero");
                numeri3[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(numeri3[i]);
            }
            
            //Gestire somme
            int[] numeri4 = { 5,10,15,20,25,30 };
            int somma = 0;
            for (int i = 0; i < numeri4.Length; i++)
            {
                somma += numeri4[i];
            }
            Console.WriteLine("La somma è: " + somma);
            
            
            
            //Esercizio 1: crea un array di 5 numeri interi. Il programma deve:
            //- chiedere all'utente di inserire i 5 numeri
            //- stampare tutti i numeri inseriti 
            
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Inserisci numero");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            

            foreach (int n in numbers)
            {
                Console.WriteLine("I numeri inseriti sono: " + n);
            }
            
            
            //Esercizio 2: crea un array di 10 numeri interi. Il programma deve:
            //- calcolare la somma di tutti gli elementi dell'array
            //- stampare il risultato
            
            int[] numeri4 = new int[10];
            int somma = 0;
            for (int i = 0; i < numeri4.Length; i++)
            {
                Console.WriteLine("Inserisci numero: ");
                numeri4[i] = int.Parse(Console.ReadLine());
                somma += numeri4[i];
            }
            Console.WriteLine("La somma è: " + somma);
             
            
            //Esercizio 3: dato un array di numeri: {5,12,3,20,7,9}. Scrivere programma che trovi il numero più grande
            int[] numeri5 = {5, 12, 3, 20, 7, 9};
            int massimo = numeri5[0];

            for (int i = 1; i < numeri5.Length; i++)
            {
                if (numeri5[i] > massimo)
                {
                    massimo = numeri5[i]; 
                }
            }
            Console.WriteLine("Il massimo è: " + massimo);
            


            
            //ARRAY CON 2 DIMENSIONI 
            int[,] matrice =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            for (int i = 0; i < 2; i++)  //con la i indichiamo le righe (in questo caso sono 2)
            {
                for (int j = 0; j < 3; j++)  //con la j indichiamo le colonne (in questo caso sono 3)
                {
                    Console.Write(matrice[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            
            //Quando hai solo le dimensioni
            int[,] matrice2 = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Inserisci numero: ");
                    matrice2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            Random random = new Random();
            int[,] matrice3 = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrice3[i, j] = random.Next(1,51);
                    Console.Write(matrice3[i, j] + " ");
                }
            }
            
            
            
            //Esercizio 1: creare una matrice 3x3. Il programma deve stampare tutti gli elementi della matrice.
            int[,] matrix = new int[3, 3];
            
            for (int i = 0; i < 3; i++)  //con la i indichiamo le righe (in questo caso sono 2)
            {
                for (int j = 0; j < 3; j++)  //con la j indichiamo le colonne (in questo caso sono 3)
                {
                    Console.Write("Inserisci numero: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                
                Console.WriteLine();
            }
            
            
            //Esercizio 2: creare una matrice 2x3. Il programma deve:
            //- chiedere all'utente di inserire tutti i valori
            //- stampare la matrice
            int[,] matrix = new int[2, 3];
            
            for (int i = 0; i < 2; i++)  //con la i indichiamo le righe (in questo caso sono 2)
            {
                for (int j = 0; j < 3; j++)  //con la j indichiamo le colonne (in questo caso sono 3)
                {
                    Console.Write("Inserisci numero: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                
                Console.WriteLine();
            }
            */
            
            //Esercizio 3: chiedere all'utente la grandezza della matrice e popolarla con un random(1-50). Stampa matrice:
            //-sommare tutti gli elementi 
            //-sommare tutti gli elementi sulla riga
            Random random = new Random();

            Console.WriteLine("Inserisci il numero di righe: ");
            int righe = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il numero di colonne: ");
            int colonne = int.Parse(Console.ReadLine());

            int[,] matrice3 = new int[righe, colonne];
            int sommaTot = 0;


            for (int i = 0; i < righe; i++) 
            {
                int sommaRiga = 0;
        
                
                for (int j = 0; j < colonne; j++) 
                {
                    matrice3[i, j] = random.Next(1, 51); 
                    
                    Console.Write(matrice3[i, j] + "\t");
        
                    sommaTot += matrice3[i, j]; 
                    sommaRiga += matrice3[i, j];
                }
                Console.WriteLine("| Somma riga: " + sommaRiga);
            }
            Console.WriteLine("\nLa somma di tutti gli elementi è: " + sommaTot);
        }
    }
}
