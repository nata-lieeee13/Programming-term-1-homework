namespace Assignment8;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.start();
    }

    void start()
    {
        //Create a BankAccount object
        BankAccount account = new BankAccount("123456789",1000);

        //Display the intial details
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Initial Balance: {account.Balance}");

        //Deposit the money
        Console.Write("Enter deposit amount: ");
        double depositAmount = double.Parse(Console.ReadLine());
        account.Deposit(depositAmount);

        //Withdraw money
        Console.Write("Enter withdrawl amount: ");
        double withdrawlAmount = double.Parse(Console.ReadLine());
        account.Withdrawl(withdrawlAmount);

        //Display final balance
        Console.WriteLine($"Final Balance: {account.Balance}");

        Console.ReadKey();
    }
}

class BankAccount
{
    public string AccountNumber { get; private set; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if(amount >0)
        {
            Balance += amount;
            Console.WriteLine("Deposit Successful!");
        }
        else
        {
            Console.WriteLine("Deposit Failed");
        }
    }

    public void Withdrawl(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawl Succesful!");
        }
        else
        {
            Console.WriteLine("Withdrawl failed");
        }
    }
}


