using WhatsArt.Models;

namespace WhatsArt.Services.Interfaces
{
    public interface IUserService
    {

        List<User> GetUsers();

        void Create(User user);


    }
}
