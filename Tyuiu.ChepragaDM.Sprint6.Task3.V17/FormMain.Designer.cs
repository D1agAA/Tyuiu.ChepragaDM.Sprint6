namespace Tyuiu.ChepragaDM.Sprint6.Task3.V17
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
            groupBoxUslovie_CDM = new GroupBox();
            textBoxUslovie_CDM = new TextBox();
            dataGridViewMatrix_CDM = new DataGridView();
            groupBoxVivod_CDM = new GroupBox();
            textBoxResultRead_CDM = new TextBox();
            buttonVipolnit_CDM = new Button();
            buttonSpravka_CDM = new Button();
            groupBoxUslovie_CDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_CDM).BeginInit();
            groupBoxVivod_CDM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_CDM
            // 
            groupBoxUslovie_CDM.Controls.Add(textBoxUslovie_CDM);
            groupBoxUslovie_CDM.Location = new Point(12, 12);
            groupBoxUslovie_CDM.Name = "groupBoxUslovie_CDM";
            groupBoxUslovie_CDM.Size = new Size(442, 384);
            groupBoxUslovie_CDM.TabIndex = 0;
            groupBoxUslovie_CDM.TabStop = false;
            groupBoxUslovie_CDM.Text = "Условие";
            // 
            // textBoxUslovie_CDM
            // 
            textBoxUslovie_CDM.Location = new Point(6, 22);
            textBoxUslovie_CDM.Multiline = true;
            textBoxUslovie_CDM.Name = "textBoxUslovie_CDM";
            textBoxUslovie_CDM.ReadOnly = true;
            textBoxUslovie_CDM.Size = new Size(427, 354);
            textBoxUslovie_CDM.TabIndex = 0;
            textBoxUslovie_CDM.Text = resources.GetString("textBoxUslovie_CDM.Text");
            // 
            // dataGridViewMatrix_CDM
            // 
            dataGridViewMatrix_CDM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_CDM.ColumnHeadersVisible = false;
            dataGridViewMatrix_CDM.Location = new Point(6, 51);
            dataGridViewMatrix_CDM.Name = "dataGridViewMatrix_CDM";
            dataGridViewMatrix_CDM.RowHeadersVisible = false;
            dataGridViewMatrix_CDM.Size = new Size(262, 163);
            dataGridViewMatrix_CDM.TabIndex = 2;
            // 
            // groupBoxVivod_CDM
            // 
            groupBoxVivod_CDM.Controls.Add(dataGridViewMatrix_CDM);
            groupBoxVivod_CDM.Controls.Add(textBoxResultRead_CDM);
            groupBoxVivod_CDM.Location = new Point(460, 12);
            groupBoxVivod_CDM.Name = "groupBoxVivod_CDM";
            groupBoxVivod_CDM.Size = new Size(328, 320);
            groupBoxVivod_CDM.TabIndex = 1;
            groupBoxVivod_CDM.TabStop = false;
            groupBoxVivod_CDM.Text = "Вывод";
            // 
            // textBoxResultRead_CDM
            // 
            textBoxResultRead_CDM.Location = new Point(6, 22);
            textBoxResultRead_CDM.Name = "textBoxResultRead_CDM";
            textBoxResultRead_CDM.ReadOnly = true;
            textBoxResultRead_CDM.Size = new Size(203, 23);
            textBoxResultRead_CDM.TabIndex = 0;
            textBoxResultRead_CDM.Text = "Результат:";
            // 
            // buttonVipolnit_CDM
            // 
            buttonVipolnit_CDM.Location = new Point(647, 338);
            buttonVipolnit_CDM.Name = "buttonVipolnit_CDM";
            buttonVipolnit_CDM.Size = new Size(141, 48);
            buttonVipolnit_CDM.TabIndex = 2;
            buttonVipolnit_CDM.Text = "Выполнить";
            buttonVipolnit_CDM.UseVisualStyleBackColor = true;
            buttonVipolnit_CDM.Click += buttonVipolnit_CDM_Click;
            // 
            // buttonSpravka_CDM
            // 
            buttonSpravka_CDM.Location = new Point(579, 338);
            buttonSpravka_CDM.Name = "buttonSpravka_CDM";
            buttonSpravka_CDM.Size = new Size(63, 48);
            buttonSpravka_CDM.TabIndex = 3;
            buttonSpravka_CDM.Text = "?";
            buttonSpravka_CDM.UseVisualStyleBackColor = true;
            buttonSpravka_CDM.Click += buttonSpravka_CDM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(buttonSpravka_CDM);
            Controls.Add(buttonVipolnit_CDM);
            Controls.Add(groupBoxVivod_CDM);
            Controls.Add(groupBoxUslovie_CDM);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 17 | Чепрага Д.М. ";
            Load += FormMain_Load;
            groupBoxUslovie_CDM.ResumeLayout(false);
            groupBoxUslovie_CDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_CDM).EndInit();
            groupBoxVivod_CDM.ResumeLayout(false);
            groupBoxVivod_CDM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_CDM;
        private TextBox textBoxUslovie_CDM;
        private GroupBox groupBoxVivod_CDM;
        private TextBox textBoxResult_CDM;
        private TextBox textBoxResultRead_CDM;
        private DataGridView dataGridViewMatrix_CDM;
        private Button buttonVipolnit_CDM;
        private Button buttonSpravka_CDM;
    }
}
