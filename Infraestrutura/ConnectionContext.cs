using Microsoft.EntityFrameworkCore;
using apiCadastro.Model;

namespace apiCadastro.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(local)\\SQLEXPRESS;" +
                "Database=cadastros;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True");
        }
    }
}
