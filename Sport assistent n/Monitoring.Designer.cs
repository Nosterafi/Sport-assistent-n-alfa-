namespace Sport_assistent_n
{
    partial class Monitoring
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.attendance = new System.Windows.Forms.TabPage();
            this.gain = new System.Windows.Forms.TabPage();
            this.trainersWork = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.attendance);
            this.tabControl1.Controls.Add(this.gain);
            this.tabControl1.Controls.Add(this.trainersWork);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(21, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 658);
            this.tabControl1.TabIndex = 0;
            // 
            // attendance
            // 
            this.attendance.Location = new System.Drawing.Point(4, 47);
            this.attendance.Name = "attendance";
            this.attendance.Padding = new System.Windows.Forms.Padding(3);
            this.attendance.Size = new System.Drawing.Size(860, 607);
            this.attendance.TabIndex = 0;
            this.attendance.Text = "Отчёты о посещаемости";
            this.attendance.UseVisualStyleBackColor = true;
            // 
            // gain
            // 
            this.gain.Location = new System.Drawing.Point(4, 47);
            this.gain.Name = "gain";
            this.gain.Padding = new System.Windows.Forms.Padding(3);
            this.gain.Size = new System.Drawing.Size(860, 607);
            this.gain.TabIndex = 1;
            this.gain.Text = "Отчёты о доходности";
            this.gain.UseVisualStyleBackColor = true;
            // 
            // trainersWork
            // 
            this.trainersWork.Location = new System.Drawing.Point(4, 47);
            this.trainersWork.Name = "trainersWork";
            this.trainersWork.Size = new System.Drawing.Size(860, 607);
            this.trainersWork.TabIndex = 2;
            this.trainersWork.Text = "Отчёт об эффективности работы тренеров";
            this.trainersWork.UseVisualStyleBackColor = true;
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Monitoring";
            this.Size = new System.Drawing.Size(914, 698);
            this.Load += new System.EventHandler(this.Monitoring_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage attendance;
        private System.Windows.Forms.TabPage gain;
        private System.Windows.Forms.TabPage trainersWork;
    }
}
