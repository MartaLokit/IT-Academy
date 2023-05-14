using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iterator;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodContainsDataParticipant()
        {
            var participant = new DataParticipant[]
            {
                 new DataParticipant("Nikita","Sudar",29,"Guide"),
                 new DataParticipant("Emil","Imanov",24,"Survival Instructor"),
                 new DataParticipant("Dmitriy","Maslenikov",28,"Supervisor" )
            };
            var location = new Location[]
            {
                 new Location("Belarus","Grodno", TypeLocation.Fort)
            };
            var gostBuster = new CollectionGostBuster(participant, location);
            string gost = gostBuster.Contains(gostBuster, "Sudar");
            string res = "\'Sudar' Contains in Participant";
            Assert.AreEqual(res, gost, "TestMethodContainsDataParticipant is not correct");
        }
    }
}
