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
            
            //List<object> list1 = new List<object>();
            //list1[0] = 1;
            //list1[1] = "igitgj";


            convertingtojson convertingtojsonn = new convertingtojson()
            {
                name = "tarun",
                place = "bangalore"

            }
            ;

            string contoj = JsonSerializer.Serialize<convertingtojson>(convertingtojsonn);
            File.WriteAllText("jsss.json", contoj);
            var data = File.ReadAllText("jsss.json");
            convertingtojson? readdata = JsonSerializer.Deserialize<convertingtojson>(data);
            Console.WriteLine(readdata.place);
        }
    }
}
