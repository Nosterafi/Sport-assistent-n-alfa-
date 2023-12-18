namespace Sport_assistent_n
{
    partial class Trainer
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
            this.trainerPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trainerLabel = new System.Windows.Forms.Label();
            this.profilButton = new System.Windows.Forms.Button();
            this.timetableButton = new System.Windows.Forms.Button();
            this.profile1 = new Sport_assistent_n.Profile();
            this.trainerTimetable1 = new Sport_assistent_n.TrainerTimetable();
            this.notificationButton = new System.Windows.Forms.Button();
            this.notifications1 = new Sport_assistent_n.Notifications();
            this.exitButton1 = new Sport_assistent_n.ExitButton();
            this.actionsPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.trainerPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.exitButton1);
            this.actionsPanel.Controls.Add(this.notificationButton);
            this.actionsPanel.Controls.Add(this.timetableButton);
            this.actionsPanel.Controls.Add(this.profilButton);
            this.actionsPanel.Controls.Add(this.trainerPanel);
            this.actionsPanel.Size = new System.Drawing.Size(255, 597);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.notifications1);
            this.dataPanel.Controls.Add(this.trainerTimetable1);
            this.dataPanel.Controls.Add(this.profile1);
            this.dataPanel.Size = new System.Drawing.Size(686, 567);
            // 
            // trainerPanel
            // 
            this.trainerPanel.BackColor = System.Drawing.Color.DarkGray;
            this.trainerPanel.Controls.Add(this.panel2);
            this.trainerPanel.Controls.Add(this.trainerLabel);
            this.trainerPanel.Location = new System.Drawing.Point(0, 0);
            this.trainerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trainerPanel.Name = "trainerPanel";
            this.trainerPanel.Size = new System.Drawing.Size(255, 81);
            this.trainerPanel.TabIndex = 1;
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
            // trainerLabel
            // 
            this.trainerLabel.AutoSize = true;
            this.trainerLabel.BackColor = System.Drawing.Color.DarkGray;
            this.trainerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trainerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainerLabel.Location = new System.Drawing.Point(65, 20);
            this.trainerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trainerLabel.Name = "trainerLabel";
            this.trainerLabel.Size = new System.Drawing.Size(122, 37);
            this.trainerLabel.TabIndex = 2;
            this.trainerLabel.Text = "Тренер";
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
            this.profilButton.TabIndex = 2;
            this.profilButton.Text = "Профиль";
            this.profilButton.UseVisualStyleBackColor = true;
            this.profilButton.Click += new System.EventHandler(this.profilButton_Click);
            // 
            // timetableButton
            // 
            this.timetableButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.timetableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timetableButton.ForeColor = System.Drawing.Color.Orange;
            this.timetableButton.Location = new System.Drawing.Point(-1, 143);
            this.timetableButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timetableButton.Name = "timetableButton";
            this.timetableButton.Size = new System.Drawing.Size(256, 80);
            this.timetableButton.TabIndex = 4;
            this.timetableButton.Text = "Расписание тренировок";
            this.timetableButton.UseVisualStyleBackColor = true;
            this.timetableButton.Click += new System.EventHandler(this.timetableButton_Click);
            // 
            // profile1
            // 
            this.profile1.Location = new System.Drawing.Point(2, 2);
            this.profile1.Margin = new System.Windows.Forms.Padding(2);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(686, 567);
            this.profile1.TabIndex = 0;
            // 
            // trainerTimetable1
            // 
            this.trainerTimetable1.Location = new System.Drawing.Point(0, 0);
            this.trainerTimetable1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trainerTimetable1.Name = "trainerTimetable1";
            this.trainerTimetable1.Size = new System.Drawing.Size(686, 567);
            this.trainerTimetable1.TabIndex = 1;
            // 
            // notificationButton
            // 
            this.notificationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.notificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notificationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notificationButton.ForeColor = System.Drawing.Color.Orange;
            this.notificationButton.Location = new System.Drawing.Point(0, 219);
            this.notificationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(255, 62);
            this.notificationButton.TabIndex = 5;
            this.notificationButton.Text = "Уведомления";
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
            this.exitButton1.Location = new System.Drawing.Point(2, 548);
            this.exitButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(34, 39);
            this.exitButton1.TabIndex = 6;
            // 
            // Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "Trainer";
            this.Size = new System.Drawing.Size(974, 597);
            this.actionsPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.trainerPanel.ResumeLayout(false);
            this.trainerPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel trainerPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label trainerLabel;
        private System.Windows.Forms.Button profilButton;
        private System.Windows.Forms.Button timetableButton;
        private TrainerTimetable trainerTimetable1;
        private Profile profile1;
        private System.Windows.Forms.Button notificationButton;
        private Notifications notifications1;
        private ExitButton exitButton1;
    }
}
