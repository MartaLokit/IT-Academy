using Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var participant = new DataParticipant[]
            {
                 new DataParticipant("Nikita","Sudar",29,"Guide"),
                 new DataParticipant("Emil","Imanov",24,"Survival Instructor"),
                 new DataParticipant("Dmitriy","Maslenikov",28,"Supervisor" )
            };
            //commit for git
            var location = new Location[]
            {
                 new Location("Belarus","Grodno", TypeLocation.Fort)
            };
            var gostBuster = new CollectionGostBuster(participant, location);
            foreach (Location _location in location)
            {
                Console.WriteLine($"{_location.Country}, {_location.City},{_location.location.ToString()}");
            }
            foreach (DataParticipant participan in gostBuster)
            {
                Console.WriteLine($"{participan.Name} {participan.FirstName} {participan.Age} {participan.JobTitle}");
            }
            gostBuster.Contains(gostBuster, "Sudar");
            Console.ReadLine();
        }
    }
}
