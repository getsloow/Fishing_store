using WhatsArt.Models;
using WhatsArt.Repositories;
using WhatsArt.Repositories.Interfaces;
using WhatsArt.Services.Interfaces;

namespace WhatsArt.Services
{
    public class PostServices : IPostServices
    {
        private IRepositoryWrapper _repositoryWrapper;

        public PostServices(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
            
        }

        public void CreatePost(Post _obj)
        {
            _repositoryWrapper.PostRepository.Create(_obj);
            _repositoryWrapper.Save();
        }

        public List<Post> GetAllPosts()
        {
            var posts = new List<Post>();
            posts = _repositoryWrapper.PostRepository.FindAll().ToList();
            return posts;
        }

        
    }
}
