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
    public partial class EmployeeManager : Form
    {
        private const string connectionString = "Data Source=AMAR-HAITHAM;Initial Catalog=\"employee system\";Integrated Security=True";

        private string Name;
        private int ID;
        
        public EmployeeManager(string Name, int ID)
        {
            InitializeComponent();
            this.Name = Name;
            this.ID = ID;
            Load += EmployeeManager_Load;
        }


        private void EmployeeManager_Load(object sender, EventArgs e)
        {
            label1.Text = " Welcome " + Name;
            label2.Text = " ID : " + ID;
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Salary From Employee WHERE EmployeeID LIKE @EmployeeID ";
                SqlCommand command = new SqlCommand(query, connection);
              
                command.Parameters.AddWithValue("@EmployeeID", ID);
                int Salary = Convert.ToInt32(command.ExecuteScalar());

                try
                {
                    
                    int rowsAffected = command.ExecuteNonQuery();
                    Salarytext.Text = Salary.ToString();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Form form = new RegisterEmpForm();
            form.Show();
            Visible = false;
        }

        private void Salarytext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
