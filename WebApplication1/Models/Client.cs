using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public string PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        
    }

    public class ClientDBContext : DbContext
    {
        public DbSet<Client> Movies { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Patrol> Patrols { get; set; }
    }
}