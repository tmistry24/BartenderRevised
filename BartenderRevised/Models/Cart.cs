using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BartenderRevised.Models
{
    public class Cart
    {
        [Key]
        public int RecordID { get; set; }
        public string CartId { get; set; }
        public int BrandId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Brand Brand { get; set; }

    }
}