using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();

            int die = 20;
            int num = 1;
            int mod = -3;
            int roll = 0;

            for (int i = 0; i < num; i++)
                roll += dice.Next(1, die + 1);

            int total = roll + mod;

            Console.WriteLine("Roll is " + roll + ". With mod of " + mod + ", total is " + total + ".");
        }
    }
}
