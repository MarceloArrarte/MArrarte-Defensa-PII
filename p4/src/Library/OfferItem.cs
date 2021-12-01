namespace Ucu.Poo.Defense
{
    public class OfferItem
    {
        public Residue Residue { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public int SubTotal
        {
            get
            {
                return this.Quantity * this.Price;
            }
        }

        public OfferItem(Residue residue, int quantity, int price)
        {
            this.Residue = residue;
            this.Quantity = quantity;
            this.Price = price;
        }
    }
}