
using Tyuiu.UsoltsevME.Sprint5.Task0.V22.Lib;
using System;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("Ошибка! x не может быть равен нулю.");
                Console.ReadKey();
                return;
            }

            string path = ds.SaveToFileTextData(x);

            string result = File.ReadAllText(path);

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Значение функции: " + result);
            Console.WriteLine("Файл сохранен: " + path);

            Console.ReadKey();
        }
    }
}
