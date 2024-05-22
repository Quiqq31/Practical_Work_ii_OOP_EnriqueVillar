namespace Practical_Work_2_Enrique
{
    partial class RecuperarPassword
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
            btn_confirm_pas = new Button();
            textbox_passwd_rep = new TextBox();
            textbox_passwd1 = new TextBox();
            lbl_passwd = new Label();
            lbl_username = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textbox_user = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_confirm_pas
            // 
            btn_confirm_pas.BackColor = SystemColors.ScrollBar;
            btn_confirm_pas.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_confirm_pas.Location = new Point(281, 380);
            btn_confirm_pas.Name = "btn_confirm_pas";
            btn_confirm_pas.Size = new Size(212, 55);
            btn_confirm_pas.TabIndex = 16;
            btn_confirm_pas.Text = "CONFIRM";
            btn_confirm_pas.UseVisualStyleBackColor = false;
            btn_confirm_pas.Click += btn_confirm_pas_Click;
            // 
            // textbox_passwd_rep
            // 
            textbox_passwd_rep.Location = new Point(400, 292);
            textbox_passwd_rep.Margin = new Padding(4, 5, 4, 5);
            textbox_passwd_rep.MinimumSize = new Size(50, 40);
            textbox_passwd_rep.Name = "textbox_passwd_rep";
            textbox_passwd_rep.PasswordChar = '*';
            textbox_passwd_rep.PlaceholderText = "Repeat Password";
            textbox_passwd_rep.Size = new Size(336, 40);
            textbox_passwd_rep.TabIndex = 14;
            // 
            // textbox_passwd1
            // 
            textbox_passwd1.Location = new Point(400, 174);
            textbox_passwd1.Margin = new Padding(4, 5, 4, 5);
            textbox_passwd1.MinimumSize = new Size(50, 40);
            textbox_passwd1.Name = "textbox_passwd1";
            textbox_passwd1.PasswordChar = '*';
            textbox_passwd1.PlaceholderText = "Password";
            textbox_passwd1.Size = new Size(336, 40);
            textbox_passwd1.TabIndex = 12;
            // 
            // lbl_passwd
            // 
            lbl_passwd.AutoSize = true;
            lbl_passwd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_passwd.Location = new Point(439, 242);
            lbl_passwd.Name = "lbl_passwd";
            lbl_passwd.Size = new Size(207, 32);
            lbl_passwd.TabIndex = 11;
            lbl_passwd.Text = "Repeat Password";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(437, 124);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(180, 32);
            lbl_username.TabIndex = 10;
            lbl_username.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(194, 26);
            label1.Name = "label1";
            label1.Size = new Size(389, 54);
            label1.TabIndex = 9;
            label1.Text = "OOP CALCULATOR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox1.Location = new Point(-20, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(838, 103);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // textbox_user
            // 
            textbox_user.Location = new Point(31, 236);
            textbox_user.Margin = new Padding(4, 5, 4, 5);
            textbox_user.MinimumSize = new Size(50, 40);
            textbox_user.Name = "textbox_user";
            textbox_user.PlaceholderText = "Username";
            textbox_user.Size = new Size(336, 40);
            textbox_user.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 186);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // RecuperarPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 468);
            Controls.Add(textbox_user);
            Controls.Add(label2);
            Controls.Add(btn_confirm_pas);
            Controls.Add(textbox_passwd_rep);
            Controls.Add(textbox_passwd1);
            Controls.Add(lbl_passwd);
            Controls.Add(lbl_username);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RecuperarPassword";
            Text = "RecuperarPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_confirm_pas;
        private TextBox textbox_passwd_rep;
        private TextBox textbox_passwd1;
        private Label lbl_passwd;
        private Label lbl_username;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textbox_user;
        private Label label2;
    }
}