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
        public void Pos_GetTom()
        {
            Assert.That(Helpers.GetTom("1") == "1Tom");
        }

        [Test]
        public void Neg_GetTom()
        {
            Assert.That(Helpers.GetTom("") != "1Tom");
        }




    }
}