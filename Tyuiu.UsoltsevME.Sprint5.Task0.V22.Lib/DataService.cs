
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
            if (x == 0)
            {
                throw new ArgumentException("x не должен быть равен нулю");
            }

            double result = Math.Pow(1 - x, 2) / (-3.0 * x);

            result = Math.Round(result, 3);

            string path = Path.Combine(
                Path.GetTempPath(),
                "OutPutFileTask0.txt"
            );

            File.WriteAllText(
                path,
                result.ToString("F3", CultureInfo.InvariantCulture)
            );

            return path;
        }
    }
}
