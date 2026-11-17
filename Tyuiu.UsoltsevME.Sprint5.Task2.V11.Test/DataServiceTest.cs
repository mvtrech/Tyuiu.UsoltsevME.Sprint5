
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint5.Task2.V11.Lib;
using System.IO;

namespace Tyuiu.UsoltsevME.Sprint5.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextDataTest()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 4, 9, 3 },
                { 5, 8, 8 },
                { 5, 7, 5 }
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            string[] wait =
            {
                "4;0;0",
                "0;8;8",
                "0;0;0"
            };

            CollectionAssert.AreEqual(wait, lines);
        }
    }
}
