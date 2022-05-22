using WhatsArt.Models;

namespace WhatsArt.Services.Interfaces
{
    public interface IPostServices
    {
        List<Post> GetPosts();

        void Create(Post post);
        IEnumerable<Post> GetUserPosts(int id);
    }
}
