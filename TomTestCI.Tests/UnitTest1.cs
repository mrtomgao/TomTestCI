using NUnit.Framework;
using TomsTestCI.Functions;

namespace TomTestCI.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Pos_GetLOL()
        {
            Assert.That(Helpers.GetLOL("1") == "1LOL");
        }

        [Test]
        public void Neg_GetLOL()
        {
            Assert.That(Helpers.GetLOL("1") != "LOL");
        }
        [Test]
        public void Pos_GetHaha()
        {
            Assert.That(Helpers.GetLOL("1") == "1Haha");
        }

        [Test]
        public void Neg_GetHaha()
        {
            Assert.That(Helpers.GetLOL("1") != "Haha");
        }
    }
}