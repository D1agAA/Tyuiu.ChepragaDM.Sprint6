using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChepragaDM.Sprint6.Task1.V8.Lib
{
    public class DataService : ISprint6Task1V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double f = 0;
                if (i + 1 != 0)
                {
                    f = Math.Round((Math.Cos(i) / (i - 0.4)) + Math.Sin(i) * (8 * i) + 2, 2);
                }
                res[count++] = f;

            }
            return res;
        }
    }
}
