using BankConsoleApplication.Entities;

namespace BankConsoleApplication.Interfaces;

public interface IAccountRepositry
{
    Account Create();
    void Read(int accountNumber);
    void ReadAll();
    void Update(int accountNumber);
    void Delete(int accountNumber);
}