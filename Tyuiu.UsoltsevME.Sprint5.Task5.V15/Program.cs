
using System;
using System.IO;
using System.Globalization;
using Tyuiu.UsoltsevME.Sprint5.Task5.V15.Lib;

namespace Tyuiu.UsoltsevME.Sprint5.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            string folder = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask5V15.txt";
            string path = Path.Combine(folder, fileName);

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден!");
                Console.WriteLine("Создай файл по адресу:");
                Console.WriteLine(path);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Файл найден: " + path);

            double result = ds.LoadFromDataFile(path);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Минимальное число = " +
                result.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
