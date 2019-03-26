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
    public partial class PersonnelEdit : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\LrmdsDb.mdf;Integrated Security=True");
        int ID = 0;
        public PersonnelEdit()
        {
            InitializeComponent();
        }

        private void PersonnelEdit_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Refresh();
            display();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            ID = Convert.ToInt32(dr.Cells[0].Value.ToString());
           txLn.Text = dr.Cells[1].Value.ToString();
           txFn.Text = dr.Cells[2].Value.ToString();
           txMn.Text = dr.Cells[3].Value.ToString();
           cbPos.Text = dr.Cells[4].Value.ToString();
           txSec.Text = dr.Cells[5].Value.ToString();
           txRm.Text = dr.Cells[6].Value.ToString();
           cbSes.Text = dr.Cells[7].Value.ToString();
           cbGl.Text = dr.Cells[8].Value.ToString();
           txLn.Enabled = false;
           txFn.Enabled = false;
           txMn.Enabled = false;
           txRm.Enabled = false;
           txSec.Enabled = false;
           cbGl.Enabled = false;
           cbPos.Enabled = false;
           cbSes.Enabled = false;
        }
        void display()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from Teachers", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            txLn.Enabled = true;
            txFn.Enabled = true;
            txMn.Enabled = true;
            txRm.Enabled = true;
            txSec.Enabled = true;
            cbSes.Enabled = true;
            cbPos.Enabled = true;
            cbGl.Enabled = true;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Teachers set Lastname=@ln, Firstname=@fn, Middlename=@mn, Position=@ps, Section=@sc, Room=@rm, Session=@sn, Grade_Level=@gl where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@ln", txLn.Text);
            cmd.Parameters.AddWithValue("@fn", txFn.Text);
            cmd.Parameters.AddWithValue("@mn", txMn.Text);
            cmd.Parameters.AddWithValue("@ps", cbPos.Text);
            cmd.Parameters.AddWithValue("@sc", txSec.Text);
            cmd.Parameters.AddWithValue("@rm", txRm.Text);
            cmd.Parameters.AddWithValue("@sn", cbSes.Text);
            cmd.Parameters.AddWithValue("@gl", cbGl.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully!");
            con.Close();
            display();
            txLn.Clear();
            txFn.Clear();
            txMn.Clear();
            txRm.Clear();
            txSec.Clear();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                SqlCommand cmd = new SqlCommand("delete Personnel where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                display();
                txLn.Clear();
                txFn.Clear();
                txMn.Clear();
                txRm.Clear();
                txSec.Clear();

            }
        }
    }
}
