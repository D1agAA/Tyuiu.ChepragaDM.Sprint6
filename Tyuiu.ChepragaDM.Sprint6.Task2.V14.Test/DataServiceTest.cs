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
            double[] wait = [-36.41, -22.07, 5.68, 16.72, 8.35, -0.5, 9.63, 16.29, 5.01, -22.4, -36.3]
;
            int start = -5;
            int stop = 5;
            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
