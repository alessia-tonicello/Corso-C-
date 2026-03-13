using System;
using System.Collections.Generic;

namespace Tombola
{
    internal class Program
    {
        class Giocatore
        {
            public string Nome;
            public List<Cartella> MieCartelle = new List<Cartella>();

            public Giocatore(string nome, int quante)
            {
                Nome = nome;
                for (int i = 0; i < quante; i++)
                {
                    MieCartelle.Add(new Cartella());
                }
            }
        }

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
                        if (numeri[i, j] == 0) Console.Write("--\t");
                        else if (numeri[i, j] == -1) Console.Write("X\t");
                        else Console.Write(numeri[i, j] + "\t");
                    }
                    Console.WriteLine("\n");
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Numero giocatori: ");
            int numeroGiocatori = int.Parse(Console.ReadLine());

            List<Giocatore> listaGiocatori = new List<Giocatore>();

            for (int i = 0; i < numeroGiocatori; i++)
            {
                Console.WriteLine("\nGiocatore " + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                
                Console.Write("Numero cartelle: ");
                int quante = int.Parse(Console.ReadLine());

                // Creiamo il giocatore e le sue cartelle
                Giocatore nuovoG = new Giocatore(nome, quante);
                
                // Stampiamo subito le sue cartelle per conferma
                foreach (var c in nuovoG.MieCartelle)
                {
                    c.StampaCartella();
                }

                listaGiocatori.Add(nuovoG);
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("TABELLONE INIZIALE");

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

            // ESTRAZIONE
            List<int> sacchetto = new List<int>();
            for (int n = 1; n <= 90; n++) sacchetto.Add(n);

            Random random2 = new Random();
            List<int> estratti = new List<int>();
            int vincitaMassimaComune = 1;

            List<Cartella> CartelleTabellone = new List<Cartella>();
            for (int t = 0; t < 6; t++) CartelleTabellone.Add(new Cartella());

            bool vittoria = false;

            while (sacchetto.Count > 0 && vittoria != true)
            {
                Console.WriteLine("\nPremi INVIO per estrarre un numero...");
                Console.ReadLine();

                int indice = random2.Next(0, sacchetto.Count);
                int numeroEstratto = sacchetto[indice];
                sacchetto.RemoveAt(indice);
                estratti.Add(numeroEstratto);

                Console.Clear();
                Console.WriteLine("NUMERO ESTRATTO: " + numeroEstratto);

                // CONTROLLO CARTELLE DI OGNI GIOCATORE
                foreach (Giocatore g in listaGiocatori)
                {
                    for (int i = 0; i < g.MieCartelle.Count; i++)
                    {
                        Cartella c = g.MieCartelle[i];
                        int totaliInCartella = 0;

                        for (int righe = 0; righe < 3; righe++)
                        {
                            int numeriSegnatiInRiga = 0;
                            for (int col = 0; col < 9; col++)
                            {
                                if (c.numeri[col, righe] == numeroEstratto) c.numeri[col, righe] = -1;
                                if (c.numeri[col, righe] == -1)
                                {
                                    numeriSegnatiInRiga++;
                                    totaliInCartella++;
                                }
                            }

                            if (numeriSegnatiInRiga == 2 && vincitaMassimaComune < 2)
                            {
                                Console.WriteLine("AMBO! Giocatore: " + g.Nome + " (Cartella " + (i + 1) + ")");
                                vincitaMassimaComune = 2;
                            }
                            else if (numeriSegnatiInRiga == 3 && vincitaMassimaComune < 3)
                            {
                                Console.WriteLine("TERNA! Giocatore: " + g.Nome + " (Cartella " + (i + 1) + ")");
                                vincitaMassimaComune = 3;
                            }
                            else if (numeriSegnatiInRiga == 4 && vincitaMassimaComune < 4)
                            {
                                Console.WriteLine("QUATERNA! Giocatore: " + g.Nome + " (Cartella " + (i + 1) + ")");
                                vincitaMassimaComune = 4;
                            }
                            else if (numeriSegnatiInRiga == 5 && vincitaMassimaComune < 5)
                            {
                                Console.WriteLine("CINQUINA! Giocatore: " + g.Nome + " (Cartella " + (i + 1) + ")");
                                vincitaMassimaComune = 5;
                            }
                        }

                        if (totaliInCartella == 15)
                        {
                            Console.WriteLine("TOMBOLA! Vince " + g.Nome + " con la cartella " + (i + 1));
                            vittoria = true;
                            break;
                        }
                    }
                    if (vittoria) break;
                }

                // CONTROLLO CARTELLE TABELLONE
                if (vittoria != true)
                {
                    for (int i = 0; i < CartelleTabellone.Count; i++)
                    {
                        Cartella ct = CartelleTabellone[i];
                        int totaliInTab = 0;

                        for (int rT = 0; rT < 3; rT++)
                        {
                            int segnatiInRigaT = 0;
                            for (int cT = 0; cT < 9; cT++)
                            {
                                if (ct.numeri[cT, rT] == numeroEstratto) ct.numeri[cT, rT] = -1;
                                if (ct.numeri[cT, rT] == -1)
                                {
                                    segnatiInRigaT++;
                                    totaliInTab++;
                                }
                            }

                            if (segnatiInRigaT == 2 && vincitaMassimaComune < 2)
                            {
                                Console.WriteLine("AMBO sul Tabellone! (Cartella " + (i + 1) + ")");
                                vincitaMassimaComune = 2;
                            }
                            else if (segnatiInRigaT == 3 && vincitaMassimaComune < 3)
                            {
                                Console.WriteLine("TERNA sul Tabellone! (Cartella " + (i + 1) + ")");
                                vincitaMassimaComune = 3;
                            }
                            else if (segnatiInRigaT == 4 && vincitaMassimaComune < 4)
                            {
                                Console.WriteLine("QUATERNA sul Tabellone! (Cartella " + (i + 1) + ")");
                                vincitaMassimaComune = 4;
                            }
                            else if (segnatiInRigaT == 5 && vincitaMassimaComune < 5)
                            {
                                Console.WriteLine("CINQUINA sul Tabellone! (Cartella " + (i + 1) + ")");
                                vincitaMassimaComune = 5;
                            }
                        }

                        if (totaliInTab == 15)
                        {
                            Console.WriteLine("TOMBOLA sul Tabellone! (Cartella " + (i + 1) + ")");
                            vittoria = true;
                            break;
                        }
                    }
                }
            }
            
            Console.WriteLine("\nIl gioco è terminato. Grazie per aver giocato!");
            Console.ReadKey();
        }
    }
}