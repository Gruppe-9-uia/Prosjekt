using Prosjekt.Models;

namespace Prosjekt.Data
{
    public class ProsjektContext : DbContext
    {
        public ProsjektContext(DbContextOptions<ProsjektContext> options) : base (options) { }

        public DbSet<SjekklisteModel> Sjekkliste { get; set; }
    }
}
