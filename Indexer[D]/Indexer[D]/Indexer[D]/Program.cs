using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_D_
{
    class Country
    {
        private string[] cities = new string[] { "Dhaka", "New York", "Tokiyo" };
        private string[] capitals = new string[] { "Delhi", "London", "Lisbon" };

        public string[] Cities
        {
            set { this.cities = value; }
            get { return this.cities; }
        }

        //Indexer declaration

        public string this[int index]
        {
            set { this.cities[index] = value; }
            get { return this.cities[index]; }
        }
        public string this[byte index]
        {
            set { this.capitals[index] = value; }
            get { return this.capitals[index]; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country();
            //Console.WriteLine(country.cities[1]);
            //Console.WriteLine(country.Cities[0]);
            Console.WriteLine(country[(byte)1]);
            
        }
    }
}
