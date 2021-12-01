using NUnit.Framework;

namespace Ucu.Poo.Defense.Tests
{
    public class ResidueTests
    {
        ResidueType dangerousType;
        ResidueType nonDangerousType;

        [SetUp]
        public void Setup()
        {
            this.nonDangerousType = new ResidueType("Non dangerous type", false);
            this.dangerousType = new ResidueType("Dangerous type", true);
        }

        [Test]
        public void TestCreateNonDangerousResidue()
        {
            Residue Residue = new Residue("Non dangerous Residue", nonDangerousType);
            Assert.That(Residue.IsOrganic, Is.False);
        }

        [Test]
        public void TestCreateDangerousResidue()
        {
            Residue Residue = new Residue("Dangerous Residue", dangerousType);

            Assert.That(Residue.IsOrganic, Is.True);

        }
    }
}