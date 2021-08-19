using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abacus_C_sharp
{
    class Program
    {
        static int schoty(string[] abacus)
        {
            int unitFactor = 1;
            int value = 0;
            int count = 0;
            for (int i = 6; i > -1; i--)
            {
                string[] beads = abacus[i].Split('-');
                for (int a = 0; a < beads[0].Length; a++)
                {
                    if(beads[0][a]=='O')
                    {
                        count++;
                    }
                }
                value += count * unitFactor;
                count = 0;
                unitFactor *= 10;
            }
            return value;
        }

        static int soroban(string[] abacus)
        {
            return -1;
        }

        static void Main(string[] args)
        {
            string[] schotyAbacus = new string[7] {"---OOOOOOOOOO",
                                                   "OOOOO---OOOOO",
                                                   "---OOOOOOOOOO",
                                                   "O---OOOOOOOOO",
                                                   "OO---OOOOOOOO",
                                                   "OOOOOO---OOOO",
                                                   "OOOO---OOOOOO" };
            Console.WriteLine(schoty(schotyAbacus));

            Console.ReadLine();
        }
    }
}
