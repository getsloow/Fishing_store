using WhatsArt.Data;
using WhatsArt.Models;
using WhatsArt.Repositories.Interfaces;

namespace WhatsArt.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {

        public UserRepository(ApplicationDbContext tripContext) : base(tripContext) { }

    }
}