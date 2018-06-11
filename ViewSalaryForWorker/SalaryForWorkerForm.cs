﻿using System;
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "Employee|*.fig";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {

                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate);
                List<EmployeeBase> deserializeFigures = (List<EmployeeBase>)_serializer.ReadObject(fileStream);
                fileStream.Dispose();

                bindingSource1.Clear();

                foreach (EmployeeBase salary in deserializeFigures)
                {
                    bindingSource1.Add(salary);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Employee|*.fig";
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {

                FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
                _serializer.WriteObject(fileStream, _employees);
                fileStream.Dispose();
            }
        }
    }
}