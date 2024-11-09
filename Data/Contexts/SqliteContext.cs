using ExcursonatorAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExcursonatorAPI.Data.Contexts
{
    public class SqliteContext : DbContext
    {
        public DbSet<Excursion> Excursions { get; set; }

        public SqliteContext(DbContextOptions<SqliteContext> options) : base(options)
        {
        }
    }
}
