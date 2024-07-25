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

namespace EmployeeSystem
{
    public partial class RegisterEmpForm : Form
    {
        private const string connectionString = "Data Source=AMAR-HAITHAM;Initial Catalog=\"employee system\";Integrated Security=True";
        
        public RegisterEmpForm()
        {
            InitializeComponent();
        }
   
        private void Login_button_Click(object sender, EventArgs e)
        {
            string Email = Emailtext.Text;
            string Password = Passwordtext.Text;

            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter valid employee name.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();

                    command.CommandText = "SELECT EmployeeID,Name FROM Employee WHERE Email LIKE @Email AND Password LIKE @Password";
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Password", Password);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int EmployeeID = reader.GetInt32(0);
                        string Name = reader.GetString(1);

                        MessageBox.Show("Employee found!");

                        EmployeeManager employeeManager = new EmployeeManager(Name, EmployeeID);
                        employeeManager.Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Employee not found. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Signing in: " + ex.Message);
            }
        }

        private void RegisterEmpForm_Load(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
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
    }
}
