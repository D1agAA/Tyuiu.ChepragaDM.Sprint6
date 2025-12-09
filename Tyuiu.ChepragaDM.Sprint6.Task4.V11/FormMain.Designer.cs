namespace Tyuiu.ChepragaDM.Sprint6.Task4.V11
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
            textBoxUslovie_CDM = new TextBox();
            groupBoxVivod_CDM = new GroupBox();
            textBoxResult_CDM = new TextBox();
            chartFunction_CDM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxVvod_CDM = new GroupBox();
            buttonVipolnit_CDM = new Button();
            buttonSave_CDM = new Button();
            buttonSpravka_CDM = new Button();
            textBoxStop_CDM = new TextBox();
            textBoxStopRead_CDM = new TextBox();
            textBoxStart_CDM = new TextBox();
            textBoxStartRead_CDM = new TextBox();
            panel1 = new Panel();
            splitter3 = new Splitter();
            panel2 = new Panel();
            splitter1 = new Splitter();
            panel3 = new Panel();
            splitter2 = new Splitter();
            groupBoxUslovie_CDM.SuspendLayout();
            groupBoxVivod_CDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CDM).BeginInit();
            groupBoxVvod_CDM.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_CDM
            // 
            groupBoxUslovie_CDM.Controls.Add(textBoxUslovie_CDM);
            groupBoxUslovie_CDM.Location = new Point(0, 4);
            groupBoxUslovie_CDM.Name = "groupBoxUslovie_CDM";
            groupBoxUslovie_CDM.Size = new Size(317, 103);
            groupBoxUslovie_CDM.TabIndex = 0;
            groupBoxUslovie_CDM.TabStop = false;
            groupBoxUslovie_CDM.Text = "Условие";
            // 
            // textBoxUslovie_CDM
            // 
            textBoxUslovie_CDM.Dock = DockStyle.Left;
            textBoxUslovie_CDM.Location = new Point(3, 19);
            textBoxUslovie_CDM.Multiline = true;
            textBoxUslovie_CDM.Name = "textBoxUslovie_CDM";
            textBoxUslovie_CDM.ReadOnly = true;
            textBoxUslovie_CDM.Size = new Size(293, 81);
            textBoxUslovie_CDM.TabIndex = 0;
            textBoxUslovie_CDM.Text = "Протабулировать функцию cos(x) + sin(x)/2-2x - 4x на заданном диопозоне [-5 ; 5 ] с шагом 1. Вывести результат d TextBox и сохранить в файл по нажатию.";
            textBoxUslovie_CDM.TextChanged += textBoxUslovie_CDM_TextChanged;
            // 
            // groupBoxVivod_CDM
            // 
            groupBoxVivod_CDM.Controls.Add(textBoxResult_CDM);
            groupBoxVivod_CDM.Dock = DockStyle.Fill;
            groupBoxVivod_CDM.Location = new Point(0, 0);
            groupBoxVivod_CDM.Name = "groupBoxVivod_CDM";
            groupBoxVivod_CDM.Size = new Size(163, 450);
            groupBoxVivod_CDM.TabIndex = 1;
            groupBoxVivod_CDM.TabStop = false;
            groupBoxVivod_CDM.Text = "Вывод";
            // 
            // textBoxResult_CDM
            // 
            textBoxResult_CDM.Dock = DockStyle.Fill;
            textBoxResult_CDM.Location = new Point(3, 19);
            textBoxResult_CDM.Multiline = true;
            textBoxResult_CDM.Name = "textBoxResult_CDM";
            textBoxResult_CDM.ReadOnly = true;
            textBoxResult_CDM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CDM.Size = new Size(157, 428);
            textBoxResult_CDM.TabIndex = 1;
            // 
            // chartFunction_CDM
            // 
            chartFunction_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartFunction_CDM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_CDM.Legends.Add(legend1);
            chartFunction_CDM.Location = new Point(9, 18);
            chartFunction_CDM.Name = "chartFunction_CDM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_CDM.Series.Add(series1);
            chartFunction_CDM.Size = new Size(782, 432);
            chartFunction_CDM.TabIndex = 0;
            chartFunction_CDM.Text = "График функции ";
            title1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.RoyalBlue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction_CDM.Titles.Add(title1);
            // 
            // groupBoxVvod_CDM
            // 
            groupBoxVvod_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxVvod_CDM.Controls.Add(buttonVipolnit_CDM);
            groupBoxVvod_CDM.Controls.Add(buttonSave_CDM);
            groupBoxVvod_CDM.Controls.Add(buttonSpravka_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStop_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStopRead_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStart_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStartRead_CDM);
            groupBoxVvod_CDM.Location = new Point(317, 4);
            groupBoxVvod_CDM.Name = "groupBoxVvod_CDM";
            groupBoxVvod_CDM.Size = new Size(644, 104);
            groupBoxVvod_CDM.TabIndex = 1;
            groupBoxVvod_CDM.TabStop = false;
            groupBoxVvod_CDM.Text = "Ввод";
            // 
            // buttonVipolnit_CDM
            // 
            buttonVipolnit_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonVipolnit_CDM.BackColor = Color.Green;
            buttonVipolnit_CDM.Location = new Point(218, 19);
            buttonVipolnit_CDM.Name = "buttonVipolnit_CDM";
            buttonVipolnit_CDM.Size = new Size(83, 52);
            buttonVipolnit_CDM.TabIndex = 6;
            buttonVipolnit_CDM.Text = "Выполнить";
            buttonVipolnit_CDM.UseVisualStyleBackColor = false;
            buttonVipolnit_CDM.Click += buttonVipolnit_CDM_Click;
            // 
            // buttonSave_CDM
            // 
            buttonSave_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_CDM.BackColor = Color.SteelBlue;
            buttonSave_CDM.Location = new Point(307, 19);
            buttonSave_CDM.Name = "buttonSave_CDM";
            buttonSave_CDM.Size = new Size(80, 52);
            buttonSave_CDM.TabIndex = 5;
            buttonSave_CDM.Text = "Сохранить";
            buttonSave_CDM.UseVisualStyleBackColor = false;
            buttonSave_CDM.Click += buttonSave_CDM_Click;
            // 
            // buttonSpravka_CDM
            // 
            buttonSpravka_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSpravka_CDM.BackColor = Color.SkyBlue;
            buttonSpravka_CDM.Location = new Point(572, 19);
            buttonSpravka_CDM.Name = "buttonSpravka_CDM";
            buttonSpravka_CDM.Size = new Size(65, 52);
            buttonSpravka_CDM.TabIndex = 4;
            buttonSpravka_CDM.Text = "Справка";
            buttonSpravka_CDM.UseVisualStyleBackColor = false;
            buttonSpravka_CDM.Click += buttonSpravka_CDM_Click;
            // 
            // textBoxStop_CDM
            // 
            textBoxStop_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxStop_CDM.Location = new Point(112, 48);
            textBoxStop_CDM.Name = "textBoxStop_CDM";
            textBoxStop_CDM.Size = new Size(100, 23);
            textBoxStop_CDM.TabIndex = 3;
            // 
            // textBoxStopRead_CDM
            // 
            textBoxStopRead_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxStopRead_CDM.Location = new Point(112, 19);
            textBoxStopRead_CDM.Name = "textBoxStopRead_CDM";
            textBoxStopRead_CDM.ReadOnly = true;
            textBoxStopRead_CDM.Size = new Size(100, 23);
            textBoxStopRead_CDM.TabIndex = 2;
            textBoxStopRead_CDM.Text = "Конец шага:";
            // 
            // textBoxStart_CDM
            // 
            textBoxStart_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxStart_CDM.Location = new Point(6, 48);
            textBoxStart_CDM.Name = "textBoxStart_CDM";
            textBoxStart_CDM.Size = new Size(100, 23);
            textBoxStart_CDM.TabIndex = 1;
            // 
            // textBoxStartRead_CDM
            // 
            textBoxStartRead_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxStartRead_CDM.Location = new Point(6, 19);
            textBoxStartRead_CDM.Name = "textBoxStartRead_CDM";
            textBoxStartRead_CDM.ReadOnly = true;
            textBoxStartRead_CDM.Size = new Size(100, 23);
            textBoxStartRead_CDM.TabIndex = 0;
            textBoxStartRead_CDM.Text = "Старт шага:";
            // 
            // panel1
            // 
            panel1.Controls.Add(splitter3);
            panel1.Controls.Add(groupBoxVvod_CDM);
            panel1.Controls.Add(groupBoxUslovie_CDM);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 113);
            panel1.TabIndex = 7;
            // 
            // splitter3
            // 
            splitter3.Dock = DockStyle.Bottom;
            splitter3.Location = new Point(0, 110);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(963, 3);
            splitter3.TabIndex = 2;
            splitter3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxVivod_CDM);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 450);
            panel2.TabIndex = 2;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(163, 113);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 450);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(splitter2);
            panel3.Controls.Add(chartFunction_CDM);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(166, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(797, 450);
            panel3.TabIndex = 10;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 450);
            splitter2.TabIndex = 1;
            splitter2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 563);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(979, 602);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Спринт 6 | Таск 4 | Вариант 11 | Чепрага Д.М. ";
            groupBoxUslovie_CDM.ResumeLayout(false);
            groupBoxUslovie_CDM.PerformLayout();
            groupBoxVivod_CDM.ResumeLayout(false);
            groupBoxVivod_CDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CDM).EndInit();
            groupBoxVvod_CDM.ResumeLayout(false);
            groupBoxVvod_CDM.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_CDM;
        private GroupBox groupBoxVivod_CDM;
        private TextBox textBoxUslovie_CDM;
        private GroupBox groupBoxVvod_CDM;
        private Button buttonVipolnit_CDM;
        private Button buttonSave_CDM;
        private Button buttonSpravka_CDM;
        private TextBox textBoxStop_CDM;
        private TextBox textBoxStopRead_CDM;
        private TextBox textBoxStart_CDM;
        private TextBox textBoxStartRead_CDM;
        private TextBox textBoxResult_CDM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CDM;
        private Panel panel1;
        private Panel panel2;
        private Splitter splitter1;
        private Panel panel3;
        private Splitter splitter3;
        private Splitter splitter2;
    }
}
