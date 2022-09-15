using UserModel;

namespace Repositories
{
    public interface IUserRepository
    {
        bool AddUser(User u);
    }
}