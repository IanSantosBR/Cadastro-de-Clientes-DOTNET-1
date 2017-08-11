using System.Data.Entity;

namespace Cadastro_de_Clientes
{
    public class Database : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}
