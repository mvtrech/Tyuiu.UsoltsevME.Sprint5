
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint5.Task5.V15.Lib;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFileTest()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            File.WriteAllText(path, "15\n10\n-20\n7\n25\n");

            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(10.0, result, 0.001);

            File.Delete(path);
        }

        [TestMethod]
        public void LoadFromDataFileAnyValueTest()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            File.WriteAllText(path, "30\n12\n-5\n18\n40\n");

            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(30.0, result, 0.001);

            File.Delete(path);
        }

        [TestMethod]
        public void LoadFromDataFileDecimalTest()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            File.WriteAllText(path, "15.5\n10.25\n-10.5\n20\n");

            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(20.0, result, 0.001);

            File.Delete(path);
        }
    }
}

