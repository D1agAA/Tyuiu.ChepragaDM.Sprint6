namespace Tyuiu.ChepragaDM.Sprint6.Task0.V3
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
            pictureBoxPrimer_CDM = new PictureBox();
            textBoxUslovie_CDM = new TextBox();
            groupBoxVvod_CDM = new GroupBox();
            textBoxPeremennayaX_CDM = new TextBox();
            textBoxPeremennayaXRead_CDM = new TextBox();
            groupBoxVivod_CDM = new GroupBox();
            textBoxResult_CDM = new TextBox();
            textBoxResultRead_CDM = new TextBox();
            buttonVipolnit_CDM = new Button();
            buttonSpravka_CDM = new Button();
            groupBoxUslovie_CDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrimer_CDM).BeginInit();
            groupBoxVvod_CDM.SuspendLayout();
            groupBoxVivod_CDM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_CDM
            // 
            groupBoxUslovie_CDM.Controls.Add(pictureBoxPrimer_CDM);
            groupBoxUslovie_CDM.Controls.Add(textBoxUslovie_CDM);
            groupBoxUslovie_CDM.Location = new Point(12, 12);
            groupBoxUslovie_CDM.Name = "groupBoxUslovie_CDM";
            groupBoxUslovie_CDM.Size = new Size(776, 273);
            groupBoxUslovie_CDM.TabIndex = 0;
            groupBoxUslovie_CDM.TabStop = false;
            groupBoxUslovie_CDM.Text = "Условие";
            // 
            // pictureBoxPrimer_CDM
            // 
            pictureBoxPrimer_CDM.Image = (Image)resources.GetObject("pictureBoxPrimer_CDM.Image");
            pictureBoxPrimer_CDM.Location = new Point(599, 22);
            pictureBoxPrimer_CDM.Name = "pictureBoxPrimer_CDM";
            pictureBoxPrimer_CDM.Size = new Size(157, 79);
            pictureBoxPrimer_CDM.TabIndex = 5;
            pictureBoxPrimer_CDM.TabStop = false;
            // 
            // textBoxUslovie_CDM
            // 
            textBoxUslovie_CDM.Location = new Point(6, 22);
            textBoxUslovie_CDM.Multiline = true;
            textBoxUslovie_CDM.Name = "textBoxUslovie_CDM";
            textBoxUslovie_CDM.ReadOnly = true;
            textBoxUslovie_CDM.Size = new Size(578, 228);
            textBoxUslovie_CDM.TabIndex = 4;
            textBoxUslovie_CDM.Text = "Вычислить значение выражения";
            // 
            // groupBoxVvod_CDM
            // 
            groupBoxVvod_CDM.Controls.Add(textBoxPeremennayaX_CDM);
            groupBoxVvod_CDM.Controls.Add(textBoxPeremennayaXRead_CDM);
            groupBoxVvod_CDM.Location = new Point(12, 291);
            groupBoxVvod_CDM.Name = "groupBoxVvod_CDM";
            groupBoxVvod_CDM.Size = new Size(391, 101);
            groupBoxVvod_CDM.TabIndex = 1;
            groupBoxVvod_CDM.TabStop = false;
            groupBoxVvod_CDM.Text = "Ввод";
            // 
            // textBoxPeremennayaX_CDM
            // 
            textBoxPeremennayaX_CDM.Location = new Point(17, 51);
            textBoxPeremennayaX_CDM.Name = "textBoxPeremennayaX_CDM";
            textBoxPeremennayaX_CDM.Size = new Size(100, 23);
            textBoxPeremennayaX_CDM.TabIndex = 7;
            textBoxPeremennayaX_CDM.KeyPress += textBoxPeremennayaX_CDM_KeyPress;
            // 
            // textBoxPeremennayaXRead_CDM
            // 
            textBoxPeremennayaXRead_CDM.Location = new Point(17, 22);
            textBoxPeremennayaXRead_CDM.Name = "textBoxPeremennayaXRead_CDM";
            textBoxPeremennayaXRead_CDM.ReadOnly = true;
            textBoxPeremennayaXRead_CDM.Size = new Size(100, 23);
            textBoxPeremennayaXRead_CDM.TabIndex = 6;
            textBoxPeremennayaXRead_CDM.Text = "Переменная Х:";
            // 
            // groupBoxVivod_CDM
            // 
            groupBoxVivod_CDM.Controls.Add(textBoxResult_CDM);
            groupBoxVivod_CDM.Controls.Add(textBoxResultRead_CDM);
            groupBoxVivod_CDM.Location = new Point(409, 292);
            groupBoxVivod_CDM.Name = "groupBoxVivod_CDM";
            groupBoxVivod_CDM.Size = new Size(379, 100);
            groupBoxVivod_CDM.TabIndex = 0;
            groupBoxVivod_CDM.TabStop = false;
            groupBoxVivod_CDM.Text = "Вывод";
            // 
            // textBoxResult_CDM
            // 
            textBoxResult_CDM.Location = new Point(20, 50);
            textBoxResult_CDM.Name = "textBoxResult_CDM";
            textBoxResult_CDM.ReadOnly = true;
            textBoxResult_CDM.Size = new Size(323, 23);
            textBoxResult_CDM.TabIndex = 1;
            // 
            // textBoxResultRead_CDM
            // 
            textBoxResultRead_CDM.Location = new Point(20, 21);
            textBoxResultRead_CDM.Name = "textBoxResultRead_CDM";
            textBoxResultRead_CDM.ReadOnly = true;
            textBoxResultRead_CDM.Size = new Size(323, 23);
            textBoxResultRead_CDM.TabIndex = 0;
            textBoxResultRead_CDM.Text = "Результат:";
            // 
            // buttonVipolnit_CDM
            // 
            buttonVipolnit_CDM.Location = new Point(602, 398);
            buttonVipolnit_CDM.Name = "buttonVipolnit_CDM";
            buttonVipolnit_CDM.Size = new Size(186, 40);
            buttonVipolnit_CDM.TabIndex = 2;
            buttonVipolnit_CDM.Text = "Выполнить";
            buttonVipolnit_CDM.UseVisualStyleBackColor = true;
            buttonVipolnit_CDM.Click += buttonVipolnit_CDM_Click;
            // 
            // buttonSpravka_CDM
            // 
            buttonSpravka_CDM.Location = new Point(555, 398);
            buttonSpravka_CDM.Name = "buttonSpravka_CDM";
            buttonSpravka_CDM.Size = new Size(41, 40);
            buttonSpravka_CDM.TabIndex = 3;
            buttonSpravka_CDM.Text = "?";
            buttonSpravka_CDM.UseVisualStyleBackColor = true;
            buttonSpravka_CDM.Click += buttonSpravka_CDM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSpravka_CDM);
            Controls.Add(buttonVipolnit_CDM);
            Controls.Add(groupBoxVivod_CDM);
            Controls.Add(groupBoxVvod_CDM);
            Controls.Add(groupBoxUslovie_CDM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 3 | Чепрага Д.М. ";
            groupBoxUslovie_CDM.ResumeLayout(false);
            groupBoxUslovie_CDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrimer_CDM).EndInit();
            groupBoxVvod_CDM.ResumeLayout(false);
            groupBoxVvod_CDM.PerformLayout();
            groupBoxVivod_CDM.ResumeLayout(false);
            groupBoxVivod_CDM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_CDM;
        private GroupBox groupBoxVvod_CDM;
        private GroupBox groupBoxVivod_CDM;
        private Button buttonVipolnit_CDM;
        private Button buttonSpravka_CDM;
        private PictureBox pictureBoxPrimer_CDM;
        private TextBox textBoxUslovie_CDM;
        private TextBox textBoxPeremennayaX_CDM;
        private TextBox textBoxPeremennayaXRead_CDM;
        private TextBox textBoxResult_CDM;
        private TextBox textBoxResultRead_CDM;
    }
}
