using BankConsoleApplication.Entities;
using BankConsoleApplication.Interfaces;

namespace BankConsoleApplication.Repositry;

public class AccountRepositry : IAccountRepositry
{
    private List<Account> obj = new List<Account>();
    public Account Create()
    {
        Account account = new Account();
        Console.Write("Enter Customer ID:");
        account.CustomerID = int.Parse(Console.ReadLine());
        Console.Write("Enter Account Number:");
        account.AccountNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter Account Type:");
        account.AccountType = Console.ReadLine();
        Console.Write("Enter Initial Balance:");
        account.Balance = double.Parse(Console.ReadLine());
        account.OnCreated = DateTime.Now;
        return account;
    }

    public void Delete(int accountNumber)
    {
        Account account = obj.FirstOrDefault(a => a.AccountNumber == accountNumber);
        if (account != null)
        {
            obj.Remove(account);
            Console.WriteLine($"\nAccount {accountNumber} Deleted successfully");
        }
        else
        {
            Console.WriteLine($"\nAccount {accountNumber} Not Found");
        }
    }

    public void Read(int accountNumber)
    {
        Account account = obj.FirstOrDefault(a => a.AccountNumber == accountNumber);
        if (account != null)
        {
            Console.WriteLine($"\nAccount Number: {account.AccountNumber}");
            Console.WriteLine($"Customer ID: {account.CustomerID}");
            Console.WriteLine($"Account Type: {account.AccountType}");
            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine($"Created On: {account.OnCreated}");
        }
        else
        {
            Console.WriteLine($"\nAccount {accountNumber} Not Found");
        }
    }

    public void ReadAll()
    {
        Console.WriteLine("All Accounts:");
        foreach (var account in obj)
        {
            Console.WriteLine($"\nAccount Number: {account.AccountNumber}");
            Console.WriteLine($"Customer ID: {account.CustomerID}");
            Console.WriteLine($"Account Type: {account.AccountType}");
            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine($"Created On: {account.OnCreated}");
        }
    }

    public void Update(int accountNumber)
    {

        Account account = obj.FirstOrDefault(a => a.AccountNumber == accountNumber);
        if (account != null)
        {
            Console.Write("Enter new Account Type:");
            account.AccountType = Console.ReadLine();
            Console.WriteLine($"\nAccount {accountNumber} Updated successfully");
        }
        else
        {
            Console.WriteLine($"\nAccount {accountNumber} Not Found");
        }
    }

    public int ManageAccount()
    {
        Console.WriteLine("1. Create Account");
        Console.WriteLine("2. View All Accounts");
        Console.WriteLine("3. View Account by Account Number");
        Console.WriteLine("4. Update Account");
        Console.WriteLine("5. Delete Account");
        Console.WriteLine("6. Exit");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
}