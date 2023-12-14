
namespace Tyuiu.KomanichRM.Sprint7.Project.V5
{
    partial class FormProducts
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
            this.panelTopProducts = new System.Windows.Forms.Panel();
            this.panelFillProducts = new System.Windows.Forms.Panel();
            this.buttonProducts_OpenFile = new System.Windows.Forms.Button();
            this.buttonProducts_Done = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.openFileDialogProducts = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTopProducts.SuspendLayout();
            this.panelFillProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopProducts
            // 
            this.panelTopProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelTopProducts.Controls.Add(this.buttonProducts_Done);
            this.panelTopProducts.Controls.Add(this.buttonProducts_OpenFile);
            this.panelTopProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopProducts.Location = new System.Drawing.Point(0, 0);
            this.panelTopProducts.Name = "panelTopProducts";
            this.panelTopProducts.Size = new System.Drawing.Size(346, 183);
            this.panelTopProducts.TabIndex = 0;
            // 
            // panelFillProducts
            // 
            this.panelFillProducts.BackColor = System.Drawing.Color.PaleGreen;
            this.panelFillProducts.Controls.Add(this.dataGridViewProducts);
            this.panelFillProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFillProducts.Location = new System.Drawing.Point(0, 183);
            this.panelFillProducts.Name = "panelFillProducts";
            this.panelFillProducts.Size = new System.Drawing.Size(346, 462);
            this.panelFillProducts.TabIndex = 0;
            // 
            // buttonProducts_OpenFile
            // 
            this.buttonProducts_OpenFile.Location = new System.Drawing.Point(44, 32);
            this.buttonProducts_OpenFile.Name = "buttonProducts_OpenFile";
            this.buttonProducts_OpenFile.Size = new System.Drawing.Size(107, 84);
            this.buttonProducts_OpenFile.TabIndex = 0;
            this.buttonProducts_OpenFile.Text = "Открыть файл";
            this.buttonProducts_OpenFile.UseVisualStyleBackColor = true;
            this.buttonProducts_OpenFile.Click += new System.EventHandler(this.buttonProducts_OpenFile_Click);
            // 
            // buttonProducts_Done
            // 
            this.buttonProducts_Done.Enabled = false;
            this.buttonProducts_Done.Location = new System.Drawing.Point(225, 32);
            this.buttonProducts_Done.Name = "buttonProducts_Done";
            this.buttonProducts_Done.Size = new System.Drawing.Size(107, 84);
            this.buttonProducts_Done.TabIndex = 0;
            this.buttonProducts_Done.Text = "Загрузить таблицу";
            this.buttonProducts_Done.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(342, 462);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // openFileDialogProducts
            // 
            this.openFileDialogProducts.FileName = "openFileDialog1";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 645);
            this.Controls.Add(this.panelFillProducts);
            this.Controls.Add(this.panelTopProducts);
            this.Name = "FormProducts";
            this.Text = "Информация о товарах";
            this.panelTopProducts.ResumeLayout(false);
            this.panelFillProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopProducts;
        private System.Windows.Forms.Panel panelFillProducts;
        private System.Windows.Forms.Button buttonProducts_Done;
        private System.Windows.Forms.Button buttonProducts_OpenFile;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.OpenFileDialog openFileDialogProducts;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}