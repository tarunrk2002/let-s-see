using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // brute force
            // first let's create an array and then move to smth else 
            //int[] newarray = new int[5];
            //newarray[0] = 1;
            //newarray[1] = 2;
            //newarray[2] = 3;
            //newarray[3] = 4;
            //newarray[4] = 5;

            //int[] find = new int[2];
            //find[0] = 3;
            //find[1] = 4;
             
            int num = 0;
            int less = 0;

            while (num != 4)
            {
                Console.WriteLine("hi");
                num++;
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine(less);
                    less = less + 1;
                }
            }


            //for (int i = 0;i <= 4; i++)
            //{
            //    if (i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    if (i > 0)
            //    {
            //        Console.WriteLine(i);
            //        Console.WriteLine(i);
            //    }
            //}
            
            
        }

       
    }
}
