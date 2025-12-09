namespace Tyuiu.ChepragaDM.Sprint6.Task7.V5
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
            panelVerh = new Panel();
            buttonVipolnit_CDM = new Button();
            buttonSpravka_CDM = new Button();
            buttonOpen_CDM = new Button();
            buttonSave_CDM = new Button();
            panelUslovie_CDM = new Panel();
            groupBoxUslovie_CDM = new GroupBox();
            textBoxUslovie_CDM = new TextBox();
            splitter1 = new Splitter();
            panelVvod_CDM = new Panel();
            groupBoxVvod_CDM = new GroupBox();
            dataGridViewIn_CDM = new DataGridView();
            splitter2 = new Splitter();
            panelVivod_CDM = new Panel();
            groupBoxVivod_CDM = new GroupBox();
            dataGridViewOut_CDM = new DataGridView();
            openFileDialogTask_CDM = new OpenFileDialog();
            saveFileDialogTask_CDM = new SaveFileDialog();
            toolTip = new ToolTip(components);
            panelVerh.SuspendLayout();
            panelUslovie_CDM.SuspendLayout();
            groupBoxUslovie_CDM.SuspendLayout();
            panelVvod_CDM.SuspendLayout();
            groupBoxVvod_CDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_CDM).BeginInit();
            panelVivod_CDM.SuspendLayout();
            groupBoxVivod_CDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_CDM).BeginInit();
            SuspendLayout();
            // 
            // panelVerh
            // 
            panelVerh.Controls.Add(buttonVipolnit_CDM);
            panelVerh.Controls.Add(buttonSpravka_CDM);
            panelVerh.Controls.Add(buttonOpen_CDM);
            panelVerh.Controls.Add(buttonSave_CDM);
            panelVerh.Dock = DockStyle.Top;
            panelVerh.Location = new Point(0, 0);
            panelVerh.Name = "panelVerh";
            panelVerh.Size = new Size(1112, 78);
            panelVerh.TabIndex = 0;
            // 
            // buttonVipolnit_CDM
            // 
            buttonVipolnit_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonVipolnit_CDM.Enabled = false;
            buttonVipolnit_CDM.Image = (Image)resources.GetObject("buttonVipolnit_CDM.Image");
            buttonVipolnit_CDM.Location = new Point(86, 4);
            buttonVipolnit_CDM.Name = "buttonVipolnit_CDM";
            buttonVipolnit_CDM.Size = new Size(70, 66);
            buttonVipolnit_CDM.TabIndex = 10;
            toolTip.SetToolTip(buttonVipolnit_CDM, "Выполнить замену в последнем столбце всех значений меньше 2 на 2\r\n");
            buttonVipolnit_CDM.UseVisualStyleBackColor = true;
            buttonVipolnit_CDM.Click += buttonVipolnit_CDM_Click;
            buttonVipolnit_CDM.MouseEnter += buttonVipolnit_CDM_MouseEnter;
            // 
            // buttonSpravka_CDM
            // 
            buttonSpravka_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSpravka_CDM.Image = (Image)resources.GetObject("buttonSpravka_CDM.Image");
            buttonSpravka_CDM.Location = new Point(1033, 3);
            buttonSpravka_CDM.Name = "buttonSpravka_CDM";
            buttonSpravka_CDM.Size = new Size(73, 69);
            buttonSpravka_CDM.TabIndex = 11;
            buttonSpravka_CDM.UseVisualStyleBackColor = true;
            buttonSpravka_CDM.Click += buttonSpravka_CDM_Click;
            buttonSpravka_CDM.MouseEnter += buttonSpravka_CDM_MouseEnter;
            // 
            // buttonOpen_CDM
            // 
            buttonOpen_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOpen_CDM.Image = (Image)resources.GetObject("buttonOpen_CDM.Image");
            buttonOpen_CDM.Location = new Point(12, 4);
            buttonOpen_CDM.Name = "buttonOpen_CDM";
            buttonOpen_CDM.Size = new Size(68, 66);
            buttonOpen_CDM.TabIndex = 9;
            toolTip.SetToolTip(buttonOpen_CDM, "Загрузить файл с устройства \r\n");
            buttonOpen_CDM.UseVisualStyleBackColor = true;
            buttonOpen_CDM.Click += buttonOpen_CDM_Click;
            buttonOpen_CDM.MouseEnter += buttonOpen_CDM_MouseEnter;
            // 
            // buttonSave_CDM
            // 
            buttonSave_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave_CDM.Enabled = false;
            buttonSave_CDM.Image = (Image)resources.GetObject("buttonSave_CDM.Image");
            buttonSave_CDM.Location = new Point(162, 4);
            buttonSave_CDM.Name = "buttonSave_CDM";
            buttonSave_CDM.Size = new Size(63, 66);
            buttonSave_CDM.TabIndex = 2;
            toolTip.SetToolTip(buttonSave_CDM, "Сохранить файл");
            buttonSave_CDM.UseVisualStyleBackColor = true;
            buttonSave_CDM.Click += buttonSave_CDM_Click;
            // 
            // panelUslovie_CDM
            // 
            panelUslovie_CDM.Controls.Add(groupBoxUslovie_CDM);
            panelUslovie_CDM.Dock = DockStyle.Top;
            panelUslovie_CDM.Location = new Point(0, 78);
            panelUslovie_CDM.Name = "panelUslovie_CDM";
            panelUslovie_CDM.Size = new Size(1112, 79);
            panelUslovie_CDM.TabIndex = 5;
            // 
            // groupBoxUslovie_CDM
            // 
            groupBoxUslovie_CDM.Controls.Add(textBoxUslovie_CDM);
            groupBoxUslovie_CDM.Dock = DockStyle.Fill;
            groupBoxUslovie_CDM.Location = new Point(0, 0);
            groupBoxUslovie_CDM.Name = "groupBoxUslovie_CDM";
            groupBoxUslovie_CDM.Size = new Size(1112, 79);
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
            textBoxUslovie_CDM.Size = new Size(1106, 57);
            textBoxUslovie_CDM.TabIndex = 0;
            textBoxUslovie_CDM.Text = resources.GetString("textBoxUslovie_CDM.Text");
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 157);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1112, 3);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // panelVvod_CDM
            // 
            panelVvod_CDM.Controls.Add(groupBoxVvod_CDM);
            panelVvod_CDM.Controls.Add(splitter2);
            panelVvod_CDM.Dock = DockStyle.Left;
            panelVvod_CDM.Location = new Point(0, 160);
            panelVvod_CDM.Name = "panelVvod_CDM";
            panelVvod_CDM.Size = new Size(638, 336);
            panelVvod_CDM.TabIndex = 7;
            // 
            // groupBoxVvod_CDM
            // 
            groupBoxVvod_CDM.Controls.Add(dataGridViewIn_CDM);
            groupBoxVvod_CDM.Dock = DockStyle.Fill;
            groupBoxVvod_CDM.Location = new Point(0, 0);
            groupBoxVvod_CDM.Name = "groupBoxVvod_CDM";
            groupBoxVvod_CDM.Size = new Size(635, 336);
            groupBoxVvod_CDM.TabIndex = 0;
            groupBoxVvod_CDM.TabStop = false;
            groupBoxVvod_CDM.Text = "Ввод";
            // 
            // dataGridViewIn_CDM
            // 
            dataGridViewIn_CDM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_CDM.Dock = DockStyle.Fill;
            dataGridViewIn_CDM.Location = new Point(3, 19);
            dataGridViewIn_CDM.Name = "dataGridViewIn_CDM";
            dataGridViewIn_CDM.Size = new Size(629, 314);
            dataGridViewIn_CDM.TabIndex = 0;
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Right;
            splitter2.Location = new Point(635, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 336);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // panelVivod_CDM
            // 
            panelVivod_CDM.Controls.Add(groupBoxVivod_CDM);
            panelVivod_CDM.Dock = DockStyle.Fill;
            panelVivod_CDM.Location = new Point(638, 160);
            panelVivod_CDM.Name = "panelVivod_CDM";
            panelVivod_CDM.Size = new Size(474, 336);
            panelVivod_CDM.TabIndex = 8;
            // 
            // groupBoxVivod_CDM
            // 
            groupBoxVivod_CDM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxVivod_CDM.Controls.Add(dataGridViewOut_CDM);
            groupBoxVivod_CDM.Location = new Point(3, 3);
            groupBoxVivod_CDM.Name = "groupBoxVivod_CDM";
            groupBoxVivod_CDM.Size = new Size(468, 330);
            groupBoxVivod_CDM.TabIndex = 0;
            groupBoxVivod_CDM.TabStop = false;
            groupBoxVivod_CDM.Text = "Вывод";
            // 
            // dataGridViewOut_CDM
            // 
            dataGridViewOut_CDM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_CDM.Dock = DockStyle.Fill;
            dataGridViewOut_CDM.Location = new Point(3, 19);
            dataGridViewOut_CDM.Name = "dataGridViewOut_CDM";
            dataGridViewOut_CDM.Size = new Size(462, 308);
            dataGridViewOut_CDM.TabIndex = 1;
            // 
            // openFileDialogTask_CDM
            // 
            openFileDialogTask_CDM.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 496);
            Controls.Add(panelVivod_CDM);
            Controls.Add(panelVvod_CDM);
            Controls.Add(splitter1);
            Controls.Add(panelUslovie_CDM);
            Controls.Add(panelVerh);
            MinimumSize = new Size(1128, 535);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 5 | Чепрага Д.М. ";
            panelVerh.ResumeLayout(false);
            panelUslovie_CDM.ResumeLayout(false);
            groupBoxUslovie_CDM.ResumeLayout(false);
            groupBoxUslovie_CDM.PerformLayout();
            panelVvod_CDM.ResumeLayout(false);
            groupBoxVvod_CDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_CDM).EndInit();
            panelVivod_CDM.ResumeLayout(false);
            groupBoxVivod_CDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_CDM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVerh;
        private Button buttonSave_CDM;
        private Panel panelUslovie_CDM;
        private GroupBox groupBoxUslovie_CDM;
        private Splitter splitter1;
        private Panel panelVvod_CDM;
        private GroupBox groupBoxVvod_CDM;
        private Splitter splitter2;
        private Panel panelVivod_CDM;
        private GroupBox groupBoxVivod_CDM;
        private DataGridView dataGridViewIn_CDM;
        private DataGridView dataGridViewOut_CDM;
        private Button buttonVipolnit_CDM;
        private Button buttonSpravka_CDM;
        private Button buttonOpen_CDM;
        private OpenFileDialog openFileDialogTask_CDM;
        private SaveFileDialog saveFileDialogTask_CDM;
        private ToolTip toolTip;
        private TextBox textBoxUslovie_CDM;
    }
}
