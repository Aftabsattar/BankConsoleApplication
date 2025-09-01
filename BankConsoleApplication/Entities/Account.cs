
namespace BankConsoleApplication.Entities;

public class Account 
{
    public int CustomerID { get; set; }
    public int AccountNumber { get; set; }
    public string AccountType { get; set; } = string.Empty;
    public double Balance { get; set; }
    public DateTime OnCreated { get; set; }
}