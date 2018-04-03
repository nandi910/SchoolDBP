namespace SchoolDBP
{
    partial class RegisterForm
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
            this.usernameBox = new System.Windows.Forms.RichTextBox();
            this.passwordBox = new System.Windows.Forms.RichTextBox();
            this.firstNameBox = new System.Windows.Forms.RichTextBox();
            this.lastNameBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.year1rad = new System.Windows.Forms.RadioButton();
            this.year2rad = new System.Windows.Forms.RadioButton();
            this.year3rad = new System.Windows.Forms.RadioButton();
            this.year4rad = new System.Windows.Forms.RadioButton();
            this.semester1rad = new System.Windows.Forms.RadioButton();
            this.semester2rad = new System.Windows.Forms.RadioButton();
            this.spec1rad = new System.Windows.Forms.RadioButton();
            this.spec2rad = new System.Windows.Forms.RadioButton();
            this.spec3rad = new System.Windows.Forms.RadioButton();
            this.spec4rad = new System.Windows.Forms.RadioButton();
            this.yearGBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.sendEmail = new System.Windows.Forms.Button();
            this.verifyBox = new System.Windows.Forms.RichTextBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.yearGBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(12, 12);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(137, 27);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.Text = "";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 45);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(137, 27);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.Text = "";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(12, 78);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(137, 27);
            this.firstNameBox.TabIndex = 2;
            this.firstNameBox.Text = "";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(12, 111);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(137, 27);
            this.lastNameBox.TabIndex = 3;
            this.lastNameBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(12, 144);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(137, 27);
            this.emailBox.TabIndex = 7;
            this.emailBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "E-mail";
            // 
            // year1rad
            // 
            this.year1rad.AutoSize = true;
            this.year1rad.Location = new System.Drawing.Point(6, 19);
            this.year1rad.Name = "year1rad";
            this.year1rad.Size = new System.Drawing.Size(56, 17);
            this.year1rad.TabIndex = 16;
            this.year1rad.TabStop = true;
            this.year1rad.Text = "Year 1";
            this.year1rad.UseVisualStyleBackColor = true;
            this.year1rad.CheckedChanged += new System.EventHandler(this.year1rad_CheckedChanged);
            // 
            // year2rad
            // 
            this.year2rad.AutoSize = true;
            this.year2rad.Location = new System.Drawing.Point(68, 19);
            this.year2rad.Name = "year2rad";
            this.year2rad.Size = new System.Drawing.Size(56, 17);
            this.year2rad.TabIndex = 17;
            this.year2rad.TabStop = true;
            this.year2rad.Text = "Year 2";
            this.year2rad.UseVisualStyleBackColor = true;
            this.year2rad.CheckedChanged += new System.EventHandler(this.year2rad_CheckedChanged);
            // 
            // year3rad
            // 
            this.year3rad.AutoSize = true;
            this.year3rad.Location = new System.Drawing.Point(130, 19);
            this.year3rad.Name = "year3rad";
            this.year3rad.Size = new System.Drawing.Size(56, 17);
            this.year3rad.TabIndex = 18;
            this.year3rad.TabStop = true;
            this.year3rad.Text = "Year 3";
            this.year3rad.UseVisualStyleBackColor = true;
            this.year3rad.CheckedChanged += new System.EventHandler(this.year3rad_CheckedChanged);
            // 
            // year4rad
            // 
            this.year4rad.AutoSize = true;
            this.year4rad.Location = new System.Drawing.Point(192, 19);
            this.year4rad.Name = "year4rad";
            this.year4rad.Size = new System.Drawing.Size(56, 17);
            this.year4rad.TabIndex = 19;
            this.year4rad.TabStop = true;
            this.year4rad.Text = "Year 4";
            this.year4rad.UseVisualStyleBackColor = true;
            this.year4rad.CheckedChanged += new System.EventHandler(this.year4rad_CheckedChanged);
            // 
            // semester1rad
            // 
            this.semester1rad.AutoSize = true;
            this.semester1rad.Location = new System.Drawing.Point(6, 15);
            this.semester1rad.Name = "semester1rad";
            this.semester1rad.Size = new System.Drawing.Size(78, 17);
            this.semester1rad.TabIndex = 20;
            this.semester1rad.TabStop = true;
            this.semester1rad.Text = "Semester 1";
            this.semester1rad.UseVisualStyleBackColor = true;
            this.semester1rad.CheckedChanged += new System.EventHandler(this.semester1rad_CheckedChanged);
            // 
            // semester2rad
            // 
            this.semester2rad.AutoSize = true;
            this.semester2rad.Location = new System.Drawing.Point(90, 15);
            this.semester2rad.Name = "semester2rad";
            this.semester2rad.Size = new System.Drawing.Size(78, 17);
            this.semester2rad.TabIndex = 21;
            this.semester2rad.TabStop = true;
            this.semester2rad.Text = "Semester 2";
            this.semester2rad.UseVisualStyleBackColor = true;
            this.semester2rad.CheckedChanged += new System.EventHandler(this.semester2rad_CheckedChanged);
            // 
            // spec1rad
            // 
            this.spec1rad.AutoSize = true;
            this.spec1rad.Location = new System.Drawing.Point(6, 23);
            this.spec1rad.Name = "spec1rad";
            this.spec1rad.Size = new System.Drawing.Size(40, 17);
            this.spec1rad.TabIndex = 22;
            this.spec1rad.TabStop = true;
            this.spec1rad.Text = "AR";
            this.spec1rad.UseVisualStyleBackColor = true;
            this.spec1rad.CheckedChanged += new System.EventHandler(this.spec1rad_CheckedChanged);
            // 
            // spec2rad
            // 
            this.spec2rad.AutoSize = true;
            this.spec2rad.Location = new System.Drawing.Point(52, 23);
            this.spec2rad.Name = "spec2rad";
            this.spec2rad.Size = new System.Drawing.Size(56, 17);
            this.spec2rad.TabIndex = 23;
            this.spec2rad.TabStop = true;
            this.spec2rad.Text = "ROBO";
            this.spec2rad.UseVisualStyleBackColor = true;
            this.spec2rad.CheckedChanged += new System.EventHandler(this.spec2rad_CheckedChanged);
            // 
            // spec3rad
            // 
            this.spec3rad.AutoSize = true;
            this.spec3rad.Location = new System.Drawing.Point(114, 23);
            this.spec3rad.Name = "spec3rad";
            this.spec3rad.Size = new System.Drawing.Size(48, 17);
            this.spec3rad.TabIndex = 24;
            this.spec3rad.TabStop = true;
            this.spec3rad.Text = "TCM";
            this.spec3rad.UseVisualStyleBackColor = true;
            this.spec3rad.CheckedChanged += new System.EventHandler(this.spec3rad_CheckedChanged);
            // 
            // spec4rad
            // 
            this.spec4rad.AutoSize = true;
            this.spec4rad.Location = new System.Drawing.Point(168, 23);
            this.spec4rad.Name = "spec4rad";
            this.spec4rad.Size = new System.Drawing.Size(52, 17);
            this.spec4rad.TabIndex = 25;
            this.spec4rad.TabStop = true;
            this.spec4rad.Text = "IEDM";
            this.spec4rad.UseVisualStyleBackColor = true;
            this.spec4rad.CheckedChanged += new System.EventHandler(this.spec4rad_CheckedChanged);
            // 
            // yearGBox
            // 
            this.yearGBox.Controls.Add(this.year1rad);
            this.yearGBox.Controls.Add(this.year2rad);
            this.yearGBox.Controls.Add(this.year3rad);
            this.yearGBox.Controls.Add(this.year4rad);
            this.yearGBox.Location = new System.Drawing.Point(12, 177);
            this.yearGBox.Name = "yearGBox";
            this.yearGBox.Size = new System.Drawing.Size(256, 44);
            this.yearGBox.TabIndex = 26;
            this.yearGBox.TabStop = false;
            this.yearGBox.Text = "Year";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.semester1rad);
            this.groupBox1.Controls.Add(this.semester2rad);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 38);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.spec1rad);
            this.groupBox2.Controls.Add(this.spec2rad);
            this.groupBox2.Controls.Add(this.spec3rad);
            this.groupBox2.Controls.Add(this.spec4rad);
            this.groupBox2.Location = new System.Drawing.Point(13, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 46);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(677, 295);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 29;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sendEmail
            // 
            this.sendEmail.Location = new System.Drawing.Point(275, 295);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(75, 26);
            this.sendEmail.TabIndex = 30;
            this.sendEmail.Text = "Register";
            this.sendEmail.UseVisualStyleBackColor = true;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // verifyBox
            // 
            this.verifyBox.Location = new System.Drawing.Point(356, 294);
            this.verifyBox.Name = "verifyBox";
            this.verifyBox.Size = new System.Drawing.Size(137, 27);
            this.verifyBox.TabIndex = 31;
            this.verifyBox.Text = "";
            // 
            // verifyBtn
            // 
            this.verifyBtn.Location = new System.Drawing.Point(500, 294);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(80, 27);
            this.verifyBtn.TabIndex = 32;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 328);
            this.ControlBox = false;
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.verifyBox);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.yearGBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.yearGBox.ResumeLayout(false);
            this.yearGBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox usernameBox;
        private System.Windows.Forms.RichTextBox passwordBox;
        private System.Windows.Forms.RichTextBox firstNameBox;
        private System.Windows.Forms.RichTextBox lastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox emailBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton year1rad;
        private System.Windows.Forms.RadioButton year2rad;
        private System.Windows.Forms.RadioButton year3rad;
        private System.Windows.Forms.RadioButton year4rad;
        private System.Windows.Forms.RadioButton semester1rad;
        private System.Windows.Forms.RadioButton semester2rad;
        private System.Windows.Forms.RadioButton spec1rad;
        private System.Windows.Forms.RadioButton spec2rad;
        private System.Windows.Forms.RadioButton spec3rad;
        private System.Windows.Forms.RadioButton spec4rad;
        private System.Windows.Forms.GroupBox yearGBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button sendEmail;
        private System.Windows.Forms.RichTextBox verifyBox;
        private System.Windows.Forms.Button verifyBtn;
    }
}

