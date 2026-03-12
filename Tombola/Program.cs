using System;
using System.Collections.Generic;

namespace NumeriRandom
{
    internal class Program
    {
        class Cartella
        {
            public int[,] numeri = new int[9, 3];

            public Cartella()
            {
                Random random = new Random();
                List<int> estratti = new List<int>();

                for (int i = 0; i < 9; i++)
                {
                    int min = i * 10;
                    int max = i * 10 + 10;

                    if (i == 0) min = 1;
                    if (i == 8) max = 91;

                    for (int j = 0; j < 3; j++)
                    {
                        int n;
                        do
                        {
                            n = random.Next(min, max);
                        } while (estratti.Contains(n));

                        numeri[i, j] = n;
                        estratti.Add(n);
                    }

                    if (numeri[i, 0] > numeri[i, 1]) Scambia(i, 0, 1);
                    if (numeri[i, 0] > numeri[i, 2]) Scambia(i, 0, 2);
                    if (numeri[i, 1] > numeri[i, 2]) Scambia(i, 1, 2);
                }

                for (int j = 0; j < 3; j++)
                {
                    int spaziDaTogliere = 4;
                    while (spaziDaTogliere > 0)
                    {
                        int colonnaCasuale = random.Next(0, 9);
                        if (numeri[colonnaCasuale, j] != 0)
                        {
                            numeri[colonnaCasuale, j] = 0;
                            spaziDaTogliere--;
                        }
                    }
                }
            }

            private void Scambia(int col, int r1, int r2)
            {
                int temp = numeri[col, r1];
                numeri[col, r1] = numeri[col, r2];
                numeri[col, r2] = temp;
            }

            public void StampaCartella()
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (numeri[i, j] == 0)
                        {
                            Console.Write("--\t");
                        }
                        else
                        {
                            Console.Write(numeri[i, j] + "\t");
                        }
                    }

                    Console.WriteLine("\n");
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Inserisci numero cartelle: ");
            int numeroCartelle = int.Parse(Console.ReadLine());

            for (int k = 0; k < numeroCartelle; k++)
            {
                Console.WriteLine("CARTELLA NUMERO " + (k + 1));
                Cartella c = new Cartella();
                c.StampaCartella();
            }
            
            Console.WriteLine("-----------------------");
            Console.WriteLine("TABELLONE");

            
            //TABELLONE
            List<int> tabellone = new List<int>();

            int[,] numeriTabellone = new int[9, 10];

            int contatore = 1;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    numeriTabellone[i, j] = contatore;
                    contatore++;
                    Console.Write(numeriTabellone[i, j] + "\t");
                }

                Console.WriteLine();
            }
            
            //ESTRAZIONE
            List<int> sacchetto = new List<int>();
            for (int n = 1; n <= 90; n++) sacchetto.Add(n);

            Random random2 = new Random();
            List<int> estratti = new List<int>();
            int vincitaAttuale = 1;
            
            while (sacchetto.Count > 0)
            {
                Console.WriteLine("\nPremi INVIO per estrarre un numero...");
                Console.ReadLine();
                
                int indice = random2.Next(0, sacchetto.Count);
                int numeroEstratto = sacchetto[indice];
                
                sacchetto.RemoveAt(indice);
                tabellone.Add(numeroEstratto); 

                Console.Clear(); 
                Console.WriteLine("   NUMERO ESTRATTO: " + numeroEstratto);
                
                Console.WriteLine("\nNumeri rimasti nel sacchetto: " + sacchetto.Count);
                
                
                for (int r = 0; r < 3; r++)
                {
                    int numeriSegnatiInRiga = 0;
                    
    
                    for (int col = 0; col < 9; col++)
                    {
                        // Se il numero è quello estratto, lo segniamo con -1
                        if (c.numeri[col, r] == numeroEstratto)
                        {
                            c.numeri[col, r] = -1; 
                        }

                        // Contiamo quanti numeri segnati (-1) abbiamo in questa riga
                        if (c.numeri[col, r] == -1)
                        {
                            numeriSegnatiInRiga++;
                        }
                    }

                    // 2. Controlliamo la vincita in questa riga
                    if (numeriSegnatiInRiga == 2) Console.WriteLine("AMBO in riga " + (r + 1));
                    else if (numeriSegnatiInRiga == 3) Console.WriteLine("TERNA in riga " + (r + 1));
                    else if (numeriSegnatiInRiga == 4) Console.WriteLine("QUATERNA in riga " + (r + 1));
                    else if (numeriSegnatiInRiga == 5) Console.WriteLine("CINQUINA in riga " + (r + 1));
                }
            }
            
            
        }
    }
}