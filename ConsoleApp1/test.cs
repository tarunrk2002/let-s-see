using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class test:Me
    {
        public void newfun()
        {
            Console.WriteLine("enter the length of the array");
            string str_num = Console.ReadLine();
            int len;
            int.TryParse(str_num, out len);
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("enter the {0} element of the array", i);
                string input = Console.ReadLine();
                int int_input;
                int.TryParse(input, out int_input);
                arr[i] = int_input;
            }
            Console.WriteLine("enter the target");
            string target = Console.ReadLine();
            int int_target;
            int.TryParse(target, out int_target);
            int num = 0;
            int stop = 0;

            while (stop != 1)
            {
                if (arr[num] + arr[num + 1] == int_target)
                {
                    Console.WriteLine("target found with index {0} & {1}", num, num + 1);
                    Console.WriteLine("And their values are {0} & {1}", arr[num], arr[num+1]);
                    stop = 1;
                }
                else
                {
                    Console.WriteLine("match not found");
                }
                num++;
            }

        }
    }
}
