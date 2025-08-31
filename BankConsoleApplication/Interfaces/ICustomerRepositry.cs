namespace BankConsoleApplication.Interfaces;

public interface ICustomerRepositry
{
    void Create();
    void Read(int id);
    void ReadAll();
    void Update(int id);
    void Delete(int id);
}