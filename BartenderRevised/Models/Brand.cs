using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BartenderRevised.Models
{
    [Bind(Exclude = "BrandId")]
    public class Brand
    {
        [ScaffoldColumn(false)]
        public int BrandID { get; set; }
        [DisplayName("Drink Type")]
        public int DrinkTypeID { get; set; }
        [Required(ErrorMessage = "Please enter a drink brand!")]
        [StringLength(160)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        public virtual DrinkType DrinkType { get; set; }
    }
}