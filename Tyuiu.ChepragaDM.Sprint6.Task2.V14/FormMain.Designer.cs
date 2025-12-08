namespace Tyuiu.ChepragaDM.Sprint6.Task2.V14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxUslovia_CDM = new GroupBox();
            pictureBoxPrimer_CDM = new PictureBox();
            textBoxUslovie_CDM = new TextBox();
            groupBoxVvod_CDM = new GroupBox();
            textBoxStop_CDM = new TextBox();
            textBoxStopRead_CDM = new TextBox();
            textBoxStart_CDM = new TextBox();
            textBoxStartRead_CDM = new TextBox();
            buttonSpravka_CDM = new Button();
            buttonVipolnit_CDM = new Button();
            textBoxResult_CDM = new TextBox();
            groupBoxVivod_CDM = new GroupBox();
            chartFunction_CDM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewMatrix_CDM = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Fx = new DataGridViewTextBoxColumn();
            groupBoxUslovia_CDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrimer_CDM).BeginInit();
            groupBoxVvod_CDM.SuspendLayout();
            groupBoxVivod_CDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CDM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_CDM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUslovia_CDM
            // 
            groupBoxUslovia_CDM.Controls.Add(pictureBoxPrimer_CDM);
            groupBoxUslovia_CDM.Controls.Add(textBoxUslovie_CDM);
            groupBoxUslovia_CDM.Location = new Point(12, 12);
            groupBoxUslovia_CDM.Name = "groupBoxUslovia_CDM";
            groupBoxUslovia_CDM.Size = new Size(554, 318);
            groupBoxUslovia_CDM.TabIndex = 0;
            groupBoxUslovia_CDM.TabStop = false;
            groupBoxUslovia_CDM.Text = "Условия";
            // 
            // pictureBoxPrimer_CDM
            // 
            pictureBoxPrimer_CDM.Image = (Image)resources.GetObject("pictureBoxPrimer_CDM.Image");
            pictureBoxPrimer_CDM.Location = new Point(18, 56);
            pictureBoxPrimer_CDM.Name = "pictureBoxPrimer_CDM";
            pictureBoxPrimer_CDM.Size = new Size(303, 44);
            pictureBoxPrimer_CDM.TabIndex = 1;
            pictureBoxPrimer_CDM.TabStop = false;
            // 
            // textBoxUslovie_CDM
            // 
            textBoxUslovie_CDM.Location = new Point(6, 22);
            textBoxUslovie_CDM.Multiline = true;
            textBoxUslovie_CDM.Name = "textBoxUslovie_CDM";
            textBoxUslovie_CDM.ReadOnly = true;
            textBoxUslovie_CDM.Size = new Size(542, 290);
            textBoxUslovie_CDM.TabIndex = 0;
            textBoxUslovie_CDM.Text = resources.GetString("textBoxUslovie_CDM.Text");
            // 
            // groupBoxVvod_CDM
            // 
            groupBoxVvod_CDM.Controls.Add(textBoxStop_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStopRead_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStart_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStartRead_CDM);
            groupBoxVvod_CDM.Location = new Point(12, 336);
            groupBoxVvod_CDM.Name = "groupBoxVvod_CDM";
            groupBoxVvod_CDM.Size = new Size(308, 89);
            groupBoxVvod_CDM.TabIndex = 2;
            groupBoxVvod_CDM.TabStop = false;
            groupBoxVvod_CDM.Text = "Ввод";
            // 
            // textBoxStop_CDM
            // 
            textBoxStop_CDM.Location = new Point(148, 51);
            textBoxStop_CDM.Name = "textBoxStop_CDM";
            textBoxStop_CDM.Size = new Size(141, 23);
            textBoxStop_CDM.TabIndex = 5;
            // 
            // textBoxStopRead_CDM
            // 
            textBoxStopRead_CDM.Location = new Point(148, 22);
            textBoxStopRead_CDM.Name = "textBoxStopRead_CDM";
            textBoxStopRead_CDM.ReadOnly = true;
            textBoxStopRead_CDM.Size = new Size(141, 23);
            textBoxStopRead_CDM.TabIndex = 3;
            textBoxStopRead_CDM.Text = "Конец шага:";
            // 
            // textBoxStart_CDM
            // 
            textBoxStart_CDM.Location = new Point(6, 51);
            textBoxStart_CDM.Name = "textBoxStart_CDM";
            textBoxStart_CDM.Size = new Size(136, 23);
            textBoxStart_CDM.TabIndex = 4;
            // 
            // textBoxStartRead_CDM
            // 
            textBoxStartRead_CDM.Location = new Point(6, 22);
            textBoxStartRead_CDM.Name = "textBoxStartRead_CDM";
            textBoxStartRead_CDM.ReadOnly = true;
            textBoxStartRead_CDM.Size = new Size(136, 23);
            textBoxStartRead_CDM.TabIndex = 3;
            textBoxStartRead_CDM.Text = "Старт шага:";
            // 
            // buttonSpravka_CDM
            // 
            buttonSpravka_CDM.BackColor = Color.RoyalBlue;
            buttonSpravka_CDM.Location = new Point(326, 345);
            buttonSpravka_CDM.Name = "buttonSpravka_CDM";
            buttonSpravka_CDM.Size = new Size(99, 80);
            buttonSpravka_CDM.TabIndex = 6;
            buttonSpravka_CDM.Text = "Справка";
            buttonSpravka_CDM.UseVisualStyleBackColor = false;
            buttonSpravka_CDM.Click += buttonSpravka_CDM_Click;
            // 
            // buttonVipolnit_CDM
            // 
            buttonVipolnit_CDM.BackColor = Color.Green;
            buttonVipolnit_CDM.Location = new Point(431, 345);
            buttonVipolnit_CDM.Name = "buttonVipolnit_CDM";
            buttonVipolnit_CDM.Size = new Size(135, 80);
            buttonVipolnit_CDM.TabIndex = 7;
            buttonVipolnit_CDM.Text = "Выполнить";
            buttonVipolnit_CDM.UseVisualStyleBackColor = false;
            buttonVipolnit_CDM.Click += buttonVipolnit_CDM_Click;
            // 
            // textBoxResult_CDM
            // 
            textBoxResult_CDM.Location = new Point(6, 22);
            textBoxResult_CDM.Name = "textBoxResult_CDM";
            textBoxResult_CDM.ReadOnly = true;
            textBoxResult_CDM.Size = new Size(578, 23);
            textBoxResult_CDM.TabIndex = 8;
            textBoxResult_CDM.Text = "Результат:";
            // 
            // groupBoxVivod_CDM
            // 
            groupBoxVivod_CDM.Controls.Add(chartFunction_CDM);
            groupBoxVivod_CDM.Controls.Add(dataGridViewMatrix_CDM);
            groupBoxVivod_CDM.Controls.Add(textBoxResult_CDM);
            groupBoxVivod_CDM.Location = new Point(572, 12);
            groupBoxVivod_CDM.Name = "groupBoxVivod_CDM";
            groupBoxVivod_CDM.Size = new Size(600, 413);
            groupBoxVivod_CDM.TabIndex = 9;
            groupBoxVivod_CDM.TabStop = false;
            groupBoxVivod_CDM.Text = "Вывод";
            // 
            // chartFunction_CDM
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_CDM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_CDM.Legends.Add(legend1);
            chartFunction_CDM.Location = new Point(117, 51);
            chartFunction_CDM.Name = "chartFunction_CDM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_CDM.Series.Add(series1);
            chartFunction_CDM.Size = new Size(477, 356);
            chartFunction_CDM.TabIndex = 9;
            chartFunction_CDM.Text = "chart1";
            // 
            // dataGridViewMatrix_CDM
            // 
            dataGridViewMatrix_CDM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_CDM.Columns.AddRange(new DataGridViewColumn[] { X, Fx });
            dataGridViewMatrix_CDM.Location = new Point(6, 51);
            dataGridViewMatrix_CDM.Name = "dataGridViewMatrix_CDM";
            dataGridViewMatrix_CDM.ReadOnly = true;
            dataGridViewMatrix_CDM.RowHeadersVisible = false;
            dataGridViewMatrix_CDM.Size = new Size(105, 347);
            dataGridViewMatrix_CDM.TabIndex = 6;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // Fx
            // 
            Fx.HeaderText = "F(X)";
            Fx.Name = "Fx";
            Fx.ReadOnly = true;
            Fx.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 431);
            Controls.Add(groupBoxVivod_CDM);
            Controls.Add(buttonVipolnit_CDM);
            Controls.Add(buttonSpravka_CDM);
            Controls.Add(groupBoxVvod_CDM);
            Controls.Add(groupBoxUslovia_CDM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 14 | Чепрага Д.М. ";
            groupBoxUslovia_CDM.ResumeLayout(false);
            groupBoxUslovia_CDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrimer_CDM).EndInit();
            groupBoxVvod_CDM.ResumeLayout(false);
            groupBoxVvod_CDM.PerformLayout();
            groupBoxVivod_CDM.ResumeLayout(false);
            groupBoxVivod_CDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CDM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_CDM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovia_CDM;
        private TextBox textBoxUslovie_CDM;
        private PictureBox pictureBoxPrimer_CDM;
        private GroupBox groupBoxVvod_CDM;
        private TextBox textBoxStop_CDM;
        private TextBox textBoxStopRead_CDM;
        private TextBox textBoxStart_CDM;
        private TextBox textBoxStartRead_CDM;
        private Button buttonSpravka_CDM;
        private Button buttonVipolnit_CDM;
        private TextBox textBoxResult_CDM;
        private GroupBox groupBoxVivod_CDM;
        private DataGridView dataGridViewMatrix_CDM;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Fx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CDM;
    }
}
