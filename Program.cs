bool running = true;
bool accountCreated = false;
string accountName = "";
double balance = 100;
bool accountMenuOpen = false;

Console.WriteLine("Welcome to Simple Bank!");

while (running)
{
    if (accountCreated)
    {
        Console.WriteLine("1 - Open account");
    }
    else
    {
        Console.WriteLine("1 - Create new account");
    }

    Console.WriteLine("2 - Exit");

    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        if (!accountCreated)
        {
            Console.WriteLine("Enter your name:");
            accountName = Console.ReadLine();

            accountCreated = true;

            Console.WriteLine($"Account created for {accountName}.");
        }
        else
        {
            Console.WriteLine($"Welcome {accountName}!");
            accountMenuOpen = true;
        }
    }
    else if (choice == 2)
    {
        running = false;
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }

    while (accountMenuOpen)
    {
        Console.WriteLine();
        Console.WriteLine("1 - Show balance");
        Console.WriteLine("2 - Withdraw money");
        Console.WriteLine("3 - Deposit money");
        Console.WriteLine("4 - Account info");
        Console.WriteLine("5 - Back");

        int accountChoice = int.Parse(Console.ReadLine());

        if (accountChoice == 1)
        {
            ShowBalance(balance);
        }
        else if (accountChoice == 2)
        {
            balance = WithdrawMoney(balance);
        }
        else if (accountChoice == 3)
        {
            balance = DepositMoney(balance);
        }
        else if (accountChoice == 4)
        {
            ShowAccountInfo(accountName, balance);
        }
        else if (accountChoice == 5)
        {
            accountMenuOpen = false;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}

static void ShowBalance(double balance)
{
    Console.WriteLine($"Your balance is: {balance}€");
}

static double WithdrawMoney(double balance)
{
    Console.WriteLine("Enter withdrawal amount:");

    double withdrawalAmount = double.Parse(Console.ReadLine());

    if (withdrawalAmount > 0 && withdrawalAmount <= balance)
    {
        balance -= withdrawalAmount;
        Console.WriteLine($"You have withdrawn {withdrawalAmount}€.");
    }
    else if (withdrawalAmount <= 0)
    {
        Console.WriteLine("Invalid amount.");
    }
    else
    {
        Console.WriteLine("Insufficient balance.");
    }

    return balance;
}

static double DepositMoney(double balance)
{
    Console.WriteLine("Enter deposit amount:");

    double depositAmount = double.Parse(Console.ReadLine());

    if (depositAmount > 0)
    {
        balance += depositAmount;
        Console.WriteLine($"You have deposited {depositAmount}€.");
    }
    else
    {
        Console.WriteLine("Invalid amount.");
    }

    return balance;
}

static void ShowAccountInfo(string accountName, double balance)
{
    Console.WriteLine("Account information");
    Console.WriteLine($"Account owner: {accountName}");
    Console.WriteLine($"Balance: {balance}€");
}