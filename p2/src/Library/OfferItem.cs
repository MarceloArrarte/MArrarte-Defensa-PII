using System;
using System.Text;

namespace Ucu.Poo.Defense
{
    public class OfferItem
    {
        public Residue Residue { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public OfferItem(Residue residue, int quantity, int price)
        {
            this.Residue = residue;
            this.Quantity = quantity;
            this.Price = price;
        }
    }
}