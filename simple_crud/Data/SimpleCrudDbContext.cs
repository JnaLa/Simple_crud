using Microsoft.EntityFrameworkCore;
using simple_crud.Models;

namespace simple_crud.Data
{
    public class SimpleCrudDbContext: DbContext
    {

        public SimpleCrudDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Disc> Discs { get; set; }
    }
}
