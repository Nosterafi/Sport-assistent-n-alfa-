namespace Sport_assistent_n
{
    partial class Profile
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
            this.profileBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userPatronymic = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.hideLogin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.hidePassword = new System.Windows.Forms.Button();
            this.userSurname = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profileBox
            // 
            this.profileBox.BackColor = System.Drawing.Color.White;
            this.profileBox.BackgroundImage = global::Sport_assistent_n.Properties.Resources.free_icon_avatar_126486;
            this.profileBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileBox.Location = new System.Drawing.Point(13, 13);
            this.profileBox.Margin = new System.Windows.Forms.Padding(2);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(196, 181);
            this.profileBox.TabIndex = 0;
            this.profileBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(302, 93);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 37);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.ForeColor = System.Drawing.Color.Orange;
            this.userName.Location = new System.Drawing.Point(390, 93);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(27, 38);
            this.userName.TabIndex = 3;
            this.userName.Text = "-";
            // 
            // userPatronymic
            // 
            this.userPatronymic.AutoSize = true;
            this.userPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPatronymic.ForeColor = System.Drawing.Color.Orange;
            this.userPatronymic.Location = new System.Drawing.Point(390, 158);
            this.userPatronymic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userPatronymic.Name = "userPatronymic";
            this.userPatronymic.Size = new System.Drawing.Size(27, 38);
            this.userPatronymic.TabIndex = 7;
            this.userPatronymic.Text = "-";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicLabel.Location = new System.Drawing.Point(230, 156);
            this.patronymicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(160, 37);
            this.patronymicLabel.TabIndex = 5;
            this.patronymicLabel.Text = "Отчество:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(25, 235);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(107, 37);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Логин:";
            // 
            // userLogin
            // 
            this.userLogin.Enabled = false;
            this.userLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLogin.ForeColor = System.Drawing.Color.Orange;
            this.userLogin.Location = new System.Drawing.Point(136, 235);
            this.userLogin.Margin = new System.Windows.Forms.Padding(2);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(354, 39);
            this.userLogin.TabIndex = 9;
            this.userLogin.UseSystemPasswordChar = true;
            // 
            // userPassword
            // 
            this.userPassword.Enabled = false;
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPassword.ForeColor = System.Drawing.Color.Orange;
            this.userPassword.Location = new System.Drawing.Point(136, 314);
            this.userPassword.Margin = new System.Windows.Forms.Padding(2);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(354, 39);
            this.userPassword.TabIndex = 11;
            this.userPassword.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(7, 313);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(133, 37);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Пароль:";
            // 
            // hideLogin
            // 
            this.hideLogin.BackColor = System.Drawing.Color.White;
            this.hideLogin.BackgroundImage = global::Sport_assistent_n.Properties.Resources.free_icon_lock_5525365;
            this.hideLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideLogin.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.hideLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.hideLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.hideLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideLogin.Location = new System.Drawing.Point(514, 235);
            this.hideLogin.Margin = new System.Windows.Forms.Padding(2);
            this.hideLogin.Name = "hideLogin";
            this.hideLogin.Size = new System.Drawing.Size(38, 38);
            this.hideLogin.TabIndex = 12;
            this.hideLogin.UseVisualStyleBackColor = false;
            this.hideLogin.Click += new System.EventHandler(this.hideLogin_Click);
            // 
            // hidePassword
            // 
            this.hidePassword.BackColor = System.Drawing.Color.White;
            this.hidePassword.BackgroundImage = global::Sport_assistent_n.Properties.Resources.free_icon_lock_5525365;
            this.hidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidePassword.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.hidePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.hidePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.hidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidePassword.Location = new System.Drawing.Point(514, 314);
            this.hidePassword.Margin = new System.Windows.Forms.Padding(2);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(38, 38);
            this.hidePassword.TabIndex = 13;
            this.hidePassword.UseVisualStyleBackColor = false;
            this.hidePassword.Click += new System.EventHandler(this.hidePassword_Click);
            // 
            // userSurname
            // 
            this.userSurname.AutoSize = true;
            this.userSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurname.ForeColor = System.Drawing.Color.Orange;
            this.userSurname.Location = new System.Drawing.Point(390, 26);
            this.userSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(27, 38);
            this.userSurname.TabIndex = 15;
            this.userSurname.Text = "-";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(230, 24);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(153, 37);
            this.surnameLabel.TabIndex = 14;
            this.surnameLabel.Text = "Фамилия:";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userSurname);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.hideLogin);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.userPatronymic);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profileBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(686, 567);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profileBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button hideLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button hidePassword;
        private System.Windows.Forms.Label surnameLabel;
        public System.Windows.Forms.Label userName;
        public System.Windows.Forms.Label userPatronymic;
        public System.Windows.Forms.TextBox userLogin;
        public System.Windows.Forms.TextBox userPassword;
        public System.Windows.Forms.Label userSurname;
    }
}
