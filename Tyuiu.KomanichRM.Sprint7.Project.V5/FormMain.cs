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
    public partial class FormMain_KRM : Form
    {
        public FormMain_KRM()
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
                openFileDialog_KRM.ShowDialog();
                openFile = openFileDialog_KRM.FileName;

                matrix = ds.LoadFromDataFile(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewOpenFile_KRM.Rows.Clear();
                dataGridViewOpenFile_KRM.Columns.Clear();
                dataGridViewOpenFile_KRM.RowCount = rows + 1;
                dataGridViewOpenFile_KRM.ColumnCount = columns + 1;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOpenFile_KRM.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewOpenFile_KRM.Rows[i].Cells[j].Selected = false;
                    }
                }
                this.dataGridViewOpenFile_KRM.DefaultCellStyle.Font = new Font("Tahoma", 9);
                dataGridViewOpenFile_KRM.AutoResizeColumns();
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
                saveFileDialog_KRM.FileName = ".csv";
                saveFileDialog_KRM.InitialDirectory = @":C"; //дописать путь до опен фолдер
                if (saveFileDialog_KRM.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_KRM.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewOpenFile_KRM.RowCount - 1;
                    int columns = dataGridViewOpenFile_KRM.ColumnCount - 1;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewOpenFile_KRM.Rows[i].Cells[j].Value);

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
            if (int.TryParse(textBoxAddColumns_KRM.Text, out columnsToAdd))
            {
                int existingColumnsCount = dataGridViewOpenFile_KRM.Columns.Count;
                int newColumnsCount = existingColumnsCount + columnsToAdd;
                for (int i = existingColumnsCount; i < newColumnsCount; i++)
                {
                    dataGridViewOpenFile_KRM.Columns.Add("Column" + (i + 1), "Column" + (i + 1));
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
            if (int.TryParse(textBoxAddRows_KRM.Text, out rowsToAdd))
            {
                int existingRowsCount = dataGridViewOpenFile_KRM.Columns.Count;
                int newColumnsCount = existingRowsCount + rowsToAdd;
                for (int i = existingRowsCount; i < newColumnsCount; i++)
                {
                    dataGridViewOpenFile_KRM.Rows.Add();
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
            if (dataGridViewOpenFile_KRM.SelectedCells.Count == 1)
            {
                DataGridViewCell selectedCell = dataGridViewOpenFile_KRM.SelectedCells[0];

                string value = textBoxMean_KRM.Text;

                selectedCell.Value = value;
            }
            if (dataGridViewOpenFile_KRM.SelectedCells.Count > 0)
            {
                DataGridViewCell currentCell = dataGridViewOpenFile_KRM.SelectedCells[0];
                int nextCellIndex = currentCell.ColumnIndex + 1;
                if (nextCellIndex < dataGridViewOpenFile_KRM.Columns.Count)
                {
                    currentCell.Selected = false;

                    dataGridViewOpenFile_KRM.Rows[currentCell.RowIndex].Cells[nextCellIndex].Selected = true;

                    dataGridViewOpenFile_KRM.FirstDisplayedScrollingColumnIndex = nextCellIndex;
                }
            }
            textBoxMean_KRM.Text = "";
            textBoxMean_KRM.Focus();
        }

        private void buttonStat_Click(object sender, EventArgs e)
        {
            int columnIndex = dataGridViewOpenFile_KRM.SelectedCells[0].ColumnIndex;
            double minValue = double.MaxValue;
            double maxValue = double.MinValue;
            double sum = 0;
            int count = 0;
            foreach (DataGridViewRow row in dataGridViewOpenFile_KRM.Rows)
            {
                if (row.Cells[columnIndex].Value != null && double.TryParse(row.Cells[columnIndex].Value.ToString(), out double value))
                {
                    minValue = Math.Min(minValue, value);
                    maxValue = Math.Max(maxValue, value);
                    sum += value;
                    count++;
                }
            }

            double average = sum / count;
            textBoxMin_KRM.Text = minValue.ToString();
            textBoxMax_KRM.Text = maxValue.ToString();
            textBoxAver_KRM.Text = average.ToString();
        }

        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_KRM.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridViewOpenFile_KRM.SelectedCells[0].RowIndex;
                if (rowIndex != -1)
                {
                    dataGridViewOpenFile_KRM.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите действительную ячейку");
                }
            }
            else if (dataGridViewOpenFile_KRM.RowCount > 0)
            {
                dataGridViewOpenFile_KRM.Rows.RemoveAt(dataGridViewOpenFile_KRM.RowCount - 1);
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_KRM.Text;
            bool found = false;

            foreach (DataGridViewRow row in dataGridViewOpenFile_KRM.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        cell.Selected = !cell.Selected;
                        found = true;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Элемент не найден");
            }
        }

        private void buttonDeleteColumn_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile_KRM.SelectedCells.Count > 0)
            {
                int columnIndex = dataGridViewOpenFile_KRM.SelectedCells[0].ColumnIndex;
                if (columnIndex != -1)
                {
                    dataGridViewOpenFile_KRM.Columns.RemoveAt(columnIndex);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите действительную ячейку");
                }
            }
            else if (dataGridViewOpenFile_KRM.ColumnCount > 0)
            {
                dataGridViewOpenFile_KRM.Columns.RemoveAt(dataGridViewOpenFile_KRM.ColumnCount - 1);
            }
            else
            {
                MessageBox.Show("Нет столбца для удаления");
            }
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void buttonGuide_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void groupBoxDone_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFilt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewOpenFile_KRM.RowCount - 1; i++)
            {
                string filterValue = textBoxFilt_KRM.Text.ToLower();
                dataGridViewOpenFile_KRM.Rows[i].Visible = false;
                for (int j = 0; j < dataGridViewOpenFile_KRM.ColumnCount; j++)
                {
                    var cellValue = dataGridViewOpenFile_KRM.Rows[i].Cells[j].Value?.ToString()?.ToLower();
                    if (cellValue != null && cellValue == filterValue)
                    {
                        dataGridViewOpenFile_KRM.Rows[i].Visible = true;
                        break;
                    }
                }
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOpenFile_KRM.Rows[matrix.GetLength(0) - 1].Cells[c].Value = "";
                }
            }
        }
    }
}
