
using System;
using System.IO;
using Tyuiu.UsoltsevME.Sprint5.Task6.V18.Lib;

namespace Tyuiu.UsoltsevME.Sprint5.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V18.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден: " + path);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Файл найден: " + path);

            int result = ds.LoadFromDataFile(path);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Количество однозначных чисел: " + result);

            Console.ReadKey();
        }
    }
}
