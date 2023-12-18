namespace Sport_assistent_n
{
    partial class Entry
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
            this.entryButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.inputDataLabel = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.passwordBox2 = new System.Windows.Forms.PictureBox();
            this.loginBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // entryButton
            // 
            this.entryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.entryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryButton.ForeColor = System.Drawing.Color.Orange;
            this.entryButton.Location = new System.Drawing.Point(140, 209);
            this.entryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(115, 37);
            this.entryButton.TabIndex = 23;
            this.entryButton.Text = "Войти";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.passwordTextBox.Location = new System.Drawing.Point(140, 151);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(174, 23);
            this.passwordTextBox.TabIndex = 21;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.loginTextBox.Location = new System.Drawing.Point(140, 99);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(174, 23);
            this.loginTextBox.TabIndex = 20;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(70, 151);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 20);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Пароль:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(80, 98);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(59, 20);
            this.loginLabel.TabIndex = 17;
            this.loginLabel.Text = "Логин:";
            // 
            // inputDataLabel
            // 
            this.inputDataLabel.AutoSize = true;
            this.inputDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputDataLabel.Location = new System.Drawing.Point(38, 33);
            this.inputDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputDataLabel.Name = "inputDataLabel";
            this.inputDataLabel.Size = new System.Drawing.Size(355, 20);
            this.inputDataLabel.TabIndex = 16;
            this.inputDataLabel.Text = "Введите логин и пароль для входа в аккаунт";
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.Transparent;
            this.registrationButton.FlatAppearance.BorderSize = 0;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.registrationButton.Location = new System.Drawing.Point(74, 250);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(0);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(238, 24);
            this.registrationButton.TabIndex = 24;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // passwordBox2
            // 
            this.passwordBox2.BackgroundImage = global::Sport_assistent_n.Properties.Resources.free_icon_lock_5525365;
            this.passwordBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordBox2.Location = new System.Drawing.Point(40, 143);
            this.passwordBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordBox2.Name = "passwordBox2";
            this.passwordBox2.Size = new System.Drawing.Size(26, 28);
            this.passwordBox2.TabIndex = 26;
            this.passwordBox2.TabStop = false;
            // 
            // loginBox1
            // 
            this.loginBox1.BackgroundImage = global::Sport_assistent_n.Properties.Resources.free_icon_avatar_126486;
            this.loginBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBox1.Location = new System.Drawing.Point(40, 89);
            this.loginBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBox1.Name = "loginBox1";
            this.loginBox1.Size = new System.Drawing.Size(26, 29);
            this.loginBox1.TabIndex = 27;
            this.loginBox1.TabStop = false;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.loginBox1);
            this.Controls.Add(this.passwordBox2);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.entryButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.inputDataLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Entry";
            this.Size = new System.Drawing.Size(404, 308);
            this.Load += new System.EventHandler(this.Entry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.MaskedTextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label inputDataLabel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.PictureBox passwordBox2;
        private System.Windows.Forms.PictureBox loginBox1;
    }
}
