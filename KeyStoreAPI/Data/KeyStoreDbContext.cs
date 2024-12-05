using KeyStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace KeyStoreAPI.Data
{
    public class KeyStoreDbContext : DbContext
    {
        public KeyStoreDbContext(DbContextOptions<KeyStoreDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Key> Keys { get; set; }

    }
}

