namespace Tyuiu.ChepragaDM.Sprint6.Task6.V18
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
            buttonOk_CDM = new Button();
            pictureBoxAva_CDM = new PictureBox();
            labelInfo_CDM = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_CDM).BeginInit();
            SuspendLayout();
            // 
            // buttonOk_CDM
            // 
            buttonOk_CDM.Location = new Point(395, 150);
            buttonOk_CDM.Name = "buttonOk_CDM";
            buttonOk_CDM.Size = new Size(83, 28);
            buttonOk_CDM.TabIndex = 0;
            buttonOk_CDM.Text = "Ok";
            buttonOk_CDM.UseVisualStyleBackColor = true;
            buttonOk_CDM.Click += buttonOk_CDM_Click;
            // 
            // pictureBoxAva_CDM
            // 
            pictureBoxAva_CDM.Image = (Image)resources.GetObject("pictureBoxAva_CDM.Image");
            pictureBoxAva_CDM.Location = new Point(12, 12);
            pictureBoxAva_CDM.Name = "pictureBoxAva_CDM";
            pictureBoxAva_CDM.Size = new Size(162, 166);
            pictureBoxAva_CDM.TabIndex = 1;
            pictureBoxAva_CDM.TabStop = false;
            // 
            // labelInfo_CDM
            // 
            labelInfo_CDM.AutoSize = true;
            labelInfo_CDM.Location = new Point(180, 9);
            labelInfo_CDM.Name = "labelInfo_CDM";
            labelInfo_CDM.Size = new Size(302, 135);
            labelInfo_CDM.TabIndex = 2;
            labelInfo_CDM.Text = resources.GetString("labelInfo_CDM.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 190);
            Controls.Add(labelInfo_CDM);
            Controls.Add(pictureBoxAva_CDM);
            Controls.Add(buttonOk_CDM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_CDM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk_CDM;
        private PictureBox pictureBoxAva_CDM;
        private Label labelInfo_CDM;
    }
}