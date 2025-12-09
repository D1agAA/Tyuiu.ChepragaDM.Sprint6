using Tyuiu.ChepragaDM.Sprint6.Task6.V18.Lib;
namespace Tyuiu.ChepragaDM.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        
        private void buttonOpen_CDM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CDM.ShowDialog();
            openFilePath = openFileDialogTask_CDM.FileName;
            textBoxVvod_CDM.Text = File.ReadAllText(openFilePath);
            
            buttonVipolnit_CDM.Enabled = true;
        }

        private void buttonVipolnit_CDM_Click(object sender, EventArgs e)
        {

            string str = "";
            textBoxResult_CDM.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonSpravka_CDM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }











    }
}
