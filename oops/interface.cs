using System;

interface IAnimal
{
    void Sound();
}

class Cat : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        Cat c = new Cat();
        c.Sound();
    }
}
