
using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;
using System.Globalization;

namespace Tyuiu.UsoltsevME.Sprint5.Task0.V22.Lib
{
    public class DataService : ISprint5Task0V22
    {
        public string SaveToFileTextData(int x)
        {
            double result = Math.Pow(1 - x, 2) / (-3.0 * x);

            result = Math.Round(result, 3);

            string text = result.ToString("F3", new CultureInfo("ru-RU"));

            string folder = Path.Combine(
                Path.GetTempPath(),
                Guid.NewGuid().ToString()
            );

            Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, "OutPutFileTask0.txt");

            File.WriteAllText(path, text);

            return path;
        }
    }
}
