using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace test_project
{
    public partial class FormAddUser : Form
    {
        SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog = khalid; Integrated Security = True");
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.TextLength == 0 || txtPassword.TextLength == 0 || txtRePass.TextLength == 0)
            {
                MessageBox.Show("None of the fields must be empty");
                
            }
            else if (txtPassword.Text != txtRePass.Text)
                MessageBox.Show("Password is wrong");
            else
            {
                connect.Open();
                SqlCommand com = new SqlCommand("insert into users (username , passowrd) values ('" + txtUsername.Text + "', '" + txtPassword.Text + "' ) ", connect);
                MessageBox.Show("Done");
                com.ExecuteNonQuery();
            }
               
        }
    }
}
