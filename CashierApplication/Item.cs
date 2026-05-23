using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;

        public Item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            item_quantity = quantity;
        }
        public virtual double getTotalPrice()
        {
            return item_price * item_quantity;
        }
    }
}