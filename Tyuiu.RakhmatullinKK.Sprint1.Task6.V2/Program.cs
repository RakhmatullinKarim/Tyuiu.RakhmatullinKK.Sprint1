using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RakhmatullinKK.Sprint1.Task6.V2.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint1.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Рахматуллин К.К. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Рахматуллин Карим Камильевич | АСОиУб-23-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя текст и проверяет, *");
            Console.WriteLine("* есть ли в строке слово <<Hello>>                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value;

            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            if (inputText.Contains("Hello"))

            {
                Console.WriteLine("Слово 'Hello' найдено в тексте.");
            }
            else
            {
                Console.WriteLine("Слово 'Hello' не найдено в тексте.");
            }

            Console.ReadKey();
        }
    }
}