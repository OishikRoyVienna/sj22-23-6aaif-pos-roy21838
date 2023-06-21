using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SPG_Fachtheorie.Aufgabe2.Domain;
using SPG_Fachtheorie.Aufgabe2.Infrastructure;

namespace SPG_Fachtheorie.Aufgabe2.Services
{
    public class PodcastService
    {
        private readonly PodcastContext _db;
        public PodcastService(PodcastContext db)
        {
            _db = db;
        }
        public bool CalcTotalCosts(int customerId, DateTime begin, DateTime end)
        {
            
            var customer = _db.Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer == null) { return false; }
            if (customer.TotalCosts != 0.0M) { return false; }
            if (end < begin) { return false; }
            

            decimal totalCosts = 0;
            


            var customer_advertisements = customer.Advertisements.ToList();
            if(!customer_advertisements.Any()) { return false; }
            
            foreach (Advertisement advertisement in  customer_advertisements)
            {
                foreach(ListenedItem listenedItem in advertisement.ListenedItems)
                {
                    if(listenedItem.Timestamp >= begin && listenedItem.Timestamp <= end)
                    {
                        totalCosts += advertisement.CostsPerPlay;
                    }
                }
            }

            customer.TotalCosts = totalCosts;
            _db.SaveChanges();

            return true;
        }


        public int CalcQuantityAdditionalAds(int playlistId)
        {
            throw new NotImplementedException("Noch keine Implementierung vorhanden");
        }

        public bool AddPostionForAd(int itemId, int position)
        {
            throw new NotImplementedException("Noch keine Implementierung vorhanden");
        }
    }
}