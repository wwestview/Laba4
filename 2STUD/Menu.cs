using Laba4Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Menu
    {


        public static void Main(string[] args)
        {



            int choice;
            do
            {
                Console.WriteLine("============================================");
                Console.WriteLine("Для виконання завдань Колачка  введіть 1");
                Console.WriteLine("Для виконання завдань Харченка  введіть 2");
                Console.WriteLine("Для виходу з програми введіть 0");
                Console.WriteLine("============================================");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("=============================");
                        Console.WriteLine("Виконую варіант Колачка ");
                        Console.WriteLine("=============================");
                        Kolachko.TupM();
                        Console.WriteLine("=============================");
                        break;
                    case 2:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Виконую варіант Харченка");
                        Console.WriteLine("-------------------------");
                        Kharchenko.TupM();
                        break;
                    case 0:
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 3, 0.", choice);
                        break;
                }
            } while (choice != 0);



        }
    }
}
