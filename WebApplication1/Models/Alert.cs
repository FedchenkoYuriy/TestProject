using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Alert
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public string Patrol { get; set; }
        public string Status { get; set; }
       
    }

    public class AlertDBContext : DbContext
    {
        public DbSet<Alert> Movies { get; set; }
    }
}