using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class test
    {
        public void newfun()
        {
            Console.WriteLine("enter the length of the array");
            string str_num = Console.ReadLine();
            int len;
            int.TryParse(str_num,out len);
            int[] arr = new int[len];


            

        }
//optional parameters
        public void newfun2(int a , int b = 3) { Console.WriteLine(a+b); }
    }
}
