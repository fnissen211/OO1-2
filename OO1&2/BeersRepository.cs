using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace OO1_2
{
    public class BeersRepository
    {
        private List<Beer> beers = new()
        {
            new Beer(0, "Carlsberg",4.6),
            new Beer(1, "Tuborg",4.5),
            new Beer(2, "Guinnes",5.2)
        };

        public List<Beer> Get()
        {
            return new List<Beer>(beers);
        }

        public Beer? GetById(int id)
        {
            Beer? newBeer = beers.Find(b => b.Id == id);

            if (newBeer is null)
            {
                return null;
            }
            return newBeer;
        }

        public Beer AddBeer(Beer beer)
        {
            beers.Add(beer);
            return beer;
        }

        public Beer? RemoveBeer(int id)
        {
            Beer? newBeer = beers.Find(b => b.Id == id);
            if (newBeer is null)
            {
                return null;
            }
            beers.Remove(newBeer);
            return newBeer;
        }

        public Beer? Update(int id, Beer values)
        {
            values.Id = id;

            try
            {
                int index = beers.FindIndex(x => x.Id == id);
                beers[index] = values;

                return beers[index];
            }
            catch (Exception e)
            {
                Exception ex = new Exception(e.Message);
                return null;
            }
        }

        public override string ToString()
        {
            return $"{string.Join(", ", beers)}";
        }
    }
}
