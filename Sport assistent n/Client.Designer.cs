namespace Sport_assistent_n
{
    partial class Client
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
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.profilButton = new System.Windows.Forms.Button();
            this.subscriptionButton = new System.Windows.Forms.Button();
            this.timetableButton = new System.Windows.Forms.Button();
            this.notificationButton = new System.Windows.Forms.Button();
            this.profile1 = new Sport_assistent_n.Profile();
            this.subscription1 = new Sport_assistent_n.Subscription();
            this.timetable1 = new Sport_assistent_n.Timetable();
            this.notifications1 = new Sport_assistent_n.Notifications();
            this.exitButton1 = new Sport_assistent_n.ExitButton();
            this.actionsPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.clientPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.exitButton1);
            this.actionsPanel.Controls.Add(this.notificationButton);
            this.actionsPanel.Controls.Add(this.timetableButton);
            this.actionsPanel.Controls.Add(this.subscriptionButton);
            this.actionsPanel.Controls.Add(this.profilButton);
            this.actionsPanel.Controls.Add(this.clientPanel);
            this.actionsPanel.Size = new System.Drawing.Size(255, 604);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.notifications1);
            this.dataPanel.Controls.Add(this.timetable1);
            this.dataPanel.Controls.Add(this.subscription1);
            this.dataPanel.Controls.Add(this.profile1);
            this.dataPanel.Size = new System.Drawing.Size(686, 567);
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.BackColor = System.Drawing.Color.DarkGray;
            this.clientLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLabel.Location = new System.Drawing.Point(60, 20);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(134, 37);
            this.clientLabel.TabIndex = 2;
            this.clientLabel.Text = "Клиент  ";
            // 
            // clientPanel
            // 
            this.clientPanel.BackColor = System.Drawing.Color.DarkGray;
            this.clientPanel.Controls.Add(this.panel2);
            this.clientPanel.Controls.Add(this.clientLabel);
            this.clientPanel.Location = new System.Drawing.Point(0, 0);
            this.clientPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(255, 81);
            this.clientPanel.TabIndex = 0;
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
            this.profilButton.TabIndex = 1;
            this.profilButton.Text = "Профиль";
            this.profilButton.UseVisualStyleBackColor = true;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // subscriptionButton
            // 
            this.subscriptionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.subscriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscriptionButton.ForeColor = System.Drawing.Color.Orange;
            this.subscriptionButton.Location = new System.Drawing.Point(-1, 138);
            this.subscriptionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subscriptionButton.Name = "subscriptionButton";
            this.subscriptionButton.Size = new System.Drawing.Size(256, 62);
            this.subscriptionButton.TabIndex = 2;
            this.subscriptionButton.Text = "Абонементы";
            this.subscriptionButton.UseVisualStyleBackColor = true;
            this.subscriptionButton.Click += new System.EventHandler(this.subscriptionButton_Click);
            // 
            // timetableButton
            // 
            this.timetableButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.timetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timetableButton.ForeColor = System.Drawing.Color.Orange;
            this.timetableButton.Location = new System.Drawing.Point(-1, 197);
            this.timetableButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(256, 80);
            this.timetableButton.TabIndex = 3;
            this.timetableButton.Text = "Расписание занятий";
            this.timetableButton.UseVisualStyleBackColor = true;
            this.timetableButton.Click += new System.EventHandler(this.timeTableButton_Click);
            // 
            // notificationButton
            // 
            this.notificationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.notificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notificationButton.ForeColor = System.Drawing.Color.Orange;
            this.notificationButton.Location = new System.Drawing.Point(-1, 272);
            this.notificationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(256, 62);
            this.notificationButton.TabIndex = 4;
            this.notificationButton.Text = "Уведомления";
            this.notificationButton.UseVisualStyleBackColor = true;
            this.notificationButton.Click += new System.EventHandler(this.notificationButton_Click);
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(0, 0);
            this.profile1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(686, 567);
            this.profile1.TabIndex = 0;
            // 
            // subscription1
            // 
            this.subscription1.Location = new System.Drawing.Point(0, 0);
            this.subscription1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subscription1.Name = "subscription1";
            this.subscription1.Size = new System.Drawing.Size(686, 567);
            this.subscription1.TabIndex = 1;
            // 
            // timetable1
            // 
            this.timetable1.Location = new System.Drawing.Point(0, 0);
            this.timetable1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timetable1.Name = "timetable1";
            this.timetable1.Size = new System.Drawing.Size(686, 567);
            this.timetable1.TabIndex = 2;
            // 
            // notifications1
            // 
            this.notifications1.Location = new System.Drawing.Point(2, 2);
            this.notifications1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notifications1.Name = "notifications1";
            this.notifications1.Size = new System.Drawing.Size(686, 567);
            this.notifications1.TabIndex = 3;
            this.notifications1.Load += new System.EventHandler(this.notifications1_Load);
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(2, 548);
            this.exitButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(34, 39);
            this.exitButton1.TabIndex = 5;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "Client";
            this.Size = new System.Drawing.Size(974, 604);
            this.actionsPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Button timetableButton;
        private System.Windows.Forms.Button subscriptionButton;
        private System.Windows.Forms.Button profilButton;
        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Button notificationButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Profile profile1;
        public Notifications notifications1;
        private Timetable timetable1;
        private Subscription subscription1;
        private ExitButton exitButton1;
    }
}
