namespace Sport_assistent_n
{
    partial class Accountant
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
            this.accountentPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.accountentLabel = new System.Windows.Forms.Label();
            this.profilButton = new System.Windows.Forms.Button();
            this.profile1 = new Sport_assistent_n.Profile();
            this.salesButton = new System.Windows.Forms.Button();
            this.sales1 = new Sport_assistent_n.Sales();
            this.gainButton = new System.Windows.Forms.Button();
            this.gain1 = new Sport_assistent_n.Gain();
            this.debts1 = new Sport_assistent_n.Debts();
            this.debtsButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.report1 = new Sport_assistent_n.Report();
            this.exitButton1 = new Sport_assistent_n.ExitButton();
            this.actionsPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.accountentPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.exitButton1);
            this.actionsPanel.Controls.Add(this.reportButton);
            this.actionsPanel.Controls.Add(this.debtsButton);
            this.actionsPanel.Controls.Add(this.gainButton);
            this.actionsPanel.Controls.Add(this.salesButton);
            this.actionsPanel.Controls.Add(this.profilButton);
            this.actionsPanel.Controls.Add(this.accountentPanel);
            this.actionsPanel.Size = new System.Drawing.Size(255, 604);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.report1);
            this.dataPanel.Controls.Add(this.debts1);
            this.dataPanel.Controls.Add(this.gain1);
            this.dataPanel.Controls.Add(this.sales1);
            this.dataPanel.Controls.Add(this.profile1);
            this.dataPanel.Size = new System.Drawing.Size(686, 567);
            // 
            // accountentPanel
            // 
            this.accountentPanel.BackColor = System.Drawing.Color.DarkGray;
            this.accountentPanel.Controls.Add(this.panel2);
            this.accountentPanel.Controls.Add(this.accountentLabel);
            this.accountentPanel.Location = new System.Drawing.Point(0, 0);
            this.accountentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accountentPanel.Name = "accountentPanel";
            this.accountentPanel.Size = new System.Drawing.Size(255, 81);
            this.accountentPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(58, 62);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Sport_assistent_n.Properties.Resources.free_icon_avatar_126486;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 62);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Sport_assistent_n.Properties.Resources.free_icon_avatar_126486;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(5, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 52);
            this.panel3.TabIndex = 5;
            // 
            // accountentLabel
            // 
            this.accountentLabel.AutoSize = true;
            this.accountentLabel.BackColor = System.Drawing.Color.DarkGray;
            this.accountentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountentLabel.Location = new System.Drawing.Point(40, 25);
            this.accountentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.accountentLabel.Name = "accountentLabel";
            this.accountentLabel.Size = new System.Drawing.Size(170, 37);
            this.accountentLabel.TabIndex = 2;
            this.accountentLabel.Text = " Бухгалтер";
            // 
            // profilButton
            // 
            this.profilButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.profilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profilButton.ForeColor = System.Drawing.Color.Orange;
            this.profilButton.Location = new System.Drawing.Point(-1, 79);
            this.profilButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(256, 62);
            this.profilButton.TabIndex = 2;
            this.profilButton.Text = "Профиль";
            this.profilButton.UseVisualStyleBackColor = true;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(0, 0);
            this.profile1.Margin = new System.Windows.Forms.Padding(2);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(686, 567);
            this.profile1.TabIndex = 0;
            // 
            // salesButton
            // 
            this.salesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salesButton.ForeColor = System.Drawing.Color.Orange;
            this.salesButton.Location = new System.Drawing.Point(-1, 136);
            this.salesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(256, 94);
            this.salesButton.TabIndex = 3;
            this.salesButton.Text = "Учёт продаж абонементов";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // sales1
            // 
            this.sales1.Location = new System.Drawing.Point(0, 0);
            this.sales1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sales1.Name = "sales1";
            this.sales1.Size = new System.Drawing.Size(686, 567);
            this.sales1.TabIndex = 1;
            // 
            // gainButton
            // 
            this.gainButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gainButton.ForeColor = System.Drawing.Color.Orange;
            this.gainButton.Location = new System.Drawing.Point(-1, 224);
            this.gainButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gainButton.Name = "gainButton";
            this.gainButton.Size = new System.Drawing.Size(256, 62);
            this.gainButton.TabIndex = 4;
            this.gainButton.Text = "Расчёт доходов";
            this.gainButton.UseVisualStyleBackColor = true;
            this.gainButton.Click += new System.EventHandler(this.gainButton_Click);
            // 
            // gain1
            // 
            this.gain1.Location = new System.Drawing.Point(0, 0);
            this.gain1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gain1.Name = "gain1";
            this.gain1.Size = new System.Drawing.Size(686, 567);
            this.gain1.TabIndex = 2;
            // 
            // debts1
            // 
            this.debts1.Location = new System.Drawing.Point(0, 0);
            this.debts1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.debts1.Name = "debts1";
            this.debts1.Size = new System.Drawing.Size(686, 567);
            this.debts1.TabIndex = 3;
            // 
            // debtsButton
            // 
            this.debtsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.debtsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debtsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.debtsButton.ForeColor = System.Drawing.Color.Orange;
            this.debtsButton.Location = new System.Drawing.Point(-1, 284);
            this.debtsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.debtsButton.Name = "debtsButton";
            this.debtsButton.Size = new System.Drawing.Size(256, 100);
            this.debtsButton.TabIndex = 5;
            this.debtsButton.Text = "Контроль задолженностей клиентов";
            this.debtsButton.UseVisualStyleBackColor = true;
            this.debtsButton.Click += new System.EventHandler(this.debtsButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportButton.ForeColor = System.Drawing.Color.Orange;
            this.reportButton.Location = new System.Drawing.Point(0, 380);
            this.reportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(255, 100);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "Генерация отчётов о финансовых показателях";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // report1
            // 
            this.report1.Location = new System.Drawing.Point(0, 0);
            this.report1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(686, 567);
            this.report1.TabIndex = 4;
            this.report1.Load += new System.EventHandler(this.report1_Load);
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(5, 548);
            this.exitButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(32, 37);
            this.exitButton1.TabIndex = 7;
            // 
            // Accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "Accountant";
            this.Size = new System.Drawing.Size(974, 604);
            this.actionsPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.accountentPanel.ResumeLayout(false);
            this.accountentPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel accountentPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label accountentLabel;
        private System.Windows.Forms.Button profilButton;
        private Profile profile1;
        private System.Windows.Forms.Button salesButton;
        private Sales sales1;
        private System.Windows.Forms.Button gainButton;
        private Gain gain1;
        private Debts debts1;
        private System.Windows.Forms.Button debtsButton;
        private System.Windows.Forms.Button reportButton;
        private Report report1;
        private ExitButton exitButton1;
    }
}
