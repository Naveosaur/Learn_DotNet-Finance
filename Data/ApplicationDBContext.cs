using dotnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace dotnet.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<Comments> Comments { get; set; }
        
        
    }
}  