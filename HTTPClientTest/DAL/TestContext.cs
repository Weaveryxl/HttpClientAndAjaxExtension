using HTTPClientTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HTTPClientTest.DAL
{
    public class TestContext : DbContext
    {
        public TestContext() : base("TestContext")
        {
            this.Configuration.AutoDetectChangesEnabled = true;
        }

        public DbSet<User> Users { get; set; }
    }
}