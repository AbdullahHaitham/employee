using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeSystem
{
    public partial class ManageEmp : Form
    {
            
        private const string connectionString = "Data Source=AMAR-HAITHAM;Initial Catalog=\"employee system\";Integrated Security=True";

        public ManageEmp()
        {
            InitializeComponent();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            string Name = Name2text.Text;
            string input = IDtext.Text; // Get the input from the TextBox as a string

            int EmployeeID;
            int.TryParse(input, out EmployeeID);

            if (string.IsNullOrWhiteSpace(Name) )
            {
                MessageBox.Show("Please enter a valid ID and Name.");
                return;
            }
            if (!int.TryParse(input, out EmployeeID))
            {
                MessageBox.Show("Please enter a valid ID and Name.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();

                    command.CommandText = "DELETE FROM Employee WHERE Name LIKE @Name AND EmployeeID LIKE @EmployeeID";
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Employee not found. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Deleting Employee: " + ex.Message);
            }
        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            string Name = Name1text.Text;
            string Email = Emailtext.Text;
            string Password = Passwordtext.Text;
            string Salary = Salarytext.Text;
            string Department = DepartmentBox.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(Name)|| string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(Salary) )
            {
                MessageBox.Show("Please enter valid credentials.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
         
                    command.CommandText = "INSERT INTO Employee (Name,Email,Password,Salary,Department) VALUES (@Name, @Email,@Password,@Salary,@Department);SELECT SCOPE_IDENTITY()";
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Salary", Salary);
                    command.Parameters.AddWithValue("@Department", Department);
         
                    int EmployeeID = Convert.ToInt32(command.ExecuteScalar());

                    if (EmployeeID > 0)
                    {
                        MessageBox.Show("Employee Added!");

                    }
                    else
                    {
                        MessageBox.Show("Error, Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void ManageEmp_Load(object sender, EventArgs e)
        {

            DepartmentBox.Items.Add("Sales Department");
            DepartmentBox.Items.Add("Marketing Department");
            DepartmentBox.Items.Add("Human Resources");
            DepartmentBox.Items.Add("Customer Service");
            DepartmentBox.SelectedIndex = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Modifybutton_Click(object sender, EventArgs e)
        {
           ModifyEmp modifyEmp = new ModifyEmp();
            modifyEmp.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form form = new AdminMenu();
            form.Show();
            Visible = false;
        }

        private void Name1text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emailtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salarytext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name2text_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
