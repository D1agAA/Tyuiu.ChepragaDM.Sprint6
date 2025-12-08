using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChepragaDM.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

          
            int[,] result = (int[,])matrix.Clone();

           
            int[] fourthColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                fourthColumn[i] = matrix[i, 3];
            }

           
            Array.Sort(fourthColumn);

           
            for (int i = 0; i < rows; i++)
            {
                result[i, 3] = fourthColumn[i];
            }

            return result;
        }
    }
}
