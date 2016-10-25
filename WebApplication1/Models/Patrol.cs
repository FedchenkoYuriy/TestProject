using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Patrol
    {
        public int ID { get; set; }
        public string PatrolN { get; set; }
        public string CarN { get; set; }
        public string Status { get; set; }
        
    }

    public class PatrolDBContext : DbContext
    {
        public DbSet<Patrol> Movies { get; set; }
    }
}