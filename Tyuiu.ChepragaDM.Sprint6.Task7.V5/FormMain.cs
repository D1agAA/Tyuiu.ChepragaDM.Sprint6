using Tyuiu.ChepragaDM.Sprint6.Task7.V5.Lib;

namespace Tyuiu.ChepragaDM.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_CDM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_CDM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);

                }
            }
            return arrayValues;
        }
        private void buttonOpen_CDM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CDM.ShowDialog();
            openFilePath = openFileDialogTask_CDM.FileName;
            int[,] arrayValues = new int[rows, cols];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_CDM.ColumnCount = cols;
            dataGridViewIn_CDM.RowCount = rows;
            dataGridViewOut_CDM.ColumnCount = cols;
            dataGridViewOut_CDM.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewIn_CDM.Columns[i].Width = 25;
                    dataGridViewOut_CDM.Columns[i].Width = 25;
                }
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewIn_CDM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            
            buttonVipolnit_CDM.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_CDM.ColumnCount = 50;
            dataGridViewOut_CDM.ColumnCount = 50;
            dataGridViewIn_CDM.RowCount = 50;
            dataGridViewOut_CDM.RowCount = 50;
        }

        private void buttonVipolnit_CDM_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, cols];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewOut_CDM.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_CDM.Enabled = true;
        }

        private void buttonSave_CDM_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_CDM.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_CDM.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_CDM.ShowDialog();

            string path = saveFileDialogTask_CDM.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_CDM.RowCount;
            int cols = dataGridViewOut_CDM.ColumnCount;
            string str = "";
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (c != cols - 1)
                    {
                        str = str + dataGridViewOut_CDM.Rows[r].Cells[c].Value + ";";

                    }
                    else
                    {
                        str = str + dataGridViewOut_CDM.Rows[r].Cells[c].Value;

                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpen_CDM_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Подсказка";
        }

        private void buttonVipolnit_CDM_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Подсказка";
        }

        private void buttonSave_CDM_MouseEnter(object sender, MouseEventArgs e)
        {
            toolTip.ToolTipTitle = "Подсказка";
        }

        private void buttonSpravka_CDM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();

        }
        private void buttonSpravka_CDM_MouseEnter(Object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Подсказка";

        }
    }
}