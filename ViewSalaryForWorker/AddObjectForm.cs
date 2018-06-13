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
            string descriptionHourly = GetDescription(TypeSalary.Hourly);
            string descriptionRate = GetDescription(TypeSalary.Rate);
            ComboBoxSalaryType.Items.Add(descriptionHourly);
            ComboBoxSalaryType.Items.Add(descriptionRate);
            ComboBoxSalaryType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //TODO: Должно быть в отдельном CS файле
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
                (DescriptionAttribute[]) fi.GetCustomAttributes(
                    typeof(DescriptionAttribute),
                    false);

            //TODO: Все операции под if - в скобочки
            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        /// <summary>
        /// Обработка элемента с выпадающим списком
        /// </summary>
        private void SelectSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = ComboBoxSalaryType.SelectedItem.ToString();
            MessageBox.Show(selectedState);
            var salary = ComboBoxSalaryType.Text;
            //TODO: Тут правильнее через switch-case, т.к. потенциально количество вариантов расчёта может расшириться
            //TODO: А текущее условие предполагает только 2 состояния
            if (salary == "По часам")
            {
                LabelSalary.Text = "Оплата в час";
                TextBoxRate.Visible = false;
                LabelRate.Visible = false;
            }
            else
            {
                TextBoxRate.Visible = true;
                LabelRate.Visible = true;
                LabelSalary.Text = "Оклад (норма)";
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
                }

                catch (Exception exception)
                {
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
                }
                catch (Exception exception)
                {
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

