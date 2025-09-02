namespace BankConsoleApplication.Repositry;

public class BasicBankOperation
{
    private readonly AccountRepositry _accountRepositry;
    private readonly CustomerRepositry _customerRepositry;
    public BasicBankOperation(AccountRepositry accountRepositry, CustomerRepositry customerRepositry)
    {
        _accountRepositry = accountRepositry;
        _customerRepositry = customerRepositry;
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
}