namespace WindowsFormsApp1
{
    partial class FormNhanVien
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
            this.Information = new System.Windows.Forms.GroupBox();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Change = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.tBx_Phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBx_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdBtnFemale = new System.Windows.Forms.RadioButton();
            this.raBtn_Male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.DOBpicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tBx_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_EmployID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Information.SuspendLayout();
            this.EmployList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Information.Controls.Add(this.Btn_Cancel);
            this.Information.Controls.Add(this.Btn_Save);
            this.Information.Controls.Add(this.Btn_Change);
            this.Information.Controls.Add(this.Btn_Remove);
            this.Information.Controls.Add(this.Btn_Add);
            this.Information.Controls.Add(this.tBx_Phone);
            this.Information.Controls.Add(this.label6);
            this.Information.Controls.Add(this.tBx_Address);
            this.Information.Controls.Add(this.label5);
            this.Information.Controls.Add(this.rdBtnFemale);
            this.Information.Controls.Add(this.raBtn_Male);
            this.Information.Controls.Add(this.label4);
            this.Information.Controls.Add(this.DOBpicker);
            this.Information.Controls.Add(this.label3);
            this.Information.Controls.Add(this.tBx_name);
            this.Information.Controls.Add(this.label2);
            this.Information.Controls.Add(this.tbx_EmployID);
            this.Information.Controls.Add(this.label1);
            this.Information.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.ForeColor = System.Drawing.Color.Black;
            this.Information.Location = new System.Drawing.Point(9, 3);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(1005, 202);
            this.Information.TabIndex = 0;
            this.Information.TabStop = false;
            this.Information.Text = "Employ information";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Cancel.AutoSize = true;
            this.Btn_Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.Btn_Cancel.Location = new System.Drawing.Point(720, 133);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(92, 53);
            this.Btn_Cancel.TabIndex = 16;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Save.AutoSize = true;
            this.Btn_Save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.Black;
            this.Btn_Save.Location = new System.Drawing.Point(589, 133);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(92, 53);
            this.Btn_Save.TabIndex = 15;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Change
            // 
            this.Btn_Change.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Change.AutoSize = true;
            this.Btn_Change.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Change.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Change.ForeColor = System.Drawing.Color.Black;
            this.Btn_Change.Location = new System.Drawing.Point(455, 133);
            this.Btn_Change.Name = "Btn_Change";
            this.Btn_Change.Size = new System.Drawing.Size(92, 53);
            this.Btn_Change.TabIndex = 13;
            this.Btn_Change.Text = "Reset";
            this.Btn_Change.UseVisualStyleBackColor = false;
            this.Btn_Change.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Remove.AutoSize = true;
            this.Btn_Remove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Remove.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Remove.ForeColor = System.Drawing.Color.Black;
            this.Btn_Remove.Location = new System.Drawing.Point(319, 133);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(92, 53);
            this.Btn_Remove.TabIndex = 14;
            this.Btn_Remove.Text = "Remove";
            this.Btn_Remove.UseVisualStyleBackColor = false;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Add.AutoSize = true;
            this.Btn_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.Black;
            this.Btn_Add.Location = new System.Drawing.Point(184, 133);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(92, 53);
            this.Btn_Add.TabIndex = 2;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // tBx_Phone
            // 
            this.tBx_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBx_Phone.Location = new System.Drawing.Point(771, 74);
            this.tBx_Phone.Name = "tBx_Phone";
            this.tBx_Phone.Size = new System.Drawing.Size(202, 25);
            this.tBx_Phone.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(655, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone number";
            // 
            // tBx_Address
            // 
            this.tBx_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBx_Address.Location = new System.Drawing.Point(387, 71);
            this.tBx_Address.Name = "tBx_Address";
            this.tBx_Address.Size = new System.Drawing.Size(250, 25);
            this.tBx_Address.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // rdBtnFemale
            // 
            this.rdBtnFemale.AutoSize = true;
            this.rdBtnFemale.Location = new System.Drawing.Point(146, 74);
            this.rdBtnFemale.Name = "rdBtnFemale";
            this.rdBtnFemale.Size = new System.Drawing.Size(71, 24);
            this.rdBtnFemale.TabIndex = 8;
            this.rdBtnFemale.TabStop = true;
            this.rdBtnFemale.Text = "Female";
            this.rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // raBtn_Male
            // 
            this.raBtn_Male.AutoSize = true;
            this.raBtn_Male.Location = new System.Drawing.Point(72, 74);
            this.raBtn_Male.Name = "raBtn_Male";
            this.raBtn_Male.Size = new System.Drawing.Size(56, 24);
            this.raBtn_Male.TabIndex = 7;
            this.raBtn_Male.TabStop = true;
            this.raBtn_Male.Text = "Male";
            this.raBtn_Male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // DOBpicker
            // 
            this.DOBpicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DOBpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBpicker.Location = new System.Drawing.Point(771, 31);
            this.DOBpicker.Name = "DOBpicker";
            this.DOBpicker.Size = new System.Drawing.Size(202, 25);
            this.DOBpicker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of birth";
            // 
            // tBx_name
            // 
            this.tBx_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBx_name.Location = new System.Drawing.Point(387, 29);
            this.tBx_name.Name = "tBx_name";
            this.tBx_name.Size = new System.Drawing.Size(250, 25);
            this.tBx_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tbx_EmployID
            // 
            this.tbx_EmployID.Location = new System.Drawing.Point(31, 29);
            this.tbx_EmployID.Name = "tbx_EmployID";
            this.tbx_EmployID.Size = new System.Drawing.Size(250, 25);
            this.tbx_EmployID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // EmployList
            // 
            this.EmployList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployList.Controls.Add(this.dataGridView1);
            this.EmployList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployList.ForeColor = System.Drawing.Color.Black;
            this.EmployList.Location = new System.Drawing.Point(9, 224);
            this.EmployList.Name = "EmployList";
            this.EmployList.Size = new System.Drawing.Size(1008, 217);
            this.EmployList.TabIndex = 1;
            this.EmployList.TabStop = false;
            this.EmployList.Text = "List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.dataGridView1.Location = new System.Drawing.Point(5, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1000, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DOB";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Phone";
            this.Column6.Name = "Column6";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 453);
            this.Controls.Add(this.EmployList);
            this.Controls.Add(this.Information);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhanVien";
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.EmployList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.GroupBox EmployList;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.TextBox tbx_EmployID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBx_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DOBpicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button Btn_Change;
        private System.Windows.Forms.TextBox tBx_Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBx_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.RadioButton rdBtnFemale;
        private System.Windows.Forms.RadioButton raBtn_Male;
    }
}