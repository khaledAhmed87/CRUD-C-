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

namespace test_project
{
    public partial class FormColumn : Form
    {
        SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog = khalid; Integrated Security = True");
        void check()
        {
            if (txtNnameColumn.TextLength == 0 && radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                MessageBox.Show("Please enter name column");
                connect.Close();
            }
           else if (radioButton1.Checked)
            {
                SqlCommand com = new SqlCommand(" alter table [dbo].[employee] add " + txtNnameColumn.Text.ToString() + "  int  ", connect);
                com.ExecuteNonQuery();
                MessageBox.Show("Done");
                connect.Close();
            }
            else if (radioButton2.Checked)
            {
                SqlCommand com = new SqlCommand(" alter table [dbo].[employee] add " + txtNnameColumn.Text.ToString() + " Nvarchar(10) ", connect);
                com.ExecuteNonQuery();
                MessageBox.Show("Done");
                connect.Close();
            }
            else if (radioButton3.Checked)
            {
                SqlCommand com = new SqlCommand(" alter table [dbo].[employee] add " + txtNnameColumn.Text.ToString() + " date ", connect);
                com.ExecuteNonQuery();
                MessageBox.Show("Done");
                connect.Close();
            }
            else if (radioButton4.Checked)
            {
                SqlCommand com = new SqlCommand(" alter table [dbo].[employee] add " + txtNnameColumn.Text.ToString() + " varbinary(max) ", connect);
                com.ExecuteNonQuery();
                MessageBox.Show("Done");
                connect.Close();
            }
            else
            {
                MessageBox.Show("Please enter name column and select any choose");
                connect.Close();
            }
        }
        public FormColumn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            check();
            

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
