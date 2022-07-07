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
    public partial class FormKid : Form
    {
        public string fatherId { get; set; }
        SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog = khalid; Integrated Security = True");
        
        public FormKid()
        {
            InitializeComponent();
        }

        private void FormKid_Load(object sender, EventArgs e)
        {
            
            connect.Open();
            SqlCommand com = new SqlCommand("select * from kids", connect);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            connect.Close();
            
        }

        private void btnAddKids_Click(object sender, EventArgs e)
        {
            if (txtName.TextLength == 0 && comboSex.Text == "" )
            {
                MessageBox.Show("Please enter kid id and check sex");
            }
           else if (comboSex.Text == "" )
            { MessageBox.Show("Select sex"); }
            else if ( comboSex.Text == "Male" || comboSex.Text == "Female" && txtName.TextLength == 0)
            { MessageBox.Show("Please enter kid name"); }
            else
            {
                string a = fatherId;
                connect.Open();
                SqlCommand com = new SqlCommand("insert into dbo.kids values ( " + txtId.Text + " ,  '" + txtName.Text + "'," + a + "," + (1+comboSex.SelectedIndex) + ", '" + dateTimeOfBirth.Value.Date.ToString("yyyMMdd") + "')", connect);
                com.ExecuteNonQuery();
                MessageBox.Show("Done");
                 com = new SqlCommand("select * from kids", connect);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                connect.Close();
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericIdKid_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
