
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint5.Task1.V29.Lib;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextDataTest()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(11, lines.Length);
        }

        [TestMethod]
        public void SaveToFileTextDataOneValueTest()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(3, 3);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(1, lines.Length);
        }
    }
}
