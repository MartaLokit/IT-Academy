using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class CollectionGostBuster
    {
        DataParticipant[] participant;
        Location[] locations;
        public CollectionGostBuster(DataParticipant[] participant, Location[] locations)
        {
            this.participant = participant;
            this.locations = locations;
        }
        public int Length => participant.Length;
        public IEnumerator<DataParticipant> GetEnumerator()
        {
            for (int i = 0; i < participant.Length; i++)
            {
                yield return participant[i];
            }
        }
        public string Contains(CollectionGostBuster gost, string firstName)
        {
            string res = " ";
            foreach (DataParticipant participan in gost)
            {
                if (participan.FirstName.Contains(firstName))
                {
                    res = $"\'{firstName}' Contains in Participant";
                }
                /*else
                {
                    Console.WriteLine($"\'{firstName}' not found");
                }*/
            }
            return res;
        }
    }
}
