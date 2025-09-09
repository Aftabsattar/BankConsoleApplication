using BankConsoleApplication.Repositry.UserRepository;

namespace BankConsoleApplication.Services;

public class AuthService
{
    private readonly RegisterRepository _registerRepository;
    public AuthService(RegisterRepository registerRepository)
    {
        _registerRepository = registerRepository;
    }

    public void Register()
    {
        var user = _registerRepository.Create();
        if (user != null)
        {
            Console.WriteLine($"User {user.UserName} registered successfully!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
        else
        {
            Console.WriteLine("Registration failed. Please try again.");
        }
    }
    public void Login()
    {
        while (true)
        {
            Console.WriteLine("++++++++++++++++Please login to continue.++++++++++++++++");
            var user = _registerRepository.Login();
            if (user != null)
            {
                GenerateOTP();
                Console.WriteLine($"{user.UserName} Login Successfully!\n*******************************");
                break;
            }
            else
            {
                Console.WriteLine("Invalid email or password. Please try again.");
            }
        }
    }

    public void GenerateOTP()
    {
        var otp = new Random().Next(100000, 999999);
        Console.WriteLine($"Your OTP is: {otp}");
        Console.WriteLine("Please enter the OTP:");
        var inputOtp = Console.ReadLine();
        if (inputOtp == otp.ToString())
        {
            Console.WriteLine("OTP verified successfully.\n");
        }
        else
        {
            Console.WriteLine("\nInvalid OTP. Please try again.");
        }
    }
}