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

        public int roll(int mod)
        {
            Random rand = new Random();
            int rolled = rand.Next(1, dieValue + 1);
            rolled += mod;
            return rolled;
        }
    }

    public static class StatMethods
    {
        public static string RemoveWhitespace(this string str)
        {
            return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries)); //from Stack Overflow, seems to work slightly faster than RegEx
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                string fullDieCode = Console.ReadLine();
                fullDieCode = StatMethods.RemoveWhitespace(fullDieCode);
                fullDieCode = fullDieCode.Replace("+-", "-");
                fullDieCode = fullDieCode.Replace("-", "+-");
                string[] splitFullCode = fullDieCode.Split('+');
                string dieCode = splitFullCode[0];
                int mod = 0;
                if (splitFullCode.Length > 1) mod = Int32.Parse(splitFullCode[1]);
                string[] splitCode = dieCode.Split('d');
                try { if (Int32.Parse(splitCode[0]) == 0) break; }
                catch { System.Environment.Exit(0); }
                int result = 0;
                for (int i = 0; i < Int32.Parse(splitCode[0]); i++)
                {
                    Die useDie = new Die(Int32.Parse(splitCode[1]));
                    result += useDie.roll(mod);
                }
                Console.WriteLine(result);
            }
        }
    }
}
