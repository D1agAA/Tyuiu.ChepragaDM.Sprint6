using Tyuiu.ChepragaDM.Sprint6.Task1.V8.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task1.V8
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
                int stopStep = Convert.ToInt32(textBoxFinish_CDM.Text);
                string strline;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_CDM.Text = "";
                textBoxResult_CDM.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_CDM.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_CDM.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,5:d}     | {1,  6:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_CDM.AppendText(strline + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_CDM.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSpravka_CDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИБКСб-25-1 Чепрага Дмитрий Максимович", "Сообщение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }











    }
}
