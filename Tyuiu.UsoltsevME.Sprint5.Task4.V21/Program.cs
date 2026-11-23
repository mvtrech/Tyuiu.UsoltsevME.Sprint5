
using System;
using System.IO;
using System.Globalization;
using Tyuiu.UsoltsevME.Sprint5.Task4.V21.Lib;

namespace Tyuiu.UsoltsevME.Sprint5.Task4.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден: " + path);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Путь к файлу: " + path);

            double result = ds.LoadFromDataFile(path);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Результат = " +
                result.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
