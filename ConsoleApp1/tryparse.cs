using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tryparse
    {
        public void parsee()
        {
            string a = "hjh";
            int b;
            int.TryParse(a, out b);
            Console.WriteLine(b);
        }
    }
}
