using System;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Dinamic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripButtonEdit.Enabled = false;
            toolStripButtonDelete.Enabled = false;
        }

        int projectsCount, totalAmount, investmentsPortions;
        int[] sequenceInvestments;
        string whatToolButtonClicked = "";
        int absoluteMaximum = int.MinValue;

        private void toolStripButtonCreate_Click(object sender, EventArgs e)
        {
            projectsCountLB.Enabled = true;
            projectsCountTB.Enabled = true;
            totalAmountLB.Enabled = true;
            totalAmountTB.Enabled = true;
            investmentsPortionsLB.Enabled = true;
            investmentsPortionsTB.Enabled = true;
            sequenceInvestmentsLB.Enabled = true;
            sequenceInvestmentsTB.Enabled = true;
            applyButton.Enabled = true;
            cancelButton.Enabled = true;
            projectsCountTB.Focus();
            whatToolButtonClicked = "create";
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            projectsCountTB.Text = projectsCount.ToString();
            totalAmountTB.Text = totalAmount.ToString();
            investmentsPortionsTB.Text = investmentsPortions.ToString();
            sequenceInvestmentsTB.Text = String.Concat<int>(sequenceInvestments);
            projectsCountLB.Enabled = true;
            projectsCountTB.Enabled = true;
            totalAmountLB.Enabled = true;
            totalAmountTB.Enabled = true;
            investmentsPortionsLB.Enabled = true;
            investmentsPortionsTB.Enabled = true;
            sequenceInvestmentsLB.Enabled = true;
            sequenceInvestmentsTB.Enabled = true;
            dataGVResult.RowCount = 0;
            dataGVResult.ColumnCount = 0;
            applyButton.Enabled = true;
            cancelButton.Enabled = true;
            projectsCountTB.Focus();
            whatToolButtonClicked = "edit";
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            dataGVRevenue.RowCount = 0;
            dataGVRevenue.ColumnCount = 0;
            whatToolButtonClicked = "delete";
            toolStripButtonCreate.Enabled = true;
            toolStripButtonEdit.Enabled = false;
            errorProvider1.Clear();
        }

        private void projectsCountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void projectsCountTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                totalAmountTB.Focus();
            if (e.KeyCode == Keys.Enter)
                applyButton_Click(sender, e);
            if (e.KeyCode == Keys.Escape)
                cancelButton_Click(sender, e);
        }

        private void totalAmountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void totalAmountTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                investmentsPortionsTB.Focus();
            if (e.KeyCode == Keys.Up)
                projectsCountTB.Focus();
            if (e.KeyCode == Keys.Enter)
                applyButton_Click(sender, e);
            if (e.KeyCode == Keys.Escape)
                cancelButton_Click(sender, e);
        }

        private void investmentsPortionsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void investmentsPortionsTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                totalAmountTB.Focus();
            if (e.KeyCode == Keys.Down)
                sequenceInvestmentsTB.Focus();
            if (e.KeyCode == Keys.Escape)
                cancelButton_Click(sender, e);
        }

        private void sequenceInvestmentsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void sequenceInvestmentsTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                investmentsPortionsTB.Focus();
            if (e.KeyCode == Keys.Enter)
                applyButton_Click(sender, e);
            if (e.KeyCode == Keys.Escape)
                cancelButton_Click(sender, e);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            totalAmountLB.Enabled = false;
            totalAmountTB.Enabled = false;
            totalAmountTB.Clear();
            projectsCountLB.Enabled = false;
            projectsCountTB.Enabled = false;
            projectsCountTB.Clear();
            investmentsPortionsLB.Enabled = false;
            investmentsPortionsTB.Enabled = false;
            investmentsPortionsTB.Clear();
            sequenceInvestmentsLB.Enabled = false;
            sequenceInvestmentsTB.Enabled = false;
            sequenceInvestmentsTB.Clear();
            applyButton.Enabled = false;
            cancelButton.Enabled = false;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (projectsCountTB.Text != "" && totalAmountTB.Text != "" && investmentsPortionsTB.Text != "" && sequenceInvestmentsTB.Text != "")
            {
                projectsCount = Convert.ToInt32(projectsCountTB.Text);
                totalAmount = Convert.ToInt32(totalAmountTB.Text);
                investmentsPortions = Convert.ToInt32(investmentsPortionsTB.Text);
                string sequence = sequenceInvestmentsTB.Text;
                sequenceInvestments = sequence.Select(x => int.Parse(x.ToString())).ToArray();

                if (((double)totalAmount % (double)investmentsPortions) == 0 && totalAmount > investmentsPortions)
                {
                    int rowPortionsCount = totalAmount / investmentsPortions;
                    int temp = investmentsPortions;

                    dataGVRevenue.RowCount = rowPortionsCount;
                    dataGVRevenue.ColumnCount = projectsCount;
                    dataGVRevenue.TopLeftHeaderCell.Value = "xi";
                    dataGVRevenue.RowHeadersWidth = 70;
                    dataGVRevenue.BeginEdit(true);

                    //Названия для столбцов
                    for (int i = 0; i < dataGVRevenue.ColumnCount; i++)
                    {
                        dataGVRevenue.Columns[i].HeaderText = "f" + (i + 1).ToString() + "(xi)";
                    }
                    //Названия для строк
                    for (int i = 0; i < dataGVRevenue.RowCount; i++)
                    {
                        dataGVRevenue.Rows[i].HeaderCell.Value = temp.ToString();
                        temp += investmentsPortions;
                    }

                    totalAmountLB.Enabled = false;
                    totalAmountTB.Enabled = false;
                    totalAmountTB.Clear();
                    projectsCountLB.Enabled = false;
                    projectsCountTB.Enabled = false;
                    projectsCountTB.Clear();
                    investmentsPortionsLB.Enabled = false;
                    investmentsPortionsTB.Enabled = false;
                    investmentsPortionsTB.Clear();
                    sequenceInvestmentsLB.Enabled = false;
                    sequenceInvestmentsTB.Enabled = false;
                    sequenceInvestmentsTB.Clear();
                    applyButton.Enabled = false;
                    cancelButton.Enabled = false;
                    errorProvider1.Clear();
                    if (whatToolButtonClicked == "create")
                    {
                        toolStripButtonCreate.Enabled = false;
                        toolStripButtonEdit.Enabled = true;
                        toolStripButtonDelete.Enabled = true;
                    }
                }
                else
                    errorProvider1.SetError(applyButton, "Порции инвестиций должны быть кратны и не больше суммы средств.");
            } else
                errorProvider1.SetError(applyButton, "Пустые поля не разрешены!");
        }

        private void getSolution_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == solutionTab)
            {
                if (errorProvider1.GetError(dataGVRevenue) == "")
                {
                    errorProvider1.Clear();
                    tabControl.SelectTab(solutionTab);

                    int[,] matrix_income = ReadingInvestmentsIncomeValues(dataGVRevenue);
                    int[] matrix_portions = ReadingInvestmentsPortions(dataGVRevenue);
                    int[] income;
                    List<int> income_midway = new List<int>();
                    
                    //Создание таблицы результатов
                    dataGVResult.RowCount = matrix_portions.Length - 1;
                    dataGVResult.TopLeftHeaderCell.Value = "xi";
                    dataGVResult.RowHeadersWidth = 70;
                    dataGVResult.ColumnCount = projectsCount * 2;
                    for (int i = 0; i < dataGVResult.Columns.Count; i++)
                        dataGVResult.Columns[i].Width = 70;
                    for (int i = 0; i < dataGVResult.Rows.Count; i++)
                        dataGVResult.Rows[i].HeaderCell.Value = matrix_portions[i + 1].ToString();
                    for (int i = 0; i < projectsCount; i++)
                    {
                        dataGVResult.Columns[(i * 2) + 1].HeaderCell.Value = "F" + (i + 1).ToString();
                        dataGVResult.Columns[i * 2].HeaderCell.Value = "x" + (i + 1).ToString();
                    }

                    //Начальный столбец
                    for (int temp = 1; temp <= matrix_income.GetLength(0) - 1; temp++)
                    {
                        int current = sequenceInvestments[0] - 1;
                        income_midway.Add(matrix_income[temp, current]);
                        if (income_midway[temp - 1] > absoluteMaximum)
                        {

                            absoluteMaximum = income_midway[temp - 1];
                            dataGVResult.Rows[temp - 1].Cells[(current * 2) + 1].Value = absoluteMaximum;
                            dataGVResult.Rows[temp - 1].Cells[(current * 2)].Value = matrix_portions[temp];
                        } else
                        {
                            dataGVResult.Rows[temp - 1].Cells[(current * 2) + 1].Value = absoluteMaximum;
                            dataGVResult.Rows[temp - 1].Cells[(current * 2)].Value = matrix_portions[income_midway.IndexOf(absoluteMaximum) + 1];
                        }
                    }
                    income_midway.Clear();

                    sequenceLB.Text = sequenceInvestments[0] + " ";
                    //Прямой проход sequenceInvestments.Length - 1
                    for (int i = 1; i <= sequenceInvestments.Length - 1; i++)
                    {
                        int current = sequenceInvestments[i] - 1;
                        int previous = sequenceInvestments[i - 1] - 1;
                        income = ReadingIncome(dataGVResult, ((previous * 2) + 1));
                        List<int> income_temp = new List<int>();
                        string portion_temp = "";
                        sequenceLB.Text += "-> " + sequenceInvestments[i];

                        //Основной цикл для конечной таблицы
                        for (int j = 1; j <= matrix_income.GetLength(0) - 1; j++)
                        {
                            int temp = j;
                            income_temp.Clear();
                            income_midway.Clear();

                            //Сумма вложений промежуточная таблица
                            for (int k = 0; k <= j; k++)
                            {
                                income_midway.Add(income[k]);
                                income_temp.Insert(0, matrix_income[temp, current] + income_midway[k]);
                                temp--;
                            }
                            int max_temp = income_temp.Max();
                            int enter_count = 0;

                            //Порции инвестиций
                            for (int l = 0; l < income_temp.Count; l++)
                            {
                                if (income_temp[l] >= max_temp)
                                {
                                    enter_count++;
                                    if (enter_count >= 2)
                                    {
                                        portion_temp += "," + matrix_portions[l];
                                        dataGVResult.Rows[j - 1].Cells[current * 2].Value = portion_temp;
                                    } else
                                    {
                                        portion_temp += matrix_portions[l];
                                        dataGVResult.Rows[j - 1].Cells[current * 2].Value = portion_temp;
                                    }
                                }
                            }
                            portion_temp = "";
                            dataGVResult.Rows[j - 1].Cells[(current * 2) + 1].Value = income_temp.Max();
                        }
                    }

                    matchLB.Text = "";
                    int index_max = matrix_income.GetLength(0) - 1;
                    int income_max = 0;
                    int totalCalc = totalAmount;
                    //Обратный проход
                    for (int i = sequenceInvestments.Length - 1; i >= 0; i--)
                    {
                        int backword_current = sequenceInvestments[i] - 1;
                        int[] matrix_result = ReadingIncome(dataGVResult, (backword_current * 2) + 1);
                        
                        if (i == sequenceInvestments.Length - 1)
                            income_max = matrix_result.Max();
                        
                        for (int j = index_max; j >= 0; j--)
                        {
                            if (matrix_result[j] > absoluteMaximum)
                                absoluteMaximum = matrix_result[j];
                        }
                        
                        int portion_exclude = Convert.ToInt32(dataGVResult.Rows[Array.IndexOf(matrix_result, absoluteMaximum) - 1].Cells[backword_current * 2].Value);
                        matchLB.Text += "x" + sequenceInvestments[i] + " = " + portion_exclude + ", F" + sequenceInvestments[i] +
                            " = " + absoluteMaximum + ", E(" + totalCalc + " - " + portion_exclude + ") = ";
                        totalCalc -= portion_exclude;
                        index_max = Array.IndexOf(matrix_portions, totalCalc);
                        matchLB.Text += totalCalc + "\n";

                        absoluteMaximum = int.MinValue;
                    }

                    //Вывод функции F(..) = result
                    resultLB.Text = "F(";
                    for (int i = sequenceInvestments.Length - 1; i >= 1; i--)
                        resultLB.Text += "x" + sequenceInvestments[i] + ", ";
                    resultLB.Text += "x" + sequenceInvestments[0] + ") = " + income_max;
                }
                else
                    tabControl.SelectTab(inputDataTab);
            }
            else if (tabControl.SelectedTab == inputDataTab)
                tabControl.SelectTab(inputDataTab);
        }

        //Чтение значений порций по вложениям
        private int[] ReadingInvestmentsPortions(DataGridView dataGridView)
        {
            int[] portions;

            portions = new int[dataGridView.RowCount + 1];
            try
            {
                for (int i = 0; i < portions.Length; i++)
                {
                    if (i == 0)
                        portions[i] = 0;
                    else 
                        portions[i] = Convert.ToInt32(dataGridView.Rows[i - 1].HeaderCell.Value);
                }
            }
            catch (System.Exception e)
            {
                errorProvider1.SetError(dataGridView, e.Message);
            }

            return portions;
        }

        private int[] ReadingIncome(DataGridView dataGridView, int line)
        {
            int[] income;

            income = new int[dataGridView.RowCount + 1];
            try
            {
                for (int i = 0; i < income.Length; i++)
                {
                    if (i == 0)
                        income[i] = 0;
                    else
                        income[i] = Convert.ToInt32(dataGridView.Rows[i - 1].Cells[line].Value); ;
                }
            }
            catch (System.Exception e)
            {
                errorProvider1.SetError(dataGridView, e.Message);
            }

            return income;
        }

        //Чтение значений альтернатива - критерий
        private int[,] ReadingInvestmentsIncomeValues(DataGridView dataGridView)
        {
            int[,] values;

            values = new int[dataGridView.RowCount + 1, dataGridView.ColumnCount];
            try
            {
                for (int i = 0; i < values.GetLength(0); i++)
                {
                    for (int j = 0; j < values.GetLength(1); j++)
                    {
                        if (i == 0)
                            values[i, j] = 0;
                        else
                            values[i, j] = Convert.ToInt32(dataGridView.Rows[i - 1].Cells[j].Value);
                    }
                }
            }
            catch (System.Exception e)
            {
                errorProvider1.SetError(dataGridView, e.Message);
            }

            return values;
        }

        //Запись матрицы в dataGridView
        private static void WriteDataGridView(int[,] matrix, DataGridView dataGridView)
        {
            dataGridView.RowCount = matrix.GetLength(0);
            dataGridView.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                    dataGridView.Columns[j].Width = 70;
                }
            }
        }
    }
}