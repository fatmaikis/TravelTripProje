using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Entities
{
	public class About
	{
        [Key]
        public int AboutID { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }

    }
}