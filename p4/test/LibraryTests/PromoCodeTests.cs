using System;
using NUnit.Framework;

namespace Ucu.Poo.Defense.Tests
{
    public class PromoCodeTests
    {
        [Test]
        public void CreateValidDiscount()
        {
            Assert.That(() => new PromoCode("Black Friday", -1), Throws.Nothing);
        }

        [Test]
        public void AssignValidDiscount()
        {
            PromoCode discount = new PromoCode("Black Friday", -1);
            Assert.That(() => discount.SubTotal = -2, Throws.Nothing);
        }

        [Test]
        public void CreateInvalidDiscount()
        {
            Assert.That(() => new PromoCode("Black Friday", 1), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void AssignInvalidDiscount()
        {
            PromoCode discount = new PromoCode("Black Friday", -1);
            Assert.That(() => discount.SubTotal = 2, Throws.TypeOf<ArgumentException>());
        }

    }
}