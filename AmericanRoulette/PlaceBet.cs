using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanRoulette
{
    class PlaceBet
    {
        public static void Bet(int seed, string bet)
        {
            var process = @"Bet.exe";
            if (File.Exists("Bet.exe"))
            {
                Process.Start(process, seed.ToString() + " " + bet);
            }
        }
    }
}
