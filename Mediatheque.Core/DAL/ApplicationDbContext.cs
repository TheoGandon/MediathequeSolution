using Mediatheque.Core.Model;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Mediatheque.Core.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CD> CDs { get; set; }
        public DbSet<JeuxDeSociete> Jeux { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=5432;Database=Mediatheque;Uid=postgres;Pwd=multimedia";
            var serverVersion = new Version(8, 0, 34);
            optionsBuilder.UseNpgsql(connectionString, o => o.SetPostgresVersion(serverVersion));
        }
    }
}
