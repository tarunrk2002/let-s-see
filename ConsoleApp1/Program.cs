using newproject;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double people = 43;
           double capacity = 5;
           double c = people / capacity;
           Console.WriteLine(c);

           double d = Math.Ceiling(c);
           Console.WriteLine(d);
        }
    }
}
