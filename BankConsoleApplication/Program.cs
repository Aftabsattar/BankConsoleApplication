using BankConsoleApplication.Repositry;
Console.WriteLine("****************Welcome To The Bank of Punjab*******************");
var customerRepository = new CustomerRepositry();
var accountRepository = new AccountRepositry();
var basicBankOperation = new BankServices(accountRepository, customerRepository);

while (true) 
{
    Console.WriteLine("1. for Manage Customer");
    Console.WriteLine("2. for Manage Account");
    Console.WriteLine("3. for Basic Bank Operations");
    Console.WriteLine("4. for Exit");
    Console.WriteLine("your choice:");
    
    var choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            int result;
            do
            {
                result = customerRepository.ManageCustomer();
                switch (result)
                {
                    case 1:
                        char ch;
                        do
                        {
                            customerRepository.Create();
                            Console.Clear();
                            Console.WriteLine("Do you want to add another customer and his Account? (y/n)");
                            ch = char.Parse(Console.ReadLine());
                        } while (ch == 'y' || ch == 'Y');
                        break;
                    case 2:
                        customerRepository.ReadAll();
                        break;
                    case 3:
                        Console.WriteLine("Enter Customer ID to Read:");
                        int readId = int.Parse(Console.ReadLine());
                        customerRepository.Read(readId);
                        break;
                    case 4:
                        Console.WriteLine("Enter Customer ID to Update:");
                        int updateId = int.Parse(Console.ReadLine());
                        customerRepository.Update(updateId);
                        break;
                    case 5:
                        Console.WriteLine("Enter Customer ID to Delete:");
                        int deleteId = int.Parse(Console.ReadLine());
                        customerRepository.Delete(deleteId);
                        break;
                    case 6:
                        Console.WriteLine("Returning to Main Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (result != 6); 
            break;

        case 2:
         int res;
            do {
                Console.Clear();
                res = accountRepository.ManageAccount();
                switch (res)
                {
                    case 1:
                        char ch;
                        do
                        {
                            accountRepository.Create();
                            Console.Clear();
                            Console.WriteLine("Do you want to add another Account? (y/n)");
                            ch = char.Parse(Console.ReadLine());
                        } while (ch == 'y' || ch == 'Y');
                        break;
                    case 2:
                        Console.WriteLine("Enter Customer ID to create Account:");
                        int CusID = int.Parse(Console.ReadLine());
                        basicBankOperation.CreateAccountByCustomerId(CusID);
                        break;
                    case 3:
                        Console.WriteLine("Enter Account Number to Delete:");
                        int deleteAccNum = int.Parse(Console.ReadLine());
                        accountRepository.Delete(deleteAccNum);
                        break;
                    case 4:
                        Console.WriteLine("Enter Account Number to Read:");
                        int readAccNum = int.Parse(Console.ReadLine());
                        accountRepository.Read(readAccNum);
                        break;
                    case 5:
                        accountRepository.ReadAll();
                        break;
                    case 6:
                        Console.WriteLine("Enter Account Number to Update:");
                        int updateAccNum = int.Parse(Console.ReadLine());
                        accountRepository.Update(updateAccNum);
                        break;
                    case 7:
                        Console.WriteLine("Returning to Main Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (res != 7);
            break;
        case 3:
            int resu;
            do 
            {
                Console.Clear();
                resu = basicBankOperation.ManageBasicOperation();
                switch (resu)
                {
                    case 1:
                        Console.WriteLine("Enter Account Number");
                        var accountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Amount for Deposit");
                        var amount = double.Parse(Console.ReadLine());
                        basicBankOperation.Deposit(accountNumber, amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter Account Number");
                        var WithaccountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter amount for withdraw");
                        var WithDrawAmount = int.Parse(Console.ReadLine());
                        basicBankOperation.Withdraw(WithaccountNumber, WithDrawAmount);
                        break;
                    case 3:
                        Console.WriteLine("Enter Account Number");
                        var InquiryaccountNumber = int.Parse(Console.ReadLine());
                        basicBankOperation.BalanceInquiry(InquiryaccountNumber);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                
            }while(resu  != 5);
            break;

        case 4:
            Console.WriteLine("Thanks for using Bank of Punjab!");
            return; 
    }
}