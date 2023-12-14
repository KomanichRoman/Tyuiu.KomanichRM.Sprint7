using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KomanichRM.Sprint7.Project.V5.Lib;

namespace Tyuiu.KomanichRM.Sprint7.Project.V5
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }
        static int rows;
        static int colums;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }   
        private void buttonProducts_OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogProducts.ShowDialog();
            openFilePath = openFileDialogProducts.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewProducts.ColumnCount = colums;
            dataGridViewProducts.RowCount = rows;
            dataGridViewProducts.ColumnCount = colums;
            dataGridViewProducts.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewProducts.Columns[i].Width = 25;
                dataGridViewProducts.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewProducts.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonProducts_Done.Enabled = true;
        }
    }
}
