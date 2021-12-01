using NUnit.Framework;
using Ucu.Poo.Defense;

namespace Ucu.Poo.Defense.Tests
{
    public class ResidueTests
    {
        ResidueType type1;
        ResidueType type2;

        [SetUp]
        public void Setup()
        {
            this.type2 = new ResidueType("Type 1", false);
            this.type1 = new ResidueType("Type 2", true);
        }

        [Test]
        public void TestSameResiduesAreEqual()
        {
            Residue Residue1 = new Residue("Residue 1", type1);
            Residue Residue2 = Residue1;
            object object1 = Residue1;

            Assert.True(Residue1.Equals(Residue2));
            Assert.True(Residue1.Equals(object1));
        }

        [Test]
        public void TestResiduesWithSameValuesAreEqual()
        {
            Residue Residue1 = new Residue("Residue 1", type1);
            Residue Residue2 = new Residue("Residue 1", type1);
            object Residue3 = new Residue("Residue 1", type1);

            Assert.True(Residue1.Equals(Residue2));
            Assert.True(Residue1.Equals(Residue3));
            Assert.True(Residue3.Equals(Residue1));
        }

        [Test]
        public void TestResiduesWithDifferentValuesAreNotEqual()
        {
            Residue Residue1 = new Residue("Residue 1", type1);
            Residue Residue2 = new Residue("Residue 1", type2);
            Residue Residue3 = new Residue("Residue 2", type1);

            Assert.False(Residue1.Equals(null));
            Assert.False(Residue1.Equals(type1));
            Assert.False(Residue1.Equals(Residue2));
            Assert.False(Residue1.Equals(Residue3));
        }        
    }
}