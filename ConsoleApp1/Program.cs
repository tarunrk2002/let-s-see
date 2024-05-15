using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // brute force
            // first let's create an array and then move to smth else 


            Console.WriteLine("enter the size of array");
            string sizestring = Console.ReadLine();
            int sizeofarray;
            int.TryParse(sizestring, out sizeofarray);
            int[] newarray = new int[sizeofarray];
            
            for (int i = 0; i < sizeofarray; i++)
            {
                Console.WriteLine("enter the {0} element of the array", i);
                newarray[i] = int.Parse(Console.ReadLine());

            }
            
            int[] find = new int[2];
            Console.WriteLine("enter the search elements.");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter the {0} element of the array", i);
                find[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("searching...!");

            int num = 0;

            while (newarray[num] != find[0] && newarray[num + 1] != find[1])
            {
                Console.WriteLine("not matched");
                num++;

            }
            Console.WriteLine("your index starts from {0}", num);



        }


    }
}
