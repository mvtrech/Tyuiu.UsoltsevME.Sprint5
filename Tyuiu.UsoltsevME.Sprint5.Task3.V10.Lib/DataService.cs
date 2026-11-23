
using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task3.V10.Lib
{
    public class DataService : ISprint5Task3V10
    {
        public string SaveToFileTextData(int x)
        {
            double result = -Math.Pow(x, 3)
                + 4 * Math.Pow(x, 2)
                - (3.0 / 2) * x;

            result = Math.Round(result, 3);

            string folder = Path.Combine(
                Path.GetTempPath(),
                Guid.NewGuid().ToString()
            );

            Directory.CreateDirectory(folder);

            string path = Path.Combine(
                folder,
                "OutPutFileTask3.bin"
            );

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result);
            }

            return path;
        }
    }
}
