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

//using NUnit.Framework; //testing 
using RiotNet.Models;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using RiotClient;
using System.Threading.Tasks;

namespace Klash_V2
{
    class riotAccess
    {
        public riotAccess()
        {
        }

        private player checkPlayer()
        {
            RiotClient newClient = new RiotClient();
        }
            
        
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
        }
    }
}