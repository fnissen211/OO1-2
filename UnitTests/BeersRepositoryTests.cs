using OO1_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class BeersRepositoryTests
    {

        [TestMethod]
        public void Get()
        {
            BeersRepository beers = new BeersRepository();
            List<Beer> copyBeers = beers.Get();
            Assert.IsNotNull(copyBeers);
        }

        [TestMethod]
        public void GetByIdTest()
        {
            BeersRepository beers = new BeersRepository();
            Beer? newBeer = beers.GetById(1);

            Console.WriteLine(newBeer);
            Assert.IsNotNull(newBeer);
            Assert.AreEqual(1, newBeer.Id);

            Beer? newBeer2 = beers.GetById(100);
            Console.WriteLine(newBeer2);
            Assert.IsNull(newBeer2);
        }

        [TestMethod]
        public void AddBeerTest()
        {
            BeersRepository beers = new BeersRepository();
            int countBefore = beers.Get().Count;
            beers.AddBeer(new Beer(1, "Albani", 24));
            int countAfter = beers.Get().Count;

            Console.WriteLine("Before: " + countBefore + ". After: " + countAfter);
            Assert.AreNotEqual(countBefore, countAfter);
        }

        [TestMethod]
        public void DeleteBeerTest()
        {
            BeersRepository beers = new BeersRepository();
            int countBefore = beers.Get().Count;
            beers.RemoveBeer(1);
            int countAfter = beers.Get().Count;

            Assert.AreNotEqual(countBefore, countAfter);

            Assert.IsNull(beers.RemoveBeer(100));
        }

        [TestMethod]
        public void UpdateTest()
        {
            BeersRepository beers = new BeersRepository();

            Beer? beerBefore = beers.GetById(2);

            beers.Update(2, new Beer(1, "Stærk øl", 22));

            Beer? beerAfter = beers.GetById(2);

            Console.WriteLine("Before: " + beerBefore + ". After: " + beerAfter);
            Assert.AreNotEqual(beerBefore, beerAfter);

            Assert.IsNull(beers.Update(100, new Beer(2, "Frede Tuborg", 6.7)));
        }

        [TestMethod]
        public void TestToString()
        {
            BeersRepository beers = new BeersRepository();

            Assert.IsInstanceOfType(beers.ToString(), typeof(string));
            Assert.AreEqual("Id: 0, Name: Carlsberg, Abv: 4,6, Id: 1, Name: Tuborg, Abv: 4,5, Id: 2, " +
                "Name: Guinnes, Abv: 5,2", beers.ToString());
        }
    }
}
