using OO1_2;

namespace UnitTests
{
    [TestClass]
    public class BeerTests
    {
        [TestMethod]
        public void TestValidateName()
        {
            Beer beer = new Beer(0, "Tuborg", 4.6);
            Assert.IsTrue(beer.ValidateName());

            Beer beer2 = new Beer(1, null, 4.7);
            Assert.IsFalse(beer2.ValidateName());

            Beer beer3 = new Beer(2, "GG", 4.6);
            Assert.IsFalse(beer3.ValidateName());
        }

        [TestMethod]
        public void TestValidatePrice()
        {
            Beer beer = new Beer(0, "Tuborg", 4.6);
            Assert.IsTrue(beer.ValidateAlcoholByValoume());

            Beer beer2 = new Beer(1, "Tuborg", -100);
            Assert.IsFalse(beer2.ValidateAlcoholByValoume());

            Beer beer3 = new Beer(2, "Tuborg", 8000);
            Assert.IsFalse(beer3.ValidateAlcoholByValoume());

        }

        [TestMethod]
        public void TestToString()
        {
            Beer beer = new Beer(0, "Tuborg", 4.6);

            Assert.IsInstanceOfType(beer.ToString(), typeof(string));
            Assert.AreEqual("Id: 0, Name: Tuborg, Abv: 4,6", beer.ToString());
        }
    }
}