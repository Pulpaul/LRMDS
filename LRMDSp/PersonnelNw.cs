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
    public partial class PersonnelNw : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\LrmdsDb.mdf;Integrated Security=True");
        public PersonnelNw()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txLn.Text != "" && txLn.Text != "Lastname" && txFn.Text != "" && txFn.Text != "Firstname")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Teachers(Lastname,Firstname,Middlename,Position,Section,Room,Session,Grade_Level) Values(@ln,@fn,@mn,@ps,@sc,@rm,@sn,@gl)", con);
                cmd.Parameters.AddWithValue("@ln", txLn.Text);
                cmd.Parameters.AddWithValue("@fn", txFn.Text);
                cmd.Parameters.AddWithValue("@mn", txMn.Text);
                cmd.Parameters.AddWithValue("@ps", cbPos.Text);
                cmd.Parameters.AddWithValue("@sc", txSc.Text);
                cmd.Parameters.AddWithValue("@rm", txRm.Text);
                cmd.Parameters.AddWithValue("@sn", cbSes.Text);
                cmd.Parameters.AddWithValue("@gl", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully!");
                PersonnelSrc sr = new PersonnelSrc();
                PersonnelTab.panel.Controls.Clear();
                PersonnelTab.panel.Controls.Add(sr);
            }
            else
            {
                MessageBox.Show("Fill up all form!");
            }

        }

        private void txLn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void txFn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void txMn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void cbPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.SendToBack();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.SendToBack();
        }

        private void cbSes_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.SendToBack();
        }

        private void PersonnelNw_Load(object sender, EventArgs e)
        {

        }
    }
}
