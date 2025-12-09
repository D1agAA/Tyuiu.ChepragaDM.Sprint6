using System.Diagnostics;
using System.IO;
using Tyuiu.ChepragaDM.Sprint6.Task4.V11.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Tyuiu.ChepragaDM.Sprint6.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            string path = @"C:\Users\D1agAAA\source\repos\Tyuiu.ChepragaDM.Sprint6\Tyuiu.ChepragaDM.Sprint6.Task5.V26\bin\Debug\net8.0-windows\InPutDataFileTask5V26.txt";



            FileInfo file = new FileInfo(path);
            bool fileE = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE);
        }
    }
}
