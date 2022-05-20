namespace WhatsArt.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {

        IUserRepository UserRepository { get; }

        IPostRepository PostRepository { get; }


        void Save();

    }
}

