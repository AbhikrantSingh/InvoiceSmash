using Subscription.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Subscription.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<SubscriptionName> Subscriptions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubscriptionName>().HasData(
                   new SubscriptionName()
                   {
                    Id = 1,
                    Subscription_Name="invoice-smash-master-test@coupadev.com",
                    Is_Enabled =true

                   },
                   new SubscriptionName()
                   {
                       Id = 2,
                       Subscription_Name = "invoice-smash-dashmaster3@coupadev.com",
                       Is_Enabled = true

                   },
                    new SubscriptionName()
                    {
                        Id = 3,
                        Subscription_Name = "invoice-smash-master@coupadev.com",
                        Is_Enabled = true
                    }
                    ,
                    new SubscriptionName()
                    {
                        Id = 4,
                        Subscription_Name = "invoice-smash-mlgateKeeper@coupadev.com",
                        Is_Enabled = true
                    }

                );
        }
    }
    }
