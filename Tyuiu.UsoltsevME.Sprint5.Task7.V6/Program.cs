
using System;
using System.IO;
using Tyuiu.UsoltsevME.Sprint5.Task7.V6.Lib;

namespace Tyuiu.UsoltsevME.Sprint5.Task7.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V6.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден: " + path);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Файл найден: " + path);

            string outPath = ds.LoadDataAndSave(path);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine(File.ReadAllText(outPath));
            Console.WriteLine("Результат сохранен в файл: " + outPath);

            Console.ReadKey();
        }
    }
}
