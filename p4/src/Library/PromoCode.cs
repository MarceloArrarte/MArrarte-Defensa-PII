using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode : IOfferItem
    {
        private string code {get;set;}
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (value >= 0)
                {
                    throw new ArgumentException("El importe del descuento debe ser estrictamente negativo.");
                }
                
                this.amount = value;
            }
        }

        public PromoCode(string code, int amount)
        {
            this.code = code;
            this.SubTotal = amount;
        }
    }
}