using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OrderLife.Models {
    public class Login {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginDBContext : DbContext {
        public DbSet<Login> Login { get; set; }
    }
}