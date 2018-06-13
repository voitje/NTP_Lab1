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
using Salary;

namespace ViewSalaryForWorker
{
    public partial class SalaryForWorkerForm : Form
    {
        AddObjectForm _addObjectForm;
        List<EmployeeBase> _employees;
        DataContractJsonSerializer _serializer;

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

            List<Type> knownTypeList = new List<Type>
            {
                typeof(EmployeeHourly),
                typeof(EmployeeRate)
            };
            _serializer = new DataContractJsonSerializer(typeof(List<EmployeeBase>), knownTypeList);
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
            openFileDialog.AddExtension = true;
            openFileDialog.Filter = "Employee|*.emp";
            DialogResult result = openFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
                List<EmployeeBase> deserializeEmployee = (List<EmployeeBase>)_serializer.ReadObject(fileStream);
                fileStream.Dispose();

                bindingSource.Clear();

                foreach (EmployeeBase salary in deserializeEmployee)
                {
                    bindingSource.Add(salary);
                }
            }
        }

        /// <summary>
        /// Обработка событие при нажатие на "Сохранить"
        /// </summary>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Employee|*.emp";
            var result = saveFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                var fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                _serializer.WriteObject(fileStream, _employees);
                fileStream.Dispose();
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
    }
}
