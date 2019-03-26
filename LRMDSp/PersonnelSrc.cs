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
    public partial class PersonnelSrc : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\LrmdsDb.mdf;Integrated Security=True");
        public PersonnelSrc()
        {
            InitializeComponent();
        }

        private void PersonnelSrc_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Refresh();
            display();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        void display()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from Teachers", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Lastname")
            {
                DataTable dt = new DataTable();
                string sql = "Select * from Teachers where Lastname LIKE '%" + textBox1.Text + "%'";
                SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Firstname")
            {
                DataTable dt = new DataTable();
                string sql = "Select * from Teachers where Firstname LIKE '%" + textBox1.Text + "%'";
                SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Middlename")
            {
                DataTable dt = new DataTable();
                string sql = "Select * from Teachers where Middlename LIKE '%" + textBox1.Text + "%'";
                SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Teachers where Grade_Level LIKE '%" + "Kindergarten" + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Teachers where Grade_Level LIKE '%" + "Grade 1" + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Teachers where Grade_Level LIKE '%" + "Grade 2" + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Teachers where Grade_Level LIKE '%" + "Grade 3" + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Teachers where Grade_Level LIKE '%" + "Grade 4" + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Teachers where Grade_Level LIKE '%" + "Grade 5" + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Teachers where Grade_Level LIKE '%" + "Grade 6" + "%'";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
