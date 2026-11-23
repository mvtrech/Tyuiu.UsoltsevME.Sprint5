
using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.Globalization;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path).Trim();

            double x;

            if (!double.TryParse(text, NumberStyles.Float,
                CultureInfo.InvariantCulture, out x))
            {
                x = Convert.ToDouble(text, CultureInfo.CurrentCulture);
            }

            double result = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;

            result = Math.Round(result, 3);

            return result;
        }
    }
}
