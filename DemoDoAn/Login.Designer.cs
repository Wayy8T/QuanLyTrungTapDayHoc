namespace DemoDoAn
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ComboBox comboBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnl_LoginRight = new System.Windows.Forms.Panel();
            this.pnl_ErrorPassword = new System.Windows.Forms.Panel();
            this.pnl_ErrorUserName = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox_HidePass = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.checkbox_Remember = new System.Windows.Forms.CheckBox();
            this.lbl_CreateAccount = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_LoginLeft = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnl_LoginRight.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnl_LoginLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            comboBox1.DropDownHeight = 140;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] {
            "Giao Vien",
            "Hoc Sinh",
            "Addminh"});
            comboBox1.Location = new System.Drawing.Point(68, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(296, 33);
            comboBox1.TabIndex = 5;
            // 
            // pnl_LoginRight
            // 
            this.pnl_LoginRight.Controls.Add(this.pnl_ErrorPassword);
            this.pnl_LoginRight.Controls.Add(this.pnl_ErrorUserName);
            this.pnl_LoginRight.Controls.Add(this.panel5);
            this.pnl_LoginRight.Controls.Add(this.label4);
            this.pnl_LoginRight.Controls.Add(this.panel4);
            this.pnl_LoginRight.Controls.Add(this.panel1);
            this.pnl_LoginRight.Controls.Add(this.panel3);
            this.pnl_LoginRight.Controls.Add(this.button1);
            this.pnl_LoginRight.Controls.Add(this.btn_Login);
            this.pnl_LoginRight.Controls.Add(this.checkbox_Remember);
            this.pnl_LoginRight.Controls.Add(this.lbl_CreateAccount);
            this.pnl_LoginRight.Controls.Add(this.lbl_Login);
            this.pnl_LoginRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_LoginRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.pnl_LoginRight.Location = new System.Drawing.Point(688, 0);
            this.pnl_LoginRight.Name = "pnl_LoginRight";
            this.pnl_LoginRight.Size = new System.Drawing.Size(574, 754);
            this.pnl_LoginRight.TabIndex = 1;
            // 
            // pnl_ErrorPassword
            // 
            this.pnl_ErrorPassword.Location = new System.Drawing.Point(512, 365);
            this.pnl_ErrorPassword.Name = "pnl_ErrorPassword";
            this.pnl_ErrorPassword.Size = new System.Drawing.Size(27, 27);
            this.pnl_ErrorPassword.TabIndex = 7;
            // 
            // pnl_ErrorUserName
            // 
            this.pnl_ErrorUserName.Location = new System.Drawing.Point(512, 277);
            this.pnl_ErrorUserName.Name = "pnl_ErrorUserName";
            this.pnl_ErrorUserName.Size = new System.Drawing.Size(27, 27);
            this.pnl_ErrorUserName.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(comboBox1);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(129, 431);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 64);
            this.panel5.TabIndex = 6;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox4.Image = global::DemoDoAn.Properties.Resources.shield_interrogation;
            this.pictureBox4.Location = new System.Drawing.Point(7, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(127)))), ((int)(((byte)(245)))));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 63);
            this.panel6.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(74, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(520, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Please contact Wall Street English for advice on the most effective learning rout" +
    "e!\r\nWe will contact you as soon as possible.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.pictureBox_HidePass);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.txt_Password);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(129, 344);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 64);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox_HidePass
            // 
            this.pictureBox_HidePass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_HidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_HidePass.Image = global::DemoDoAn.Properties.Resources.eye;
            this.pictureBox_HidePass.Location = new System.Drawing.Point(334, 9);
            this.pictureBox_HidePass.Name = "pictureBox_HidePass";
            this.pictureBox_HidePass.Size = new System.Drawing.Size(46, 50);
            this.pictureBox_HidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_HidePass.TabIndex = 5;
            this.pictureBox_HidePass.TabStop = false;
            this.pictureBox_HidePass.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = global::DemoDoAn.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(6, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.20339F, System.Drawing.FontStyle.Italic);
            this.txt_Password.ForeColor = System.Drawing.Color.Silver;
            this.txt_Password.Location = new System.Drawing.Point(68, 18);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(260, 24);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.Text = "password";
            this.txt_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Password_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(127)))), ((int)(((byte)(245)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 80);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(127)))), ((int)(((byte)(245)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(129, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 63);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txt_Username);
            this.panel3.Location = new System.Drawing.Point(129, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 63);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::DemoDoAn.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.20339F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.Silver;
            this.txt_Username.Location = new System.Drawing.Point(69, 16);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(259, 24);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.Text = "username";
            this.txt_Username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Username_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::DemoDoAn.Properties.Resources.ThanhLogin_3x;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.762712F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(219, 138);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(200, 3);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BackgroundImage = global::DemoDoAn.Properties.Resources.ThanhLogin_3x;
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.762712F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Login.Location = new System.Drawing.Point(166, 592);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Login.Size = new System.Drawing.Size(308, 60);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "L O G I N";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // checkbox_Remember
            // 
            this.checkbox_Remember.AutoSize = true;
            this.checkbox_Remember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkbox_Remember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_Remember.FlatAppearance.BorderSize = 5;
            this.checkbox_Remember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_Remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.762712F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_Remember.Location = new System.Drawing.Point(138, 505);
            this.checkbox_Remember.Name = "checkbox_Remember";
            this.checkbox_Remember.Size = new System.Drawing.Size(109, 24);
            this.checkbox_Remember.TabIndex = 2;
            this.checkbox_Remember.Text = "Remember";
            this.checkbox_Remember.UseVisualStyleBackColor = true;
            // 
            // lbl_CreateAccount
            // 
            this.lbl_CreateAccount.AutoSize = true;
            this.lbl_CreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.152542F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAccount.ForeColor = System.Drawing.Color.Green;
            this.lbl_CreateAccount.Location = new System.Drawing.Point(407, 509);
            this.lbl_CreateAccount.Name = "lbl_CreateAccount";
            this.lbl_CreateAccount.Size = new System.Drawing.Size(120, 20);
            this.lbl_CreateAccount.TabIndex = 0;
            this.lbl_CreateAccount.Text = "Create Account";
            this.lbl_CreateAccount.Click += new System.EventHandler(this.lbl_CreateAccount_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0339F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(163)))), ((int)(((byte)(252)))));
            this.lbl_Login.Location = new System.Drawing.Point(212, 89);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(212, 29);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "LOGIN ACCOUNT";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // pnl_LoginLeft
            // 
            this.pnl_LoginLeft.BackgroundImage = global::DemoDoAn.Properties.Resources.Login_LEFT;
            this.pnl_LoginLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_LoginLeft.Controls.Add(this.label3);
            this.pnl_LoginLeft.Controls.Add(this.label2);
            this.pnl_LoginLeft.Controls.Add(this.label1);
            this.pnl_LoginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_LoginLeft.Location = new System.Drawing.Point(0, 0);
            this.pnl_LoginLeft.Name = "pnl_LoginLeft";
            this.pnl_LoginLeft.Size = new System.Drawing.Size(689, 754);
            this.pnl_LoginLeft.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Learning English at Wall Street English is not merely a course,\r\nbut also an expe" +
    "rience.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(54, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "WELCOM TO ENGLISH CENTER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.0339F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nice to see you again!";
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 754);
            this.Controls.Add(this.pnl_LoginRight);
            this.Controls.Add(this.pnl_LoginLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENGLISH CENTER";
            this.pnl_LoginRight.ResumeLayout(false);
            this.pnl_LoginRight.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnl_LoginLeft.ResumeLayout(false);
            this.pnl_LoginLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_LoginLeft;
        private System.Windows.Forms.Panel pnl_LoginRight;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.CheckBox checkbox_Remember;
        private System.Windows.Forms.Label lbl_CreateAccount;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_HidePass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnl_ErrorUserName;
        private System.Windows.Forms.Panel pnl_ErrorPassword;
    }
}

