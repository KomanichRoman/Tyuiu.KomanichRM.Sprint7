using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KomanichRM.Sprint7.Project.V5.Lib;
using System.IO;

namespace Tyuiu.KomanichRM.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void toolTipMain_Popup(object sender, PopupEventArgs e)
        {

        }
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                openFile = openFileDialog.FileName;

                matrix = ds.LoadFromDataFile(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewOpenFile.Rows.Clear();
                dataGridViewOpenFile.Columns.Clear();
                dataGridViewOpenFile.RowCount = rows + 1;
                dataGridViewOpenFile.ColumnCount = columns + 1;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOpenFile.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewOpenFile.Rows[i].Cells[j].Selected = false;
                    }
                }
                this.dataGridViewOpenFile.DefaultCellStyle.Font = new Font("Tahoma", 9);
                dataGridViewOpenFile.AutoResizeColumns();
                comboBoxSort.Text = "";
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewOpenFile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.FileName = ".csv";
                saveFileDialog.InitialDirectory = @":C"; //дописать путь до опен фолдер
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewOpenFile.RowCount - 1;
                    int columns = dataGridViewOpenFile.ColumnCount - 1;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewOpenFile.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddColumns_Click(object sender, EventArgs e)
        {
            int columnsToAdd;
            if (int.TryParse(textBoxAddColumns.Text, out columnsToAdd))
            {
                int existingColumnsCount = dataGridViewOpenFile.Columns.Count;
                int newColumnsCount = existingColumnsCount + columnsToAdd;
                for (int i = existingColumnsCount; i < newColumnsCount; i++)
                {
                    dataGridViewOpenFile.Columns.Add("Column" + (i + 1), "Column" + (i + 1));
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите правильное целое число в поле ввода.");
            }
        }

        private void buttonAddRows_Click(object sender, EventArgs e)
        {
            int rowsToAdd;
            if (int.TryParse(textBoxAddRows.Text, out rowsToAdd))
            {
                int existingRowsCount = dataGridViewOpenFile.Columns.Count;
                int newColumnsCount = existingRowsCount + rowsToAdd;
                for (int i = existingRowsCount; i < newColumnsCount; i++)
                {
                    dataGridViewOpenFile.Rows.Add();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите правильное целое число в поле ввода.");
            }
        }

        private void buttonСharts_Click(object sender, EventArgs e)
        {
            FormCharts formCharts = new FormCharts();
            formCharts.ShowDialog();
        }

        private void buttonMean_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile.SelectedCells.Count == 1)
            {
                DataGridViewCell selectedCell = dataGridViewOpenFile.SelectedCells[0];

                string value = textBoxMean.Text;

                selectedCell.Value = value;
            }
            if (dataGridViewOpenFile.SelectedCells.Count > 0)
            {
                DataGridViewCell currentCell = dataGridViewOpenFile.SelectedCells[0];
                int nextCellIndex = currentCell.ColumnIndex + 1;
                if (nextCellIndex < dataGridViewOpenFile.Columns.Count)
                {
                    currentCell.Selected = false;

                    dataGridViewOpenFile.Rows[currentCell.RowIndex].Cells[nextCellIndex].Selected = true;

                    dataGridViewOpenFile.FirstDisplayedScrollingColumnIndex = nextCellIndex;
                }
            }
            textBoxMean.Text = "";
        }

        private void comboBoxResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonStat_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridViewOpenFile.SelectedCells[0].RowIndex;
                if (rowIndex != -1)
                {
                    dataGridViewOpenFile.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите действительную ячейку");
                }
            }
            else if (dataGridViewOpenFile.RowCount > 0)
            {
                dataGridViewOpenFile.Rows.RemoveAt(dataGridViewOpenFile.RowCount - 1);
            }
            else
            {
                MessageBox.Show("Нет строк для удаления");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
