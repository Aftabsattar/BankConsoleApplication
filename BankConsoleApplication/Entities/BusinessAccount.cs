namespace BankConsoleApplication.Entities;

public class BusinessAccount:Account
{
    public string BusinessName { get; set; } = string.Empty;
    public string TaxID { get; set; } = string.Empty;
}