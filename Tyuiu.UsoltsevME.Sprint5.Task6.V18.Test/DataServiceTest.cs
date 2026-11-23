
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint5.Task6.V18.Lib;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFileTest()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            File.WriteAllText(path, "1 привет 12 км 4 раза 543 исчислений");

            int result = ds.LoadFromDataFile(path);

            Assert.AreEqual(2, result);

            File.Delete(path);
        }

        [TestMethod]
        public void LoadFromDataFileAnyValuesTest()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            File.WriteAllText(path, "5 25 7 100 3 456 9");

            int result = ds.LoadFromDataFile(path);

            Assert.AreEqual(4, result);

            File.Delete(path);
        }
    }
}
