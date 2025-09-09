namespace BankConsoleApplication.Entities;

public class SavingAccount:Account 
{
    public float InterestRate { get; set; }

    public double ApplyIntrest() 
    {
        Console.WriteLine("Enter InterestRate");
        var InterestRate = float.Parse(Console.ReadLine());
        var Interst = Balance * InterestRate/100 *1;
        return Balance+= Interst;
    }
}