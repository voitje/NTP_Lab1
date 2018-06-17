namespace ViewSalaryForWorker
{
    partial class AddObjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ComboBoxSalaryType = new System.Windows.Forms.ComboBox();
            this.employeeBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelSalaryType = new System.Windows.Forms.Label();
            this.ButtonAddObject = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.typeSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeRateControl = new ViewSalaryForWorker.EmployeeRateControl();
            this.employeeHourlyControl = new ViewSalaryForWorker.EmployeeHourlyControl();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSalaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxSalaryType
            // 
            this.ComboBoxSalaryType.DisplayMember = "Type";
            this.ComboBoxSalaryType.FormattingEnabled = true;
            this.ComboBoxSalaryType.Location = new System.Drawing.Point(204, 12);
            this.ComboBoxSalaryType.Name = "ComboBoxSalaryType";
            this.ComboBoxSalaryType.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxSalaryType.TabIndex = 0;
            this.ComboBoxSalaryType.ValueMember = "Type";
            this.ComboBoxSalaryType.SelectedIndexChanged += new System.EventHandler(this.SelectSalary_SelectedIndexChanged);
            // 
            // employeeBaseBindingSource
            // 
            this.employeeBaseBindingSource.DataSource = typeof(Salary.EmployeeBase);
            // 
            // LabelSalaryType
            // 
            this.LabelSalaryType.AutoSize = true;
            this.LabelSalaryType.Location = new System.Drawing.Point(12, 15);
            this.LabelSalaryType.Name = "LabelSalaryType";
            this.LabelSalaryType.Size = new System.Drawing.Size(186, 17);
            this.LabelSalaryType.TabIndex = 1;
            this.LabelSalaryType.Text = "Способ выплаты зарплаты";
            // 
            // ButtonAddObject
            // 
            this.ButtonAddObject.Location = new System.Drawing.Point(36, 271);
            this.ButtonAddObject.Name = "ButtonAddObject";
            this.ButtonAddObject.Size = new System.Drawing.Size(156, 23);
            this.ButtonAddObject.TabIndex = 9;
            this.ButtonAddObject.Text = "Добавить рабочего";
            this.ButtonAddObject.UseVisualStyleBackColor = true;
            this.ButtonAddObject.Click += new System.EventHandler(this.AddObjectButton_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(198, 271);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(156, 23);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // employeeRateControl
            // 
            this.employeeRateControl.Location = new System.Drawing.Point(-3, 42);
            this.employeeRateControl.Name = "employeeRateControl";
            this.employeeRateControl.Size = new System.Drawing.Size(373, 211);
            this.employeeRateControl.TabIndex = 11;
            // 
            // employeeHourlyControl
            // 
            this.employeeHourlyControl.Location = new System.Drawing.Point(-3, 42);
            this.employeeHourlyControl.Name = "employeeHourlyControl";
            this.employeeHourlyControl.Size = new System.Drawing.Size(373, 223);
            this.employeeHourlyControl.TabIndex = 12;
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 306);
            this.Controls.Add(this.employeeHourlyControl);
            this.Controls.Add(this.employeeRateControl);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAddObject);
            this.Controls.Add(this.LabelSalaryType);
            this.Controls.Add(this.ComboBoxSalaryType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddObjectForm";
            this.Text = "Добавление типа зарплаты";
            ((System.ComponentModel.ISupportInitialize)(this.employeeBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSalaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxSalaryType;
        private System.Windows.Forms.Label LabelSalaryType;
        private System.Windows.Forms.Button ButtonAddObject;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.BindingSource employeeBaseBindingSource;
        private System.Windows.Forms.BindingSource typeSalaryBindingSource;
        private EmployeeRateControl employeeRateControl;
        private EmployeeHourlyControl employeeHourlyControl;
    }
}