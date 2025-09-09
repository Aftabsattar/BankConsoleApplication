using BankConsoleApplication.Entities.User;
using BankConsoleApplication.Interfaces.IUser;

namespace BankConsoleApplication.Repositry.UserRepository;

public class RegisterRepository : IRegisterRepository
{
    List<Register> UserList = new List<Register>();
    public Register Create()
    {
        Register user = new Register();
        Console.WriteLine();
        Console.WriteLine("---------Please enter your details. for SignUp---------\n");
        Console.Write("Enter User ID: ");
        if(int.TryParse(Console.ReadLine(),out int Id)) 
        {
            user.Id = Id;
        }
        else 
        {
            Console.WriteLine("Invalid Input");
        }
        Console.Write("Enter your Name: ");
        user.UserName = Console.ReadLine();
        Console.Write("Enter your Email: ");
        user.Email = Console.ReadLine();
        Console.Write("Enter your Password: ");
        user.Password = Console.ReadLine();
        UserList.Add(user);
        return user;
    }

    public void Delete(int id)
    {
       var user = UserList.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            UserList.Remove(user);
            Console.WriteLine($"User with ID {id} deleted successfully.\n Press any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"User with ID {id} not found.");
        }
    }

    public void Read()
    {
        Console.WriteLine("User List:");
        if (UserList.Count == 0)
        {
            Console.WriteLine("No users available.");
            return;
        }
        foreach (var user in UserList)
        {
            Console.Write($"ID: {user.Id}, Name: {user.UserName}, Email: {user.Email}");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void Update(int id)
    {
        var user = UserList.FirstOrDefault(u => u.Id == id);
        if (user != null)
        {
            Console.WriteLine("Enter new Name");
            user.UserName = Console.ReadLine();
            Console.WriteLine("Enter new Email");
            user.Email = Console.ReadLine();
            Console.WriteLine("Enter new Password");
            user.Password = Console.ReadLine();
            Console.WriteLine($"User with ID {id} updated successfully.\n Press any key to continue...");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"User with ID {id} not found.");
        }
    }

    public Register Login() 
    {        
        Console.Write("Enter your Email: ");
        string email = Console.ReadLine();
        Console.Write("Enter your Password: ");
        string password = Console.ReadLine();
        var user = UserList.FirstOrDefault(u => u.Email == email && u.Password == password);
        return user;
    }
}