using Microsoft.EntityFrameworkCore;
using SPG_Fachtheorie.Aufgabe1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPG_Fachtheorie.Aufgabe1.Infrastructure
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<UserPremium> UserPremiums => Set<UserPremium>();
        public DbSet<UserStandard> UserStandards => Set<UserStandard>();
        public DbSet<Podcast> Podcasts => Set<Podcast>();
        public DbSet<Category> Categorys => Set<Category>();
        public DbSet<Favorite> Favorites => Set<Favorite>();
        public DbSet<RadioStation> RadioStations => Set<RadioStation>();
        public DbSet<Rating> Ratings => Set<Rating>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasDiscriminator(o => o.UserType);
        }
    }
}

//Infrastructure/UnserContext