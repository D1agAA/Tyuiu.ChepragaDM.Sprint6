namespace Tyuiu.ChepragaDM.Sprint6.Task5.V26
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxUslovie_CDM = new GroupBox();
            textBox1 = new TextBox();
            buttonSpravka_CDM = new Button();
            buttonOpenFile_CDM = new Button();
            buttonVipolnit_CDM = new Button();
            groupBoxVivod_CDM = new GroupBox();
            dataGridViewResult_CDM = new DataGridView();
            chartFunction_CDM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUslovie_CDM = new Panel();
            panelVivod_CDM = new Panel();
            panelGrafic_CDM = new Panel();
            splitter1 = new Splitter();
            groupBoxUslovie_CDM.SuspendLayout();
            groupBoxVivod_CDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CDM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CDM).BeginInit();
            panelUslovie_CDM.SuspendLayout();
            panelVivod_CDM.SuspendLayout();
            panelGrafic_CDM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_CDM
            // 
            groupBoxUslovie_CDM.Controls.Add(textBox1);
            groupBoxUslovie_CDM.Dock = DockStyle.Left;
            groupBoxUslovie_CDM.Location = new Point(0, 0);
            groupBoxUslovie_CDM.Name = "groupBoxUslovie_CDM";
            groupBoxUslovie_CDM.Size = new Size(475, 88);
            groupBoxUslovie_CDM.TabIndex = 0;
            groupBoxUslovie_CDM.TabStop = false;
            groupBoxUslovie_CDM.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Left;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(465, 66);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла. Вывести в DataGridView положительные значения и построить диограмму по этим значениям.";
            // 
            // buttonSpravka_CDM
            // 
            buttonSpravka_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSpravka_CDM.BackColor = Color.SkyBlue;
            buttonSpravka_CDM.Location = new Point(687, 9);
            buttonSpravka_CDM.Name = "buttonSpravka_CDM";
            buttonSpravka_CDM.Size = new Size(96, 73);
            buttonSpravka_CDM.TabIndex = 1;
            buttonSpravka_CDM.Text = "Справка";
            buttonSpravka_CDM.UseVisualStyleBackColor = false;
            buttonSpravka_CDM.Click += buttonSpravka_CDM_Click;
            // 
            // buttonOpenFile_CDM
            // 
            buttonOpenFile_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile_CDM.BackColor = Color.RoyalBlue;
            buttonOpenFile_CDM.Location = new Point(585, 9);
            buttonOpenFile_CDM.Name = "buttonOpenFile_CDM";
            buttonOpenFile_CDM.Size = new Size(96, 73);
            buttonOpenFile_CDM.TabIndex = 2;
            buttonOpenFile_CDM.Text = "Открыть файл";
            buttonOpenFile_CDM.UseVisualStyleBackColor = false;
            buttonOpenFile_CDM.Click += buttonOpen_CDM_Click;
            // 
            // buttonVipolnit_CDM
            // 
            buttonVipolnit_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonVipolnit_CDM.BackColor = Color.Green;
            buttonVipolnit_CDM.Location = new Point(481, 9);
            buttonVipolnit_CDM.Name = "buttonVipolnit_CDM";
            buttonVipolnit_CDM.Size = new Size(98, 73);
            buttonVipolnit_CDM.TabIndex = 3;
            buttonVipolnit_CDM.Text = "Выполнить";
            buttonVipolnit_CDM.UseVisualStyleBackColor = false;
            buttonVipolnit_CDM.Click += buttonVipolnit_CDM_Click;
            // 
            // groupBoxVivod_CDM
            // 
            groupBoxVivod_CDM.Controls.Add(dataGridViewResult_CDM);
            groupBoxVivod_CDM.Dock = DockStyle.Fill;
            groupBoxVivod_CDM.Location = new Point(0, 0);
            groupBoxVivod_CDM.Name = "groupBoxVivod_CDM";
            groupBoxVivod_CDM.Size = new Size(179, 362);
            groupBoxVivod_CDM.TabIndex = 4;
            groupBoxVivod_CDM.TabStop = false;
            groupBoxVivod_CDM.Text = "Вывод";
            // 
            // dataGridViewResult_CDM
            // 
            dataGridViewResult_CDM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_CDM.ColumnHeadersVisible = false;
            dataGridViewResult_CDM.Dock = DockStyle.Fill;
            dataGridViewResult_CDM.Location = new Point(3, 19);
            dataGridViewResult_CDM.Name = "dataGridViewResult_CDM";
            dataGridViewResult_CDM.ReadOnly = true;
            dataGridViewResult_CDM.RowHeadersVisible = false;
            dataGridViewResult_CDM.Size = new Size(173, 340);
            dataGridViewResult_CDM.TabIndex = 1;
            // 
            // chartFunction_CDM
            // 
            chartFunction_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartFunction_CDM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_CDM.Legends.Add(legend1);
            chartFunction_CDM.Location = new Point(196, 7);
            chartFunction_CDM.Name = "chartFunction_CDM";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_CDM.Series.Add(series1);
            chartFunction_CDM.Size = new Size(589, 343);
            chartFunction_CDM.TabIndex = 0;
            chartFunction_CDM.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.RoyalBlue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction_CDM.Titles.Add(title1);
            // 
            // panelUslovie_CDM
            // 
            panelUslovie_CDM.Controls.Add(buttonSpravka_CDM);
            panelUslovie_CDM.Controls.Add(groupBoxUslovie_CDM);
            panelUslovie_CDM.Controls.Add(buttonOpenFile_CDM);
            panelUslovie_CDM.Controls.Add(buttonVipolnit_CDM);
            panelUslovie_CDM.Dock = DockStyle.Top;
            panelUslovie_CDM.Location = new Point(0, 0);
            panelUslovie_CDM.Name = "panelUslovie_CDM";
            panelUslovie_CDM.Size = new Size(800, 88);
            panelUslovie_CDM.TabIndex = 5;
            // 
            // panelVivod_CDM
            // 
            panelVivod_CDM.Controls.Add(groupBoxVivod_CDM);
            panelVivod_CDM.Dock = DockStyle.Left;
            panelVivod_CDM.Location = new Point(0, 88);
            panelVivod_CDM.Name = "panelVivod_CDM";
            panelVivod_CDM.Size = new Size(179, 362);
            panelVivod_CDM.TabIndex = 1;
            // 
            // panelGrafic_CDM
            // 
            panelGrafic_CDM.Controls.Add(chartFunction_CDM);
            panelGrafic_CDM.Dock = DockStyle.Fill;
            panelGrafic_CDM.Location = new Point(0, 88);
            panelGrafic_CDM.Name = "panelGrafic_CDM";
            panelGrafic_CDM.Size = new Size(800, 362);
            panelGrafic_CDM.TabIndex = 2;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(179, 88);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 362);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitter1);
            Controls.Add(panelVivod_CDM);
            Controls.Add(panelGrafic_CDM);
            Controls.Add(panelUslovie_CDM);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 26 | Чепрага Д.М. ";
            groupBoxUslovie_CDM.ResumeLayout(false);
            groupBoxUslovie_CDM.PerformLayout();
            groupBoxVivod_CDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CDM).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CDM).EndInit();
            panelUslovie_CDM.ResumeLayout(false);
            panelVivod_CDM.ResumeLayout(false);
            panelGrafic_CDM.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_CDM;
        private TextBox textBox1;
        private Button buttonSpravka_CDM;
        private Button buttonOpenFile_CDM;
        private Button buttonVipolnit_CDM;
        private GroupBox groupBoxVivod_CDM;
        private DataGridView dataGridViewResult_CDM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CDM;
        private Panel panelUslovie_CDM;
        private Panel panelGrafic_CDM;
        private Panel panelVivod_CDM;
        private Splitter splitter1;
    }
}
