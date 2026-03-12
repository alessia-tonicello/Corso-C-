namespace proprietàClassi;

public class Veicolo
{
    public string Marca { get; set; }

    public void Avvia()
    {
        Console.WriteLine("Il veicolo si avvia");
    }
}

public class Auto: Veicolo
{
    public int NumeroPorte { get; set; }

    public void SuonaClacson()
    {
        Console.WriteLine("Beep Beep!");
    }
}