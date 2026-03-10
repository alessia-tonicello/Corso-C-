using System;

namespace doWhile
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            int i = 1;
            do
            {
                Console.WriteLine("Numero " + i);
                i++;
            } while (i <= 10);


            int numero;
            while (true)
            {
                Console.WriteLine("Inserisci un numero (0 per uscire)");
                numero =  int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    Console.WriteLine("Uscita in corso");
                    break;
                }
                Console.WriteLine("Hai inserito questo numero: " + numero);
            }


            //Esercizio 1: chiedere all'utente una password finché non inserisce quella corretta
            string password;
            string passwordCorretta = "Segreta123!";

            do
            {
                Console.WriteLine("Inserisci la password: ");
                password = Console.ReadLine();

                if (password != passwordCorretta)
                {
                    Console.WriteLine("La password è errata, riprova");

                }
            } while (password != passwordCorretta);

            Console.WriteLine("Accesso garantito!");



            //Esercizio 2: creare un programma che chieda un numero finché non è compreso tra 1 e 10
            int numero;

            do
            {
                Console.WriteLine("Inserisci un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

            } while (numero >= 1 && numero <= 10);

            Console.WriteLine("Accesso garantito!");
            
        


            //Esercizio 3: creare un menu ripetuto con do while
            int scelta;

            do
            {
                Console.WriteLine("1. Profilo");
                Console.WriteLine("2. Impostazioni");
                Console.WriteLine("3. Contatti");
                Console.WriteLine("4. Esci");
                Console.Write("Scegli un'opzione: ");

                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Personalizza profilo");
                        break;
                    case 2:
                        Console.WriteLine("Cambia nome utente, email, password");
                        break;
                    case 3:
                        Console.WriteLine("email, LinkedIn, numero di telefono");
                        break;
                    case 4:
                        Console.WriteLine("Logged out");
                        break;
                }

            } while (scelta != 4); 
            Console.WriteLine("Salvataggio in corso... Arrivederci!");
            */
            
            //Esercizio 3: chiedere all'utente numeri e contare quanti numeri sono stati inseriti.
            //Il programma termina quando viene inserito 0.
            int contatore = 0;
            int numeroInserito;

            do
            {
                Console.WriteLine("Inserisci un numero");
                numeroInserito = Convert.ToInt32(Console.ReadLine());
                
                contatore++;
                
            } while (numeroInserito != 0);
            Console.WriteLine("Hai inserito in totale " + contatore + " numeri");
            
        }

    }
}
