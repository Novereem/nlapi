using Microsoft.EntityFrameworkCore;
using nl.Commen.Models;

namespace nl.Data
{
    public class NlContext : DbContext
    {
        
        public DbSet<Account> Accounts { get; set; }
        
        public NlContext(DbContextOptions<NlContext> options)
            : base(options)
        {
            
        }
    }
}