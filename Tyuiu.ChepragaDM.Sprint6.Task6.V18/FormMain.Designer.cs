namespace Tyuiu.ChepragaDM.Sprint6.Task6.V18
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelVerh_CDM = new Panel();
            buttonSpravka_CDM = new Button();
            buttonVipolnit_CDM = new Button();
            buttonOpen_CDM = new Button();
            panel1 = new Panel();
            groupBoxUslovie_CDM = new GroupBox();
            textBoxUslovie_CDM = new TextBox();
            splitter1 = new Splitter();
            panel2 = new Panel();
            groupBoxVvod_CDM = new GroupBox();
            textBoxVvod_CDM = new TextBox();
            panel3 = new Panel();
            groupBoxVivod_CDM = new GroupBox();
            textBoxResult_CDM = new TextBox();
            splitter2 = new Splitter();
            openFileDialogTask_CDM = new OpenFileDialog();
            toolTip_CDM = new ToolTip(components);
            panelVerh_CDM.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxUslovie_CDM.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxVvod_CDM.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxVivod_CDM.SuspendLayout();
            SuspendLayout();
            // 
            // panelVerh_CDM
            // 
            panelVerh_CDM.Controls.Add(buttonSpravka_CDM);
            panelVerh_CDM.Controls.Add(buttonVipolnit_CDM);
            panelVerh_CDM.Controls.Add(buttonOpen_CDM);
            panelVerh_CDM.Dock = DockStyle.Top;
            panelVerh_CDM.Location = new Point(0, 0);
            panelVerh_CDM.Name = "panelVerh_CDM";
            panelVerh_CDM.Size = new Size(964, 75);
            panelVerh_CDM.TabIndex = 0;
            // 
            // buttonSpravka_CDM
            // 
            buttonSpravka_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSpravka_CDM.Image = (Image)resources.GetObject("buttonSpravka_CDM.Image");
            buttonSpravka_CDM.Location = new Point(862, 3);
            buttonSpravka_CDM.Name = "buttonSpravka_CDM";
            buttonSpravka_CDM.Size = new Size(90, 69);
            buttonSpravka_CDM.TabIndex = 2;
            toolTip_CDM.SetToolTip(buttonSpravka_CDM, "Сведения о приложении");
            buttonSpravka_CDM.UseVisualStyleBackColor = true;
            buttonSpravka_CDM.Click += buttonSpravka_CDM_Click;
            // 
            // buttonVipolnit_CDM
            // 
            buttonVipolnit_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVipolnit_CDM.Image = (Image)resources.GetObject("buttonVipolnit_CDM.Image");
            buttonVipolnit_CDM.Location = new Point(92, 3);
            buttonVipolnit_CDM.Name = "buttonVipolnit_CDM";
            buttonVipolnit_CDM.Size = new Size(91, 66);
            buttonVipolnit_CDM.TabIndex = 1;
            toolTip_CDM.SetToolTip(buttonVipolnit_CDM, "Производит вывод слов в файле, в которых встречается n в результирующую строуку");
            buttonVipolnit_CDM.UseVisualStyleBackColor = true;
            buttonVipolnit_CDM.Click += buttonVipolnit_CDM_Click;
            // 
            // buttonOpen_CDM
            // 
            buttonOpen_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOpen_CDM.Image = (Image)resources.GetObject("buttonOpen_CDM.Image");
            buttonOpen_CDM.Location = new Point(3, 3);
            buttonOpen_CDM.Name = "buttonOpen_CDM";
            buttonOpen_CDM.Size = new Size(83, 66);
            buttonOpen_CDM.TabIndex = 0;
            toolTip_CDM.SetToolTip(buttonOpen_CDM, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpen_CDM.UseVisualStyleBackColor = true;
            buttonOpen_CDM.Click += buttonOpen_CDM_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxUslovie_CDM);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 100);
            panel1.TabIndex = 0;
            // 
            // groupBoxUslovie_CDM
            // 
            groupBoxUslovie_CDM.Controls.Add(textBoxUslovie_CDM);
            groupBoxUslovie_CDM.Dock = DockStyle.Fill;
            groupBoxUslovie_CDM.Location = new Point(0, 0);
            groupBoxUslovie_CDM.Name = "groupBoxUslovie_CDM";
            groupBoxUslovie_CDM.Size = new Size(964, 100);
            groupBoxUslovie_CDM.TabIndex = 0;
            groupBoxUslovie_CDM.TabStop = false;
            groupBoxUslovie_CDM.Text = "Условие";
            // 
            // textBoxUslovie_CDM
            // 
            textBoxUslovie_CDM.Dock = DockStyle.Fill;
            textBoxUslovie_CDM.Location = new Point(3, 19);
            textBoxUslovie_CDM.Multiline = true;
            textBoxUslovie_CDM.Name = "textBoxUslovie_CDM";
            textBoxUslovie_CDM.ReadOnly = true;
            textBoxUslovie_CDM.Size = new Size(958, 78);
            textBoxUslovie_CDM.TabIndex = 0;
            textBoxUslovie_CDM.Text = resources.GetString("textBoxUslovie_CDM.Text");
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 175);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(964, 3);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxVvod_CDM);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 404);
            panel2.TabIndex = 2;
            // 
            // groupBoxVvod_CDM
            // 
            groupBoxVvod_CDM.Controls.Add(textBoxVvod_CDM);
            groupBoxVvod_CDM.Dock = DockStyle.Fill;
            groupBoxVvod_CDM.Location = new Point(0, 0);
            groupBoxVvod_CDM.Name = "groupBoxVvod_CDM";
            groupBoxVvod_CDM.Size = new Size(437, 404);
            groupBoxVvod_CDM.TabIndex = 1;
            groupBoxVvod_CDM.TabStop = false;
            groupBoxVvod_CDM.Text = "Ввод";
            // 
            // textBoxVvod_CDM
            // 
            textBoxVvod_CDM.Dock = DockStyle.Fill;
            textBoxVvod_CDM.Location = new Point(3, 19);
            textBoxVvod_CDM.Multiline = true;
            textBoxVvod_CDM.Name = "textBoxVvod_CDM";
            textBoxVvod_CDM.ScrollBars = ScrollBars.Vertical;
            textBoxVvod_CDM.Size = new Size(431, 382);
            textBoxVvod_CDM.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxVivod_CDM);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(437, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(527, 404);
            panel3.TabIndex = 0;
            // 
            // groupBoxVivod_CDM
            // 
            groupBoxVivod_CDM.Controls.Add(textBoxResult_CDM);
            groupBoxVivod_CDM.Dock = DockStyle.Fill;
            groupBoxVivod_CDM.Location = new Point(0, 0);
            groupBoxVivod_CDM.Name = "groupBoxVivod_CDM";
            groupBoxVivod_CDM.Size = new Size(527, 404);
            groupBoxVivod_CDM.TabIndex = 2;
            groupBoxVivod_CDM.TabStop = false;
            groupBoxVivod_CDM.Text = "Вывод";
            // 
            // textBoxResult_CDM
            // 
            textBoxResult_CDM.Dock = DockStyle.Fill;
            textBoxResult_CDM.Location = new Point(3, 19);
            textBoxResult_CDM.Multiline = true;
            textBoxResult_CDM.Name = "textBoxResult_CDM";
            textBoxResult_CDM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CDM.Size = new Size(521, 382);
            textBoxResult_CDM.TabIndex = 0;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(437, 178);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 404);
            splitter2.TabIndex = 3;
            splitter2.TabStop = false;
            // 
            // openFileDialogTask_CDM
            // 
            openFileDialogTask_CDM.FileName = "openFileDialog1";
            // 
            // toolTip_CDM
            // 
            toolTip_CDM.ToolTipIcon = ToolTipIcon.Info;
            toolTip_CDM.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 582);
            Controls.Add(splitter2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(splitter1);
            Controls.Add(panel1);
            Controls.Add(panelVerh_CDM);
            MinimumSize = new Size(980, 621);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 18 | Чепрага Д.М. ";
            panelVerh_CDM.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBoxUslovie_CDM.ResumeLayout(false);
            groupBoxUslovie_CDM.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxVvod_CDM.ResumeLayout(false);
            groupBoxVvod_CDM.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxVivod_CDM.ResumeLayout(false);
            groupBoxVivod_CDM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVerh_CDM;
        private Panel panel1;
        private Splitter splitter1;
        private Button buttonSpravka_CDM;
        private Button buttonVipolnit_CDM;
        private Button buttonOpen_CDM;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter2;
        private GroupBox groupBoxUslovie_CDM;
        private TextBox textBoxUslovie_CDM;
        private GroupBox groupBoxVvod_CDM;
        private TextBox textBoxVvod_CDM;
        private GroupBox groupBoxVivod_CDM;
        private TextBox textBoxResult_CDM;
        private ToolTip toolTip_CDM;
        private OpenFileDialog openFileDialogTask_CDM;
    }
}
