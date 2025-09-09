using BankConsoleApplication.Entities.User;

namespace BankConsoleApplication.Interfaces.IUser;

public interface IRegisterRepository
{
    Register Create();
    void Delete(int id);
    void Update(int id);
    void Read();
}