using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Windows.Forms.VisualStyles;
using Salary;

namespace ViewSalaryForWorker
{
    //TODO: Везде ниже XML \ DONE
    /// <summary>
    /// Главная форма SalaryForWorker
    /// </summary>
    public partial class SalaryForWorkerForm : Form
    {
        /// <summary>
        /// Объект второй формы
        /// </summary>
        private AddObjectForm _addObjectForm;

        /// <summary>
        /// Список зарплат
        /// </summary>
        private List<EmployeeBase> _employees;

        /// <summary>
        /// Сериализация
        /// </summary>
        private DataContractJsonSerializer _serializer;

        /// <summary>
        /// Имя файла
        /// </summary>
        private const string fileName = "Employee|*.emp";

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public SalaryForWorkerForm()
        {
            InitializeComponent();
            _employees = new List<EmployeeBase>();
            _addObjectForm = new AddObjectForm();

            bindingSource.DataSource = _employees;
            dataGridView.DataSource = bindingSource;
            //dataGridView_CellClick(this, new DataGridViewCellEventArgs(0, 0));
            List<Type> knownTypeList = new List<Type>
            {
                typeof(EmployeeHourly),
                typeof(EmployeeRate)
            };
            _serializer = new DataContractJsonSerializer(typeof(List<EmployeeBase>), knownTypeList);
            DisableControls();
        }


        private void DisableControls()
        {
            employeeHourlyControl1.Visible = false;
            //employeeRateContorl1.Visible = false;


            employeeHourlyControl1.ReadOnly = true;
            //employeeRateContorl1.ReadOnly = false;


        }

        /// <summary>
        /// Кнопка добавления объекта
        /// </summary>
        private void AddObject_Click(object sender, EventArgs e)
        {
            _addObjectForm.ShowDialog();
            if (_addObjectForm.EmployeeBase != null)
            {
                bindingSource.Add(_addObjectForm.EmployeeBase);
            }

        }

        /// <summary>
        /// Кнопка удаления объекта
        /// </summary>
        private void RemoveObject_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int index = dataGridView.SelectedCells[0].RowIndex;
                dataGridView.Rows.RemoveAt(index);
            }
        }

        /// <summary>
        /// Обработка событие при нажатие на "Открыть"
        /// </summary>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.AddExtension = true;
                //TODO: Расширение вынести \ DONE
                openFileDialog.Filter = fileName;
                DialogResult result = openFileDialog.ShowDialog();

                if (result != DialogResult.Cancel)
                {
                    FileStream fileStream =
                        new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
                    List<EmployeeBase> deserializeEmployee =
                        (List<EmployeeBase>) _serializer.ReadObject(fileStream);
                    fileStream.Dispose();

                    bindingSource.Clear();

                    foreach (EmployeeBase salary in deserializeEmployee)
                    {
                        bindingSource.Add(salary);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Неверное содержание файла, проверьте правильность данных в файле!\n\n" +
                                exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ;
            }
        }

        /// <summary>
        /// Обработка событие при нажатие на "Сохранить"
        /// </summary>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.AddExtension = true;
                saveFileDialog.Filter = fileName;
                var result = saveFileDialog.ShowDialog();

                if (result != DialogResult.Cancel)
                {
                    var fileStream =
                        new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                    _serializer.WriteObject(fileStream, _employees);
                    fileStream.Dispose();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Неверное содержание файла, проверьте правильность данных в файле!\n\n" +
                                exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка добавления случайного объекта
        /// </summary>
        private void AddRandomObject_Click(object sender, EventArgs e)
        {
            var randomCase = new Random();
            var random = new Random();
            uint workTime = (uint) random.Next(1, 372);
            switch (randomCase.Next(1, 3))
            {
                case 1:
                {
                    uint costPerHour = (uint) random.Next(1, 1400);
                    bindingSource.Add(new EmployeeHourly(workTime, costPerHour));
                    break;
                }
                case 2:
                {
                    uint rate = (uint) random.Next(1, 372);
                    uint salary = (uint) random.Next(1, 1000000);
                    bindingSource.Add(new EmployeeRate(workTime, salary, rate));
                    break;
                }
            }
        }

        /// <summary>
        ///  Выводит информацию при клике на нее в таблице
        /// </summary>

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentEmployee = _employees[dataGridView.CurrentRow.Index];
            DisableControls();

            if (currentEmployee is EmployeeHourly employeeHourly)
            {
                employeeHourlyControl1.Visible = true;

                employeeHourlyControl1.EmployeeBase = employeeHourly;
            }

            //TODO:Для контроля EmployeeRate
            //else if (currentEmployee is EmployeeRate employeeRate)
            //{
            //    employeeHourlyControl1.Visible = true;

            //    employeeHourlyControl1.EmployeeBase = employeeRate;
        }
    }
}

