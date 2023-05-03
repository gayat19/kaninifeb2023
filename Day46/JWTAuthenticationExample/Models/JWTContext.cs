using Microsoft.EntityFrameworkCore;
using JWTAuthenticationExample.Models;

namespace JWTAuthenticationExample.Models
{
    public class JWTContext :DbContext
    {

        public JWTContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
