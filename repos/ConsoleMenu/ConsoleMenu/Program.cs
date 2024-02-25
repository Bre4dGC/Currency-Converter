using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            while (true)
            {
                int i = rand.Next(0, 2);
                Console.WriteLine(i);
                Console.ReadKey();
            }
        }
    }
}
