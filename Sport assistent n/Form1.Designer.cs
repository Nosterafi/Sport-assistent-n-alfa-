namespace Sport_assistent_n
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.begin1 = new Sport_assistent_n.Begin();
            this.SuspendLayout();
            // 
            // begin1
            // 
            this.begin1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.begin1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.begin1.BackColor = System.Drawing.Color.White;
            this.begin1.Location = new System.Drawing.Point(387, 196);
            this.begin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.begin1.Name = "begin1";
            this.begin1.Size = new System.Drawing.Size(545, 316);
            this.begin1.TabIndex = 0;
            this.begin1.Load += new System.EventHandler(this.begin1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sport_assistent_n.Properties.Resources.Background_Image_v_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 726);
            this.Controls.Add(this.begin1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1299, 720);
            this.Name = "MainForm";
            this.Text = "Sport Assistent 2.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Begin begin1;
    }
}

