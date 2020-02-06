using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PhoneApplication.Models;

namespace PhoneApplication
{
    public class DataContext : DbContext
    {
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public object Manufacturer {get; internal set;}
    }
}