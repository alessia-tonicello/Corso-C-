namespace proprietàClassi;

public class Animale
{
    public virtual void FaiVerso()
    {
        Console.WriteLine("L'animale fa uun verso");
    }
}

public class Cane: Animale
{
    public override void FaiVerso()
    {
        Console.WriteLine("Bau!");
    }
}

public class Gatto: Animale
{
    public override void FaiVerso()
    {
        Console.WriteLine("Miao!");
    }
}