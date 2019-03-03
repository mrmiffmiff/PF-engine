using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderEngine
{
    public class Die
    {
        public int dieValue;

        public Die(int value)
        {
            dieValue = value;
        }

        public int roll()
        {
            Random rand = new Random();
            return rand.Next(1, dieValue + 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Die example = new Die(Int32.Parse(Console.ReadLine()));
                if (example.dieValue == 0) break;
                Console.WriteLine(example.roll());
            }
        }
    }
}
