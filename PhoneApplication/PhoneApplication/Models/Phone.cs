using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace PhoneApplication.Models
{
    public class Phone
    {
        public Phone()
        {
            
            PhoneName = "";
            MSRP = 0;
            ScreenSize = "";
            DateReleased = DateTime.Now;
        }
        

        [Key]
        public int PhoneID { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        [ForeignKey("Manufacturer")]
        public int ManufacturerID { get; set; }
        public string PhoneName { get; set; }
        public double MSRP { get; set; }
        public string ScreenSize { get; set; }
        public DateTime DateReleased { get;  set; }
    }

}