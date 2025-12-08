using Tyuiu.ChepragaDM.Sprint6.Task0.V3.Lib;
namespace Tyuiu.ChepragaDM.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonVipolnit_CDM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService(); 
            try
            {
                textBoxResult_CDM.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxPeremennayaX_CDM.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBoxPeremennayaX_CDM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonSpravka_CDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИБКСб-25-1 Чепрага Дмитрий Максимович", "Сообщение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
