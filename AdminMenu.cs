using EmployeeSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeSystem
{
    public partial class AdminMenu : Form
    {
        private const string connectionString= "Data Source=AMAR-HAITHAM;Initial Catalog=\"employee system\";Integrated Security=True";

        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            PositionBox.Items.Add("HR Admin");
            PositionBox.Items.Add("Payroll Admin");
            PositionBox.Items.Add("Access Control Admin");
            PositionBox.Items.Add("Manager Admin");
            PositionBox.SelectedIndex = 0;


            DepartmentBox.Items.Add("Sales Department");
            DepartmentBox.Items.Add("Marketing Department");
            DepartmentBox.Items.Add("Human Resources");
            DepartmentBox.Items.Add("Customer Service");
            DepartmentBox.SelectedIndex = 0;
        }

        private void Nametext_TextChanged(object sender, EventArgs e)
        {

        }
        private void PositionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool IsAlphabetic(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private void Signup_button_Click(object sender, EventArgs e)
        {
            string Name = Nametext.Text;
            string Email = Emailtext.Text;
            string Password = Passwordtext.Text;
            string selectedRole = PositionBox.SelectedItem.ToString();
            string selectedDepartment = DepartmentBox.SelectedItem.ToString();
            string Gender = "Rather to say";

            if (Gender1.Checked)
            {
                // Male gender is selected
                // Perform the appropriate action for male
                Gender = "Male";
            }
            else if (Gender2.Checked)
            {
                // Female gender is selected
                // Perform the appropriate action for female
                Gender = "Female";
            }
            if (!IsAlphabetic(Name))
            {
                MessageBox.Show("Please enter a valid name (only alphabetic characters are allowed).");
                return;
            }

            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password) )
            {
                MessageBox.Show("Please enter valid details.");
                return;
            }

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                  
                    string query = "INSERT INTO Admin (Name, Email, Role, Password, Department, Gender) " +
                           "VALUES (@Name, @Email, @Role, @Password, @Department,@Gender);SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters and their values
                        command.Parameters.AddWithValue("@Name", Name); 
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Role", selectedRole);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Department", selectedDepartment);
                        command.Parameters.AddWithValue("@Gender", Gender);


                        // Open the connection
                        connection.Open();

                        // Execute the query
                        command.ExecuteNonQuery();

                        
                        connection.Close();

                        MessageBox.Show("Admin details added successfully.");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string Email = Emailtext2.Text;
            string Password = Passwordtext2.Text;

            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter valid details.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();

                    // Convert the 'text' column to 'nvarchar' before comparison
                    command.CommandText = "SELECT AdminID FROM Admin WHERE CAST(Email AS NVARCHAR(MAX)) = @Email AND CAST(Password AS NVARCHAR(MAX)) = @Password";
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int AdminID = Convert.ToInt32(result);

                        MessageBox.Show("Sign-in successful!");

                        ManageEmp manageEmp = new ManageEmp();
                        manageEmp.Show();
                        Visible = false;
                     
                    }
                    else
                    {
                        MessageBox.Show("Invalid admin credentials. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error signing in: " + ex.Message);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            Nametext.Clear();
            Emailtext.Clear();
            Passwordtext.Clear();
        }

        private void Gender1_CheckedChanged(object sender, EventArgs e)
        {

        }

   

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form form = new mainmenu();
            form.Show();  
            Visible = false;
        }

        private void Emailtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emailtext2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtext2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gender2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
