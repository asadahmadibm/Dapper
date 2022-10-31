using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Data;

namespace APIWithDapperTutorial.Entities
{
    public class SchoolContext
    {
        private IConfiguration _configuration;
        public SchoolContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection CreateConnection() => new SqlConnection(_configuration.GetConnectionString("SqlConnection"));
    }
}
