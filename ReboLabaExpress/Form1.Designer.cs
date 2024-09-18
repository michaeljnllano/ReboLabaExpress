namespace ReboLabaExpress
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblForgotPassword = new Label();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            lblUsername = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            cbxRememberMe = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.BackColor = Color.Transparent;
            lblForgotPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblForgotPassword.ForeColor = Color.White;
            lblForgotPassword.Location = new Point(112, 308);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(106, 17);
            lblForgotPassword.TabIndex = 6;
            lblForgotPassword.Text = "Forgot password?";
            lblForgotPassword.Click += lblAccLogin_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightPink;
            btnLogin.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(53, 273);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(223, 32);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(282, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(534, 463);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(53, 151);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(223, 23);
            txtUsername.TabIndex = 12;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Transparent;
            lblUsername.Location = new Point(53, 129);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 19);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(53, 186);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            label4.Click += label4_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(53, 208);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(223, 23);
            txtPassword.TabIndex = 15;
            // 
            // cbxRememberMe
            // 
            cbxRememberMe.AutoSize = true;
            cbxRememberMe.BackColor = Color.Transparent;
            cbxRememberMe.ForeColor = Color.Transparent;
            cbxRememberMe.Location = new Point(53, 240);
            cbxRememberMe.Name = "cbxRememberMe";
            cbxRememberMe.Size = new Size(104, 19);
            cbxRememberMe.TabIndex = 16;
            cbxRememberMe.Text = "Remember me";
            cbxRememberMe.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(cbxRememberMe);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(lblForgotPassword);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Rebo Laba Express";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblForgotPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label label4;
        private TextBox txtPassword;
        private CheckBox cbxRememberMe;
    }
}
