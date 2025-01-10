namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }

        void start()
        {
            //Account name

            Account account = new Account("John Doe");

            //Get the user ot enter in the deposit
            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            //Deposit fund and display results
            if(account.Deposit(amount))
            {
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Deposit Failed: Amount must be positive.");
            }

            Console.ReadKey();
        }
    }

    class Account
    {
        //Private fields
        private string _accountHolder;
        private double _amount;

        //initialize the account holder
        public Account(string accountHolder)
        {
            _accountHolder = accountHolder;
            _amount = 0;
        }

        //Method to deposit fund
        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                _amount += amount;
                LogTransaction($"Depositied: {amount}");
                return true;
            }
            else
            {
                LogTransaction("Failed Despoit");
                    return false;
            }
        }

        //method to log transactions
        private void LogTransaction(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}