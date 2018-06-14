using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

using Salary;

namespace ViewSalaryForWorker
{
    public partial class AddObjectForm : Form
    {
        /// <summary>
        /// Конктруктор формы
        /// </summary>
        public AddObjectForm()
        {
            InitializeComponent();
            string descriptionHourly = 
                TypeSalaryEnum.GetDescription(TypeSalaryEnum.TypeSalary.Hourly);
            string descriptionRate = 
                TypeSalaryEnum.GetDescription(TypeSalaryEnum.TypeSalary.Rate);
            ComboBoxSalaryType.Items.Add(descriptionHourly);
            ComboBoxSalaryType.Items.Add(descriptionRate);
            ComboBoxSalaryType.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeRateControl1.Hide();
            employeeHourlyControl1.Hide();
        }

        //TODO: Должно быть в отдельном CS файле \ DONE

        /// <summary>
        /// Обработка элемента с выпадающим списком
        /// </summary>
        private void SelectSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = ComboBoxSalaryType.SelectedItem.ToString();
            MessageBox.Show(selectedState);
            var salary = ComboBoxSalaryType.Text;
            //TODO: Тут правильнее через switch-case, т.к. потенциально количество вариантов расчёта может расшириться \ DONE
            //TODO: А текущее условие предполагает только 2 состояния \ DONE
            switch (salary)
            {
                case "По часам":
                {
                    LabelSalary.Text = "Оплата в час";
                    TextBoxRate.Visible = false;
                    LabelRate.Visible = false;
                    employeeRateControl1.Hide();
                    //employeeHourlyControl1.Show();
                    break;
                }
                case "По окладу и ставке":
                {
                    TextBoxRate.Visible = true;
                    LabelRate.Visible = true;
                    LabelSalary.Text = "Оклад (норма)";
                    //employeeRateControl1.Show();
                    employeeHourlyControl1.Hide();
                    break;

                }
            }

            //if (salary == "По часам")
            //{
            //    LabelSalary.Text = "Оплата в час";
            //    TextBoxRate.Visible = false;
            //    LabelRate.Visible = false;
            //    employeeRateControl1.Hide();
            //    employeeHourlyControl1.Show();
            //}
            //else
            //{
            //    TextBoxRate.Visible = true;
            //    LabelRate.Visible = true;
            //    LabelSalary.Text = "Оклад (норма)";
            //    employeeRateControl1.Show();
            //    employeeHourlyControl1.Hide();
            //}
        }

        /// <summary>
        /// Кнопка отмены
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            EmployeeBase = null;
            this.Close();
        }
        //XML
        public EmployeeBase EmployeeBase { get; private set; }

        /// <summary>
        /// Кнопка добавления объекта
        /// </summary>
        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            if (LabelSalary.Text == "Оплата в час")
            {
                try
                {
                    EmployeeHourly employeeHourly =
                        new EmployeeHourly(Convert.ToUInt32(TextBoxWorkTime.Text),
                            Convert.ToUInt32(TextBoxSalary.Text));
                    EmployeeBase = employeeHourly;

                    //ДЛЯ ПЯТОЙ
                    //employeeHourlyControl1.Show();
                    //EmployeeHourly employeeHourly =
                    //    new EmployeeHourly(employeeHourlyControl1.WorkTime,
                    //        employeeHourlyControl1.CostPerHour);
                    //EmployeeBase = employeeHourly;
                }

                catch (Exception exception)
                {
                    EmployeeBase = null;
                    MessageBox.Show(exception.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    EmployeeRate employeeRate =
                        new EmployeeRate(Convert.ToUInt32(TextBoxWorkTime.Text),
                            Convert.ToUInt32(TextBoxSalary.Text),
                            Convert.ToUInt32(TextBoxRate.Text));
                    EmployeeBase = employeeRate;

                    //ДЛЯ ПЯТОЙ
                    //employeeRateControl1.Show();
                    //EmployeeRate employeeRate =
                    //    new EmployeeRate(employeeRateControl1.WorkTime,
                    //        employeeRateControl1.Salary,
                    //        employeeRateControl1.Rate);
                    //EmployeeBase = employeeRate;
                }
                catch (Exception exception)
                {
                    EmployeeBase = null;
                    MessageBox.Show(exception.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (EmployeeBase != null)
            {
                this.Hide();
            }
        }
    }

}

