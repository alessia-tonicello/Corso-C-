using System;

namespace metodiEsercizi
{
    internal class Program
    {
        //Esercizio 1: scrivi un metodo chiamato Saluta che:
        //-non riceve parametri
        //-stampa a schermo "Ciao!"
        //-chiamalo nel Main

        public static void Saluta()
        {
            Console.WriteLine("Ciao!");
        }


        //Esercizio 2: scrivi un metodo chiamato StampaNumero che:
        //-riceve un intero 
        //-stampa il numero ricevuto
        public static void StampaNumero(int numero)
        {
            Console.WriteLine("Il numero è: " + numero);
        }

        //Esercizio 3: scrivere una mini calcolatrice con metodi: somma, moltiplicazione, divisione, sottrazione
        class Calcolatrice
        {
            public static int Somma(int x, int y)
            {
                return x + y;
            }

            public static int Moltiplicazione(int x, int y)
            {
                return x * y;
            }

            public static int Divisione(int x, int y)
            {
                return x / y;
            }

            public static int Sottrazione(int x, int y)
            {
                return x - y;
            }
        }

        //Esercizio 4: crea una classe Persona con: nome, eta
        //Crea un metodo Presentati() che stampa: "Ciao mi chiamo Marco e ho 25 anni"
        class Persona
        {
            public string nome;
            public int eta;

            public void Presentati()
            {
                Console.WriteLine("Ciao, sono " + nome + "e ho " + eta + "anni");
            }
        }

        //Esercizio 5(ref): scrivi un metodo Raddoppia che:
        //-riceve un numero con ref
        //-lo raddoppia
        static void Raddoppia(ref int numero)
        {
            numero = numero * 2;
        }

        //Esercizio 6(out): scrivi un metodo Calcola che: riceve due numeri e restituisce con out: 
        //- la somma
        //-la differenza
        static void Calcola(int a, int b, out int somma, out int differenza)
        {
            somma = a + b;
            differenza = a - b;
        }

        //Esercizio 7: crea tre metodi Area: di un quadrato, rettangolo e cerchio
        public static int areaQuadrato(int latoQ)
        {
            return latoQ * latoQ;
        }

        public static int areaRettangolo(int baseRett, int altezza)
        {
            return baseRett * altezza;
        }

        public static double areaCerchio(double raggio)
        {
            return 3.14 * raggio * raggio;
        }


        //Esercizio 8: crea un programma con metodi:
        //-LeggiNumero()
        //-Somma(int a, int b)
        //-Media(int a, int b, int c)
        //-Maggiore(int a, int b, int c)

        class Calcolatrice2
        {
            public static int LeggiNumero()
            {
                Console.WriteLine("Inserisci un numero:");
                return int.Parse(Console.ReadLine());
            }

            public static int Somma2(int a, int b)
            {
                return a + b;
            }

            public static double Media(int a, int b, int c)
            {
                return (a + b + c) / 3.0;
            }

            public static int Maggiore(int a, int b, int c)
            {
                int massimo = a;
                if (b > massimo)
                {
                    massimo = b;
                }

                if (c > massimo)
                {
                    massimo = c;
                }
                return massimo;
            }
        }

        public static void Main(string[] args)
        {
            //Esercizio 1
            Saluta();

            //Esercizio 2
            StampaNumero(1);

            //Esercizio 3
            int risultatoSomma = Calcolatrice.Somma(10, 5);
            Console.WriteLine("Il risultato finale è: " + risultatoSomma);
            int risultatoMoliplicazione = Calcolatrice.Moltiplicazione(10, 5);
            Console.WriteLine("Il risultato finale è: " + risultatoMoliplicazione);

            //Esercizio 4
            Persona p1 = new Persona();
            p1.nome = "Marco";
            p1.eta = 25;
            p1.Presentati();

            //Esercizio 5
            int x = 5;
            Raddoppia(ref x);
            Console.WriteLine(x);

            //Esercizio 6
            int s;
            int p;
            Calcola(4, 3, out s, out p);
            Console.WriteLine("La somma è " + s);
            Console.WriteLine("La differenza è " + p);

            //Esercizio 7
            int risultatoQuadrato = areaQuadrato(5);
            Console.WriteLine("L'area del quadrato è: " + risultatoQuadrato);

            int risultatoRettangolo = areaRettangolo(3, 4);
            Console.WriteLine("L'area del rettangolo è: " + risultatoRettangolo);

            double risultatoCerchio = areaCerchio(2);
            Console.WriteLine("L'area del cerchio è: " + risultatoCerchio);

            //Esercizio 8 
            int n1 = Calcolatrice2.LeggiNumero();
            int n2 = Calcolatrice2.LeggiNumero();
            int n3 = Calcolatrice2.LeggiNumero();
            Console.WriteLine("Il maggiore tra quelli inseriti è: " + Calcolatrice2.Maggiore(n1, n2, n3));
        }
    }
}