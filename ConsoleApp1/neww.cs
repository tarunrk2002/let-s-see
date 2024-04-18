using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Neww
    {
        public void fun() 
        {
            int len = 7;
            int[] a1 = new int[len];
            
            List<int> l1 = new List<int>();

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(i);
                string input_num = Console.ReadLine();
                int num ;
                int.TryParse(input_num, out num);
                
                a1[i] = num;
            }

            foreach (int numbers in a1)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}
