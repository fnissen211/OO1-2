using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO1_2
{
    public class BeersRepository
    {
        private int nextId = 3;
        private List<Beer> beers = new()
        {
            new Beer(0,"Carlsberg",4.6),
            new Beer(1,"Tuborg",4.5),
            new Beer(2,"Guinnes",5.2)
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
    }
}
