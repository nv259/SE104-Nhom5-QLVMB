namespace Service
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernametxtBox = new System.Windows.Forms.TextBox();
            this.PasswordtxtBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernametxtBox
            // 
            this.UsernametxtBox.Location = new System.Drawing.Point(69, 27);
            this.UsernametxtBox.MaxLength = 255;
            this.UsernametxtBox.Name = "UsernametxtBox";
            this.UsernametxtBox.PlaceholderText = "username";
            this.UsernametxtBox.Size = new System.Drawing.Size(371, 27);
            this.UsernametxtBox.TabIndex = 0;
            this.UsernametxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordtxtBox
            // 
            this.PasswordtxtBox.Location = new System.Drawing.Point(69, 88);
            this.PasswordtxtBox.MaxLength = 255;
            this.PasswordtxtBox.Name = "PasswordtxtBox";
            this.PasswordtxtBox.PasswordChar = '•';
            this.PasswordtxtBox.PlaceholderText = "password";
            this.PasswordtxtBox.Size = new System.Drawing.Size(371, 27);
            this.PasswordtxtBox.TabIndex = 1;
            this.PasswordtxtBox.TextChanged += new System.EventHandler(this.PasswordtxtBox_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(171, 164);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(178, 37);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Đăng nhập";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(171, 222);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(178, 37);
            this.RegisterBtn.TabIndex = 3;
            this.RegisterBtn.Text = "Đăng ký";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Service.Properties.Resources.background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 314);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordtxtBox);
            this.Controls.Add(this.UsernametxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UsernametxtBox;
        private TextBox PasswordtxtBox;
        private Button LoginBtn;
        private Button RegisterBtn;
    }
}