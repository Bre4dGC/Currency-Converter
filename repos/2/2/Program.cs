using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool yesOrNo = false;

            while (yesOrNo != true)
            {
                Console.Write("напиши exit чтобы выйти: ");
                string exit = Console.ReadLine();

                switch (exit)
                {
                    case "exit":
                        yesOrNo = true;
                        break;
                }
            }
        }
    }
}
