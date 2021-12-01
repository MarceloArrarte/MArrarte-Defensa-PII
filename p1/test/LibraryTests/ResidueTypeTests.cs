using NUnit.Framework;

namespace Ucu.Poo.Defense.Tests
{
    public class ResidueTypeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateNonDangerousResidueType()
        {
            ResidueType ResidueType = new ResidueType("test", false);

            Assert.That(ResidueType.IsOrganic, Is.False);
        }

        [Test]
        public void TestCreateDangerousResidueType()
        {
            ResidueType ResidueType = new ResidueType("test", true);

            Assert.That(ResidueType.IsOrganic, Is.True);
        }
    }
}