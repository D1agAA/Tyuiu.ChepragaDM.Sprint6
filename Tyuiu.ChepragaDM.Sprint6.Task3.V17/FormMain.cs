using Tyuiu.ChepragaDM.Sprint6.Task3.V17.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = { { 22, 32, -16, 24, 27 }, { 3, -20, 24, -20, 25 }, { 21, 17, -8, -19, 17 }, { 8, 22, 28, 27, 19 }, { 11, 20, 12, 27, 29 } };



        private void FormMain_Load(object sender, EventArgs e)
        {
            
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);

            dataGridViewMatrix_CDM.ColumnCount = cols;
            dataGridViewMatrix_CDM.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_CDM.Columns[i].Width = 50;
            }
        }
        private void buttonVipolnit_CDM_Click(object sender, EventArgs e)
        {

            int[,] resultMatrix = ds.Calculate(mtrx);

            int rows = resultMatrix.GetLength(0);
            int cols = resultMatrix.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_CDM.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }
        }
        private void buttonSpravka_CDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3  выполнил студент группы ИБКСб-25-1 Чепрага Дмитрий Максимович", "Сообщение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

