
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.UsoltsevME.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            MatchCollection numbers = Regex.Matches(
                text, @"(?<![\p{L}\d])\d(?![\p{L}\d])");

            return numbers.Count;
        }
    }
}
