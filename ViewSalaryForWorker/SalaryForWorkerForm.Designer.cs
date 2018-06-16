namespace ViewSalaryForWorker
{
    partial class SalaryForWorkerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonAddObjectNewForm = new System.Windows.Forms.Button();
            this.ButtonRemoveObject = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ButtomAddRandomObject = new System.Windows.Forms.Button();
            this.employeeHourlyControl = new ViewSalaryForWorker.EmployeeHourlyControl();
            this.employeeRateControl1 = new ViewSalaryForWorker.EmployeeRateControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(16, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица зарплат";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Salary,
            this.workTimeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.bindingSource;
            this.dataGridView.Location = new System.Drawing.Point(6, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(522, 232);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Тип зарплаты";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Payroll";
            this.Salary.HeaderText = "Зарплата";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // workTimeDataGridViewTextBoxColumn
            // 
            this.workTimeDataGridViewTextBoxColumn.DataPropertyName = "WorkTime";
            this.workTimeDataGridViewTextBoxColumn.HeaderText = "Время работы";
            this.workTimeDataGridViewTextBoxColumn.Name = "workTimeDataGridViewTextBoxColumn";
            this.workTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Salary.EmployeeRate);
            // 
            // ButtonAddObjectNewForm
            // 
            this.ButtonAddObjectNewForm.Location = new System.Drawing.Point(22, 317);
            this.ButtonAddObjectNewForm.Name = "ButtonAddObjectNewForm";
            this.ButtonAddObjectNewForm.Size = new System.Drawing.Size(151, 23);
            this.ButtonAddObjectNewForm.TabIndex = 1;
            this.ButtonAddObjectNewForm.Text = "Добавить объект";
            this.ButtonAddObjectNewForm.UseVisualStyleBackColor = true;
            this.ButtonAddObjectNewForm.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // ButtonRemoveObject
            // 
            this.ButtonRemoveObject.Location = new System.Drawing.Point(393, 317);
            this.ButtonRemoveObject.Name = "ButtonRemoveObject";
            this.ButtonRemoveObject.Size = new System.Drawing.Size(151, 23);
            this.ButtonRemoveObject.TabIndex = 2;
            this.ButtonRemoveObject.Text = "Удалить объект";
            this.ButtonRemoveObject.UseVisualStyleBackColor = true;
            this.ButtonRemoveObject.Click += new System.EventHandler(this.RemoveObject_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(562, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ButtomAddRandomObject
            // 
            this.ButtomAddRandomObject.Location = new System.Drawing.Point(179, 317);
            this.ButtomAddRandomObject.Name = "ButtomAddRandomObject";
            this.ButtomAddRandomObject.Size = new System.Drawing.Size(208, 23);
            this.ButtomAddRandomObject.TabIndex = 4;
            this.ButtomAddRandomObject.Text = "Добавить случайный объект";
            this.ButtomAddRandomObject.UseVisualStyleBackColor = true;
            this.ButtomAddRandomObject.Click += new System.EventHandler(this.AddRandomObject_Click);
            // 
            // employeeHourlyControl
            // 
            this.employeeHourlyControl.Location = new System.Drawing.Point(22, 346);
            this.employeeHourlyControl.Name = "employeeHourlyControl";
            this.employeeHourlyControl.Size = new System.Drawing.Size(434, 160);
            this.employeeHourlyControl.TabIndex = 5;
            // 
            // employeeRateControl1
            // 
            this.employeeRateControl1.Location = new System.Drawing.Point(22, 353);
            this.employeeRateControl1.Name = "employeeRateControl1";
            this.employeeRateControl1.Size = new System.Drawing.Size(451, 160);
            this.employeeRateControl1.TabIndex = 1;
            // 
            // SalaryForWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 525);
            this.Controls.Add(this.employeeRateControl1);
            this.Controls.Add(this.employeeHourlyControl);
            this.Controls.Add(this.ButtomAddRandomObject);
            this.Controls.Add(this.ButtonRemoveObject);
            this.Controls.Add(this.ButtonAddObjectNewForm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SalaryForWorkerForm";
            this.Text = "Расчет зарплаты";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ButtonAddObjectNewForm;
        private System.Windows.Forms.Button ButtonRemoveObject;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn workTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button ButtomAddRandomObject;
        private EmployeeHourlyControl employeeHourlyControl;
        private EmployeeRateControl employeeRateControl;
    }
}

