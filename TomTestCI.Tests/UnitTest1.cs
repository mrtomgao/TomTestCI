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
            Assert.That(Helpers.GetLOL("") != "1LOL");
        }

        [Test]
        public void Pos_GetHAHA()
        {
            Assert.That(Helpers.GetHAHA("1") == "1HAHA");
        }

        [Test]
        public void Neg_GetHAHA()
        {
            Assert.That(Helpers.GetHAHA("") != "1HAHA");
        }

    }
}