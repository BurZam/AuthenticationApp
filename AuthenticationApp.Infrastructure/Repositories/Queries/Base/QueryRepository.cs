using AuthenticationApp.Core.Interfaces.Base;
using AuthenticationApp.Infrastructure.Data;
using Microsoft.Extensions.Configuration;

namespace AuthenticationApp.Infrastructure.Repositories.Queries.Base
{
    public class QueryRepository<T> : DbConnector, IQueryRepository<T> where T : class
    {
        protected QueryRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
