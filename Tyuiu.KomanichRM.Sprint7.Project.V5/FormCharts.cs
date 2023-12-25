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

namespace Tyuiu.KomanichRM.Sprint7.Project.V5
{
    public partial class FormCharts : Form
    {
        public FormCharts()
        {
            InitializeComponent();
        }
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        DataService ds = new DataService();
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogCharts.ShowDialog();
                openFile = openFileDialogCharts.FileName;

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
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDoneChart_Click(object sender, EventArgs e)
        {
            if (dataGridViewOpenFile.RowCount != 0)
            {
                if (dataGridViewOpenFile.RowCount > 2)
                {
                    int nugno = -1;
                    for (int i = 0; i < dataGridViewOpenFile.RowCount - 1; i++)
                    {
                        for (int j = 0; j < dataGridViewOpenFile.ColumnCount - 1; j++)
                        {
                            if (dataGridViewOpenFile.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridViewOpenFile.Rows[i].Cells[j].Selected == true)
                                {
                                    nugno = j;
                                    break;
                                }
                            }
                            if (nugno > -1) break;
                        }
                    }

                    if (nugno > -1)
                    {
                        int kaktak = 0;
                        for (int i = 0; i < dataGridViewOpenFile.RowCount - 1; i++)
                        {
                            if (dataGridViewOpenFile.Rows[i].Cells[0].Selected == true) kaktak++;
                        }
                        if (kaktak == 0)
                        {
                            int nadopodumati = 0;
                            for (int i = 1; i < dataGridViewOpenFile.RowCount - 1; i++)
                            {
                                if (dataGridViewOpenFile.Rows[i].Cells[nugno].Value != null)
                                {
                                    double cellValue;
                                    if (double.TryParse(dataGridViewOpenFile.Rows[i].Cells[nugno].Value.ToString(), out cellValue)) nadopodumati += 0;
                                    else if (dataGridViewOpenFile.Rows[i].Cells[nugno].ValueType.ToString().Any(char.IsLetter)) nadopodumati++;
                                }
                            }
                            if (nadopodumati == 0)
                            {
                                this.chartFunction.ChartAreas[0].AxisX.Title = "ID";
                                string name = Convert.ToString(dataGridViewOpenFile.Rows[0].Cells[nugno].Value);
                                this.chartFunction.ChartAreas[0].AxisY.Title = name;

                                int startValue = Convert.ToInt32(dataGridViewOpenFile.Rows[1].Cells[0].Value);
                                for (int i = 1; i < dataGridViewOpenFile.RowCount - 1; i++)
                                {
                                    this.chartFunction.Series[0].Points.AddXY(startValue, Convert.ToDouble(dataGridViewOpenFile.Rows[i].Cells[nugno].Value));
                                    startValue++;
                                }
                            }
                            else MessageBox.Show("Пожалуйста, выберите столбец с числами!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Нельзя выбрать первый столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Не выбран столбец", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Нет данных для построения графика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
