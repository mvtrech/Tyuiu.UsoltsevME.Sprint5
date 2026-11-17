
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint5.Task0.V22.Lib;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextDataTest()
        {
            DataService ds = new DataService();

            int x = 3;

            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            string result = File.ReadAllText(path);

            Assert.AreEqual("-0.444", result);
        }
    }
}
