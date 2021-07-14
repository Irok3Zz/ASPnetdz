using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace krynkoASP1407.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers{ get; set; }
        public DbSet<Publisher> Publishers{ get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Game>(b =>
            {
                b.Property(e => e.Tags).HasConversion<string>(
                    array => JsonSerializer.Serialize(array, null),
                    str => JsonSerializer.Deserialize<HashSet<string>>(str, null));
            });
        }

    }
}
