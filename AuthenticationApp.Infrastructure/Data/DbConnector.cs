using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace AuthenticationApp.Infrastructure.Data
{
    public class DbConnector
    {
        private readonly IConfiguration _configuration;

        protected DbConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            var _connectionString = this._configuration.GetConnectionString("DefaultConnection");

            return new SqliteConnection(_connectionString);
        }
    }
}
