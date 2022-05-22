using System.Data.Entity;
using WhatsArt.Data;
using WhatsArt.Models;
using WhatsArt.Repositories;
using WhatsArt.Repositories.Interfaces;
using WhatsArt.Services.Interfaces;

namespace WhatsArt.Services
{
    public class PostServices : IPostServices
    {
        private IRepositoryWrapper _repositoryWrapper;
        private readonly ApplicationDbContext _dbContext;

        public PostServices(IRepositoryWrapper repositoryWrapper, ApplicationDbContext dbContext)
        {
            _repositoryWrapper = repositoryWrapper;
            this._dbContext = dbContext;
        }

        public void Create(Post post)
        {
            _repositoryWrapper.PostRepository.Create(post);
            _repositoryWrapper.Save();
        }

        public List<Post> GetPosts()
        {
            var posts = new List<Post>();
            posts = _repositoryWrapper.PostRepository.FindAll().ToList();
            return posts;
        }

        public IEnumerable<Post> GetUserPosts(int id)
        {
            var posts = _dbContext.Posts.Include("User").Where(x => x.UserId == id).ToList();
            return posts;
        }
    }
}
