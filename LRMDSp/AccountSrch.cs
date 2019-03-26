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
    public partial class AccountSrch : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\LrmdsDb.mdf;Integrated Security=True");
        SqlDataAdapter adapt;
        public AccountSrch()
        {
            InitializeComponent();
        }

        private void AccountSrch_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from Accounts where Username LIKE '%" + textBox1.Text + "%'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
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
    }
}
