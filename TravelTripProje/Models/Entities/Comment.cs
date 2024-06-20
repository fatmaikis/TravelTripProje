using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Entities
{
	public class Comment
	{
        [Key]
        public int CommentID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string PersonComment { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }



    }
}