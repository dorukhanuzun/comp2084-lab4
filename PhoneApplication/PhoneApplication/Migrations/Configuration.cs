﻿namespace PhoneApplication.Migrations
{
    using PhoneApplication.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PhoneApplication.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PhoneApplication.DataContext context)
        {
            var manufacturers = new List<Manufacturer>
            {
                new Manufacturer {
                ManufacturerName = "Apple",
                URL = "www.apple.ca",
                DateReleased = new DateTime(1968,10,20),
                PhoneList = new List<Phone>() },
                new Manufacturer {
                ManufacturerName = "Samsung",
                URL = "www.samsung.ca",
                DateReleased = new DateTime(1950,10,20),
                PhoneList = new List<Phone>()  },
            };
            manufacturers.ForEach(s => context.Manufacturers.Add(s));
                 
                 context.SaveChanges();

            var phones = new List<Phone>
{
new Phone {
PhoneName = "iPhone 11 Pro",
MSRP = 1500,
DateReleased = new DateTime(2019,10,20),
ManufacturerID= manufacturers.Single(x => x.ManufacturerName == "Apple").ManufacturerID
},
new Phone {
PhoneName = "iPhone XR",
MSRP = 1000,
DateReleased = new DateTime(2018,01,20),
ManufacturerID = manufacturers.Single(x => x.ManufacturerName == "Apple").ManufacturerID },
new Phone {
PhoneName = "Galaxy S10",
MSRP = 700,
DateReleased = new DateTime(2016,10,20),
ManufacturerID = manufacturers.Single(x =>  x.ManufacturerName == "Samsung").ManufacturerID  }
};
            phones.ForEach(s => context.Phone.Add(s));
            context.SaveChanges();


        }
    }
}
