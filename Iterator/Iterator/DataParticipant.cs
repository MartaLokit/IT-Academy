using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class DataParticipant
    {
        public string Name { get; set; }
        public string FirstName;
        public int Age;
        public string JobTitle;
        public DataParticipant()
        {

        }
        public DataParticipant(string name, string firstName, int age, string jobTitle)
        {
            Name = name;
            FirstName = firstName;
            Age = age;
            JobTitle = jobTitle;
        }

    }
}
