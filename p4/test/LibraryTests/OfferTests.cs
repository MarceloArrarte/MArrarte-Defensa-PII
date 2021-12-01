using System;
using NUnit.Framework;

namespace Ucu.Poo.Defense.Tests
{
    public class OfferTests
    {
        private ResidueType carton;
        private Residue caja;
        private Residue placa;

        [SetUp]
        public void Setup()
        {
            carton = new ResidueType("Cartón", false);
            caja = new Residue("Caja de cartón", carton);
            placa = new Residue("Placa de cartón", carton);
        }

        [Test]
        public void AddItemTest()
        {
            Offer Offer = new Offer(DateTime.Today);
            IOfferItem item =  Offer.AddItem(caja, 1, 1);
            IOfferItem discount = Offer.AddDiscount(-1);

            Assert.That(Offer.Items, Has.Member(item));
            Assert.That(Offer.Items, Has.Member(discount));
        }

        [Test]
        public void RemoveItemTest()
        {
            Offer Offer = new Offer(DateTime.Today);
            IOfferItem item = Offer.AddItem(caja, 1, 1);
            IOfferItem discount = Offer.AddDiscount(-1);
            Assert.That(Offer.Items, Has.Member(item));
            Assert.That(Offer.Items, Has.Member(discount));

            Offer.RemoveItem(item);
            Assert.That(Offer.Items, Has.None.EqualTo(item));

            Offer.RemoveItem(discount);
            Assert.That(Offer.Items, Has.None.EqualTo(discount));
        }

        [Test]
        public void TotalTest()
        {
            Offer Offer = new Offer(DateTime.Today);
            OfferItem item1 = Offer.AddItem(caja, 2, 2);
            OfferItem item2 = Offer.AddItem(placa, 3, 4);
            PromoCode discount = Offer.AddDiscount(-1);
            int expected = item1.Quantity * item1.Price + item2.Quantity * item2.Price -1;

            Assert.That(Offer.Total, Is.EqualTo(expected));
        }

        [Test]
        public void AddInvalidDiscount()
        {
            Offer Offer = new Offer(DateTime.Today);
            Assert.That(() => Offer.AddDiscount(1), Throws.TypeOf<ArgumentException>());            
        }
    }
}