using WhatsArt.Data;
using WhatsArt.Models;
using WhatsArt.Repositories.Interfaces;

namespace WhatsArt.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {

        private ApplicationDbContext dbContext;

        private IUserRepository? userRepository;
        private IPostRepository? postRepository;

        public IUserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(dbContext);
                }

                return userRepository;
            }
        }

        public IPostRepository PostRepository
        {
            get
            {
                if (postRepository == null)
                {
                    postRepository = new PostRepository(dbContext);
                }

                return postRepository;
            }
        }

        public RepositoryWrapper(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

    }
}