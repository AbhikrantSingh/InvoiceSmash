using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Subscription.Models;
using Subscription.Repostiory.IRepostiory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Subscription.Controllers
{

    [Route("api/subscription")]
    [ApiController]
    public class SubscriptionController : Controller
    {


        private readonly ISubscriptionRepostiory subscriptionRepostiory;
        public SubscriptionController(ISubscriptionRepostiory _subscriptionRepostiory)
        {
            subscriptionRepostiory = _subscriptionRepostiory;
        }
        [HttpGet]
        public ActionResult<IEnumerable<SubscriptionName>> GetSubscription()
        {

            return Ok(subscriptionRepostiory.getAllSubscription());
        }
        [HttpPut]
        public ActionResult<SubscriptionName> updateIsEnabled(SubscriptionName subscriptionName)
        {
            return Ok(subscriptionRepostiory.updateIsEnabled(subscriptionName));
        }

    }
}
