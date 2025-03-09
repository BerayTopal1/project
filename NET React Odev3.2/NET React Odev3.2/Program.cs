using System;


class BankAccount
{
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public virtual void CalculateInterest()
    {
        
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance:C}");
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountHolder, double balance)
        : base(accountHolder, balance) { }

    public override void CalculateInterest()
    {
        double interest = Balance * 0.05; 
        Console.WriteLine($"Interest Earned: {interest:C}");
    }
}


class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountHolder, double balance)
        : base(accountHolder, balance) { }

    public override void CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Savings Account Holder Name: ");
        string savingsName = Console.ReadLine();

        Console.Write("Enter Checking Account Holder Name: ");
        string checkingName = Console.ReadLine();

        SavingsAccount savings = new SavingsAccount(savingsName, 5000);
        CheckingAccount checking = new CheckingAccount(checkingName, 3000);

        savings.DisplayInfo();
        savings.CalculateInterest();

        Console.WriteLine();

        checking.DisplayInfo();
        checking.CalculateInterest();
    }
}
