using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    class DiscountedItem : Item
    {
        private double item_discount;
        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            item_discount = discount;
        }
        public override double getTotalPrice()
        {
            double discountValue = item_discount * 0.01;
            double discountedPrice = item_price - (item_price * discountValue);
            return discountedPrice * item_quantity;
        }

    }


}