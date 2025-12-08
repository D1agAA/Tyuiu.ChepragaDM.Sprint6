using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChepragaDM.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double f = 0;
                if (((2 * i) - 0.5) != 0)
                {
                    f = Math.Round(5 - (3*i) + (1 + Math.Sin(1) / ((2 * i) - 0.5)), 2);
                }
                res[count++] = f;

            }
            return res;
        }
    }
}
