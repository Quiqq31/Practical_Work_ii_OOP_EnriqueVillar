namespace Practical_Work_2_Enrique
{
    partial class RegisterAcc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Register = new Button();
            textbox_passwd = new TextBox();
            textbox_user = new TextBox();
            lbl_passwd = new Label();
            lbl_username = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textbox_repeat_passwd = new TextBox();
            textbox_email = new TextBox();
            lbl_rep_passwd = new Label();
            lbl_email = new Label();
            linkLabel1 = new LinkLabel();
            textbox_name = new TextBox();
            lbl_name = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Register
            // 
            btn_Register.BackColor = SystemColors.ScrollBar;
            btn_Register.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Register.Location = new Point(304, 365);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(212, 55);
            btn_Register.TabIndex = 7;
            btn_Register.Text = "SIGN IN";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // textbox_passwd
            // 
            textbox_passwd.Location = new Point(557, 176);
            textbox_passwd.Margin = new Padding(4, 5, 4, 5);
            textbox_passwd.MinimumSize = new Size(50, 40);
            textbox_passwd.Name = "textbox_passwd";
            textbox_passwd.PasswordChar = '*';
            textbox_passwd.PlaceholderText = "Password";
            textbox_passwd.Size = new Size(210, 40);
            textbox_passwd.TabIndex = 4;
            // 
            // textbox_user
            // 
            textbox_user.Location = new Point(33, 174);
            textbox_user.Margin = new Padding(4, 5, 4, 5);
            textbox_user.MinimumSize = new Size(50, 40);
            textbox_user.Name = "textbox_user";
            textbox_user.PlaceholderText = "Username";
            textbox_user.Size = new Size(208, 40);
            textbox_user.TabIndex = 1;
            // 
            // lbl_passwd
            // 
            lbl_passwd.AutoSize = true;
            lbl_passwd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_passwd.Location = new Point(596, 126);
            lbl_passwd.Name = "lbl_passwd";
            lbl_passwd.Size = new Size(122, 32);
            lbl_passwd.TabIndex = 11;
            lbl_passwd.Text = "Password";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(70, 124);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(128, 32);
            lbl_username.TabIndex = 10;
            lbl_username.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 26);
            label1.Name = "label1";
            label1.Size = new Size(389, 54);
            label1.TabIndex = 0;
            label1.Text = "OOP CALCULATOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox1.Location = new Point(-7, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(818, 103);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // textbox_repeat_passwd
            // 
            textbox_repeat_passwd.Location = new Point(557, 308);
            textbox_repeat_passwd.Margin = new Padding(4, 5, 4, 5);
            textbox_repeat_passwd.MinimumSize = new Size(50, 40);
            textbox_repeat_passwd.Name = "textbox_repeat_passwd";
            textbox_repeat_passwd.PasswordChar = '*';
            textbox_repeat_passwd.PlaceholderText = "Password";
            textbox_repeat_passwd.Size = new Size(210, 40);
            textbox_repeat_passwd.TabIndex = 5;
            // 
            // textbox_email
            // 
            textbox_email.Location = new Point(301, 214);
            textbox_email.Margin = new Padding(4, 5, 4, 5);
            textbox_email.MinimumSize = new Size(50, 40);
            textbox_email.Name = "textbox_email";
            textbox_email.PlaceholderText = "E-mail";
            textbox_email.Size = new Size(215, 40);
            textbox_email.TabIndex = 3;
            // 
            // lbl_rep_passwd
            // 
            lbl_rep_passwd.AutoSize = true;
            lbl_rep_passwd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_rep_passwd.Location = new Point(565, 258);
            lbl_rep_passwd.Name = "lbl_rep_passwd";
            lbl_rep_passwd.Size = new Size(207, 32);
            lbl_rep_passwd.TabIndex = 18;
            lbl_rep_passwd.Text = "Repeat Password";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_email.Location = new Point(355, 164);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(97, 32);
            lbl_email.TabIndex = 17;
            lbl_email.Text = "E-MAIL";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(688, 402);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textbox_name
            // 
            textbox_name.Location = new Point(33, 308);
            textbox_name.Margin = new Padding(4, 5, 4, 5);
            textbox_name.MinimumSize = new Size(50, 40);
            textbox_name.Name = "textbox_name";
            textbox_name.PlaceholderText = "Name";
            textbox_name.Size = new Size(208, 40);
            textbox_name.TabIndex = 2;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_name.Location = new Point(70, 258);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(81, 32);
            lbl_name.TabIndex = 22;
            lbl_name.Text = "Name";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatAppearance.BorderColor = Color.Black;
            checkBox1.FlatAppearance.BorderSize = 3;
            checkBox1.FlatAppearance.CheckedBackColor = Color.Lime;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(364, 315);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Agree";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(337, 287);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 23;
            label2.Text = "Protection Policy";
            // 
            // RegisterAcc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(textbox_name);
            Controls.Add(lbl_name);
            Controls.Add(linkLabel1);
            Controls.Add(textbox_repeat_passwd);
            Controls.Add(textbox_email);
            Controls.Add(lbl_rep_passwd);
            Controls.Add(lbl_email);
            Controls.Add(btn_Register);
            Controls.Add(textbox_passwd);
            Controls.Add(textbox_user);
            Controls.Add(lbl_passwd);
            Controls.Add(lbl_username);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RegisterAcc";
            Text = "RegisterAcc";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Register;
        private TextBox textbox_passwd;
        private TextBox textbox_user;
        private Label lbl_passwd;
        private Label lbl_username;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textbox_repeat_passwd;
        private TextBox textbox_email;
        private Label lbl_rep_passwd;
        private Label lbl_email;
        private LinkLabel linkLabel1;
        private TextBox textbox_name;
        private Label lbl_name;
        private CheckBox checkBox1;
        private Label label2;
    }
}