using System;

namespace Ucu.Poo.Defense
{
    public class PromoCode
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