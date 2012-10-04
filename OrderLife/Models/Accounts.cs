using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OrderLife.Models
{
    public class Accounts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string OtherInfo { get; set; }
    }
    
    public class AccountsDBContext : DbContext
    {
        public DbSet<Accounts> Accounts { get; set; }
    }
}