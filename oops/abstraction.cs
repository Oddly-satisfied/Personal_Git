abstract class Animal
{
    public abstract void Sound();
}

class Lion : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Lion Roars");
    }
}

class Program
{
    static void Main()
    {
        Lion l = new Lion();
        l.Sound();
    }
}
