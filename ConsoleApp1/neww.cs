﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Neww:origami
    {
        public void fun() 
        {
            int len = 7;
            int[] a1 = new int[len];
            
            List<int> l1 = new List<int>();
            int add = 0;
           

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("enter the {0} number",i);
                string input_num = Console.ReadLine();
                int num ;
                int.TryParse(input_num, out num);
                
                a1[i] = num;
                add = add + num;
            }

            //foreach (int numbers in a1)
            //{
            //    Console.WriteLine(numbers);
            //}
            Console.WriteLine(add);
        }


    }
}
