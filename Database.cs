using System;
public class Database : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
}
