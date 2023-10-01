using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RakhmatullinKK.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            return Console.WriteLine("Введите текст: ");
            string inputText = Console.ReadLine();

            if (inputText.Contains("Hello"))
            {
                Console.WriteLine("Слово 'Hello' найдено в тексте.");
            }
            else
            {
                Console.WriteLine("Слово 'Hello' не найдено в тексте.");
            }
        }
    }
}
