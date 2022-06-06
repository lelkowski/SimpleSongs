using SimpleSongs.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSongs.Utils
{
    public class ConsoleInputSystem : IInputSystem
    {

        public string FetchStringValue(string prompt)
        {
            string result = "";
            while (result == "")
            {
                Console.WriteLine("\n\t" + prompt);
                Console.Write("\t");
                result = Console.ReadLine();
            }
            return result;
        }

        public double FetchDoubleValue(string prompt)
        {
            double value;
            while (!Double.TryParse(FetchStringValue(prompt), out value)) continue;
            return value;
        }
        public int FetchIntValue(string prompt)
        {
            int value;
            while (!Int32.TryParse(FetchStringValue(prompt), out value)) continue;
            return value;
        }
    }
}
