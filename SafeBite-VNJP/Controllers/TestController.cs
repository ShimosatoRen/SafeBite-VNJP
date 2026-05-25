using Microsoft.AspNetCore.Mvc;
using Npgsql;
using SafeBite_VNJP.Models;

namespace SafeBite_VNJP.Controllers
{
    public class TestController : Controller
    {
        private readonly IConfiguration _configuration;

        public TestController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var users = new List<Test>();

            var connectionString =
                _configuration.GetConnectionString("DefaultConnection");

            using var connection =
                new NpgsqlConnection(connectionString);

            connection.Open();

            var sql = "SELECT id, name FROM test";

            using var command =
                new NpgsqlCommand(sql, connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new Test
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }

            return View(users);
        }
    }
}