using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClothesLine_sm.Models;

namespace ClothesLine_sm.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}