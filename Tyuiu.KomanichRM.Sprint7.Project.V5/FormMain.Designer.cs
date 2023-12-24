
namespace Tyuiu.KomanichRM.Sprint7.Project.V5
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonСharts = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.groupBoxDone = new System.Windows.Forms.GroupBox();
            this.labelAddRows = new System.Windows.Forms.Label();
            this.labelAddColumns = new System.Windows.Forms.Label();
            this.textBoxAddRows = new System.Windows.Forms.TextBox();
            this.textBoxAddColumns = new System.Windows.Forms.TextBox();
            this.buttonAddRows = new System.Windows.Forms.Button();
            this.buttonAddColumns = new System.Windows.Forms.Button();
            this.dataGridViewOpenFile = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.comboBoxResult = new System.Windows.Forms.ComboBox();
            this.groupBox_Filt = new System.Windows.Forms.GroupBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelTop.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.groupBoxDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpenFile)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBox_Filt.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.buttonСharts);
            this.panelTop.Controls.Add(this.buttonSaveFile);
            this.panelTop.Controls.Add(this.buttonAddFile);
            this.panelTop.Controls.Add(this.button3);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1232, 124);
            this.panelTop.TabIndex = 3;
            // 
            // buttonСharts
            // 
            this.buttonСharts.Location = new System.Drawing.Point(302, 23);
            this.buttonСharts.Name = "buttonСharts";
            this.buttonСharts.Size = new System.Drawing.Size(109, 70);
            this.buttonСharts.TabIndex = 2;
            this.buttonСharts.Text = "Графики";
            this.buttonСharts.UseVisualStyleBackColor = true;
            this.buttonСharts.Click += new System.EventHandler(this.buttonСharts_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(162, 23);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(100, 70);
            this.buttonSaveFile.TabIndex = 1;
            this.buttonSaveFile.Text = "Сохранить";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(25, 23);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(100, 70);
            this.buttonAddFile.TabIndex = 1;
            this.buttonAddFile.Text = "Открыть";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1114, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 81);
            this.button3.TabIndex = 0;
            this.button3.Text = "Справка";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelFill.Controls.Add(this.groupBoxDone);
            this.panelFill.Controls.Add(this.dataGridViewOpenFile);
            this.panelFill.Controls.Add(this.splitter1);
            this.panelFill.Controls.Add(this.panelLeft);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 124);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1232, 529);
            this.panelFill.TabIndex = 3;
            // 
            // groupBoxDone
            // 
            this.groupBoxDone.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBoxDone.Controls.Add(this.labelAddRows);
            this.groupBoxDone.Controls.Add(this.labelAddColumns);
            this.groupBoxDone.Controls.Add(this.textBoxAddRows);
            this.groupBoxDone.Controls.Add(this.textBoxAddColumns);
            this.groupBoxDone.Controls.Add(this.buttonAddRows);
            this.groupBoxDone.Controls.Add(this.buttonAddColumns);
            this.groupBoxDone.Location = new System.Drawing.Point(15, 332);
            this.groupBoxDone.Name = "groupBoxDone";
            this.groupBoxDone.Size = new System.Drawing.Size(1011, 168);
            this.groupBoxDone.TabIndex = 3;
            this.groupBoxDone.TabStop = false;
            this.groupBoxDone.Text = "Действия";
            // 
            // labelAddRows
            // 
            this.labelAddRows.AutoSize = true;
            this.labelAddRows.Location = new System.Drawing.Point(153, 31);
            this.labelAddRows.Name = "labelAddRows";
            this.labelAddRows.Size = new System.Drawing.Size(94, 17);
            this.labelAddRows.TabIndex = 3;
            this.labelAddRows.Text = "Кол-во строк";
            // 
            // labelAddColumns
            // 
            this.labelAddColumns.AutoSize = true;
            this.labelAddColumns.Location = new System.Drawing.Point(6, 31);
            this.labelAddColumns.Name = "labelAddColumns";
            this.labelAddColumns.Size = new System.Drawing.Size(118, 17);
            this.labelAddColumns.TabIndex = 3;
            this.labelAddColumns.Text = "Кол-во столбцов";
            // 
            // textBoxAddRows
            // 
            this.textBoxAddRows.Location = new System.Drawing.Point(156, 51);
            this.textBoxAddRows.Name = "textBoxAddRows";
            this.textBoxAddRows.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddRows.TabIndex = 2;
            // 
            // textBoxAddColumns
            // 
            this.textBoxAddColumns.Location = new System.Drawing.Point(6, 51);
            this.textBoxAddColumns.Name = "textBoxAddColumns";
            this.textBoxAddColumns.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddColumns.TabIndex = 1;
            // 
            // buttonAddRows
            // 
            this.buttonAddRows.Location = new System.Drawing.Point(156, 79);
            this.buttonAddRows.Name = "buttonAddRows";
            this.buttonAddRows.Size = new System.Drawing.Size(100, 50);
            this.buttonAddRows.TabIndex = 0;
            this.buttonAddRows.Text = "Добавить строки";
            this.buttonAddRows.UseVisualStyleBackColor = true;
            this.buttonAddRows.Click += new System.EventHandler(this.buttonAddRows_Click);
            // 
            // buttonAddColumns
            // 
            this.buttonAddColumns.Location = new System.Drawing.Point(6, 79);
            this.buttonAddColumns.Name = "buttonAddColumns";
            this.buttonAddColumns.Size = new System.Drawing.Size(100, 50);
            this.buttonAddColumns.TabIndex = 0;
            this.buttonAddColumns.Text = "Добавить столбы";
            this.buttonAddColumns.UseVisualStyleBackColor = true;
            this.buttonAddColumns.Click += new System.EventHandler(this.buttonAddColumns_Click);
            // 
            // dataGridViewOpenFile
            // 
            this.dataGridViewOpenFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpenFile.ColumnHeadersVisible = false;
            this.dataGridViewOpenFile.Location = new System.Drawing.Point(14, 7);
            this.dataGridViewOpenFile.Name = "dataGridViewOpenFile";
            this.dataGridViewOpenFile.RowHeadersVisible = false;
            this.dataGridViewOpenFile.RowHeadersWidth = 51;
            this.dataGridViewOpenFile.RowTemplate.Height = 24;
            this.dataGridViewOpenFile.Size = new System.Drawing.Size(1012, 319);
            this.dataGridViewOpenFile.TabIndex = 2;
            this.dataGridViewOpenFile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOpenFile_CellContentClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 529);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Red;
            this.panelLeft.Controls.Add(this.groupBoxResult);
            this.panelLeft.Controls.Add(this.groupBox_Filt);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeft.Location = new System.Drawing.Point(1032, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 529);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.comboBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(22, 184);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(166, 168);
            this.groupBoxResult.TabIndex = 0;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат";
            // 
            // comboBoxResult
            // 
            this.comboBoxResult.FormattingEnabled = true;
            this.comboBoxResult.Location = new System.Drawing.Point(7, 47);
            this.comboBoxResult.Name = "comboBoxResult";
            this.comboBoxResult.Size = new System.Drawing.Size(121, 24);
            this.comboBoxResult.TabIndex = 0;
            // 
            // groupBox_Filt
            // 
            this.groupBox_Filt.Controls.Add(this.comboBoxSort);
            this.groupBox_Filt.Location = new System.Drawing.Point(22, 6);
            this.groupBox_Filt.Name = "groupBox_Filt";
            this.groupBox_Filt.Size = new System.Drawing.Size(166, 172);
            this.groupBox_Filt.TabIndex = 0;
            this.groupBox_Filt.TabStop = false;
            this.groupBox_Filt.Text = "Фильтрация";
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(7, 48);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSort.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // toolTipMain
            // 
            this.toolTipMain.IsBalloon = true;
            this.toolTipMain.Tag = "Подсказка!";
            this.toolTipMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipMain.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipMain_Popup);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 653);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база | Команич Р. М.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            this.groupBoxDone.ResumeLayout(false);
            this.groupBoxDone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpenFile)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBox_Filt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.DataGridView dataGridViewOpenFile;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.ComboBox comboBoxResult;
        private System.Windows.Forms.GroupBox groupBox_Filt;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBoxDone;
        private System.Windows.Forms.TextBox textBoxAddRows;
        private System.Windows.Forms.TextBox textBoxAddColumns;
        private System.Windows.Forms.Button buttonAddRows;
        private System.Windows.Forms.Button buttonAddColumns;
        private System.Windows.Forms.Label labelAddRows;
        private System.Windows.Forms.Label labelAddColumns;
        private System.Windows.Forms.Button buttonСharts;
    }
}

