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
    public partial class Form1 : Form
    {
        string connection = "Data Source=AMAR-HAITHAM;Initial Catalog=\"employee system\";Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            Visible = false; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            RegisterEmpForm registerEmpForm = new RegisterEmpForm();
            registerEmpForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
