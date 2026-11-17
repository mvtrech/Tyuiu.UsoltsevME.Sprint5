
using Tyuiu.UsoltsevME.Sprint5.Task2.V11.Lib;
using System;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3];

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Введите 9 целых чисел для массива 3 на 3:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Элемент [" + i + ", " + j + "]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            string path = ds.SaveToFileTextData(matrix);

            int[,] result = (int[,])matrix.Clone();

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Файл сохранен: " + path);

            Console.ReadKey();
        }
    }
}
