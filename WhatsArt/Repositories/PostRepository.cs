using WhatsArt.Data;
using WhatsArt.Models;
using WhatsArt.Repositories.Interfaces;

namespace WhatsArt.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {

        public PostRepository(ApplicationDbContext tripContext) : base(tripContext) { }

    }
}