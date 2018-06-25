namespace ViewSalaryForWorker
{
    partial class EmployeeHourlyControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalaryHourlyGroupBox = new System.Windows.Forms.GroupBox();
            this.CostPerHourTextBox = new System.Windows.Forms.TextBox();
            this.WorkTimeTextBox = new System.Windows.Forms.TextBox();
            this.CostPerHourLabel = new System.Windows.Forms.Label();
            this.WorkTimeLabel = new System.Windows.Forms.Label();
            this.SalaryHourlyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalaryHourlyGroupBox
            // 
            this.SalaryHourlyGroupBox.Controls.Add(this.CostPerHourTextBox);
            this.SalaryHourlyGroupBox.Controls.Add(this.WorkTimeTextBox);
            this.SalaryHourlyGroupBox.Controls.Add(this.CostPerHourLabel);
            this.SalaryHourlyGroupBox.Controls.Add(this.WorkTimeLabel);
            this.SalaryHourlyGroupBox.Location = new System.Drawing.Point(4, 3);
            this.SalaryHourlyGroupBox.Name = "SalaryHourlyGroupBox";
            this.SalaryHourlyGroupBox.Size = new System.Drawing.Size(427, 206);
            this.SalaryHourlyGroupBox.TabIndex = 0;
            this.SalaryHourlyGroupBox.TabStop = false;
            this.SalaryHourlyGroupBox.Text = "Зарплата по часу";
            // 
            // CostPerHourTextBox
            // 
            this.CostPerHourTextBox.Location = new System.Drawing.Point(117, 89);
            this.CostPerHourTextBox.Name = "CostPerHourTextBox";
            this.CostPerHourTextBox.Size = new System.Drawing.Size(117, 22);
            this.CostPerHourTextBox.TabIndex = 3;
            // 
            // WorkTimeTextBox
            // 
            this.WorkTimeTextBox.Location = new System.Drawing.Point(117, 59);
            this.WorkTimeTextBox.Name = "WorkTimeTextBox";
            this.WorkTimeTextBox.Size = new System.Drawing.Size(117, 22);
            this.WorkTimeTextBox.TabIndex = 2;
            // 
            // CostPerHourLabel
            // 
            this.CostPerHourLabel.AutoSize = true;
            this.CostPerHourLabel.Location = new System.Drawing.Point(7, 89);
            this.CostPerHourLabel.Name = "CostPerHourLabel";
            this.CostPerHourLabel.Size = new System.Drawing.Size(104, 17);
            this.CostPerHourLabel.TabIndex = 1;
            this.CostPerHourLabel.Text = "Оплата за час";
            // 
            // WorkTimeLabel
            // 
            this.WorkTimeLabel.AutoSize = true;
            this.WorkTimeLabel.Location = new System.Drawing.Point(7, 59);
            this.WorkTimeLabel.Name = "WorkTimeLabel";
            this.WorkTimeLabel.Size = new System.Drawing.Size(103, 17);
            this.WorkTimeLabel.TabIndex = 0;
            this.WorkTimeLabel.Text = "Время работы";
            // 
            // EmployeeHourlyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SalaryHourlyGroupBox);
            this.Name = "EmployeeHourlyControl";
            this.Size = new System.Drawing.Size(434, 231);
            this.SalaryHourlyGroupBox.ResumeLayout(false);
            this.SalaryHourlyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SalaryHourlyGroupBox;
        private System.Windows.Forms.TextBox CostPerHourTextBox;
        private System.Windows.Forms.TextBox WorkTimeTextBox;
        private System.Windows.Forms.Label CostPerHourLabel;
        private System.Windows.Forms.Label WorkTimeLabel;
    }
}
