using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace PhoneApplication.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            ManufacturerName = "";
            URL = "";
            DateReleased = DateTime.Now;
        }
        [Key]
        public int ManufacturerID { get; set; }
        public string ManufacturerName { get; set; }
        public string URL { get; set; }
        public DateTime DateReleased { get; set; }
        public List<Phone> PhoneList { get; set; }
    }
}