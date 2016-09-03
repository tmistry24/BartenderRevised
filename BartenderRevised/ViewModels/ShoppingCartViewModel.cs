using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BartenderRevised.Models;

namespace BartenderRevised.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}