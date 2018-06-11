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

        public SalaryForWorkerForm()
        {
            InitializeComponent();
            _employees = new List<EmployeeBase>();
            _addObjectForm = new AddObjectForm();

            bindingSource1.DataSource = _employees;
            dataGridView1.DataSource = bindingSource1;

            ToolStripMenuItem filename = new ToolStripMenuItem("File");

            filename.DropDownItems.Add("Открыть");
            filename.DropDownItems.Add(new ToolStripMenuItem("Сохранить"));

            menuStrip1.Items.Add(filename);
            //fileToolStripMenuItem.Image = Image.FromFile(@"D:\Icons\0023\block32.png");
            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            //aboutItem.Click += aboutItem_Click;
            menuStrip1.Items.Add(aboutItem);

            List<Type> knownTypeList = new List<Type>
            {
                typeof(EmployeeHourly),
                typeof(EmployeeRate)
            };

            _serializer = new DataContractJsonSerializer(typeof(List<EmployeeBase>), knownTypeList);
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            _addObjectForm.ShowDialog();
            if (_addObjectForm.EmployeeBase != null)
            {
                bindingSource1.Add(_addObjectForm.EmployeeBase);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(index);
            }
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
    }
}
