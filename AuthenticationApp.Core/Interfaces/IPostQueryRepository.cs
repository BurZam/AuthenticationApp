using AuthenticationApp.Core.Entities;
using AuthenticationApp.Core.Interfaces.Base;

namespace AuthenticationApp.Core.Interfaces
{
    public interface IPostQueryRepository : IQueryRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetAll();

        Task<Post?> GetByIdAsync(int id);

        Task<IReadOnlyList<Post>> GetPostsByAuthor(string author);
    }
}
