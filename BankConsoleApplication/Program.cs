using BankConsoleApplication.Repositry;
using BankConsoleApplication.Repositry.UserRepository;
using BankConsoleApplication.Services;
Console.WriteLine("****************Welcome To The Bank of Punjab*******************");
var customerRepository = new CustomerRepositry();
var accountRepository = new AccountRepositry();
var userRepository = new RegisterRepository();
var basicBankOperation = new BankServices(accountRepository, customerRepository);
var authService = new AuthService(userRepository);

authService.Register();
authService.Login();

while (true) 
{
    Console.WriteLine("1. for Manage Customer");
    Console.WriteLine("2. for Manage Account");
    Console.WriteLine("3. for Basic Bank Operations");
    Console.WriteLine("4. for Exit");

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
                            basicBankOperation.CreateCustomerWithAccount();
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
                res = accountRepository.ManageAccount();
                switch (res)
                {
                    case 1:
                        Console.WriteLine("Enter Customer ID to create Account:");
                        int CusID = int.Parse(Console.ReadLine());
                        basicBankOperation.CreateAccountByCustomerId(CusID);
                        break;
                    case 2:
                        accountRepository.ReadAll();
                        break;
                    case 3:
                        Console.WriteLine("Enter Account Number to Read:");
                        int readAccNum = int.Parse(Console.ReadLine());
                        accountRepository.Read(readAccNum);
                        break;
                    case 4:
                        Console.WriteLine("Enter Account Number to Update:");
                        int updateAccNum = int.Parse(Console.ReadLine());
                        accountRepository.Update(updateAccNum);
                        break;
                    case 5:
                        Console.WriteLine("Enter Account Number to Delete:");
                        int deleteAccNum = int.Parse(Console.ReadLine());
                        accountRepository.Delete(deleteAccNum);
                        break;
                    case 6:
                        Console.WriteLine("Returning to Main Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (res != 6);
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
                        Console.WriteLine("Enter source Account Number");
                        var fromAccountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter destination Account number");
                        var ToAccountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter amount to transfer");
                        var amountToTransfer = double.Parse(Console.ReadLine());
                        basicBankOperation.Transfer(fromAccountNumber, ToAccountNumber, amountToTransfer);
                        break;
                    case 4:
                        Console.WriteLine("Enter Account Number");
                        var InquiryaccountNumber = int.Parse(Console.ReadLine());
                        basicBankOperation.BalanceInquiry(InquiryaccountNumber);
                        break;
                    case 5:
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