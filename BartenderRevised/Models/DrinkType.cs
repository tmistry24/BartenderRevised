using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BartenderRevised.Models
{
    public class DrinkType
    {
        public int DrinkTypeID { get; set; }
        public string Name { get; set; }
        public List<Brand> Brands { set; get; }
    }
}