using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using Tyuiu.ChepragaDM.Sprint6.Task4.V11.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task4.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private double[]? currentXValues;
        private double[]? currentYValues;

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

                textBoxResult_CDM.Text = "";
                chartFunction_CDM.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_CDM.ChartAreas[0].AxisY.Title = "Ось Y";

                chartFunction_CDM.Series[0].Points.Clear();

                chartFunction_CDM.Series[0].ChartType = SeriesChartType.Spline;

                currentXValues = new double[len];
                currentYValues = new double[len];

                string resultText = "";

                for (int i = 0; i < len; i++)
                {
                    int currentX = startStep + i;
                    currentXValues[i] = currentX;
                    currentYValues[i] = valueArray[i];
                    chartFunction_CDM.Series[0].Points.AddXY(currentX, valueArray[i]);

                    resultText += Convert.ToString(currentX) + "\t" + Convert.ToString(valueArray[i]) + "\r\n";
                }

                textBoxResult_CDM.Text = resultText;

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_CDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4  выполнил студент группы ИБКСб-25-1 Чепрага Дмитрий Максимович", "Сообщение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_CDM_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.GetTempPath();
                string path = Path.Combine(tempPath, "OutPutFileTask4V9.txt");

                File.WriteAllText(path, textBoxResult_CDM.Text);

                DialogResult dialogResult = MessageBox.Show(" файл " + path + " сохранено успешно\nОткрыть его?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();

                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxUslovie_CDM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
