using Subscription.Data;
using Subscription.Models;
using Subscription.Repostiory.IRepostiory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Subscription.Repostiory
{
    public class SubscriptionRepostiory : Repostiory<SubscriptionName>, ISubscriptionRepostiory
    {
        private readonly ApplicationDbContext _db;

        public SubscriptionRepostiory(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SubscriptionName> getAllSubscription()
        {
            return _db.Subscriptions.ToList();
        }

        public SubscriptionName updateIsEnabled(SubscriptionName subscriptionName)
        {
            var subs = _db.Subscriptions.FirstOrDefault(s=>s.Subscription_Name==subscriptionName.Subscription_Name);
            subs.Subscription_Name = subscriptionName.Subscription_Name;
            subs.Is_Enabled = !subscriptionName.Is_Enabled;
            _db.Subscriptions.Update(subs);
            _db.SaveChanges();
            return subs;
        }


    }
}
