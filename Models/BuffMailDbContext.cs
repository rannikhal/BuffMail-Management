using Microsoft.EntityFrameworkCore;

namespace BuffMail.Models
{
    public class BuffMailDbContext : DbContext
    {
        public BuffMailDbContext (DbContextOptions<BuffMailDbContext> options)
        : base(options)
        {
        }
        public DbSet<Staff> Staff {get;set;} = default!;
        public DbSet<Resident> Resident {get;set;} = default!;
        public DbSet<Package> Package {get;set;} = default!;
    }
}