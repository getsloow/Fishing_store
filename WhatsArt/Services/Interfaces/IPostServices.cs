using WhatsArt.Models;

namespace WhatsArt.Services.Interfaces
{
    public interface IPostServices
    {
       public List<Post> GetAllPosts();

        public void CreatePost(Post obj);
    }
}
