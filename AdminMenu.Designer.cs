namespace EmployeeSystem
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.Signup_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nametext = new System.Windows.Forms.TextBox();
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.PositionBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DepartmentBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Emailtext2 = new System.Windows.Forms.TextBox();
            this.Passwordtext2 = new System.Windows.Forms.TextBox();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Gender1 = new System.Windows.Forms.RadioButton();
            this.Gender2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Signup_button
            // 
            this.Signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Signup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup_button.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup_button.ForeColor = System.Drawing.Color.White;
            this.Signup_button.Location = new System.Drawing.Point(284, 382);
            this.Signup_button.Name = "Signup_button";
            this.Signup_button.Size = new System.Drawing.Size(81, 36);
            this.Signup_button.TabIndex = 0;
            this.Signup_button.Text = "SignUp";
            this.Signup_button.UseVisualStyleBackColor = false;
            this.Signup_button.Click += new System.EventHandler(this.Signup_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label1.Location = new System.Drawing.Point(32, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label2.Location = new System.Drawing.Point(32, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label3.Location = new System.Drawing.Point(32, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Role:";
            // 
            // Nametext
            // 
            this.Nametext.BackColor = System.Drawing.Color.White;
            this.Nametext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nametext.Location = new System.Drawing.Point(132, 142);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(100, 13);
            this.Nametext.TabIndex = 4;
            this.Nametext.TextChanged += new System.EventHandler(this.Nametext_TextChanged);
            // 
            // Emailtext
            // 
            this.Emailtext.BackColor = System.Drawing.Color.White;
            this.Emailtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emailtext.Location = new System.Drawing.Point(132, 187);
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(100, 13);
            this.Emailtext.TabIndex = 5;
            this.Emailtext.TextChanged += new System.EventHandler(this.Emailtext_TextChanged);
            // 
            // PositionBox
            // 
            this.PositionBox.Font = new System.Drawing.Font("Sitka Heading", 8F);
            this.PositionBox.FormattingEnabled = true;
            this.PositionBox.Location = new System.Drawing.Point(131, 263);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(121, 24);
            this.PositionBox.TabIndex = 6;
            this.PositionBox.SelectedIndexChanged += new System.EventHandler(this.PositionBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label4.Location = new System.Drawing.Point(31, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department:";
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.Font = new System.Drawing.Font("Sitka Heading", 8F);
            this.DepartmentBox.FormattingEnabled = true;
            this.DepartmentBox.Location = new System.Drawing.Point(131, 295);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(121, 24);
            this.DepartmentBox.TabIndex = 8;
            this.DepartmentBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name:";
            // 
            // Passwordtext
            // 
            this.Passwordtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtext.Location = new System.Drawing.Point(132, 226);
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.PasswordChar = '*';
            this.Passwordtext.Size = new System.Drawing.Size(100, 13);
            this.Passwordtext.TabIndex = 10;
            this.Passwordtext.TextChanged += new System.EventHandler(this.Passwordtext_TextChanged);
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutton.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.White;
            this.Loginbutton.Location = new System.Drawing.Point(540, 382);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 36);
            this.Loginbutton.TabIndex = 11;
            this.Loginbutton.Text = "LogIn";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label6.Location = new System.Drawing.Point(476, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label7.Location = new System.Drawing.Point(476, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password:";
            // 
            // Emailtext2
            // 
            this.Emailtext2.BackColor = System.Drawing.Color.White;
            this.Emailtext2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emailtext2.Location = new System.Drawing.Point(561, 116);
            this.Emailtext2.Name = "Emailtext2";
            this.Emailtext2.Size = new System.Drawing.Size(100, 13);
            this.Emailtext2.TabIndex = 14;
            this.Emailtext2.TextChanged += new System.EventHandler(this.Emailtext2_TextChanged);
            // 
            // Passwordtext2
            // 
            this.Passwordtext2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtext2.Location = new System.Drawing.Point(564, 170);
            this.Passwordtext2.Name = "Passwordtext2";
            this.Passwordtext2.PasswordChar = '*';
            this.Passwordtext2.Size = new System.Drawing.Size(100, 13);
            this.Passwordtext2.TabIndex = 15;
            this.Passwordtext2.TextChanged += new System.EventHandler(this.Passwordtext2_TextChanged);
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Clearbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.ForeColor = System.Drawing.Color.White;
            this.Clearbutton.Location = new System.Drawing.Point(380, 382);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(80, 36);
            this.Clearbutton.TabIndex = 16;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Gender1
            // 
            this.Gender1.AutoSize = true;
            this.Gender1.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.Gender1.Location = new System.Drawing.Point(106, 353);
            this.Gender1.Name = "Gender1";
            this.Gender1.Size = new System.Drawing.Size(60, 27);
            this.Gender1.TabIndex = 17;
            this.Gender1.TabStop = true;
            this.Gender1.Text = "Male";
            this.Gender1.UseVisualStyleBackColor = true;
            this.Gender1.CheckedChanged += new System.EventHandler(this.Gender1_CheckedChanged);
            // 
            // Gender2
            // 
            this.Gender2.AutoSize = true;
            this.Gender2.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.Gender2.Location = new System.Drawing.Point(172, 353);
            this.Gender2.Name = "Gender2";
            this.Gender2.Size = new System.Drawing.Size(75, 27);
            this.Gender2.TabIndex = 18;
            this.Gender2.TabStop = true;
            this.Gender2.Text = "Female";
            this.Gender2.UseVisualStyleBackColor = true;
            this.Gender2.CheckedChanged += new System.EventHandler(this.Gender2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label8.Location = new System.Drawing.Point(32, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gender";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, -9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 105);
            this.button4.TabIndex = 20;
            this.button4.Text = "             Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(-22, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 91);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(132, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 1);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(131, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 1);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(561, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 1);
            this.panel4.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel6.Location = new System.Drawing.Point(561, 131);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 1);
            this.panel6.TabIndex = 26;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel7.Location = new System.Drawing.Point(132, 199);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 1);
            this.panel7.TabIndex = 27;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Gender2);
            this.Controls.Add(this.Gender1);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Passwordtext2);
            this.Controls.Add(this.Emailtext2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.Passwordtext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.Emailtext);
            this.Controls.Add(this.Nametext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Signup_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Signup_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nametext;
        private System.Windows.Forms.TextBox Emailtext;
        private System.Windows.Forms.ComboBox PositionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DepartmentBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Emailtext2;
        private System.Windows.Forms.TextBox Passwordtext2;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.RadioButton Gender1;
        private System.Windows.Forms.RadioButton Gender2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}