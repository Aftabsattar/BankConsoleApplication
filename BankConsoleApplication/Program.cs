using BankConsoleApplication.Repositry;
Console.WriteLine("****************Welome To The Bank of Punjab*******************");
var accountRepo = new AccountRepositry();
var customerRepositry = new CustomerRepositry(accountRepo);
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
                Console.WriteLine("Do you want to add another customer and his Account? (y/n)");
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
