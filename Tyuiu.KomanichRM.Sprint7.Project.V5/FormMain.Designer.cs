
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
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.groupBoxDone = new System.Windows.Forms.GroupBox();
            this.groupBoxMean = new System.Windows.Forms.GroupBox();
            this.buttonMean = new System.Windows.Forms.Button();
            this.textBoxMean = new System.Windows.Forms.TextBox();
            this.labelMean = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddRows = new System.Windows.Forms.Button();
            this.buttonAddColumns = new System.Windows.Forms.Button();
            this.textBoxAddColumns = new System.Windows.Forms.TextBox();
            this.textBoxAddRows = new System.Windows.Forms.TextBox();
            this.labelAddRows = new System.Windows.Forms.Label();
            this.labelAddColumns = new System.Windows.Forms.Label();
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
            this.groupBoxStat = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxAver = new System.Windows.Forms.TextBox();
            this.buttonStat = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelAver = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.groupBoxDone.SuspendLayout();
            this.groupBoxMean.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpenFile)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBox_Filt.SuspendLayout();
            this.groupBoxStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LawnGreen;
            this.panelTop.Controls.Add(this.buttonСharts);
            this.panelTop.Controls.Add(this.buttonSaveFile);
            this.panelTop.Controls.Add(this.buttonAddFile);
            this.panelTop.Controls.Add(this.buttonHelp);
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
            this.toolTipMain.SetToolTip(this.buttonСharts, "Перейти к построению графиков");
            this.buttonСharts.UseVisualStyleBackColor = true;
            this.buttonСharts.Click += new System.EventHandler(this.buttonСharts_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(166, 23);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(100, 70);
            this.buttonSaveFile.TabIndex = 1;
            this.buttonSaveFile.Text = "Сохранить";
            this.toolTipMain.SetToolTip(this.buttonSaveFile, "Сохранить измененную таблицу");
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
            this.toolTipMain.SetToolTip(this.buttonAddFile, "Открыть исходную таблицу");
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(1114, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(88, 81);
            this.buttonHelp.TabIndex = 0;
            this.buttonHelp.Text = "Справка";
            this.toolTipMain.SetToolTip(this.buttonHelp, "Посмотреть информацию о разработчике");
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.button3_Click);
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
            this.groupBoxDone.BackColor = System.Drawing.Color.LawnGreen;
            this.groupBoxDone.Controls.Add(this.groupBoxStat);
            this.groupBoxDone.Controls.Add(this.groupBoxMean);
            this.groupBoxDone.Controls.Add(this.groupBoxAdd);
            this.groupBoxDone.Location = new System.Drawing.Point(3, 332);
            this.groupBoxDone.Name = "groupBoxDone";
            this.groupBoxDone.Size = new System.Drawing.Size(1045, 197);
            this.groupBoxDone.TabIndex = 3;
            this.groupBoxDone.TabStop = false;
            // 
            // groupBoxMean
            // 
            this.groupBoxMean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxMean.Controls.Add(this.buttonDeleteRow);
            this.groupBoxMean.Controls.Add(this.buttonMean);
            this.groupBoxMean.Controls.Add(this.textBoxMean);
            this.groupBoxMean.Controls.Add(this.labelMean);
            this.groupBoxMean.Location = new System.Drawing.Point(431, 21);
            this.groupBoxMean.Name = "groupBoxMean";
            this.groupBoxMean.Size = new System.Drawing.Size(268, 158);
            this.groupBoxMean.TabIndex = 7;
            this.groupBoxMean.TabStop = false;
            this.groupBoxMean.Text = "Изменение элементов";
            // 
            // buttonMean
            // 
            this.buttonMean.Location = new System.Drawing.Point(15, 88);
            this.buttonMean.Name = "buttonMean";
            this.buttonMean.Size = new System.Drawing.Size(100, 50);
            this.buttonMean.TabIndex = 5;
            this.buttonMean.Text = "Изменить ячейку";
            this.toolTipMain.SetToolTip(this.buttonMean, "Изменить значение в ячейке на указанное");
            this.buttonMean.UseVisualStyleBackColor = true;
            this.buttonMean.Click += new System.EventHandler(this.buttonMean_Click);
            // 
            // textBoxMean
            // 
            this.textBoxMean.Location = new System.Drawing.Point(15, 60);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.Size = new System.Drawing.Size(100, 22);
            this.textBoxMean.TabIndex = 4;
            // 
            // labelMean
            // 
            this.labelMean.AutoSize = true;
            this.labelMean.Location = new System.Drawing.Point(12, 40);
            this.labelMean.Name = "labelMean";
            this.labelMean.Size = new System.Drawing.Size(116, 17);
            this.labelMean.TabIndex = 6;
            this.labelMean.Text = "Новое значение";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxAdd.Controls.Add(this.buttonAddRows);
            this.groupBoxAdd.Controls.Add(this.buttonAddColumns);
            this.groupBoxAdd.Controls.Add(this.textBoxAddColumns);
            this.groupBoxAdd.Controls.Add(this.textBoxAddRows);
            this.groupBoxAdd.Controls.Add(this.labelAddRows);
            this.groupBoxAdd.Controls.Add(this.labelAddColumns);
            this.groupBoxAdd.Location = new System.Drawing.Point(22, 21);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(324, 158);
            this.groupBoxAdd.TabIndex = 7;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление элементов";
            // 
            // buttonAddRows
            // 
            this.buttonAddRows.Location = new System.Drawing.Point(178, 89);
            this.buttonAddRows.Name = "buttonAddRows";
            this.buttonAddRows.Size = new System.Drawing.Size(100, 50);
            this.buttonAddRows.TabIndex = 0;
            this.buttonAddRows.Text = "Добавить строки";
            this.toolTipMain.SetToolTip(this.buttonAddRows, "Добавить указанное кол-во строк");
            this.buttonAddRows.UseVisualStyleBackColor = true;
            this.buttonAddRows.Click += new System.EventHandler(this.buttonAddRows_Click);
            // 
            // buttonAddColumns
            // 
            this.buttonAddColumns.Location = new System.Drawing.Point(6, 89);
            this.buttonAddColumns.Name = "buttonAddColumns";
            this.buttonAddColumns.Size = new System.Drawing.Size(100, 50);
            this.buttonAddColumns.TabIndex = 0;
            this.buttonAddColumns.Text = "Добавить столбы";
            this.toolTipMain.SetToolTip(this.buttonAddColumns, "Добавить указанное кол-во столбцов");
            this.buttonAddColumns.UseVisualStyleBackColor = true;
            this.buttonAddColumns.Click += new System.EventHandler(this.buttonAddColumns_Click);
            // 
            // textBoxAddColumns
            // 
            this.textBoxAddColumns.Location = new System.Drawing.Point(6, 61);
            this.textBoxAddColumns.Name = "textBoxAddColumns";
            this.textBoxAddColumns.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddColumns.TabIndex = 1;
            // 
            // textBoxAddRows
            // 
            this.textBoxAddRows.Location = new System.Drawing.Point(178, 61);
            this.textBoxAddRows.Name = "textBoxAddRows";
            this.textBoxAddRows.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddRows.TabIndex = 2;
            // 
            // labelAddRows
            // 
            this.labelAddRows.AutoSize = true;
            this.labelAddRows.Location = new System.Drawing.Point(175, 41);
            this.labelAddRows.Name = "labelAddRows";
            this.labelAddRows.Size = new System.Drawing.Size(94, 17);
            this.labelAddRows.TabIndex = 3;
            this.labelAddRows.Text = "Кол-во строк";
            // 
            // labelAddColumns
            // 
            this.labelAddColumns.AutoSize = true;
            this.labelAddColumns.Location = new System.Drawing.Point(6, 41);
            this.labelAddColumns.Name = "labelAddColumns";
            this.labelAddColumns.Size = new System.Drawing.Size(118, 17);
            this.labelAddColumns.TabIndex = 3;
            this.labelAddColumns.Text = "Кол-во столбцов";
            // 
            // dataGridViewOpenFile
            // 
            this.dataGridViewOpenFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.splitter1.BackColor = System.Drawing.Color.LawnGreen;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 529);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LawnGreen;
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
            this.groupBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.comboBoxResult.SelectedIndexChanged += new System.EventHandler(this.comboBoxResult_SelectedIndexChanged);
            // 
            // groupBox_Filt
            // 
            this.groupBox_Filt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.toolTipMain.ToolTipTitle = "Подсказка!";
            this.toolTipMain.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipMain_Popup);
            // 
            // groupBoxStat
            // 
            this.groupBoxStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBoxStat.Controls.Add(this.labelAver);
            this.groupBoxStat.Controls.Add(this.labelMax);
            this.groupBoxStat.Controls.Add(this.labelMin);
            this.groupBoxStat.Controls.Add(this.buttonStat);
            this.groupBoxStat.Controls.Add(this.textBoxAver);
            this.groupBoxStat.Controls.Add(this.textBoxMax);
            this.groupBoxStat.Controls.Add(this.textBoxMin);
            this.groupBoxStat.Location = new System.Drawing.Point(733, 21);
            this.groupBoxStat.Name = "groupBoxStat";
            this.groupBoxStat.Size = new System.Drawing.Size(306, 158);
            this.groupBoxStat.TabIndex = 7;
            this.groupBoxStat.TabStop = false;
            this.groupBoxStat.Text = "Статистика";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(136, 24);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxMin.TabIndex = 0;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(136, 72);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxMax.TabIndex = 0;
            // 
            // textBoxAver
            // 
            this.textBoxAver.Location = new System.Drawing.Point(136, 125);
            this.textBoxAver.Name = "textBoxAver";
            this.textBoxAver.Size = new System.Drawing.Size(100, 22);
            this.textBoxAver.TabIndex = 0;
            // 
            // buttonStat
            // 
            this.buttonStat.Location = new System.Drawing.Point(15, 49);
            this.buttonStat.Name = "buttonStat";
            this.buttonStat.Size = new System.Drawing.Size(95, 66);
            this.buttonStat.TabIndex = 1;
            this.buttonStat.Text = "Высчитать";
            this.toolTipMain.SetToolTip(this.buttonStat, "Высчитать мин/макс/сред значение выбранного столбца");
            this.buttonStat.UseVisualStyleBackColor = true;
            this.buttonStat.Click += new System.EventHandler(this.buttonStat_Click);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.Location = new System.Drawing.Point(167, 91);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(95, 45);
            this.buttonDeleteRow.TabIndex = 7;
            this.buttonDeleteRow.Text = "Удаление строки";
            this.toolTipMain.SetToolTip(this.buttonDeleteRow, "Удалить строку с выбранным элементом");
            this.buttonDeleteRow.UseVisualStyleBackColor = true;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(133, 6);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(166, 17);
            this.labelMin.TabIndex = 2;
            this.labelMin.Text = "Минимальное значение";
            // 
            // labelAver
            // 
            this.labelAver.AutoSize = true;
            this.labelAver.Location = new System.Drawing.Point(133, 105);
            this.labelAver.Name = "labelAver";
            this.labelAver.Size = new System.Drawing.Size(132, 17);
            this.labelAver.TabIndex = 2;
            this.labelAver.Text = "Среднее значение";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(133, 54);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(172, 17);
            this.labelMax.TabIndex = 2;
            this.labelMax.Text = "Максимальное значение";
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
            this.groupBoxMean.ResumeLayout(false);
            this.groupBoxMean.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpenFile)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBox_Filt.ResumeLayout(false);
            this.groupBoxStat.ResumeLayout(false);
            this.groupBoxStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Button buttonHelp;
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
        private System.Windows.Forms.Label labelMean;
        private System.Windows.Forms.Button buttonMean;
        private System.Windows.Forms.TextBox textBoxMean;
        private System.Windows.Forms.GroupBox groupBoxMean;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxStat;
        private System.Windows.Forms.Button buttonStat;
        private System.Windows.Forms.TextBox textBoxAver;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Label labelAver;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
    }
}

