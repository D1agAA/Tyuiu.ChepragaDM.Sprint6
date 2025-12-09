using Tyuiu.ChepragaDM.Sprint6.Task5.V26.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task5.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\D1agAAA\source\repos\Tyuiu.ChepragaDM.Sprint6\Tyuiu.ChepragaDM.Sprint6.Task5.V26\bin\Debug\net8.0-windows\InPutDataFileTask5V26.txt";

        private void buttonVipolnit_CDM_Click(object sender, EventArgs e)
        {
            dataGridViewResult_CDM.ColumnCount = 2;
            dataGridViewResult_CDM.Columns[0].Width = 20;
            dataGridViewResult_CDM.Columns[1].Width = 50;
            this.chartFunction_CDM.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_CDM.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_CDM.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_CDM.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartFunction_CDM.Series[0].Points.AddXY(i, numMass[i]);

            }
        }

        private void buttonOpen_CDM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();

        }

        private void buttonSpravka_CDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5  выполнил студент группы ИБКСб-25-1 Чепрага Дмитрий Максимович", "Сообщение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        
    }
}
        
