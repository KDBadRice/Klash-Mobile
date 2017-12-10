using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

//using NUnit.Framework; //testing framework
using RiotNet.Models;
using System.Reflection;
using System.Threading.Tasks;
//using Microsoft.
using System.Data;
using RiotNet;

namespace Klash_V2
{
    class dataConfig
    {

        private string playerName;
        private IRiotClient newClient;
        public dataConfig(String summonerName)
        {
            ShouldCreateClientWithNonDefaultSettings();
            playerName = summonerName;
        }
        public void ShouldCreateClientWithNonDefaultSettings()
        {
            var apiKey = "RGAPI-b749ff4f-be0c-4c89-886a-5685e3d4012a"; // No, this is not a real API key. It's just used for this test.

            newClient = new RiotClient(new RiotClientSettings
            {
                ApiKey = apiKey,
                RetryOnTimeout = true,
                RetryOnConnectionFailure = true,
                RetryOnRateLimitExceeded = true
            }, PlatformId.NA1);
            //int testInt = 1;
        }
        public long checkPlayer()
        {
            Summoner playerSummoner = newClient.GetSummonerBySummonerNameAsync("Bad rice").Result;
            long accountNum;

            if (playerSummoner != null)
            {
                accountNum = playerSummoner.AccountId;
            }
            else { accountNum = 1012315; }
            return accountNum;
        }

    


        /*
        private static void VerifyDbStorage<T>() where T : class
        {
            ResetSampleValues();
            var value = Create<T>();
            var dbSetProperty = typeof(TestDbContext).GetProperties().First(p => p.PropertyType == typeof(DbSet<T>));
            // Try to save the value to the database and make sure there are no errors.
            using (var context = new TestDbContext())
            {
                var dbSet = (DbSet<T>)dbSetProperty.GetValue(context);
                dbSet.Add(value);
                context.SaveChanges();
            }

            // Re-create the object because 'value' may have been modified by Entity Framework during SaveChanges().
            ResetSampleValues();
            var expectedValue = Create<T>();

            // Use a new context to ensure that we aren't getting cached data.
            using (var context = new TestDbContext())
            {
                // Read the value from the database and make sure all properties are set.
                var dbSet = (DbSet<T>)dbSetProperty.GetValue(context);
                var dbValue = dbSet.First();
                AssertObjectEqualityRecursive(dbValue, expectedValue, forDatabase: true);
            }
        }*/
    }
}