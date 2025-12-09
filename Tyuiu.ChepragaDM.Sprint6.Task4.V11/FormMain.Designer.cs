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
            groupBoxUslovie_CDM.SuspendLayout();
            groupBoxVivod_CDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CDM).BeginInit();
            groupBoxVvod_CDM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_CDM
            // 
            groupBoxUslovie_CDM.Controls.Add(textBoxUslovie_CDM);
            groupBoxUslovie_CDM.Location = new Point(0, 0);
            groupBoxUslovie_CDM.Name = "groupBoxUslovie_CDM";
            groupBoxUslovie_CDM.Size = new Size(309, 88);
            groupBoxUslovie_CDM.TabIndex = 0;
            groupBoxUslovie_CDM.TabStop = false;
            groupBoxUslovie_CDM.Text = "Условие";
            // 
            // textBoxUslovie_CDM
            // 
            textBoxUslovie_CDM.Location = new Point(6, 12);
            textBoxUslovie_CDM.Multiline = true;
            textBoxUslovie_CDM.Name = "textBoxUslovie_CDM";
            textBoxUslovie_CDM.ReadOnly = true;
            textBoxUslovie_CDM.Size = new Size(293, 70);
            textBoxUslovie_CDM.TabIndex = 0;
            textBoxUslovie_CDM.Text = "Протабулировать функцию cos(x) + sin(x)/2-2x - 4x на заданном диопозоне [-5 ; 5 ] с шагом 1. Вывести результат d TextBox и сохранить в файл по нажатию.";
            // 
            // groupBoxVivod_CDM
            // 
            groupBoxVivod_CDM.Controls.Add(textBoxResult_CDM);
            groupBoxVivod_CDM.Controls.Add(chartFunction_CDM);
            groupBoxVivod_CDM.Location = new Point(6, 88);
            groupBoxVivod_CDM.Name = "groupBoxVivod_CDM";
            groupBoxVivod_CDM.Size = new Size(956, 485);
            groupBoxVivod_CDM.TabIndex = 1;
            groupBoxVivod_CDM.TabStop = false;
            groupBoxVivod_CDM.Text = "Вывод";
            // 
            // textBoxResult_CDM
            // 
            textBoxResult_CDM.Location = new Point(6, 22);
            textBoxResult_CDM.Multiline = true;
            textBoxResult_CDM.Name = "textBoxResult_CDM";
            textBoxResult_CDM.ReadOnly = true;
            textBoxResult_CDM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CDM.Size = new Size(138, 463);
            textBoxResult_CDM.TabIndex = 1;
            // 
            // chartFunction_CDM
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_CDM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_CDM.Legends.Add(legend1);
            chartFunction_CDM.Location = new Point(150, 22);
            chartFunction_CDM.Name = "chartFunction_CDM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_CDM.Series.Add(series1);
            chartFunction_CDM.Size = new Size(806, 463);
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
            groupBoxVvod_CDM.Controls.Add(buttonVipolnit_CDM);
            groupBoxVvod_CDM.Controls.Add(buttonSave_CDM);
            groupBoxVvod_CDM.Controls.Add(buttonSpravka_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStop_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStopRead_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStart_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStartRead_CDM);
            groupBoxVvod_CDM.Location = new Point(315, 0);
            groupBoxVvod_CDM.Name = "groupBoxVvod_CDM";
            groupBoxVvod_CDM.Size = new Size(647, 88);
            groupBoxVvod_CDM.TabIndex = 1;
            groupBoxVvod_CDM.TabStop = false;
            groupBoxVvod_CDM.Text = "Ввод";
            // 
            // buttonVipolnit_CDM
            // 
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
            textBoxStop_CDM.Location = new Point(112, 48);
            textBoxStop_CDM.Name = "textBoxStop_CDM";
            textBoxStop_CDM.Size = new Size(100, 23);
            textBoxStop_CDM.TabIndex = 3;
            // 
            // textBoxStopRead_CDM
            // 
            textBoxStopRead_CDM.Location = new Point(112, 19);
            textBoxStopRead_CDM.Name = "textBoxStopRead_CDM";
            textBoxStopRead_CDM.ReadOnly = true;
            textBoxStopRead_CDM.Size = new Size(100, 23);
            textBoxStopRead_CDM.TabIndex = 2;
            textBoxStopRead_CDM.Text = "Конец шага:";
            // 
            // textBoxStart_CDM
            // 
            textBoxStart_CDM.Location = new Point(6, 48);
            textBoxStart_CDM.Name = "textBoxStart_CDM";
            textBoxStart_CDM.Size = new Size(100, 23);
            textBoxStart_CDM.TabIndex = 1;
            // 
            // textBoxStartRead_CDM
            // 
            textBoxStartRead_CDM.Location = new Point(6, 19);
            textBoxStartRead_CDM.Name = "textBoxStartRead_CDM";
            textBoxStartRead_CDM.ReadOnly = true;
            textBoxStartRead_CDM.Size = new Size(100, 23);
            textBoxStartRead_CDM.TabIndex = 0;
            textBoxStartRead_CDM.Text = "Старт шага:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 576);
            Controls.Add(groupBoxVvod_CDM);
            Controls.Add(groupBoxVivod_CDM);
            Controls.Add(groupBoxUslovie_CDM);
            Name = "FormMain";
            Text = " Спринт 6 | Таск 4 | Вариант 11 | Чепрага Д.М. ";
            groupBoxUslovie_CDM.ResumeLayout(false);
            groupBoxUslovie_CDM.PerformLayout();
            groupBoxVivod_CDM.ResumeLayout(false);
            groupBoxVivod_CDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_CDM).EndInit();
            groupBoxVvod_CDM.ResumeLayout(false);
            groupBoxVvod_CDM.PerformLayout();
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
    }
}
