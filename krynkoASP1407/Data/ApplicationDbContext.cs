using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using krynkoASP1407.Data;

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
        public DbSet<krynkoASP1407.Data.Tag> Tag { get; set; }

    }
}
