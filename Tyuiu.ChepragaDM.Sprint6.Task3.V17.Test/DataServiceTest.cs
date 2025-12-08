using Tyuiu.ChepragaDM.Sprint6.Task3.V17.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = { { 17, 0, 19, -8, -1 }, { 9, 4, -5, 7, 15 }, { 11, 13, 4, -4, -14 }, { 11, 14, 5, -15, 16 }, { 2, -14, -2, 11, 11 } };
            int[,] wait = { { 17, 0, 19, 0, -1 }, { 9, 4, -5, 7, 15 }, { 11, 13, 4, -4, -14 }, { 11, 14, 5, -15, 16 }, { 2, -14, -2, 11, 11 } };
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
