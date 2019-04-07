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

    public static class StatMethods
    {
        public static string RemoveWhitespace(this string str)
        {
            return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                string dieCode = Console.ReadLine();
                dieCode = StatMethods.RemoveWhitespace(dieCode);
                string[] splitCode = dieCode.Split('d');
                try { if (Int32.Parse(splitCode[0]) == 0) break; }
                catch { System.Environment.Exit(0); }
                int result = 0;
                for (int i = 0; i < Int32.Parse(splitCode[0]); i++)
                {
                    Die useDie = new Die(Int32.Parse(splitCode[1]));
                    result += useDie.roll();
                }
                Console.WriteLine(result);
            }
        }
    }
}
