using BankConsoleApplication.Entities;
using BankConsoleApplication.Interfaces;

namespace BankConsoleApplication.Repositry;

public class CustomerRepositry : ICustomerRepositry
{
  private List<Customer> obj = new List<Customer>();
  private readonly AccountRepositry _accountRepo; 
    public CustomerRepositry(AccountRepositry accountRepo) 
    {
        _accountRepo = accountRepo; 
    }

    public void Create()
    {
        Customer customer = new Customer();
        Console.Write("Enter customer ID:");
        customer.ID = int.Parse(Console.ReadLine());
        Console.Write("Enter Customer Name:");
        customer.Name = Console.ReadLine();
        Console.Write("Enter Customer Email:");
        customer.Email = Console.ReadLine();
        Console.Write("Enter Customer Phone:");
        customer.Phone = Console.ReadLine();
        Console.Write("Enter Customer Address:");
        customer.Address = Console.ReadLine();
        var account = _accountRepo.Create();
        customer.Accounts.Add(account);
        obj.Add(customer);
        Console.WriteLine($"\n{customer.Name} Created successfully\nPress any key to continue...");
        Console.ReadKey();
    }
    public void ReadAll()
    {
        foreach (var cust in obj)
        {
            Console.WriteLine($"--------{cust.Name} Details--------:");
            Console.WriteLine($"Customer Id is:{cust.ID}\n");
            Console.WriteLine($"Your Name is:{cust.Name}\n");
            Console.WriteLine($"your Email is:{cust.Email}\n");
            Console.WriteLine($"your Phone number:{cust.Phone}\n");
            Console.WriteLine($"your Address is:{cust.Address}\n");
            if(cust.Accounts.Count > 0)
            {
               Console.WriteLine("Accounts:");
                foreach (var acc in cust.Accounts)
                {
                    Console.WriteLine($"Account Number: {acc.AccountNumber}\n");
                    Console.WriteLine($"Account Type: {acc.AccountType}\n");
                    Console.WriteLine($"Balance: {acc.Balance}\n");
                    Console.WriteLine($"Created On: {acc.OnCreated}\n");
                }
            }
            else
            {
                Console.WriteLine("No accounts found for this customer.\n");
            }

        }
    }
    public void Update(int id)
    {
        var customerToUpdate = obj.Find(c => c.ID == id);
        if (customerToUpdate != null)
        {
            Console.WriteLine("Enter Customer Name:");
            customerToUpdate.Name = Console.ReadLine();
            Console.WriteLine("Enter Customer Email:");
            customerToUpdate.Email = Console.ReadLine();
            Console.WriteLine("Enter Customer Phone:");
            customerToUpdate.Phone = Console.ReadLine();
            Console.WriteLine("Enter Customer Address:");
            customerToUpdate.Address = Console.ReadLine();
            Console.WriteLine($"{customerToUpdate.Name} Updated successfully");
        }
        else
        {
            Console.WriteLine("Customer not found");
        }
    }
    public void Read(int id)
    {
        var customer = obj.Find(c => c.ID == id);
        if (customer != null)
        {
            Console.WriteLine($"--------{customer.Name} Details--------:");
            Console.WriteLine($"Customer Id is:{customer.ID}\n");
            Console.WriteLine($"Your Name is:{customer.Name}\n");
            Console.WriteLine($"your Email is:{customer.Email}\n");
            Console.WriteLine($"your Phone number:{customer.Phone}\n");
            Console.WriteLine($"your Address is:{customer.Address}\n");
            if(customer.Accounts.Count > 0)
            {
               Console.WriteLine("Accounts:");
                foreach (var acc in customer.Accounts)
                {
                    Console.WriteLine($"Account Number: {acc.AccountNumber}\n");
                    Console.WriteLine($"Account Type: {acc.AccountType}\n");
                    Console.WriteLine($"Balance: {acc.Balance}\n");
                    Console.WriteLine($"Created On: {acc.OnCreated}\n");
                }
            }
            else
            {
                Console.WriteLine("No accounts found for this customer.\n");
            }
        }
        else
        {
            Console.WriteLine("Customer not found");
        }
    }
    public void Delete(int id)
    {
        var customerToDelete = obj.Find(c => c.ID == id);
        if (customerToDelete != null)
        {
            obj.Remove(customerToDelete);
            Console.WriteLine("Customer Deleted successfully");
            if(customerToDelete.Accounts.Count > 0)
            {
                foreach (var acc in customerToDelete.Accounts)
                {
                    _accountRepo.Delete(acc.AccountNumber);
                }
            }
            else
            {
                Console.WriteLine("No accounts found for this customer.\n");
            }

        }
        else
        {
            Console.WriteLine("Customer not found");
        }
    }

    public int ManageCustomer()
    {
        Console.WriteLine("Press 1 for Create Customer");
        Console.WriteLine("Press 2 for Read All Customer");
        Console.WriteLine("Press 3 for Read by id of Customers");
        Console.WriteLine("Press 4 for Update Customer");
        Console.WriteLine("Press 5 for Delete Customer");
        Console.WriteLine("Press 6 for Exit");
        return int.Parse(Console.ReadLine());
    }
}