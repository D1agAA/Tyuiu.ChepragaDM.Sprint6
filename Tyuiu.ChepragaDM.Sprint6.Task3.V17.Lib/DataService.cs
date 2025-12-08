using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChepragaDM.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            
            List<(int value, int rowIndex)> columnData = new List<(int, int)>();

            for (int i = 0; i < rows; i++)
            {
                columnData.Add((matrix[i, 3], i));
            }

          
            var sortedColumnData = columnData.OrderBy(x => x.value).ToList();

          
            int[,] sortedMatrix = new int[rows, cols];

            for (int newRow = 0; newRow < rows; newRow++)
            {
                int oldRow = sortedColumnData[newRow].rowIndex;
                for (int j = 0; j < cols; j++)
                {
                    sortedMatrix[newRow, j] = matrix[oldRow, j];
                }
            }

            return sortedMatrix;
        }
    }
}
