using Tyuiu.ChepragaDM.Sprint6.Task2.V14.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] wait = [19.81, 16.79, 13.87, 10.98, 7.94, 3.0, 3.23, -0.45, -3.79, -6.97, -10.0]
;
            int start = -5;
            int stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
