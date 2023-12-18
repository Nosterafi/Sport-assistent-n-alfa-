namespace Sport_assistent_n
{
    partial class Admin
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
            this.adminPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminLabel = new System.Windows.Forms.Label();
            this.profilButton = new System.Windows.Forms.Button();
            this.profile1 = new Sport_assistent_n.Profile();
            this.accesButton = new System.Windows.Forms.Button();
            this.acces1 = new Sport_assistent_n.Acces();
            this.notificationButton = new System.Windows.Forms.Button();
            this.notifications1 = new Sport_assistent_n.Notifications();
            this.exitButton1 = new Sport_assistent_n.ExitButton();
            this.actionsPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.exitButton1);
            this.actionsPanel.Controls.Add(this.notificationButton);
            this.actionsPanel.Controls.Add(this.accesButton);
            this.actionsPanel.Controls.Add(this.profilButton);
            this.actionsPanel.Controls.Add(this.adminPanel);
            this.actionsPanel.Size = new System.Drawing.Size(255, 600);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.notifications1);
            this.dataPanel.Controls.Add(this.acces1);
            this.dataPanel.Controls.Add(this.profile1);
            this.dataPanel.Size = new System.Drawing.Size(686, 567);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.DarkGray;
            this.adminPanel.Controls.Add(this.panel2);
            this.adminPanel.Controls.Add(this.adminLabel);
            this.adminPanel.Location = new System.Drawing.Point(0, 0);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(255, 81);
            this.adminPanel.TabIndex = 2;
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
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.BackColor = System.Drawing.Color.DarkGray;
            this.adminLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminLabel.Location = new System.Drawing.Point(9, 17);
            this.adminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(241, 37);
            this.adminLabel.TabIndex = 2;
            this.adminLabel.Text = "Администратор";
            // 
            // profilButton
            // 
            this.profilButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.profilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profilButton.ForeColor = System.Drawing.Color.Orange;
            this.profilButton.Location = new System.Drawing.Point(-1, 81);
            this.profilButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(256, 62);
            this.profilButton.TabIndex = 3;
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
            // accesButton
            // 
            this.accesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.accesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accesButton.ForeColor = System.Drawing.Color.Orange;
            this.accesButton.Location = new System.Drawing.Point(0, 143);
            this.accesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accesButton.Name = "accesButton";
            this.accesButton.Size = new System.Drawing.Size(255, 62);
            this.accesButton.TabIndex = 4;
            this.accesButton.Text = "Контроль доступа";
            this.accesButton.UseVisualStyleBackColor = true;
            this.accesButton.Click += new System.EventHandler(this.accesButton_Click);
            // 
            // acces1
            // 
            this.acces1.Location = new System.Drawing.Point(0, 0);
            this.acces1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.acces1.Name = "acces1";
            this.acces1.Size = new System.Drawing.Size(686, 567);
            this.acces1.TabIndex = 1;
            // 
            // notificationButton
            // 
            this.notificationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.notificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notificationButton.ForeColor = System.Drawing.Color.Orange;
            this.notificationButton.Location = new System.Drawing.Point(0, 201);
            this.notificationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(255, 73);
            this.notificationButton.TabIndex = 5;
            this.notificationButton.Text = "Уведомления о неполадках";
            this.notificationButton.UseVisualStyleBackColor = true;
            this.notificationButton.Click += new System.EventHandler(this.notificationButton_Click);
            // 
            // notifications1
            // 
            this.notifications1.Location = new System.Drawing.Point(0, 0);
            this.notifications1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notifications1.Name = "notifications1";
            this.notifications1.Size = new System.Drawing.Size(686, 567);
            this.notifications1.TabIndex = 2;
            this.notifications1.Load += new System.EventHandler(this.notifications1_Load);
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(5, 545);
            this.exitButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(34, 39);
            this.exitButton1.TabIndex = 6;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(974, 600);
            this.actionsPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Button profilButton;
        private Profile profile1;
        private System.Windows.Forms.Button accesButton;
        private Acces acces1;
        private System.Windows.Forms.Button notificationButton;
        private Notifications notifications1;
        private ExitButton exitButton1;
    }
}
