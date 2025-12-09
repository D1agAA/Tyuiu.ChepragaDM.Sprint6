namespace Tyuiu.ChepragaDM.Sprint6.Task7.V5
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_CDM = new Label();
            pictureBoxAva_CDM = new PictureBox();
            buttonOk_CDM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_CDM).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_CDM
            // 
            labelInfo_CDM.AutoSize = true;
            labelInfo_CDM.Location = new Point(194, 12);
            labelInfo_CDM.Name = "labelInfo_CDM";
            labelInfo_CDM.Size = new Size(302, 135);
            labelInfo_CDM.TabIndex = 5;
            labelInfo_CDM.Text = resources.GetString("labelInfo_CDM.Text");
            // 
            // pictureBoxAva_CDM
            // 
            pictureBoxAva_CDM.Image = (Image)resources.GetObject("pictureBoxAva_CDM.Image");
            pictureBoxAva_CDM.Location = new Point(12, 12);
            pictureBoxAva_CDM.Name = "pictureBoxAva_CDM";
            pictureBoxAva_CDM.Size = new Size(162, 166);
            pictureBoxAva_CDM.TabIndex = 4;
            pictureBoxAva_CDM.TabStop = false;
            // 
            // buttonOk_CDM
            // 
            buttonOk_CDM.Location = new Point(454, 159);
            buttonOk_CDM.Name = "buttonOk_CDM";
            buttonOk_CDM.Size = new Size(83, 28);
            buttonOk_CDM.TabIndex = 3;
            buttonOk_CDM.Text = "Ok";
            buttonOk_CDM.UseVisualStyleBackColor = true;
            buttonOk_CDM.Click += buttonOk_CDM_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 196);
            Controls.Add(labelInfo_CDM);
            Controls.Add(pictureBoxAva_CDM);
            Controls.Add(buttonOk_CDM);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_CDM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_CDM;
        private PictureBox pictureBoxAva_CDM;
        private Button buttonOk_CDM;
    }
}