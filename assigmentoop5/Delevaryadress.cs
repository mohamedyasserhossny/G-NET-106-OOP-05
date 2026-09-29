using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentoop5
{
    internal struct Delevaryadress
    {
        public string city;
        public string street;
        public int buldingnumber;
        public Delevaryadress(string City, string Street, int Buldingnumber)
        {
            city = City;
            street = Street;
            buldingnumber = Buldingnumber;
        }
        public string Getfulladdrees()
        {
            return $"city={city},street={street},buldingnumber={buldingnumber}";
        }

    }
}
    

