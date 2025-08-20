using WebPhim.Models;
namespace WebPhim.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByEmail( string email);
        void Register(User user, string password);
        bool CheckPassword(User user, string password);

        User GetById(string userID);
    }
}
