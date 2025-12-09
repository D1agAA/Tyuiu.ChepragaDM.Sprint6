using Tyuiu.ChepragaDM.Sprint6.Task6.V18.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string testFilePath = "test_file2.txt";
            string testContent = "apple banana cherry dragonfruit";
            File.WriteAllText(testFilePath, testContent);

            string result = ds.CollectTextFromFile(testFilePath);

            
            string expected = "banana dragonfruit";
            Assert.AreEqual(expected, result);

           
            File.Delete(testFilePath);
        }
    }
}
