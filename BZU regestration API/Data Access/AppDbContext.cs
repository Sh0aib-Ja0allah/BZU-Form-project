using BZU_regestration_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace BZU_regestration_API.Data_Access
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                        
        }
        public DbSet<User> Users { get; set; }
    }
}
