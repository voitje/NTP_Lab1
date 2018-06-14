using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
            string descriptionHourly = GetDescription(TypeSalary.Hourly);
            string descriptionRate = GetDescription(TypeSalary.Rate);
            ComboBoxSalaryType.Items.Add(descriptionHourly);
            ComboBoxSalaryType.Items.Add(descriptionRate);
            ComboBoxSalaryType.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeRateControl1.Hide();
            employeeHourlyControl1.Hide();
        }

        /// <summary>
        /// Перечисление сущностей
        /// </summary>
        public enum TypeSalary : byte
        {
            [Description("По часам")]
            Hourly,
            [Description("По окладу и ставке")]
            Rate,
        }

        /// <summary>
        /// Получить атрибут "Описание"
        /// </summary>
        public static string GetDescription(TypeSalary value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = 
                (DescriptionAttribute[]) fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        /// <summary>
        /// Обработка элемента с выпадающим списком
        /// </summary>
        private void SelectSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = ComboBoxSalaryType.SelectedItem.ToString();
            MessageBox.Show(selectedState);
            var salary = ComboBoxSalaryType.Text;
            if (salary == "По часам")
            {
                LabelSalary.Text = "Оплата в час";
                TextBoxRate.Visible = false;
                LabelRate.Visible = false;
                employeeRateControl1.Hide();
                employeeHourlyControl1.Show();
            }
            else
            {
                TextBoxRate.Visible = true;
                LabelRate.Visible = true;
                LabelSalary.Text = "Оклад (норма)";
                employeeRateControl1.Show();
                employeeHourlyControl1.Hide();
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
                    //EmployeeHourly employeeHourly =
                    //    new EmployeeRate(Convert.ToUInt32(TextBoxWorkTime.Text),
                    //        Convert.ToUInt32(TextBoxSalary.Text),
                    //EmployeeBase = employeeHourly;
                    employeeHourlyControl1.Show();
                    EmployeeHourly employeeHourly =
                        new EmployeeHourly(employeeHourlyControl1.WorkTime,
                            employeeHourlyControl1.CostPerHour);
                    EmployeeBase = employeeHourly;
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
                    //EmployeeRate employeeRate =
                    //    new EmployeeRate(Convert.ToUInt32(TextBoxWorkTime.Text),
                    //        Convert.ToUInt32(TextBoxSalary.Text),
                    //        Convert.ToUInt32(TextBoxRate.Text));
                    //EmployeeBase = employeeRate;
                    employeeRateControl1.Show();
                    EmployeeRate employeeRate =
                        new EmployeeRate(employeeRateControl1.WorkTime,
                            employeeRateControl1.Salary,
                            employeeRateControl1.Rate);
                    EmployeeBase = employeeRate;
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

