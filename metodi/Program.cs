using System;

namespace metodi
{
    internal class Program
    {
        //Statico, non c'è bisogno della creazione dell'oggetto
        class Calcolatrice
        {
            public static int somma(int x, int y)
            {
                return x + y;
            }
        }
        
        //Non statico
        class Persona
        {
            public string nome;

            public void Saluta()
            {
                Console.WriteLine("Ciao, sono " + nome);
            }
        }
        
        //REF in cui la variabile deve essere già dichiarata, gli dai già un valore di riferimento, come in questo caso il +10
        //per esempio, dopo mettiamo 5 e automaticamente diventa 5+10
        static void aumenta(ref int numero)
        {
            numero = numero + 10;
        }
        
        
        //variabile non deve essere inizializzata
        static void calcola(int a, int b, out int somma, out int prodotto)
        {
            somma = a + b;
            prodotto = a * b;
        }
        
        
        //Override 
        //sovrascrivere ciò che abbiamo scritto precedentemente 
        class Calculator
        {
            public int Sum(int c, int d)
            {
                return c + d;
            }

            public int Sum(int c, int d, int e)
            {
                return c + d + e;
            }

            public double Sum(double c, double d)
            {
                return c + d;
            }
            
            
            
        
        public static void Main(string[] args)
        {
            int risultato = Calcolatrice.somma(10, 20);
                Console.WriteLine(risultato);
                
                
            Persona p1 = new Persona();
            p1.nome = "Alessia";
            p1.Saluta();


            int x = 5;
            aumenta(ref x);
            Console.WriteLine(x);

            int s;
            int p;
            calcola(4,3, out s,out p);
            Console.WriteLine("La somma è " + s);
            Console.WriteLine("Il prodotto è " + p);
            
            
            Calcolatrice c1 = new Calcolatrice();
            Console.WriteLine(c1.Sum(10,20));
            Console.WriteLine(c1.Sum(10,20,30));
            Console.WriteLine(c1.Sum(10.2,20.3,30.2));



        }
    }
}
