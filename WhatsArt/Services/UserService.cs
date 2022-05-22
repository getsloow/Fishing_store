using WhatsArt.Models;
using WhatsArt.Repositories.Interfaces;
using WhatsArt.Services.Interfaces;

namespace WhatsArt.Services
{
    public class UserService : IUserService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public UserService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        public void Create(User user)
        {
            _repositoryWrapper.UserRepository.Create(user);
            _repositoryWrapper.Save();
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();
            users = _repositoryWrapper.UserRepository.FindAll().ToList();
            return users;
        }


    }
}
