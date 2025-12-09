namespace Tyuiu.ChepragaDM.Sprint6.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
           
        }
    }
}
