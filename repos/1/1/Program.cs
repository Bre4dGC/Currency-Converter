using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float percent = 3.5f;
            Console.Write("Введите какой сейчас год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во  денег внесенных во вклад: ");
            float money = Convert.ToSingle(Console.ReadLine());
            Console.Write("На сколько лет открыт оклад: ");
            int years = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent; year = year + 1;
                Console.WriteLine("В " + year + " году у вас " + money + " денег");
                Console.ReadKey();
            }
        }
    }
}
