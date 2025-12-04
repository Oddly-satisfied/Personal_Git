class Parent
{
    public void Show()
    {
        Console.WriteLine("This is Parent class");
    }
}

class Child : Parent
{
    public void Display()
    {
        Console.WriteLine("This is Child class");
    }
}

class Program
{
    static void Main()
    {
        Child c = new Child();
        c.Show();
        c.Display();
    }
}
