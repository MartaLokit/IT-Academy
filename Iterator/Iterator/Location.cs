using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Location
    {
        public string Country;
        public string City;
        public TypeLocation location { get; set; }
        public Location(string country, string city, TypeLocation location)
        {
            Country = country;
            City = city;
            this.location = location;
        }
    }
}
