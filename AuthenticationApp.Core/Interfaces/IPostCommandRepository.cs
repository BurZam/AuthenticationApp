using AuthenticationApp.Core.Entities;
using AuthenticationApp.Core.Interfaces.Base;

namespace AuthenticationApp.Core.Interfaces
{
    public interface IPostCommandRepository : ICommandRepository<Post>
    {
    }
}
