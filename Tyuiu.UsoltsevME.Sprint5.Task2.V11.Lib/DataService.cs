
using tyuiu.cources.programming.interfaces.Sprint5;
using System;
using System.IO;
using System.Text;

namespace Tyuiu.UsoltsevME.Sprint5.Task2.V11.Lib
{
    public class DataService : ISprint5Task2V11
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            StringBuilder result = new StringBuilder();

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }

                    result.Append(matrix[i, j]);

                    if (j < columns - 1)
                    {
                        result.Append(";");
                    }
                }

                if (i < rows - 1)
                {
                    result.AppendLine();
                }
            }

            string folder = Path.Combine(
                Path.GetTempPath(),
                Guid.NewGuid().ToString()
            );

            Directory.CreateDirectory(folder);

            string path = Path.Combine(folder, "OutPutFileTask2.csv");

            File.WriteAllText(path, result.ToString());

            return path;
        }
    }
}
