using Tyuiu.ChepragaDM.Sprint6.Task5.V26.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task5.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\D1agAAA\source\repos\Tyuiu.ChepragaDM.Sprint6\Tyuiu.ChepragaDM.Sprint6.Task5.V26\bin\Debug\net8.0-windows\InPutDataFileTask5V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            var resArray = ds.LoadFromDataFile(path);
            double[] waitArray = new double[resArray.Length];
            waitArray[0] = 10;
            waitArray[1] = 0;
            


            CollectionAssert.AreEqual(waitArray, resArray);
            
        }
    }
}
