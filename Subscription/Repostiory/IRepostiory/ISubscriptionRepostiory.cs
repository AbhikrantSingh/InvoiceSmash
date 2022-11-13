using Subscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Subscription.Repostiory.IRepostiory
{
    public interface ISubscriptionRepostiory
    {
        public IEnumerable<SubscriptionName> getAllSubscription();
        public SubscriptionName updateIsEnabled(SubscriptionName subscriptionName);
    }
}
