namespace ViewSalaryForWorker
{
    partial class EmployeeRateControl
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
            this.SalaryRateGroupBox = new System.Windows.Forms.GroupBox();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.WorkTimeTextBox = new System.Windows.Forms.TextBox();
            this.RateLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.WorkTimeLabel = new System.Windows.Forms.Label();
            this.SalaryRateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalaryRateGroupBox
            // 
            this.SalaryRateGroupBox.Controls.Add(this.RateTextBox);
            this.SalaryRateGroupBox.Controls.Add(this.SalaryTextBox);
            this.SalaryRateGroupBox.Controls.Add(this.WorkTimeTextBox);
            this.SalaryRateGroupBox.Controls.Add(this.RateLabel);
            this.SalaryRateGroupBox.Controls.Add(this.SalaryLabel);
            this.SalaryRateGroupBox.Controls.Add(this.WorkTimeLabel);
            this.SalaryRateGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SalaryRateGroupBox.Name = "SalaryRateGroupBox";
            this.SalaryRateGroupBox.Size = new System.Drawing.Size(445, 194);
            this.SalaryRateGroupBox.TabIndex = 0;
            this.SalaryRateGroupBox.TabStop = false;
            this.SalaryRateGroupBox.Text = "Зарплаты по ставке и окладу";
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(123, 100);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(150, 22);
            this.RateTextBox.TabIndex = 5;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(123, 72);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(150, 22);
            this.SalaryTextBox.TabIndex = 4;
            // 
            // WorkTimeTextBox
            // 
            this.WorkTimeTextBox.Location = new System.Drawing.Point(123, 42);
            this.WorkTimeTextBox.Name = "WorkTimeTextBox";
            this.WorkTimeTextBox.Size = new System.Drawing.Size(150, 22);
            this.WorkTimeTextBox.TabIndex = 3;
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(13, 103);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(104, 17);
            this.RateLabel.TabIndex = 2;
            this.RateLabel.Text = "Норма работы";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(67, 72);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(50, 17);
            this.SalaryLabel.TabIndex = 1;
            this.SalaryLabel.Text = "Оклад";
            // 
            // WorkTimeLabel
            // 
            this.WorkTimeLabel.AutoSize = true;
            this.WorkTimeLabel.Location = new System.Drawing.Point(14, 45);
            this.WorkTimeLabel.Name = "WorkTimeLabel";
            this.WorkTimeLabel.Size = new System.Drawing.Size(103, 17);
            this.WorkTimeLabel.TabIndex = 0;
            this.WorkTimeLabel.Text = "Время работы";
            // 
            // EmployeeRateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SalaryRateGroupBox);
            this.Name = "EmployeeRateControl";
            this.Size = new System.Drawing.Size(451, 211);
            this.SalaryRateGroupBox.ResumeLayout(false);
            this.SalaryRateGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SalaryRateGroupBox;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox WorkTimeTextBox;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label WorkTimeLabel;
    }
}
