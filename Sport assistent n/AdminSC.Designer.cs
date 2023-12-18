namespace Sport_assistent_n
{
    partial class AdminSC
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
            this.adminSCPanel = new System.Windows.Forms.Panel();
            this.adminSCLabel2 = new System.Windows.Forms.Label();
            this.adminSCLabel1 = new System.Windows.Forms.Label();
            this.profilButton = new System.Windows.Forms.Button();
            this.profile1 = new Sport_assistent_n.Profile();
            this.managerButton = new System.Windows.Forms.Button();
            this.manager1 = new Sport_assistent_n.Manager();
            this.distribution1 = new Sport_assistent_n.Distribution();
            this.distributionButton = new System.Windows.Forms.Button();
            this.monitoring1 = new Sport_assistent_n.Monitoring();
            this.monitoringButton = new System.Windows.Forms.Button();
            this.exitButton1 = new Sport_assistent_n.ExitButton();
            this.actionsPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.adminSCPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.exitButton1);
            this.actionsPanel.Controls.Add(this.monitoringButton);
            this.actionsPanel.Controls.Add(this.distributionButton);
            this.actionsPanel.Controls.Add(this.managerButton);
            this.actionsPanel.Controls.Add(this.profilButton);
            this.actionsPanel.Controls.Add(this.adminSCPanel);
            this.actionsPanel.Size = new System.Drawing.Size(255, 600);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.monitoring1);
            this.dataPanel.Controls.Add(this.distribution1);
            this.dataPanel.Controls.Add(this.manager1);
            this.dataPanel.Controls.Add(this.profile1);
            this.dataPanel.Size = new System.Drawing.Size(686, 567);
            // 
            // adminSCPanel
            // 
            this.adminSCPanel.BackColor = System.Drawing.Color.DarkGray;
            this.adminSCPanel.Controls.Add(this.adminSCLabel2);
            this.adminSCPanel.Controls.Add(this.adminSCLabel1);
            this.adminSCPanel.Location = new System.Drawing.Point(0, 0);
            this.adminSCPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminSCPanel.Name = "adminSCPanel";
            this.adminSCPanel.Size = new System.Drawing.Size(255, 130);
            this.adminSCPanel.TabIndex = 3;
            // 
            // adminSCLabel2
            // 
            this.adminSCLabel2.AutoSize = true;
            this.adminSCLabel2.BackColor = System.Drawing.Color.DarkGray;
            this.adminSCLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminSCLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminSCLabel2.Location = new System.Drawing.Point(2, 70);
            this.adminSCLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminSCLabel2.Name = "adminSCLabel2";
            this.adminSCLabel2.Size = new System.Drawing.Size(252, 37);
            this.adminSCLabel2.TabIndex = 3;
            this.adminSCLabel2.Text = "спорткомплекса";
            // 
            // adminSCLabel1
            // 
            this.adminSCLabel1.AutoSize = true;
            this.adminSCLabel1.BackColor = System.Drawing.Color.DarkGray;
            this.adminSCLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminSCLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminSCLabel1.Location = new System.Drawing.Point(9, 20);
            this.adminSCLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminSCLabel1.Name = "adminSCLabel1";
            this.adminSCLabel1.Size = new System.Drawing.Size(241, 37);
            this.adminSCLabel1.TabIndex = 2;
            this.adminSCLabel1.Text = "Администратор";
            // 
            // profilButton
            // 
            this.profilButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.profilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profilButton.ForeColor = System.Drawing.Color.Orange;
            this.profilButton.Location = new System.Drawing.Point(-1, 127);
            this.profilButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(256, 62);
            this.profilButton.TabIndex = 4;
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
            // managerButton
            // 
            this.managerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.managerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managerButton.ForeColor = System.Drawing.Color.Orange;
            this.managerButton.Location = new System.Drawing.Point(-1, 186);
            this.managerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(256, 118);
            this.managerButton.TabIndex = 5;
            this.managerButton.Text = "Управление клиентскими данными";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // manager1
            // 
            this.manager1.Location = new System.Drawing.Point(0, 0);
            this.manager1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manager1.Name = "manager1";
            this.manager1.Size = new System.Drawing.Size(686, 567);
            this.manager1.TabIndex = 1;
            // 
            // distribution1
            // 
            this.distribution1.Location = new System.Drawing.Point(0, 0);
            this.distribution1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.distribution1.Name = "distribution1";
            this.distribution1.Size = new System.Drawing.Size(686, 567);
            this.distribution1.TabIndex = 2;
            // 
            // distributionButton
            // 
            this.distributionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.distributionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.distributionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distributionButton.ForeColor = System.Drawing.Color.Orange;
            this.distributionButton.Location = new System.Drawing.Point(0, 301);
            this.distributionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.distributionButton.Name = "distributionButton";
            this.distributionButton.Size = new System.Drawing.Size(255, 112);
            this.distributionButton.TabIndex = 6;
            this.distributionButton.Text = "Распределение тренеров";
            this.distributionButton.UseVisualStyleBackColor = true;
            this.distributionButton.Click += new System.EventHandler(this.distributionButton_Click);
            // 
            // monitoring1
            // 
            this.monitoring1.Location = new System.Drawing.Point(0, 0);
            this.monitoring1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monitoring1.Name = "monitoring1";
            this.monitoring1.Size = new System.Drawing.Size(686, 567);
            this.monitoring1.TabIndex = 3;
            this.monitoring1.Load += new System.EventHandler(this.monitoring1_Load);
            // 
            // monitoringButton
            // 
            this.monitoringButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.monitoringButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monitoringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monitoringButton.ForeColor = System.Drawing.Color.Orange;
            this.monitoringButton.Location = new System.Drawing.Point(0, 410);
            this.monitoringButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monitoringButton.Name = "monitoringButton";
            this.monitoringButton.Size = new System.Drawing.Size(255, 74);
            this.monitoringButton.TabIndex = 7;
            this.monitoringButton.Text = "Мониторинг";
            this.monitoringButton.UseVisualStyleBackColor = true;
            this.monitoringButton.Click += new System.EventHandler(this.monitoring1_Click);
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(2, 545);
            this.exitButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(34, 39);
            this.exitButton1.TabIndex = 8;
            // 
            // AdminSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "AdminSC";
            this.Size = new System.Drawing.Size(974, 600);
            this.actionsPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.adminSCPanel.ResumeLayout(false);
            this.adminSCPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminSCPanel;
        private System.Windows.Forms.Label adminSCLabel2;
        private System.Windows.Forms.Label adminSCLabel1;
        private System.Windows.Forms.Button profilButton;
        private Profile profile1;
        private System.Windows.Forms.Button managerButton;
        private Manager manager1;
        private Distribution distribution1;
        private System.Windows.Forms.Button distributionButton;
        private Monitoring monitoring1;
        private System.Windows.Forms.Button monitoringButton;
        private ExitButton exitButton1;
    }
}
