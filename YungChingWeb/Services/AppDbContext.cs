using System;
using System.Data.Entity;
using System.Web;
using YungChingWeb.Models;

namespace YungChingWeb.Services
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {
        }

        /// <summary>
        /// DbSet 對應資料表 Customers
        /// </summary>
        public DbSet<Customer> Customers { get; set; }
    }
}
