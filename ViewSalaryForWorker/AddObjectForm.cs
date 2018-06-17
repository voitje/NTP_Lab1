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
                ToolsForTypeSalaryEnum.GetDescription(TypeSalary.Hourly);
            string descriptionRate = 
                ToolsForTypeSalaryEnum.GetDescription(TypeSalary.Rate);
            ComboBoxSalaryType.Items.Add(descriptionHourly);
            ComboBoxSalaryType.Items.Add(descriptionRate);
            ComboBoxSalaryType.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeRateControl.Hide();
            employeeHourlyControl.Hide();
        }

        /// <summary>
        /// Обработка элемента с выпадающим списком
        /// </summary>
        private void SelectSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = ComboBoxSalaryType.SelectedItem.ToString();
            MessageBox.Show(selectedState);
            var salary = ComboBoxSalaryType.Text;
            switch (salary)
            {
                case "По часам":
                {
                    LabelSalary.Text = "Оплата в час";
                    TextBoxRate.Visible = false;
                    LabelRate.Visible = false;
                    employeeRateControl.Hide();
                    employeeHourlyControl.Show();
                    break;
                }
                case "По окладу и ставке":
                {
                    TextBoxRate.Visible = true;
                    LabelRate.Visible = true;
                    LabelSalary.Text = "Оклад (норма)";
                    employeeRateControl.Show();
                    employeeHourlyControl.Hide();
                    break;
                }
            }
        }

        /// <summary>
        /// Кнопка отмены
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            EmployeeBase = null;
            this.Close();
        }

        /// <summary>
        /// Свойство базового класса
        /// </summary>
        public EmployeeBase EmployeeBase { get; private set; }

        /// <summary>
        /// ArgumentException при ошибки присваивания
        /// </summary>
        public void MessageException(ArgumentException exception)
        {
            EmployeeBase = null;
            MessageBox.Show(exception.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Кнопка добавления объекта
        /// </summary>
        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            if (LabelSalary.Text == "Оплата в час")
            {
                //TODO: Дублируется ниже \ DONE
                //TODO: Всё ещё дублируется.
                try
                {
                    EmployeeBase = employeeHourlyControl.EmployeeBase;
                }
                catch (ArgumentException exception)
                {
                    MessageException(exception);
                }
            }
            else
            {
                try
                {
                    EmployeeBase = employeeRateControl.EmployeeBase;
                }
                catch (ArgumentException exception)
                {
                    MessageException(exception);
                }
            }
            if (EmployeeBase != null)
            {
                this.Hide();
            }
        }
    }

}

