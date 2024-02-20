using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO1_2
{
    public class Beer
    {
        public Beer(int id, string name, double abv)
        {
            Id = id;
            Name = name;
            Abv = abv;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Abv { get; set; }

        public bool ValidateName()
        {
            if (Name is null)
            {
                Exception e = new Exception("Name is empty.");
                Console.WriteLine(e);
                return false;
            }
            else if (Name.Length < 3)
            {
                Exception e = new Exception($"Name is less than 3 characters long. It's currently: " +
                    $"{Name.Length} characters long. ");
                Console.WriteLine(e);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidateAlcoholByValoume()
        {
            if (Abv > 0 && Abv <= 67)
            {
                return true;
            }
            else
            {
                Exception e = new Exception($"Abv has to be in the range between 1-67. " +
                    $"Abv was: {Abv}");
                Console.WriteLine(e);
                return false;
            }
        }


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Abv: {Abv}";
        }

    }
}