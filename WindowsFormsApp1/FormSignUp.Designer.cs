namespace WindowsFormsApp1
{
    partial class FormSignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 1);
            this.panel1.TabIndex = 6;
            // 
            // txtAccountName
            // 
            this.txtAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.ForeColor = System.Drawing.Color.White;
            this.txtAccountName.Location = new System.Drawing.Point(61, 113);
            this.txtAccountName.Multiline = true;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(246, 20);
            this.txtAccountName.TabIndex = 5;
            this.txtAccountName.Text = "Account name";
            this.txtAccountName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick_1);
            this.txtAccountName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Doubleclicked_1);
            this.txtAccountName.MouseEnter += new System.EventHandler(this.MouseENter_account);
            this.txtAccountName.MouseLeave += new System.EventHandler(this.MouseLeave_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(24, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 1);
            this.panel2.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(62, 167);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "Email address";
            this.txtEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick_2);
            this.txtEmail.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Doubleclicked_2);
            this.txtEmail.MouseEnter += new System.EventHandler(this.MouseEnter_2);
            this.txtEmail.MouseLeave += new System.EventHandler(this.MouseLeave_2);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(22, 308);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 1);
            this.panel4.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(60, 277);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "Password";
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick_4);
            this.txtPassword.TextChanged += new System.EventHandler(this.Text_Change_PassWord);
            this.txtPassword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Doubleclicked_4);
            this.txtPassword.MouseEnter += new System.EventHandler(this.MouseEnter_4);
            this.txtPassword.MouseLeave += new System.EventHandler(this.MouseLeave_4);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(22, 367);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(283, 1);
            this.panel5.TabIndex = 15;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.ForeColor = System.Drawing.Color.White;
            this.txtConfirm.Location = new System.Drawing.Point(60, 336);
            this.txtConfirm.Multiline = true;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(246, 20);
            this.txtConfirm.TabIndex = 14;
            this.txtConfirm.Text = "Confirm password";
            this.txtConfirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseClick_5);
            this.txtConfirm.TextChanged += new System.EventHandler(this.Text_Changed_Confirm);
            this.txtConfirm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Doubleclicked_5);
            this.txtConfirm.MouseEnter += new System.EventHandler(this.MouseEnter_5);
            this.txtConfirm.MouseLeave += new System.EventHandler(this.MouseLeave_5);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(22, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 1);
            this.panel3.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(60, 221);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(246, 20);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.Text = "Phone number";
            this.txtPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MousClick_3);
            this.txtPhone.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Doubleclicked_3);
            this.txtPhone.MouseEnter += new System.EventHandler(this.MouseEnter_3);
            this.txtPhone.MouseLeave += new System.EventHandler(this.MouseLeave_3);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(184, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.telephone_2;
            this.pictureBox4.Location = new System.Drawing.Point(23, 219);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.log_in_22;
            this.pictureBox6.Location = new System.Drawing.Point(23, 334);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.unlock_1;
            this.pictureBox5.Location = new System.Drawing.Point(23, 275);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.email_21;
            this.pictureBox3.Location = new System.Drawing.Point(25, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.user_2;
            this.pictureBox2.Location = new System.Drawing.Point(25, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.paper_plane;
            this.pictureBox1.Location = new System.Drawing.Point(134, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(329, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}