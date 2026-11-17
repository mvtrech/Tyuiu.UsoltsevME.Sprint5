
using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;
using System.Text;
using System.Globalization;

namespace Tyuiu.UsoltsevME.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V29
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            StringBuilder result = new StringBuilder();

            int step = startValue <= stopValue ? 1 : -1;

            for (int x = startValue; ; x += step)
            {
                double denominator = x + 1.2;
                double value = 0;

                if (denominator != 0)
                {
                    value = Math.Sin(x) / denominator
                        + Math.Cos(x) * 7 * x - 2;
                }

                value = Math.Round(value, 2);

                result.AppendLine(
                    value.ToString("0.##", new CultureInfo("ru-RU"))
                );

                if (x == stopValue)
                {
                    break;
                }
            }

            string folder = Path.Combine(
                Path.GetTempPath(),
                Guid.NewGuid().ToString()
            );

            Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, "OutPutFileTask1.txt");

            File.WriteAllText(path, result.ToString());

            return path;
        }
    }
}
