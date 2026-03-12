using System;

namespace proprietàClassi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //INCAPSULAMENTO 
            var conto = new ContoBancario(1000);
            conto.Deposita(200);
            Console.WriteLine(conto);
            
            conto.Preleva(90);
            Console.WriteLine(conto.Saldo);
            
            
            //EREDITARIETA
            Auto miaAuto = new Auto();

            miaAuto.Marca = "Fiat";
            miaAuto.NumeroPorte = 4;
            
            miaAuto.Avvia();
            miaAuto.SuonaClacson();
            
            
            //POLIMORFISMO
            Animale[] animali =
            {
                new Cane(),
                new Gatto()
            };

        }
    }
}