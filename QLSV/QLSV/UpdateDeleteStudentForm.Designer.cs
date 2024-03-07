namespace QLSV
{
    partial class UpdateDeleteStudentForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(459, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(199, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(342, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 35);
            this.button3.TabIndex = 6;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Search_Click);
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Location = new System.Drawing.Point(199, 262);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(58, 20);
            this.RadioButtonMale.TabIndex = 8;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            this.RadioButtonMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Location = new System.Drawing.Point(320, 262);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(74, 20);
            this.RadioButtonFemale.TabIndex = 9;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(188, 62);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(131, 22);
            this.TextBoxID.TabIndex = 12;
            this.TextBoxID.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Location = new System.Drawing.Point(188, 106);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(131, 22);
            this.TextBoxFname.TabIndex = 13;
            this.TextBoxFname.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.Location = new System.Drawing.Point(188, 159);
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(131, 22);
            this.TextBoxLname.TabIndex = 14;
            this.TextBoxLname.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(188, 305);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(131, 22);
            this.TextBoxPhone.TabIndex = 16;
            this.TextBoxPhone.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(567, 62);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(131, 22);
            this.TextBoxAddress.TabIndex = 17;
            this.TextBoxAddress.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Birthday";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Address";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(188, 214);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.DateTimePicker1.TabIndex = 25;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(567, 122);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(197, 160);
            this.PictureBoxStudentImage.TabIndex = 26;
            this.PictureBoxStudentImage.TabStop = false;
            this.PictureBoxStudentImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Picture";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Location = new System.Drawing.Point(454, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 38);
            this.button4.TabIndex = 28;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UpdateDeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLSV.Properties.Resources.wallpaperflare_com_wallpaper;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.RadioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UpdateDeleteStudentForm";
            this.Text = "UpdateAndDeleteStudent";
            this.Load += new System.EventHandler(this.UpdateDeleteStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.RadioButton RadioButtonMale;
        public System.Windows.Forms.RadioButton RadioButtonFemale;
        public System.Windows.Forms.TextBox TextBoxID;
        public System.Windows.Forms.TextBox TextBoxFname;
        public System.Windows.Forms.TextBox TextBoxLname;
        public System.Windows.Forms.TextBox TextBoxPhone;
        public System.Windows.Forms.TextBox TextBoxAddress;
        public System.Windows.Forms.DateTimePicker DateTimePicker1;
        public System.Windows.Forms.PictureBox PictureBoxStudentImage;
    }
}