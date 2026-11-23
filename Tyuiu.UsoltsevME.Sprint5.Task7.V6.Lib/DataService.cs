
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.UsoltsevME.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string result = Regex.Replace(text, "[a-zA-Z]", "#");

            string outPath = Path.Combine(
                Path.GetTempPath(),
                "OutPutDataFileTask7V6.txt");

            File.WriteAllText(outPath, result);

            return outPath;
        }
    }
}
