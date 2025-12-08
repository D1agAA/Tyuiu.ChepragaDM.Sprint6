namespace Tyuiu.ChepragaDM.Sprint6.Task1.V8
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
            pictureBoxFunction_CDM = new PictureBox();
            textBoxUslovie_CDM = new TextBox();
            groupBoxVivod_CDM = new GroupBox();
            textBoxResult_CDM = new TextBox();
            textBoxResultRead_CDM = new TextBox();
            groupBoxVvod_CDM = new GroupBox();
            textBoxFinish_CDM = new TextBox();
            textBoxStart_CDM = new TextBox();
            textBoxFinishRead_CDM = new TextBox();
            textBoxStartRead_CDM = new TextBox();
            buttonVipolnit_CDM = new Button();
            buttonSpravka_CDM = new Button();
            groupBoxUslovie_CDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction_CDM).BeginInit();
            groupBoxVivod_CDM.SuspendLayout();
            groupBoxVvod_CDM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_CDM
            // 
            groupBoxUslovie_CDM.Controls.Add(pictureBoxFunction_CDM);
            groupBoxUslovie_CDM.Controls.Add(textBoxUslovie_CDM);
            groupBoxUslovie_CDM.Location = new Point(12, 12);
            groupBoxUslovie_CDM.Name = "groupBoxUslovie_CDM";
            groupBoxUslovie_CDM.Size = new Size(523, 335);
            groupBoxUslovie_CDM.TabIndex = 0;
            groupBoxUslovie_CDM.TabStop = false;
            groupBoxUslovie_CDM.Text = "Условие";
            // 
            // pictureBoxFunction_CDM
            // 
            pictureBoxFunction_CDM.Image = (Image)resources.GetObject("pictureBoxFunction_CDM.Image");
            pictureBoxFunction_CDM.Location = new Point(17, 49);
            pictureBoxFunction_CDM.Name = "pictureBoxFunction_CDM";
            pictureBoxFunction_CDM.Size = new Size(404, 50);
            pictureBoxFunction_CDM.TabIndex = 1;
            pictureBoxFunction_CDM.TabStop = false;
            // 
            // textBoxUslovie_CDM
            // 
            textBoxUslovie_CDM.Location = new Point(6, 19);
            textBoxUslovie_CDM.Multiline = true;
            textBoxUslovie_CDM.Name = "textBoxUslovie_CDM";
            textBoxUslovie_CDM.ReadOnly = true;
            textBoxUslovie_CDM.Size = new Size(511, 310);
            textBoxUslovie_CDM.TabIndex = 0;
            textBoxUslovie_CDM.Text = resources.GetString("textBoxUslovie_CDM.Text");
            // 
            // groupBoxVivod_CDM
            // 
            groupBoxVivod_CDM.Controls.Add(textBoxResult_CDM);
            groupBoxVivod_CDM.Controls.Add(textBoxResultRead_CDM);
            groupBoxVivod_CDM.Location = new Point(541, 12);
            groupBoxVivod_CDM.Name = "groupBoxVivod_CDM";
            groupBoxVivod_CDM.Size = new Size(247, 426);
            groupBoxVivod_CDM.TabIndex = 0;
            groupBoxVivod_CDM.TabStop = false;
            groupBoxVivod_CDM.Text = "Вывод";
            // 
            // textBoxResult_CDM
            // 
            textBoxResult_CDM.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_CDM.Location = new Point(6, 48);
            textBoxResult_CDM.Multiline = true;
            textBoxResult_CDM.Name = "textBoxResult_CDM";
            textBoxResult_CDM.ReadOnly = true;
            textBoxResult_CDM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CDM.Size = new Size(235, 367);
            textBoxResult_CDM.TabIndex = 1;
            // 
            // textBoxResultRead_CDM
            // 
            textBoxResultRead_CDM.Location = new Point(6, 19);
            textBoxResultRead_CDM.Name = "textBoxResultRead_CDM";
            textBoxResultRead_CDM.ReadOnly = true;
            textBoxResultRead_CDM.Size = new Size(235, 23);
            textBoxResultRead_CDM.TabIndex = 0;
            textBoxResultRead_CDM.Text = "Результат:";
            // 
            // groupBoxVvod_CDM
            // 
            groupBoxVvod_CDM.Controls.Add(textBoxFinish_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStart_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxFinishRead_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxStartRead_CDM);
            groupBoxVvod_CDM.Location = new Point(12, 353);
            groupBoxVvod_CDM.Name = "groupBoxVvod_CDM";
            groupBoxVvod_CDM.Size = new Size(264, 85);
            groupBoxVvod_CDM.TabIndex = 0;
            groupBoxVvod_CDM.TabStop = false;
            groupBoxVvod_CDM.Text = "Ввод";
            // 
            // textBoxFinish_CDM
            // 
            textBoxFinish_CDM.Location = new Point(131, 51);
            textBoxFinish_CDM.Name = "textBoxFinish_CDM";
            textBoxFinish_CDM.Size = new Size(127, 23);
            textBoxFinish_CDM.TabIndex = 6;
            // 
            // textBoxStart_CDM
            // 
            textBoxStart_CDM.Location = new Point(6, 51);
            textBoxStart_CDM.Name = "textBoxStart_CDM";
            textBoxStart_CDM.Size = new Size(119, 23);
            textBoxStart_CDM.TabIndex = 5;
            // 
            // textBoxFinishRead_CDM
            // 
            textBoxFinishRead_CDM.Location = new Point(131, 22);
            textBoxFinishRead_CDM.Name = "textBoxFinishRead_CDM";
            textBoxFinishRead_CDM.ReadOnly = true;
            textBoxFinishRead_CDM.Size = new Size(127, 23);
            textBoxFinishRead_CDM.TabIndex = 4;
            textBoxFinishRead_CDM.Text = "Конец шага:";
            // 
            // textBoxStartRead_CDM
            // 
            textBoxStartRead_CDM.Location = new Point(6, 22);
            textBoxStartRead_CDM.Name = "textBoxStartRead_CDM";
            textBoxStartRead_CDM.ReadOnly = true;
            textBoxStartRead_CDM.Size = new Size(119, 23);
            textBoxStartRead_CDM.TabIndex = 3;
            textBoxStartRead_CDM.Text = "Старт шага:";
            // 
            // buttonVipolnit_CDM
            // 
            buttonVipolnit_CDM.BackColor = Color.Green;
            buttonVipolnit_CDM.Location = new Point(384, 353);
            buttonVipolnit_CDM.Name = "buttonVipolnit_CDM";
            buttonVipolnit_CDM.Size = new Size(151, 85);
            buttonVipolnit_CDM.TabIndex = 1;
            buttonVipolnit_CDM.Text = "Выполнить";
            buttonVipolnit_CDM.UseVisualStyleBackColor = false;
            buttonVipolnit_CDM.Click += buttonVipolnit_CDM_Click;
            // 
            // buttonSpravka_CDM
            // 
            buttonSpravka_CDM.BackColor = Color.SteelBlue;
            buttonSpravka_CDM.Location = new Point(282, 353);
            buttonSpravka_CDM.Name = "buttonSpravka_CDM";
            buttonSpravka_CDM.Size = new Size(96, 85);
            buttonSpravka_CDM.TabIndex = 2;
            buttonSpravka_CDM.Text = "Справка";
            buttonSpravka_CDM.UseVisualStyleBackColor = false;
            buttonSpravka_CDM.Click += buttonSpravka_CDM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSpravka_CDM);
            Controls.Add(buttonVipolnit_CDM);
            Controls.Add(groupBoxVvod_CDM);
            Controls.Add(groupBoxVivod_CDM);
            Controls.Add(groupBoxUslovie_CDM);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 8 | Чепрага Д.М. ";
            groupBoxUslovie_CDM.ResumeLayout(false);
            groupBoxUslovie_CDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFunction_CDM).EndInit();
            groupBoxVivod_CDM.ResumeLayout(false);
            groupBoxVivod_CDM.PerformLayout();
            groupBoxVvod_CDM.ResumeLayout(false);
            groupBoxVvod_CDM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_CDM;
        private GroupBox groupBoxVivod_CDM;
        private GroupBox groupBoxVvod_CDM;
        private Button buttonVipolnit_CDM;
        private Button buttonSpravka_CDM;
        private TextBox textBoxUslovie_CDM;
        private PictureBox pictureBoxFunction_CDM;
        private TextBox textBoxResultRead_CDM;
        private TextBox textBoxFinish_CDM;
        private TextBox textBoxStart_CDM;
        private TextBox textBoxFinishRead_CDM;
        private TextBox textBoxStartRead_CDM;
        private TextBox textBoxResult_CDM;
    }
}
