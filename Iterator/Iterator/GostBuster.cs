using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class GhostBuster
    {
        public int CountParticipant;
        public DataParticipant[] participant;
        public Location location;
        public GhostBuster(int countParticipant, DataParticipant[] participant, Location location)
        {
            CountParticipant = countParticipant;
            this.participant = participant;
            this.location = location;

        }

    }
}
