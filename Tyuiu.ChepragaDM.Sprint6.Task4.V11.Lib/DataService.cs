using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChepragaDM.Sprint6.Task4.V11.Lib
{
    public class DataService : ISprint6Task4V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mas = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 - 2 * x) == 0)
                {
                    mas[index++] = 0;
                }
                else
                {
                    mas[index++] = Math.Round(Math.Cos(x) + (Math.Sin(x)/(2 - 2 * x)) - (4 * x), 2);

                }
            }

            return mas;
        }
    }
}
