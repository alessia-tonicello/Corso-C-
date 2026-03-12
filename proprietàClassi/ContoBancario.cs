namespace proprietàClassi;

    public class ContoBancario
    {
        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo;}
            private set {saldo= value;}
        }

        public ContoBancario(decimal saldoiniziale)
        {
            saldo= saldoiniziale;
        }

        public void Deposita(decimal importo)
        {
            if (importo > 0)
            {
                saldo += importo;
            }
        }

        public void Preleva(decimal importo)
        {
            if (importo > 0 && importo <= saldo)
            {
                saldo -= importo;
            }
        }

    }
