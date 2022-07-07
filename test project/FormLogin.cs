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

    public partial class FormLogin : Form
    {
        string connect = ("Data Source =.; Initial Catalog = khalid; Integrated Security = True");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" && txtPassowrd.Text == "")
                {
                    MessageBox.Show("Please enter username and password");
                }
                else
                {
                    SqlConnection con = new SqlConnection(connect);
                    SqlCommand cmd = new SqlCommand("select * from users where  passowrd = '" + txtPassowrd.Text + "' and username = '" + txtUsername.Text + "'", con);
                    cmd.Parameters.AddWithValue("@passowrd", txtPassowrd.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);


                    if (txtUsername.Text == "admin" && txtPassowrd.Text == "admin")
                    {
                        MessageBox.Show("Succesfully");
                        FormEmployee f = new FormEmployee();
                        this.Hide();
                        f.Show();
                    }
                    else
                    {
                        int count = ds.Tables[0].Rows.Count;
                        if (count >= 1)
                        {
                            MessageBox.Show("Succesfully");
                            FormEmployee f = new FormEmployee();
                            f.user = "user";
                            this.Hide();
                            f.Show();
                        }
                        else
                        { MessageBox.Show("Invalid username or password"); }

                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassowrd_TextChanged(object sender, EventArgs e)
        {

        }
    }

}