
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
            this.panelFill = new System.Windows.Forms.Panel();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonInfo_Product = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.button3);
            this.panelTop.Controls.Add(this.buttonInfo_Product);
            this.panelTop.Controls.Add(this.buttonProduct);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1232, 164);
            this.panelTop.TabIndex = 3;
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 164);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1232, 489);
            this.panelFill.TabIndex = 3;
            // 
            // buttonProduct
            // 
            this.buttonProduct.Location = new System.Drawing.Point(65, 29);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(145, 81);
            this.buttonProduct.TabIndex = 0;
            this.buttonProduct.Text = "Товары";
            this.toolTipMain.SetToolTip(this.buttonProduct, "Посмотреть код и название товара\r\n");
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonInfo_Product
            // 
            this.buttonInfo_Product.Location = new System.Drawing.Point(329, 29);
            this.buttonInfo_Product.Name = "buttonInfo_Product";
            this.buttonInfo_Product.Size = new System.Drawing.Size(145, 81);
            this.buttonInfo_Product.TabIndex = 0;
            this.buttonInfo_Product.Text = "Информация о товарах";
            this.toolTipMain.SetToolTip(this.buttonInfo_Product, "Посмотреть информацию о товарах\r\n");
            this.buttonInfo_Product.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1119, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 81);
            this.button3.TabIndex = 0;
            this.button3.Text = "Справка";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "openFileDialog1";
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
            this.MaximumSize = new System.Drawing.Size(1250, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1250, 700);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база | Команич Р. М.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonInfo_Product;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
    }
}

