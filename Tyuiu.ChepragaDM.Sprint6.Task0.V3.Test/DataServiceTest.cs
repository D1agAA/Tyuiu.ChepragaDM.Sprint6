using Tyuiu.ChepragaDM.Sprint6.Task0.V3.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 4.154;
            Assert.AreEqual(wait, res);
        }
    }
}
