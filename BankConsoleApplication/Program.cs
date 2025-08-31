using System.Data;
using BankConsoleApplication.Repositry;
Console.WriteLine("****************Welome To The Bank of Punjab*******************");
Console.WriteLine("Press 1 To Manage Customer");
Console.WriteLine("Press 2 To Manage Account");
CustomerRepositry customerRepositry = new CustomerRepositry();
AccountRepositry accountRepositry = new AccountRepositry();
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        while (true)
        {
            int result = customerRepositry.ManageCustomer();
            switch (result)
            {
                case 1:
                    char ch;
                    do
                    {
                        customerRepositry.Create();
                        Console.Clear();
                        Console.WriteLine("Do you want to add another customer? (y/n)");
                        ch = char.Parse(Console.ReadLine());
                    } while (ch == 'y' || ch == 'Y'); 
                    break;
                case 2:
                    customerRepositry.ReadAll();
                    break;
                case 3:
                    Console.WriteLine("Enter Customer ID to Read:");
                    int readId = int.Parse(Console.ReadLine());
                    customerRepositry.Read(readId);
                    break;
                case 4:
                    Console.WriteLine("Enter Customer ID to Update:");
                    int updateId = int.Parse(Console.ReadLine());
                    customerRepositry.Update(updateId);
                    break;
                case 5:
                    Console.WriteLine("Enter Customer ID to Delete:");
                    int deleteId = int.Parse(Console.ReadLine());
                    customerRepositry.Delete(deleteId);
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    case 2:
        while (true)
        {
            int result = accountRepositry.ManageAccount();
            switch (result)
            {
                case 1:
                    char ch;
                    do
                    {
                        accountRepositry.Create();
                        Console.Clear();
                        Console.WriteLine("Do you want to add another account? (y/n)");
                        ch = char.Parse(Console.ReadLine());
                    } while (ch == 'y' || ch == 'Y');
                    break;
                case 2:
                    accountRepositry.ReadAll();
                    break;
                case 3:
                    Console.WriteLine("Enter Account Number to Read:");
                    int readAccNumber = int.Parse(Console.ReadLine());
                    accountRepositry.Read(readAccNumber);
                    break;
                case 4:
                    Console.WriteLine("Enter Account Number to Update:");
                    int updateAccNumber = int.Parse(Console.ReadLine());
                    accountRepositry.Update(updateAccNumber);
                    break;
                case 5:
                    Console.WriteLine("Enter Account Number to Delete:");
                    int deleteAccNumber = int.Parse(Console.ReadLine());
                    accountRepositry.Delete(deleteAccNumber);
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    default:
        Console.WriteLine("Invalid choice");
        break;
}
