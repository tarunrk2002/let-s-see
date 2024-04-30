using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();
            list.Add("ughr");
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add("eufeiuh");

           

            List<eco> result = new List<eco>();
            result.Add(new eco
            {
                name = "fgrg",
                description = "ererf",
                type = "dont'ert"
            });
            result.Add(new eco
            {
                name = "fgrg",
                description = "ererf",
                type = "dont'ert"
            });
            result.Add(new eco
            {
                name = "fgrg",
                description = "ererf",
                type = "dont'ert"
            });

            Console.WriteLine(result);
            foreach (var item in result)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.description);
                    Console.WriteLine(item.type);
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            }
            var resultq = new List<eco>();

            resultq.Add(new eco
            {
                name = "hu4hr"

            });

            Console.WriteLine(resultq.Count);
            Console.WriteLine(resultq[0]);
        }
       
    }
}
