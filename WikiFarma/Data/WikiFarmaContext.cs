using Microsoft.EntityFrameworkCore;
using WikiFarma.Models;

namespace WikiFarma.Data
{
    public class WikiFarmaContext : DbContext
    {
        public WikiFarmaContext(DbContextOptions<WikiFarmaContext> options) : base(options)
        {
        }

        public DbSet<Farmaco> Farmacos { get; set; }
    }
}
