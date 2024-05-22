namespace Practical_Work_2_Enrique
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
            label1 = new Label();
            lbl_username = new Label();
            lbl_passwd = new Label();
            textbox_user = new TextBox();
            pictureBox1 = new PictureBox();
            textbox_passwd = new TextBox();
            linkLabel1 = new LinkLabel();
            btn_Login = new Button();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(194, 28);
            label1.Name = "label1";
            label1.Size = new Size(389, 54);
            label1.TabIndex = 0;
            label1.Text = "OOP CALCULATOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(261, 126);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(128, 32);
            lbl_username.TabIndex = 2;
            lbl_username.Text = "Username";
            // 
            // lbl_passwd
            // 
            lbl_passwd.AutoSize = true;
            lbl_passwd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_passwd.Location = new Point(263, 244);
            lbl_passwd.Name = "lbl_passwd";
            lbl_passwd.Size = new Size(122, 32);
            lbl_passwd.TabIndex = 3;
            lbl_passwd.Text = "Password";
            // 
            // textbox_user
            // 
            textbox_user.Location = new Point(224, 176);
            textbox_user.Margin = new Padding(4, 5, 4, 5);
            textbox_user.MinimumSize = new Size(50, 40);
            textbox_user.Name = "textbox_user";
            textbox_user.PlaceholderText = "Username";
            textbox_user.Size = new Size(336, 40);
            textbox_user.TabIndex = 4;
            textbox_user.TextChanged += L_txtbox_User_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(795, 103);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textbox_passwd
            // 
            textbox_passwd.Location = new Point(224, 294);
            textbox_passwd.Margin = new Padding(4, 5, 4, 5);
            textbox_passwd.MinimumSize = new Size(50, 40);
            textbox_passwd.Name = "textbox_passwd";
            textbox_passwd.PasswordChar = '*';
            textbox_passwd.PlaceholderText = "Password";
            textbox_passwd.Size = new Size(336, 40);
            textbox_passwd.TabIndex = 6;
            textbox_passwd.TextChanged += textbox_passwd_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(401, 348);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(159, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password ?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = SystemColors.ScrollBar;
            btn_Login.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Login.Location = new Point(282, 400);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(212, 55);
            btn_Login.TabIndex = 8;
            btn_Login.Text = "SIGN IN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_login_click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(56, 416);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(172, 25);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create New Account";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(linkLabel2);
            Controls.Add(btn_Login);
            Controls.Add(linkLabel1);
            Controls.Add(textbox_passwd);
            Controls.Add(textbox_user);
            Controls.Add(lbl_passwd);
            Controls.Add(lbl_username);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_username;
        private Label lbl_passwd;
        private TextBox textbox_user;
        private PictureBox pictureBox1;
        private TextBox textbox_passwd;
        private LinkLabel linkLabel1;
        private Button btn_Login;
        private LinkLabel linkLabel2;
    }
}