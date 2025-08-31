namespace BankConsoleApplication.Interfaces;

public interface ICustomerRepositry
{
    void Create();
    void Read();
    void Update(int id);
    void Delete(int id);
}