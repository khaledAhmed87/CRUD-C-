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
using System.IO;
using System.Drawing.Imaging;
namespace test_project
{
    public partial class FormEmployee : Form
    {
        public string user { get; set; }
        SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog = khalid; Integrated Security = True");
        bool chId = false, chName = false, chMobile = false, chsex = false;
        public byte[] Photo { get; set; }

        void check()
        {
            if (btnDelete.Enabled == true && btnLoad.Enabled == true)
            {
                if (chId == false)
                {
                    if (textId.TextLength == 0 || textName.TextLength == 0 || textMobile.TextLength == 0 || txtSex.TextLength == 0)
                    {
                        MessageBox.Show("None of the fields must be empty");
                        connect.Close();

                    }
                    else
                    { chId = true; }
                }
            }
            else if (txtSex.TextLength == 0 && textId.TextLength == 0 && textName.TextLength == 0 && textMobile.TextLength == 0 && btnLoad.Enabled == false)
            {
                SqlCommand com = new SqlCommand("select * from employee", connect);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                btnLoad.Enabled = true;

            }
            else
                  if (textId.TextLength == 0 && textName.TextLength == 0 && textMobile.TextLength == 0 && txtSex.TextLength == 0)
            {


                MessageBox.Show("Please Enter anything");

            }
            else if (chId == false && textId.TextLength != 0)
            {
                chId = true;
            }
            else if (chName == false && textName.TextLength != 0)
            {
                chName = true;
            }
            else if (chMobile == false && textMobile.TextLength != 0)
            {
                chMobile = true;
            }
            else if (chsex == false && txtSex.TextLength != 0)
            {
                chsex = true;
            }

        }
        public FormEmployee()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string us = user;
           loaddata();
            button1.Enabled = false;
            SqlCommand com = new SqlCommand("select * from employee", connect);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            connect.Close();
            if (user == "user")
            {
                btnDelete.Hide();
                btnInsert.Hide();
                btnUpdate.Hide();
                btnInsert.Hide();
            }
        }
        public void Insert(string filename, byte[] image)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            SqlCommand com = new SqlCommand("insert into employee values ( " + textId.Text + " ,  N'" + textName.Text + "','" + textMobile.Text + "','" + txtSex.Text + "', @pictures)", connect);

            
            {
                com.CommandType = CommandType.Text;
                
                com.Parameters.AddWithValue("@pictures", image);
                com.ExecuteNonQuery();
            }
        }
        public void loaddata()
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            using (DataTable dt = new DataTable("pictures"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Select *from employee", connect);
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();
            check();
            if (chId == true)
            {
                if (txtSex.Text != "1" && txtSex.Text != "2")
                {
                    MessageBox.Show("Sex should be 1 or 2");
                }
                else
                {
                    SqlCommand com = new SqlCommand("update employee set name = N'" + textName.Text + "' , mobile = '" + textMobile.Text + "' , sexid = '" + txtSex.Text + "' where id = " + textId.Text, connect);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    chId = false;
                    com = new SqlCommand("select * from employee", connect);
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
            connect.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            connect.Open();
            btnLoad.Enabled = false;
            check();
            btnLoad.Enabled = true;
            if (chId == true)
            {
                SqlCommand com = new SqlCommand("select * from employee where id = " + textId.Text, connect);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                chId = false;
            }

            else if (chName == true)
            {
                SqlCommand com = new SqlCommand("select * from employee where name =  N'" + textName.Text + "'", connect);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                chName = false;
            }
            else if (chMobile == true)
            {
                SqlCommand com = new SqlCommand("select * from employee where mobile = " + textMobile.Text, connect);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                chMobile = false;
            }
            connect.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
public Image ConvertImageToBytes(byte[] data)
{
    using (MemoryStream ms = new MemoryStream())
    {
        return Image.FromStream(ms);
    }
}
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    txtFileName.Text = ofd.FileName;
                    Insert(txtFileName.Text, ConvertImageToBytes(pictureBox1.Image));
                    loaddata();
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dgv.DataSource as DataTable;
            if (dt != null )
            {
                DataRow row = dt.Rows[e.RowIndex];
                pictureBox1.Image = ConvertImageToBytes((byte[])row["image"]);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (comAdd.Text == "")
            {
                MessageBox.Show("Please select Row Or Column Or Kids Or User");
            }
            else if (comAdd.Text == "Row")
            {
                connect.Open();
                check();
                if (chId == true)
                {
                    using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png", Multiselect = false })
                    {
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            pictureBox1.Image = Image.FromFile(ofd.FileName);
                            txtFileName.Text = ofd.FileName;
                            Insert(txtFileName.Text, ConvertImageToBytes(pictureBox1.Image));
                            loaddata();
                        }
                    }
                }
                chId = false;
            }
            else if (comAdd.Text == "Column")
            {
                FormColumn f = new FormColumn();
                f.Show();
            }
            else if (comAdd.Text == "Kids")
            {
                if (textId.TextLength == 0)
                {
                    MessageBox.Show("Please enter id father ");
                }
                else
                {

                    FormKid f = new FormKid();
                    f.fatherId = textId.Text;
                    f.Show();
                }
            }

            else if (comAdd.Text == "User")
            {
                FormAddUser fau = new FormAddUser();
                this.Hide();
                fau.Show();
            }
            else
            { MessageBox.Show("Please select Row Or Column Or Kids Or User"); }
            connect.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connect.Open();
            btnDelete.Enabled = false;
            check();
            btnDelete.Enabled = true;
             if (chId == true)
            {
                
                SqlCommand com = new SqlCommand("delete from employee where id = ( " + textId.Text + " )", connect);
                com.ExecuteNonQuery();
                MessageBox.Show("Done");
                com = new SqlCommand("select * from employee ", connect);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                chId = false;
            }
            
            else if (chName == true)
            {
                SqlCommand com = new SqlCommand(" delete from employee where name = ( N'" + textName.Text +  "' )", connect);
                com.ExecuteNonQuery();
                MessageBox.Show("Done");
                com = new SqlCommand("select * from employee ", connect);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                chName = false;
            }
            else if (chMobile == true)
            {
                SqlCommand com = new SqlCommand("delete from employee where mobile = ( " + textMobile.Text + " )", connect);
                com.ExecuteNonQuery();
                MessageBox.Show("Done");
                com = new SqlCommand("select * from employee ", connect);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
                chMobile = false;
            }
            
            connect.Close();
        }
    }
}
