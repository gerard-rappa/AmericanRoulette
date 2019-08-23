using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AmericanRoulette
{
    class Program
    {
        static class Imports
        {
            public static IntPtr HWND_BOTTOM = (IntPtr)1;
            public static IntPtr HWND_TOP = (IntPtr)0;

            public static uint SWP_NOSIZE = 1;
            public static uint SWP_NOZORDER = 4;

            [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
            public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, uint wFlags);
        }
        static void Main(string[] args)
        {
            //Maps numbers on wheel in order from 0-36 with 00 as 37 on the end
            int[] map = new int[] { 0, 28, 9, 26, 30, 11, 7, 20, 32, 17, 5, 22, 34, 15, 3, 24, 36, 13, 1, 37, 27, 10, 25, 29, 12, 8, 19, 31, 18, 6, 21, 33, 16, 4, 23, 35, 14, 2 };
            Random r = new Random();
            int i = r.Next(0, 38);
            string bet = "";
            int y;
            bool validBet = false;
            Console.WriteLine("\t~~~~~Welcome to the Table~~~~~\n\n");          

            while (!validBet)
            {
                Console.WriteLine("\tHow many chips would you like?");
                Console.Write("\t\t$");
                bet = Console.ReadLine();
                validBet = int.TryParse(bet, out y);
                if (validBet) break;
                else Console.WriteLine("Invalid amount of money");
            }

            SpinWheel.Spin(i);
            PlaceBet.Bet(map[i], bet);
        }
    }
}
