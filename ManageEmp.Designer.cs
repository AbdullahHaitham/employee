namespace EmployeeSystem
{
    partial class ManageEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmp));
            this.Add_Employee = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Modifybutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Name1text = new System.Windows.Forms.TextBox();
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.Salarytext = new System.Windows.Forms.TextBox();
            this.DepartmentBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Name2text = new System.Windows.Forms.TextBox();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.employee_systemDataSet = new EmployeeSystem.employee_systemDataSet();
            this.employeesystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Backbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.employee_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesystemDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Employee
            // 
            this.Add_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Add_Employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Employee.Font = new System.Drawing.Font("Sitka Heading", 10F);
            this.Add_Employee.ForeColor = System.Drawing.Color.White;
            this.Add_Employee.Location = new System.Drawing.Point(33, 376);
            this.Add_Employee.Name = "Add_Employee";
            this.Add_Employee.Size = new System.Drawing.Size(122, 32);
            this.Add_Employee.TabIndex = 1;
            this.Add_Employee.Text = "Add Employee";
            this.Add_Employee.UseVisualStyleBackColor = false;
            this.Add_Employee.Click += new System.EventHandler(this.Add_Employee_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Sitka Heading", 10F);
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Location = new System.Drawing.Point(432, 376);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(121, 32);
            this.Deletebutton.TabIndex = 2;
            this.Deletebutton.Text = "Delete Employee";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Modifybutton
            // 
            this.Modifybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Modifybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifybutton.Font = new System.Drawing.Font("Sitka Heading", 10F);
            this.Modifybutton.ForeColor = System.Drawing.Color.White;
            this.Modifybutton.Location = new System.Drawing.Point(161, 376);
            this.Modifybutton.Name = "Modifybutton";
            this.Modifybutton.Size = new System.Drawing.Size(121, 32);
            this.Modifybutton.TabIndex = 3;
            this.Modifybutton.Text = "Modify Employee";
            this.Modifybutton.UseVisualStyleBackColor = false;
            this.Modifybutton.Click += new System.EventHandler(this.Modifybutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label5.Location = new System.Drawing.Point(29, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salary:-";
            // 
            // Name1text
            // 
            this.Name1text.BackColor = System.Drawing.Color.White;
            this.Name1text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name1text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Name1text.Location = new System.Drawing.Point(126, 165);
            this.Name1text.Name = "Name1text";
            this.Name1text.Size = new System.Drawing.Size(100, 13);
            this.Name1text.TabIndex = 9;
            this.Name1text.TextChanged += new System.EventHandler(this.Name1text_TextChanged);
            // 
            // Emailtext
            // 
            this.Emailtext.BackColor = System.Drawing.Color.White;
            this.Emailtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emailtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Emailtext.Location = new System.Drawing.Point(126, 203);
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(100, 13);
            this.Emailtext.TabIndex = 10;
            this.Emailtext.TextChanged += new System.EventHandler(this.Emailtext_TextChanged);
            // 
            // Passwordtext
            // 
            this.Passwordtext.BackColor = System.Drawing.Color.White;
            this.Passwordtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Passwordtext.Location = new System.Drawing.Point(128, 242);
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.PasswordChar = '*';
            this.Passwordtext.Size = new System.Drawing.Size(100, 13);
            this.Passwordtext.TabIndex = 11;
            this.Passwordtext.TextChanged += new System.EventHandler(this.Passwordtext_TextChanged);
            // 
            // Salarytext
            // 
            this.Salarytext.BackColor = System.Drawing.Color.White;
            this.Salarytext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Salarytext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Salarytext.Location = new System.Drawing.Point(128, 320);
            this.Salarytext.Name = "Salarytext";
            this.Salarytext.Size = new System.Drawing.Size(121, 13);
            this.Salarytext.TabIndex = 12;
            this.Salarytext.TextChanged += new System.EventHandler(this.Salarytext_TextChanged);
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.FormattingEnabled = true;
            this.DepartmentBox.Location = new System.Drawing.Point(128, 276);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(121, 21);
            this.DepartmentBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label7.Location = new System.Drawing.Point(392, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID:-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Name2text
            // 
            this.Name2text.BackColor = System.Drawing.Color.White;
            this.Name2text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name2text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Name2text.Location = new System.Drawing.Point(470, 164);
            this.Name2text.Name = "Name2text";
            this.Name2text.Size = new System.Drawing.Size(100, 13);
            this.Name2text.TabIndex = 16;
            this.Name2text.TextChanged += new System.EventHandler(this.Name2text_TextChanged);
            // 
            // IDtext
            // 
            this.IDtext.BackColor = System.Drawing.Color.White;
            this.IDtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.IDtext.Location = new System.Drawing.Point(470, 224);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(100, 13);
            this.IDtext.TabIndex = 17;
            this.IDtext.TextChanged += new System.EventHandler(this.IDtext_TextChanged);
            // 
            // employee_systemDataSet
            // 
            this.employee_systemDataSet.DataSetName = "employee_systemDataSet";
            this.employee_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesystemDataSetBindingSource
            // 
            this.employeesystemDataSetBindingSource.DataSource = this.employee_systemDataSet;
            this.employeesystemDataSetBindingSource.Position = 0;
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbutton.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.Color.White;
            this.Backbutton.Location = new System.Drawing.Point(-7, 0);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(154, 98);
            this.Backbutton.TabIndex = 18;
            this.Backbutton.Text = "               Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Backbutton);
            this.panel1.Location = new System.Drawing.Point(-3, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 95);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label2.Location = new System.Drawing.Point(29, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label3.Location = new System.Drawing.Point(29, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 12F);
            this.label4.Location = new System.Drawing.Point(29, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(470, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 1);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(128, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 1);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(470, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 1);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel5.Location = new System.Drawing.Point(126, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 1);
            this.panel5.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel6.Location = new System.Drawing.Point(126, 180);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 1);
            this.panel6.TabIndex = 32;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel7.Location = new System.Drawing.Point(129, 335);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 1);
            this.panel7.TabIndex = 33;
            // 
            // ManageEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 428);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.Name2text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.Salarytext);
            this.Controls.Add(this.Passwordtext);
            this.Controls.Add(this.Emailtext);
            this.Controls.Add(this.Name1text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Modifybutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Add_Employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEmp";
            this.Load += new System.EventHandler(this.ManageEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesystemDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Employee;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Modifybutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Name1text;
        private System.Windows.Forms.TextBox Emailtext;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.TextBox Salarytext;
        private System.Windows.Forms.ComboBox DepartmentBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Name2text;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.BindingSource employeesystemDataSetBindingSource;
        private employee_systemDataSet employee_systemDataSet;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}