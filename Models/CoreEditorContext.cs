using Microsoft.EntityFrameworkCore;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using CoreEditor.Models;

namespace CoreEditor.Models
{
    public class CoreEditorContext : DbContext
    {
        public string ConnectionString { get; set; }

        public CoreEditorContext(DbContextOptions<CoreEditorContext> options, IConfiguration config)
        : base(options)
        {
            ConnectionString = config.GetConnectionString("default");
        }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Material> Material { get; set; }

        public IDbConnection Connect()
        {
            var connection = new MySqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
