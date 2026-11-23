
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint5.Task7.V6.Lib;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task7.V6.Test
{
    [TestClass]
    [DoNotParallelize]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadDataAndSaveTest()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            string outPath = Path.Combine(
                Path.GetTempPath(),
                "OutPutDataFileTask7V6.txt");

            try
            {
                File.WriteAllText(path,
                    "Привет, World! This моя Первая программа.");

                if (File.Exists(outPath))
                {
                    File.Delete(outPath);
                }

                string resultPath = ds.LoadDataAndSave(path);

                string result = File.ReadAllText(resultPath);

                string wait = "Привет, #####! #### моя Первая программа.";

                Assert.AreEqual(wait, result);
            }
            finally
            {
                if (File.Exists(path))
                    File.Delete(path);

                if (File.Exists(outPath))
                    File.Delete(outPath);
            }
        }

        [TestMethod]
        public void LoadDataAndSaveAnyValuesTest()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            string outPath = Path.Combine(
                Path.GetTempPath(),
                "OutPutDataFileTask7V6.txt");

            try
            {
                File.WriteAllText(path, "Hello 123 ABC привет World");

                if (File.Exists(outPath))
                {
                    File.Delete(outPath);
                }

                string resultPath = ds.LoadDataAndSave(path);

                string result = File.ReadAllText(resultPath);

                string wait = "##### 123 ### привет #####";

                Assert.AreEqual(wait, result);
            }
            finally
            {
                if (File.Exists(path))
                    File.Delete(path);

                if (File.Exists(outPath))
                    File.Delete(outPath);
            }
        }
    }
}
