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
        public void AsTextTest()
        {
            Offer Offer = new Offer(DateTime.Today);
            OfferItem item1 = new OfferItem(caja, 1, 1);
            OfferItem item2 = new OfferItem(placa, 2, 2);
            Offer.AddItem(item1);
            Offer.AddItem(item2);
            string text = Offer.AsText();            

            Assert.That(text, Contains.Substring(item1.Residue.Name).IgnoreCase);
            Assert.That(text, Contains.Substring(item1.Quantity.ToString()));
            Assert.That(text, Contains.Substring(item1.Price.ToString()));
            Assert.That(text, Contains.Substring(item2.Residue.Name).IgnoreCase);
            Assert.That(text, Contains.Substring(item2.Quantity.ToString()));
            Assert.That(text, Contains.Substring(item2.Price.ToString()));
        }
    }
}