using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class se_de
    {

        public void do_something()
        {
            jasondata jasondataa = new jasondata()
            {
                a = "as",
                b = "d",
                c = "d"
            };

            string to_jason = JsonSerializer.Serialize<jasondata>(jasondataa);
            Console.WriteLine(to_jason);
        }
    }

    
}
