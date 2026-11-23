
using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.Globalization;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] values = text.Split(
                new char[] { ' ', '\r', '\n', '\t', ';' },
                StringSplitOptions.RemoveEmptyEntries);

            double min = double.MaxValue;
            bool found = false;

            foreach (string item in values)
            {
                string number = item.Replace(',', '.');

                double value = Convert.ToDouble(
                    number, CultureInfo.InvariantCulture);

                double quotient = value / 5;

                if (Math.Abs(quotient - Math.Round(quotient)) < 0.000000001)
                {
                    if (value < min)
                    {
                        min = value;
                        found = true;
                    }
                }
            }

            if (!found)
            {
                throw new Exception("В файле нет чисел, которые делятся на 5.");
            }

            return Math.Round(min, 3);
        }
    }
}
