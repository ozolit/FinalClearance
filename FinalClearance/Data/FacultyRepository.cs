using FinalClearance.Models;
using Microsoft.Data.SqlClient;

namespace FinalClearance.Data
{
    public class FacultyRepository
    {
        private readonly SqlConnection _connectionString;
        public FacultyRepository(IConfiguration configuration)
        {
            _connectionString = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));

        }
        //public async List<Faculty> GetFacultieAsync()
        //{
        //    await _connectionString.OpenAsync();
        //    return Faculty.ToList()
        //}
    }
}
