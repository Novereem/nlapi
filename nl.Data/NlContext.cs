using Microsoft.EntityFrameworkCore;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Data
{
    public class NlContext : DbContext, INlContext
    {
        
        public DbSet<Account> Accounts { get; set; }
        
        public NlContext(DbContextOptions<NlContext> options)
            : base(options)
        {
            
        }
    }
}