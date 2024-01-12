using AuthenticationApp.Core.Entities;
using AuthenticationApp.Core.Interfaces;
using AuthenticationApp.Infrastructure.Repositories.Queries.Base;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace AuthenticationApp.Infrastructure.Repositories.Queries
{
    public class UserQueryRepository : QueryRepository<Post>, IPostQueryRepository
    {
        protected UserQueryRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<IReadOnlyList<Post>> GetAll()
        {
            try
            {
                var query = "SELECT * FROM POSTS";

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Post>(query)).ToList();
                }
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<Post?> GetByIdAsync(int id)
        {
            try
            {
                var query = "SELECT * FROM POSTS WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    var post = await connection.QueryFirstOrDefaultAsync<Post>(query, parameters);

                    return post;
                }
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<IReadOnlyList<Post>> GetPostsByAuthor(string author)
        {
            try
            {
                var query = "SELECT * FROM POSTS WHERE Author = @Author";
                var parameters = new DynamicParameters();
                parameters.Add("Author", author, DbType.String);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Post>(query, parameters)).ToList();
                }
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message, exp);
            }
        }
    }
}
