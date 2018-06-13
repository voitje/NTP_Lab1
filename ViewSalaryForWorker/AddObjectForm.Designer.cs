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
            this.TextBoxWorkTime = new System.Windows.Forms.TextBox();
            this.TextBoxSalary = new System.Windows.Forms.TextBox();
            this.LabelSalary = new System.Windows.Forms.Label();
            this.LabelRate = new System.Windows.Forms.Label();
            this.TextBoxRate = new System.Windows.Forms.TextBox();
            this.LabelWorkTime = new System.Windows.Forms.Label();
            this.ButtonAddObject = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.typeSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // TextBoxWorkTime
            // 
            this.TextBoxWorkTime.Location = new System.Drawing.Point(225, 83);
            this.TextBoxWorkTime.Name = "TextBoxWorkTime";
            this.TextBoxWorkTime.Size = new System.Drawing.Size(100, 22);
            this.TextBoxWorkTime.TabIndex = 3;
            // 
            // TextBoxSalary
            // 
            this.TextBoxSalary.Location = new System.Drawing.Point(225, 111);
            this.TextBoxSalary.Name = "TextBoxSalary";
            this.TextBoxSalary.Size = new System.Drawing.Size(100, 22);
            this.TextBoxSalary.TabIndex = 4;
            // 
            // LabelSalary
            // 
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.Location = new System.Drawing.Point(93, 114);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(105, 17);
            this.LabelSalary.TabIndex = 5;
            this.LabelSalary.Text = "Оклад (норма)";
            // 
            // LabelRate
            // 
            this.LabelRate.AutoSize = true;
            this.LabelRate.Location = new System.Drawing.Point(33, 142);
            this.LabelRate.Name = "LabelRate";
            this.LabelRate.Size = new System.Drawing.Size(166, 17);
            this.LabelRate.TabIndex = 6;
            this.LabelRate.Text = "Норма работы (в часах)";
            // 
            // TextBoxRate
            // 
            this.TextBoxRate.Location = new System.Drawing.Point(225, 139);
            this.TextBoxRate.Name = "TextBoxRate";
            this.TextBoxRate.Size = new System.Drawing.Size(100, 22);
            this.TextBoxRate.TabIndex = 7;
            // 
            // LabelWorkTime
            // 
            this.LabelWorkTime.AutoSize = true;
            this.LabelWorkTime.Location = new System.Drawing.Point(50, 86);
            this.LabelWorkTime.Name = "LabelWorkTime";
            this.LabelWorkTime.Size = new System.Drawing.Size(149, 17);
            this.LabelWorkTime.TabIndex = 8;
            this.LabelWorkTime.Text = "Отработанное время";
            // 
            // ButtonAddObject
            // 
            this.ButtonAddObject.Location = new System.Drawing.Point(36, 183);
            this.ButtonAddObject.Name = "ButtonAddObject";
            this.ButtonAddObject.Size = new System.Drawing.Size(156, 23);
            this.ButtonAddObject.TabIndex = 9;
            this.ButtonAddObject.Text = "Добавить рабочего";
            this.ButtonAddObject.UseVisualStyleBackColor = true;
            this.ButtonAddObject.Click += new System.EventHandler(this.AddObjectButton_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(198, 183);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(156, 23);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // typeSalaryBindingSource
            // 
            this.typeSalaryBindingSource.DataSource = typeof(ViewSalaryForWorker.AddObjectForm.TypeSalary);
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 250);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAddObject);
            this.Controls.Add(this.LabelWorkTime);
            this.Controls.Add(this.TextBoxRate);
            this.Controls.Add(this.LabelRate);
            this.Controls.Add(this.LabelSalary);
            this.Controls.Add(this.TextBoxSalary);
            this.Controls.Add(this.TextBoxWorkTime);
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
        private System.Windows.Forms.TextBox TextBoxWorkTime;
        private System.Windows.Forms.TextBox TextBoxSalary;
        private System.Windows.Forms.Label LabelSalary;
        private System.Windows.Forms.Label LabelRate;
        private System.Windows.Forms.TextBox TextBoxRate;
        private System.Windows.Forms.Label LabelWorkTime;
        private System.Windows.Forms.Button ButtonAddObject;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.BindingSource employeeBaseBindingSource;
        private System.Windows.Forms.BindingSource typeSalaryBindingSource;
    }
}