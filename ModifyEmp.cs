using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeSystem
{
    public partial class ModifyEmp : Form
    {
        private const string connectionString = "Data Source=AMAR-HAITHAM;Initial Catalog=\"employee system\";Integrated Security=True";

        public ModifyEmp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModifyEmp_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT EmployeeID FROM Employee";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(selectQuery, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int employeeID = reader.GetInt32(0);
                        IdBox.Items.Add(employeeID);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
            TypeBox.Items.Add("Salary");
            TypeBox.Items.Add("Name");
            TypeBox.Items.Add("Email");
            TypeBox.Items.Add("Password");
            TypeBox.Items.Add("Department");
            TypeBox.SelectedIndex = 0;
        }

        private void IdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

  

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            connection.Open();

            command.CommandText = "SELECT* FROM Employee";

            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAttribute = TypeBox.SelectedItem.ToString();
   
            label2.Text = selectedAttribute + ":";
          
        }

        private void Modifybutton_Click(object sender, EventArgs e)
        {
            int selectedEmployeeID = int.Parse(IdBox.SelectedItem.ToString());
            string selectedAttribute = TypeBox.SelectedItem.ToString();
            string newValue = Nametext.Text; // Retrieve the modified value from the TextBox

            string updateQuery = $"UPDATE Employee SET {selectedAttribute} = @NewValue WHERE EmployeeID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@NewValue", newValue);
                command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee information updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No employee found with the selected ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        private void Nametext_TextChanged(object sender, EventArgs e)
        {

        }


        private void Backbutton_Click(object sender, EventArgs e)
        {
            Form form = new ManageEmp();
            form.Show();
            Visible = false;
        }
    }
}
