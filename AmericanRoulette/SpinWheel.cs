using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmericanRoulette
{
    public class SpinWheel
    {
        public static void Spin(int seed)
        {
            var process = @"Wheel.exe";
            if (File.Exists("Wheel.exe"))
            {
                Process.Start(process, seed.ToString());
            }
        }
    }    
}
