using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LRMDSp
{
    public partial class AccountEdit : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\LrmdsDb.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        public AccountEdit()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "All")
            {
                display();
            }
            else if (comboBox1.Text == "Admin")
            {
                DataTable dt = new DataTable();
                string sql = "Select * from Accounts where Account_type LIKE '%" + comboBox1.Text + "%'";
                adapt = new SqlDataAdapter(sql, con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "User")
            {
                DataTable dt = new DataTable();
                string sql = "Select * from Accounts where Account_type LIKE '%" + comboBox1.Text + "%'";
                adapt = new SqlDataAdapter(sql, con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountEdit_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Refresh();
            display();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
        }
        void display()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from Accounts", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            ID = Convert.ToInt32(dr.Cells[0].Value.ToString());
            textBox2.Text = dr.Cells[1].Value.ToString();
            textBox3.Text = dr.Cells[2].Value.ToString();
            textBox4.Text = dr.Cells[3].Value.ToString();
            textBox5.Text = dr.Cells[4].Value.ToString();
            textBox6.Text = dr.Cells[5].Value.ToString();
            textBox7.Text = dr.Cells[6].Value.ToString();
            comboBox2.Text = dr.Cells[7].Value.ToString();
            textBox8.Text = dr.Cells[8].Value.ToString();
            comboBox3.Text = dr.Cells[9].Value.ToString();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update Accounts set Username=@un, Password=@pd, Lastname=@ln, Firstname=@fn, MI=@mi, Birthdate=@bd, Secret_question=@sq, Answer=@an, Account_type=@at where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@un", textBox2.Text);
            cmd.Parameters.AddWithValue("@pd", textBox3.Text);
            cmd.Parameters.AddWithValue("@ln", textBox4.Text);
            cmd.Parameters.AddWithValue("@fn", textBox5.Text);
            cmd.Parameters.AddWithValue("@mi", textBox6.Text);
            cmd.Parameters.AddWithValue("@bd", textBox7.Text);
            cmd.Parameters.AddWithValue("@sq", comboBox2.Text);
            cmd.Parameters.AddWithValue("@an", textBox8.Text);
            cmd.Parameters.AddWithValue("@at", comboBox3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully!");
            con.Close();
            display();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Accounts where Username LIKE '%" + textBox1.Text + "%'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Accounts where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                display();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();

            }
        }
    }
}
