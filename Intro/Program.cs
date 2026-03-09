using System;

namespace Intro
{
    internal class Program
        {
            public static void Main(string[] args)

            {
                //WHILE DOWHILE
                //int i = 0
                //while (i < 5)
                
                // Console.WriteLine("Hello World!");

                string nome = "Alessia";
                // Console.WriteLine("Ciao " + nome);
                
                
                int a = 10;
                int b = 5;
                
                // int area = a * b;
                // Console.WriteLine("Ciao, l'area è: " + area);
                
                
                //Esercizio 1
                int somma =  a + b;
                int sottrazione = a - b;
                int moltiplicazione = a * b;
                int divisione = a / b;
                Console.WriteLine("Ciao, la somma è: " + somma);
                Console.WriteLine("Ciao, la sottrazione: " + sottrazione);
                Console.WriteLine("Ciao, il prodotto è: " + moltiplicazione);
                Console.WriteLine("Ciao, la divisione è: " + divisione);
                
                
                //Esercizio 2
                int ba = 4;
                int altezza = 2;
                
                int area = ba * altezza;
                int perimetro = 2 * (ba + altezza);
                Console.WriteLine("Ciao, l'area è: " + area);
                Console.WriteLine("Ciao, il perimetro è: " + perimetro);
                
                
                //Esercizio 3
                int bas = 8;
                int alt = 6;

                int areaTriangolo = (bas * alt) / 2;
                Console.WriteLine("Ciao, l'area è: " + areaTriangolo);
                
                
                //Esercizio 4
                int raggio = 8;
                float pi = 3.14F;
                float areaCerchio = (raggio * raggio) * pi;
                float circonferenza = 2 * pi * (raggio);
                Console.WriteLine("Ciao, l'area è: " + areaCerchio);
                Console.WriteLine("Ciao, la circonferenza è: " + circonferenza);
                
                
                //Casting
                //implicito 
                int prova = 4;
                long qwerty = prova;
                
                //esplicito
                double prova1 = 3.4;
                int numero2= (int)prova1;
                
                /*
               //Metodo di conversione (da int a stringa)
               int numero3 = 23;
               string stringa = Convert.ToString(numero3);


               //input utenti +try&catch
               Console.WriteLine("Inserisci il primo numero");
               string numer1 = Console.ReadLine();

               Console.WriteLine("Inserisci il secondo numero");
               string numer2 = Console.ReadLine();

               int num1 = 0;
               int num2 = 0;

               num1= int.Parse(numer1);
               num2= int.Parse(numer2);

               int somma2 = num1 + num2;
               Console.WriteLine(somma2);

               if (num1 > num2)
               {
                   Console.WriteLine("Numero1 maggiore");
               } else if (num1 < num2)
               {
                   Console.WriteLine("Numero2 maggiore");
               }
               else
               {
                   Console.WriteLine("i numeri sono uguali");
               }

 */
               // if (num1 && num2 != num3)
               // if (num1 || num2)

               /*
               //Esercizio 1: il programma legge 3 numeri e controlla se tutti i casi di if-else
               Console.WriteLine("Inserisci il primo numero");
               string number1 = Console.ReadLine();

               Console.WriteLine("Inserisci il secondo numero");
               string number2 = Console.ReadLine();

               Console.WriteLine("Inserisci il terzo numero");
               string number3 = Console.ReadLine();

               int numb1 = 0;
               int numb2 = 0;
               int numb3 = 0;

               numb1= int.Parse(number1);
               numb2= int.Parse(number2);
               numb3= int.Parse(number3);


               if (numb1 > numb3 && numb2 > numb3)
               {
                   Console.WriteLine("Numero3 minore di tutti");

               } else if (numb1 < numb3 && numb2 < numb3)
               {
                   Console.WriteLine("Numero3 maggiore di tutti");

               } else if (numb1 == numb2 && numb2 == numb3)
               {
                   Console.WriteLine("Tutti i numeri sono uguali");
               } else
               {
                   Console.WriteLine("i numeri sono uguali");
               }


               //Esercizio 2
               Console.WriteLine("Inserisci la tua età");
               string eta = Console.ReadLine();

               int eta_num = 0;
               eta_num= int.Parse(eta);

               if (eta_num >= 18)
               {
                   Console.WriteLine("Accesso garantito");

               } else if (eta_num < 18)
               {
                   Console.WriteLine("Accesso negato");
               }


               //Esercizio 3
               Console.WriteLine("Inserisci il primo numero");
               string number1Triangle = Console.ReadLine();

               Console.WriteLine("Inserisci il secondo numero");
               string number2Triangle = Console.ReadLine();

               Console.WriteLine("Inserisci il terzo numero");
               string number3Triangle = Console.ReadLine();

               int lato1 = 0;
               int lato2 = 0;
               int lato3 = 0;

               lato1 = int.Parse(number1Triangle);
               lato2 = int.Parse(number2Triangle);
               lato3 = int.Parse(number3Triangle);

               if (lato1 == lato2 && lato2 == lato3)
               {
                   Console.WriteLine("Il triangolo è equilatero");

               } else if (lato1 != lato2 && lato2 != lato3 && lato3 != lato1)
               {
                   Console.WriteLine("Il triangolo è scaleno");

               }
               else
               {
                   Console.WriteLine("Il triangolo è isoscele");
               }

*/
                
                //Esercizio 4
                Console.WriteLine("In che anno sei nato?");
                string anno = Console.ReadLine();

                int annoNascita = 0;
                annoNascita= int.Parse(anno);
                int annoLuna = 1969;
                
                if (annoNascita == annoLuna)
                {
                    Console.WriteLine("Stesso anno della luna");
                    
                } else if (annoNascita < annoLuna)
                {
                    int anniPrima = annoLuna - annoNascita;
                    Console.WriteLine("Sei nato " + anniPrima + " anni prima della missione sulla Luna.");

                }
                else
                {
                    int anniDopo = annoNascita - annoLuna;
                    Console.WriteLine("Sei nato " + anniDopo + " anni dopo la missione sulla Luna.");
                }


            }
        }
    
}
