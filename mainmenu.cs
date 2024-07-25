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
    public partial class mainmenu : Form
    {
        // Connection string for connecting to the database
        string connection = "Data Source=AMAR-HAITHAM;Initial Catalog=\"employee system\";Integrated Security=True";
        public mainmenu()
        {
            InitializeComponent();
        }
        // Event handler for the Showbutton click event
        private void Showbutton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            Visible = false;// Hiding the current mainmenu form 

        }
        // Creating an instance of the AdminMenu form
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        // Event handler for the Loginbutton click event
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            RegisterEmpForm registerEmpForm = new RegisterEmpForm();
            registerEmpForm.Show();
            Visible = false;// Hiding the current mainmenu form
        }
        // Event handler for the button1 click event
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();// Exiting the application
        }
    }
}
