
using Tyuiu.UsoltsevME.Sprint5.Task1.V29.Lib;
using System;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task1.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите начальное значение: ");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное значение: ");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            string path = ds.SaveToFileTextData(startValue, stopValue);

            string[] lines = File.ReadAllLines(path);

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("Файл сохранен: " + path);

            Console.ReadKey();
        }
    }
}
