
using Tyuiu.UsoltsevME.Sprint5.Task3.V10.Lib;
using System;
using System.Globalization;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            string path = ds.SaveToFileTextData(x);

            double result;

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("F(x) = " + result.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Файл сохранен: " + path);

            Console.ReadKey();
        }
    }
}
