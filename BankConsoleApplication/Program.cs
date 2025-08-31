using BankConsoleApplication.Repositry;
Console.WriteLine("****************Welome To The Bank of Punjab*******************");
Console.WriteLine("Press 1 To Manage Customer");
Console.WriteLine("Press 2 To Manage Account");
CustomerRepositry customerRepositry = new CustomerRepositry();
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
                    customerRepositry.Create();
                    Console.Clear();
                    char ch = 'y';
                    Console.WriteLine("Do you want to add another customer? (y/n)");
                    ch = char.Parse(Console.ReadLine());
                    if (ch == 'y' || ch == 'Y')
                    {
                    customerRepositry.Create();
                    }
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
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}
