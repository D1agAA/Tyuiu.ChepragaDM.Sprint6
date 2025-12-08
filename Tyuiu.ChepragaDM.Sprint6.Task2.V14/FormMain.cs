using Tyuiu.ChepragaDM.Sprint6.Task2.V14.Lib;
namespace Tyuiu.ChepragaDM.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonVipolnit_CDM_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_CDM.Text);
                int stopStep = Convert.ToInt32(textBoxStop_CDM.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_CDM.Titles.Add("Функция cos(x) + 4x/2 - sin(x) * 3x");
                this.chartFunction_CDM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_CDM.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewMatrix_CDM.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_CDM.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       
            private void buttonSpravka_CDM_Click(object sender, EventArgs e)
            {
            MessageBox.Show("Таск 2  выполнил студент группы ИБКСб-25-1 Чепрага Дмитрий Максимович", "Сообщение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
    }
}

