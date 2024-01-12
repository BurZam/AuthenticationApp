using AuthenticationApp.Core.Entities;
using AuthenticationApp.Core.Interfaces;
using AuthenticationApp.Infrastructure.Data;
using AuthenticationApp.Infrastructure.Repositories.Commands.Base;

namespace AuthenticationApp.Infrastructure.Repositories.Commands
{
    public class PostCommandRepository : CommandRepository<Post>, IPostCommandRepository
    {
        public PostCommandRepository(DataContext _context) : base(_context)
        {
        }
    }
}
