
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint5.Task3.V10.Lib;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextDataTest()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(4);

            Assert.IsTrue(File.Exists(path));

            double result;

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            Assert.AreEqual(-6.0, result, 0.001);
        }

        [TestMethod]
        public void SaveToFileTextDataAnyValueTest()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(2);

            double result;

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            Assert.AreEqual(5.0, result, 0.001);
        }
    }
}
