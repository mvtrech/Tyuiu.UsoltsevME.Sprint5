
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint5.Task4.V21.Lib;
using System;
using System.IO;
using System.Globalization;

namespace Tyuiu.UsoltsevME.Sprint5.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFileTest()
        {
            DataService ds = new DataService();

            double x = 5;
            string path = Path.GetTempFileName();

            File.WriteAllText(path, x.ToString(CultureInfo.InvariantCulture));

            double wait = Math.Round(
                Math.Pow(x, 3) * Math.Cos(x) + 2 * x, 3);

            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(wait, result, 0.001);

            File.Delete(path);
        }

        [TestMethod]
        public void LoadFromDataFileAnyValueTest()
        {
            DataService ds = new DataService();

            double x = -2;
            string path = Path.GetTempFileName();

            File.WriteAllText(path, x.ToString(CultureInfo.InvariantCulture));

            double wait = Math.Round(
                Math.Pow(x, 3) * Math.Cos(x) + 2 * x, 3);

            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(wait, result, 0.001);

            File.Delete(path);
        }

        [TestMethod]
        public void LoadFromDataFileZeroTest()
        {
            DataService ds = new DataService();

            double x = 0;
            string path = Path.GetTempFileName();

            File.WriteAllText(path, x.ToString(CultureInfo.InvariantCulture));

            double wait = 0;

            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(wait, result, 0.001);

            File.Delete(path);
        }
    }
}
