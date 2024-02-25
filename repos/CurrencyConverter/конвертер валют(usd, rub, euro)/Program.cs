using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace конвертер_валют_usd__rub__euro_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usdToRub = 92, rubToUsd = 90, usdToTl = 31, TlToUsd = 29, rubToTl = 3, TlToRub = 3;
            bool yesOrNo = false; float currencyCount; string exit = "exit";

            Console.WriteLine("Конвертер валют");
            Console.Write("\nВведите ваш баланс долларов: "); float usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите ваш баланс рублей: "); float rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите ваш баланс лир: "); float tl = Convert.ToSingle(Console.ReadLine());
            while (yesOrNo != true)
            {
                Console.WriteLine("\nУ вас: (" + usd + ") долларов, (" + rub + ") рублей, (" + tl + ") лир"); Console.ReadKey();
                Console.WriteLine("\n1а - доллары на рубли\n1б - рубли на доллары\n2а - доллары в лиры\n2б - лиры в доллары\n3а - рубли в лиры\n3б - лиры в рубли");
                Console.WriteLine("Введите exit чтобы выйти");
                Console.Write("\nВаш выбор: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1а":
                        Console.WriteLine("Обмен доллары на рубли");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle (Console.ReadLine());
                        if(usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во долларов");
                        }
                        break;

                    case "1б":
                        Console.WriteLine("Обмен рубли на доллары");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            usd += currencyCount / rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во рублей");
                        }
                        break;

                    case "2а":
                        Console.WriteLine("Обмен доллары в лиры");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            tl += currencyCount * usdToTl;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во лир");
                        }
                        break;

                    case "2б":
                        Console.WriteLine("Обмен лиры в доллары");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (tl >= currencyCount)
                        {
                            tl -= currencyCount;
                            usd += currencyCount / TlToUsd;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во долларов");
                        }
                        break;

                    case "3а":
                        Console.WriteLine("Обмен рубли в лиры");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            tl += currencyCount / rubToTl;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во долларов");
                        }
                        break;

                    case "3б":
                        Console.WriteLine("Обмен лиры в рубли");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine()); 
                        if (tl >= currencyCount)
                        {
                            tl -= currencyCount;
                            rub += currencyCount * TlToRub;
                        }
                        else
                        {
                            Console.WriteLine("Недопустимое кол-во долларов");
                        }
                        break;
                        
                     case "exit":
                        yesOrNo = true;
                        break;
                }
                Console.Clear();
            }
            

        }
    }
}
