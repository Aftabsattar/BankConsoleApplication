namespace BankConsoleApplication.Repositry;

public class BankServices
{
    private readonly AccountRepositry _accountRepositry;
    private readonly CustomerRepositry _customerRepositry;
    public BankServices(AccountRepositry accountRepositry, CustomerRepositry customerRepositry)
    {
        _accountRepositry = accountRepositry;
        _customerRepositry = customerRepositry;
    }

    public void CreateAccountByCustomerId(int id)
    {
            var FindCutomer = _customerRepositry.FindById(id);
            if (FindCutomer != null) 
            {
                var account= _accountRepositry.CreateById(FindCutomer.ID);
                if (account != null)
                {
                    FindCutomer.Accounts.Add(account);
                    Console.WriteLine($"Another {account.AccountType} for {FindCutomer.Name} created successfuly");
                }
            }
            else { Console.WriteLine($"Account not created successfuly"); }
        }
    
    public void Deposit(int accountNumber, double amount)
    {
        var account = _accountRepositry.GetAccountByNumber(accountNumber);
        if (account != null)
        {
            account.Balance += amount;
            Console.WriteLine($"Deposited {amount} to account {accountNumber}. New balance: {account.Balance}");
        }
        else
        {
            Console.WriteLine($"Account {accountNumber} not found.");
        }
    }

    public void Withdraw(int accountNumber, double amount)
    {
        var account = _accountRepositry.GetAccountByNumber(accountNumber);
        if (account != null)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
                Console.WriteLine($"Withdrew {amount} from account {accountNumber}. New balance: {account.Balance}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in account {accountNumber}.");
            }
        }
        else
        {
            Console.WriteLine($"Account {accountNumber} not found.");
        }
    }

    public void Transfer(int fromAccountNumber, int toAccountNumber, double amount)
    {
        var fromAccount = _accountRepositry.GetAccountByNumber(fromAccountNumber);
        var toAccount = _accountRepositry.GetAccountByNumber(toAccountNumber);
        if (fromAccount != null && toAccount != null)
        {
            if (fromAccount.Balance >= amount)
            {
                fromAccount.Balance -= amount;
                toAccount.Balance += amount;
                Console.WriteLine($"Transferred {amount} from account {fromAccountNumber} to account {toAccountNumber}.");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in account {fromAccountNumber}.");
            }
        }
        else
        {
            Console.WriteLine($"Invalid account(s) specified.");
        }
    }

    public void BalanceInquiry(int accountNumber)
    {
        var account = _accountRepositry.GetAccountByNumber(accountNumber);
        if (account != null)
        {
            Console.WriteLine($"Account {accountNumber} has a balance of {account.Balance}.");
        }
        else
        {
            Console.WriteLine($"Account {accountNumber} not found.");
        }
    }
    public int ManageBasicOperation()
    {
        Console.WriteLine("1. For Deposit Money");
        Console.WriteLine("2. For Withdraw");
        Console.WriteLine("3. Transfer One Account to Another");
        Console.WriteLine("4. Balance Inquiry");
        Console.WriteLine("5. Exit");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
}