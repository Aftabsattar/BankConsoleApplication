using BankConsoleApplication.Entities;

namespace BankConsoleApplication.Interfaces;

public interface ICustomerRepositry
{
    Customer Create();
    void Read(int id);
    void ReadAll();
    void Update(int id);
    void Delete(int id);
}