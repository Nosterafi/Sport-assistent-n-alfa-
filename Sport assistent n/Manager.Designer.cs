namespace Sport_assistent_n
{
    partial class Manager
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
            this.clientData = new System.Windows.Forms.TabPage();
            this.queryProcessing = new System.Windows.Forms.TabPage();
            this.clientDatabase = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clientData);
            this.tabControl1.Controls.Add(this.queryProcessing);
            this.tabControl1.Controls.Add(this.clientDatabase);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(20, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 666);
            this.tabControl1.TabIndex = 0;
            // 
            // clientData
            // 
            this.clientData.BackColor = System.Drawing.Color.White;
            this.clientData.Location = new System.Drawing.Point(4, 47);
            this.clientData.Name = "clientData";
            this.clientData.Padding = new System.Windows.Forms.Padding(3);
            this.clientData.Size = new System.Drawing.Size(865, 615);
            this.clientData.TabIndex = 0;
            this.clientData.Text = "База данных клиентов";
            // 
            // queryProcessing
            // 
            this.queryProcessing.Location = new System.Drawing.Point(4, 47);
            this.queryProcessing.Name = "queryProcessing";
            this.queryProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.queryProcessing.Size = new System.Drawing.Size(865, 615);
            this.queryProcessing.TabIndex = 1;
            this.queryProcessing.Text = "Обработка запросов клиентов";
            this.queryProcessing.UseVisualStyleBackColor = true;
            // 
            // clientDatabase
            // 
            this.clientDatabase.Location = new System.Drawing.Point(4, 47);
            this.clientDatabase.Name = "clientDatabase";
            this.clientDatabase.Size = new System.Drawing.Size(865, 615);
            this.clientDatabase.TabIndex = 2;
            this.clientDatabase.Text = "База данных клиентов";
            this.clientDatabase.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Manager";
            this.Size = new System.Drawing.Size(914, 698);
            this.Load += new System.EventHandler(this.Manager_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clientData;
        private System.Windows.Forms.TabPage queryProcessing;
        private System.Windows.Forms.TabPage clientDatabase;
    }
}
