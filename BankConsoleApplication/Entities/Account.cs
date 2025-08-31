using BankConsoleApplication.Interfaces;

namespace BankConsoleApplication.Entities;

public class Account:ICustomerRepositry
{
    public int CustomerID { get; set; }
    public int AccountNumber { get; set; }
    public string AccountType { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public DateTime OnCreated { get; set; }

    public void Create()
    {
        
    }

    public void Read()
    {
        // Implementation for reading account details
    }

    public void Update(int id)
    {
        // Implementation for updating account details
    }

    public void Delete(int id)
    {
        // Implementation for deleting an account
    }
}