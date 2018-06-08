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
using Salary;

namespace ViewSalaryForWorker
{
    public partial class SalaryForWorkerForm : Form
    {
        AddObjectForm _addObjectForm;
        List<EmployeeBase> _employees;
        
        public SalaryForWorkerForm()
        {
            InitializeComponent();
            _employees = new List<EmployeeBase>();
            _addObjectForm = new AddObjectForm();

            bindingSource1.DataSource = _employees;
            dataGridView1.DataSource = bindingSource1;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            _addObjectForm.ShowDialog();
            if (_addObjectForm.EmployeeBase != null)
            {
                bindingSource1.Add(_addObjectForm.EmployeeBase);
            }
            //this.Hide();
            //EmployeeHourly employeeHourly = new EmployeeHourly(int.Parse(textBox_WorkTime.Text), int.Parse(textBox_CostPerHour.Text));
            //list.Add(employeeHourly);
           // dataGridView1.DataSource = null;
            //dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _employees.RemoveAt(2);
        }
        void GetTextFromAddObjectForm()
        {
            var addObjectForm = new AddObjectForm();
            //addObjectForm.ShowDialog();
            //Забираем пользовательский текст из формы.
            EmployeeBase enteredObject = addObjectForm.EmployeeBase;
            //Делаем с текстом что-угодно - например, покажем его пользователю
            //MessageBox.Show(enteredText);
            _employees.Add(enteredObject);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _employees;

        }
        //void SetTextToAddObjectForm()
        //{
        //    var addObjectForm = new AddObjectForm();
        //    addObjectForm.EnteredText = "Текст, который мы хотим показать пользователю на второй форме";
        //    addObjectForm.ShowDialog(); // Форма покажется с нашим текстом из главной формы

        //    //После ShowDialog() пользователь мог ввести новый текст. И мы можем его забрать.
        //    var enteredText = addObjectForm.EnteredText;
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            //GetTextFromAddObjectForm();
        }
    }
}
