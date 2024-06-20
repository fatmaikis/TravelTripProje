using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Entities
{
	public class Address
	{
        [Key]
        public int AddressID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string OpenAddress { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }

    }
}