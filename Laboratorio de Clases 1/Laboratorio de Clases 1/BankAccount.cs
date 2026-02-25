namespace Class_BankAccount;

public class BankAccount
{
    private string holder;
    private float balance;
    private float deposit;
    private float withdraw;

    public BankAccount()
    {
        Console.WriteLine("Write the holders name\n");
        holder = (Console.ReadLine());
        Console.WriteLine("Write the balance\n");
        balance = float.Parse(Console.ReadLine());
    }
    public void ShowBalance()
    {
        Console.WriteLine($"Balance: {balance}\n");
        return;
    }
    public void Deposit()
    {
        Console.WriteLine("Write the deposit");
        deposit = float.Parse(Console.ReadLine());
        if (deposit < 0)
        {
            Console.WriteLine("Non aplicabble deposit\n");
        }
        else
        {
            balance += deposit;
        }
        return;
    }
    public void Withdraw()
    {
        Console.WriteLine("Write the withdraw");
        withdraw = float.Parse(Console.ReadLine());
        if (withdraw > balance)
        {
            Console.WriteLine("Insufficient balance\n");
        }
        else
        {
            balance -= withdraw;
        }
    }
}