using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using ToDo.Dto;

namespace ToDo.Repositoris
{
    public class TaskRepository : ITaskRepository
    {

        private readonly IConfiguration _configuration;

        public TaskRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private SqlConnection GetConnection()
        {
            string connectionString =  _configuration.GetConnectionString("DefaultConnection");
            return new SqlConnection(connectionString);
        }
    }

        public List<TaskDto> SelectAll()
        {
            using var connection = GetConnection();

            var tasks = connection.Query<TaskDto>(
                "uspSelectAll",
                commandType: CommandType.StoredProcedure
            ).ToList();

            return tasks;
        }
    }
}
