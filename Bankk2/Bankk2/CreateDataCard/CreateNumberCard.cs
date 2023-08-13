using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Банковская_система.DataBase
{
    internal class CreateNumberCard
    {
        public string numbercard;
        public string securitycode;
        private Random ran = new Random();
        private int value = 0;
        public CreateNumberCard()
        {
            GenerationNumberCard();
            GenerationSecurityCode();
        }
        private void GenerationNumberCard()
        {        
            for (int i = 0; i < 16; i++)
            {
                value = ran.Next(0, 9);
                numbercard += value;
            }
             numbercard = Regex.Replace(numbercard, "(.{4})", " $0");
        }
        private void GenerationSecurityCode()
        {
            for (int i = 0; i < 3; i++)
            {
                value = ran.Next(0, 9);
                securitycode += value;
            }
        }
    }
}
