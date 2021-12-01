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
            OfferItem item = new OfferItem(caja, 1, 1);
            Offer.AddItem(item);

            Assert.That(Offer.Items, Has.Member(item));
        }

        [Test]
        public void RemoveItemTest()
        {
            Offer Offer = new Offer(DateTime.Today);
            OfferItem item = new OfferItem(caja, 1, 1);
            Offer.AddItem(item);
            Assert.That(Offer.Items, Has.Member(item));

            Offer.RemoveItem(item);
            Assert.That(Offer.Items, Has.None.EqualTo(item));
        }

        [Test]
        public void TotalTest()
        {
            Offer Offer = new Offer(DateTime.Today);
            OfferItem item1 = new OfferItem(caja, 1, 1);
            OfferItem item2 = new OfferItem(placa, 2, 2);
            Offer.AddItem(item1);
            Offer.AddItem(item2);
            int expected = item1.Quantity * item1.Price + item2.Quantity * item2.Price;

            Assert.That(Offer.Total, Is.EqualTo(expected));
        }
    }
}