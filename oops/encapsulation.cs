class Bank
{
    private int balance = 1000;

    public int GetBalance()
    {
        return balance;
    }

    public void SetBalance(int amount)
    {
        balance = amount;
    }
}

class Program
{
    static void Main()
    {
        Bank b = new Bank();
        b.SetBalance(5000);
        Console.WriteLine("Balance: " + b.GetBalance());
    }
}
