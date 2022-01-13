using System;
using Microsoft.EntityFrameworkCore;
using nl.Commen.Models;

namespace nl.Commen.Interfaces
{
    public interface INlContext : IDbContext, IDisposable
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Chat> Chats { get; set; }
    }
}