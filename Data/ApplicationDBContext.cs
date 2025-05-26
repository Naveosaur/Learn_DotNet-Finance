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

        public DbSet<Stock> Stock { get; set; }
        public DbSet<Comment> Comment { get; set; }
        
        
    }
}  