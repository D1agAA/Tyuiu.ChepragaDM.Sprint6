using Tyuiu.ChepragaDM.Sprint6.Task1.V8.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] wait = [-36.41 ,-22.07 ,5.68 ,16.72 ,0.00,-0.50, 9.63,16.29 ,5.01,-22.40 ,-36.30];
            int start = -5;
            int stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
