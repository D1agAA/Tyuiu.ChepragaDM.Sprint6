
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChepragaDM.Sprint6.Task5.V26.Lib
{
    public class DataService : ISprint6Task5V26
    {
        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {

            len = 0;


            string allContent = File.ReadAllText(path);


            string[] allNumbers = allContent.Split(new char[] { ' ', '\r', '\n', '\t' },
                                                  StringSplitOptions.RemoveEmptyEntries);


            foreach (string numStr in allNumbers)
            {
                double number = Convert.ToDouble(numStr, System.Globalization.CultureInfo.InvariantCulture);
                number = Math.Round(number, 3);

                if (number % 5 == 0)
                {
                    len++;
                }
            }


            double[] numsArray = new double[len];
            int index = 0;


            foreach (string numStr in allNumbers)
            {
                double number = Convert.ToDouble(numStr, System.Globalization.CultureInfo.InvariantCulture);
                number = Math.Round(number, 3);

                if (number % 5 == 0)
                {
                    numsArray[index] = number;
                    index++;
                }
            }

            return numsArray;
        }
    }
}    
