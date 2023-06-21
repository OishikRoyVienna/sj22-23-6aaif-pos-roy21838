using SPG_Fachtheorie.Aufgabe2.Infrastructure;
using SPG_Fachtheorie.Aufgabe2.Services;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace SPG_Fachtheorie.Aufgabe2.Test
{
    public class DatabaseContextTest
    {
        private PodcastContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder()
                .UseSqlite(@"Data Source=Podcast.db")
                .Options;

            var db = new PodcastContext(options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            db.Seed();
            return db;
        }


        [Fact()]
        public void CalcTotalCosts_Invalid_CustomerId()
        {
            throw new NotImplementedException("Noch keine Implementierung vorhanden");
        }
        [Fact()]
        public void CalcTotalCosts_TotalCosts_Already_Calculated()
        {
            throw new NotImplementedException("Noch keine Implementierung vorhanden");
        }
        [Fact()]
        public void CalcTotalCosts_Invalid_TimePeriod()
        {
            throw new NotImplementedException("Noch keine Implementierung vorhanden");
        }
        [Fact()]
        public void CalcTotalCosts_No_Advertisements()
        {
            throw new NotImplementedException("Noch keine Implementierung vorhanden");
        }
        [Fact()]
        public void CalcTotalCosts_Success()
        {
            throw new NotImplementedException("Noch keine Implementierung vorhanden");
        }
    }
}