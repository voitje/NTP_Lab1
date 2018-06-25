using System;
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
                    employeeRateControl.Hide();
                    employeeHourlyControl.Show();
                    break;
                }
                case "По окладу и ставке":
                {
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
        /// Метод, для передачи объекта созданого в контролере
        /// </summary>
        private void ChangeSalary(EmployeeBase employee)
        {
            try
            {
                EmployeeBase = employee;
            }
            catch (ArgumentException exception)
            {
                EmployeeBase = null;
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка добавления объекта
        /// </summary>
        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            var salary = ComboBoxSalaryType.Text;
            try
            {
                switch (salary)
                {
                    case "По часам":
                    {
                        ChangeSalary(employeeHourlyControl.EmployeeBase);
                        break;
                    }
                    case "По окладу и ставке":
                    {
                        ChangeSalary(employeeRateControl.EmployeeBase);
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (EmployeeBase != null)
            {
                this.Hide();
            }
        }
    }

}

