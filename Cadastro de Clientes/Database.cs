using System.Data.Entity;

namespace Cadastro_de_Clientes
{
    public class Database : DbContext
    {
        public Database(string connectionString) : base(connectionString)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}