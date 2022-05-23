using WhatsArt.Models;

namespace WhatsArt.Services.Interfaces
{
    public interface IPostServices
    {
        List<Post> GetPosts();

        void Create(Post post);
        IEnumerable<Post> GetUserPosts(int id);

        Post GetPostById(int? id);


        void Delete(int id);

        void EditPost(Post obj);
    }
}
