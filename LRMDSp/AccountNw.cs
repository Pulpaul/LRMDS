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
    public partial class AccountNw : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\LrmdsDb.mdf;Integrated Security=True");
        SqlCommand cmd;
       
        public AccountNw()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txLn.Text != "" && txLn.Text != "Lastname" && txFn.Text != "" && txFn.Text != "Firstname" && txMi.Text != "" && txMi.Text != "M.I" && txPn.Text != "" && txPn.Text != "Enter Password" && txUn.Text != "" && txUn.Text != "Enter Username" )
            {
                txBd.Text = comboBox1.Text + "/" + comboBox2.Text + "/" + comboBox3.Text;
                cmd = new SqlCommand("insert into Accounts(Username,Password,Lastname,Firstname,MI,Birthdate,Secret_question,Answer,Account_type) Values(@un,@ps,@ln,@fn,@mi,@bd,@sq,@an,@at)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@un", txUn.Text);
                cmd.Parameters.AddWithValue("@ps", txPn.Text);
                cmd.Parameters.AddWithValue("@ln", txLn.Text);
                cmd.Parameters.AddWithValue("@fn", txFn.Text);
                cmd.Parameters.AddWithValue("@mi", txMi.Text);
                cmd.Parameters.AddWithValue("@bd", txBd.Text);
                cmd.Parameters.AddWithValue("@sq", cbSq.Text);
                cmd.Parameters.AddWithValue("@an", txAns.Text);
                cmd.Parameters.AddWithValue("@at", cbAt.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                AccountSrch src = new AccountSrch();
                MessageBox.Show("Record Inserted Successfully!");
                AccountTab.panel.Controls.Clear();
                AccountTab.panel.Controls.Add(src);
            }          
        }

        private void txFn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void txLn_Enter(object sender, EventArgs e)
        {
            if (txLn.Text == "Lastname")
            {
                txLn.Text = "";
                txLn.ForeColor = Color.Black;
            }
        }

        private void txLn_Leave(object sender, EventArgs e)
        {
            if (txLn.Text == "")
            {
                txLn.Text = "Lastname";
                txLn.ForeColor = Color.Gray;
            }
        }

        private void txFn_Enter(object sender, EventArgs e)
        {
            if (txFn.Text == "Firstname")
            {
                txFn.Text = "";
                txFn.ForeColor = Color.Black;
            }
        }

        private void txFn_Leave(object sender, EventArgs e)
        {
            if (txFn.Text == "")
            {
                txFn.Text = "Firstname";
                txFn.ForeColor = Color.Gray;
            }
        }

        private void txMi_Enter(object sender, EventArgs e)
        {
            if (txMi.Text == "M.I")
            {
                txMi.Text = "";
                txMi.ForeColor = Color.Black;
            }
        }

        private void txMi_Leave(object sender, EventArgs e)
        {
            if (txMi.Text == "")
            {
                txMi.Text = "M.I";
                txMi.ForeColor = Color.Gray;
            }
        }

        private void txUn_Enter(object sender, EventArgs e)
        {
            if (txUn.Text == "Enter username")
            {
                txUn.Text = "";
                txUn.ForeColor = Color.Black;
            }
        }

        private void txUn_Leave(object sender, EventArgs e)
        {
            if (txUn.Text == "")
            {
                txUn.Text = "Enter username";
                txUn.ForeColor = Color.Gray;
            }
        }

        private void txPn_Enter(object sender, EventArgs e)
        {
            if (txPn.Text == "Enter password")
            {
                txPn.Text = "";
                txPn.ForeColor = Color.Black;
            }
        }

        private void txPn_Leave(object sender, EventArgs e)
        {
            if (txPn.Text == "")
            {
                txPn.Text = "Enter password";
                txPn.ForeColor = Color.Gray;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Month")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Month";
                comboBox1.ForeColor = Color.Gray;
            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Day")
            {
                comboBox2.Text = "";
                comboBox2.ForeColor = Color.Black;
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.Text = "Day";
                comboBox2.ForeColor = Color.Gray;
            }
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Year")
            {
                comboBox3.Text = "";
                comboBox3.ForeColor = Color.Black;
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                comboBox3.Text = "Year";
                comboBox3.ForeColor = Color.Gray;
            }
        }

        private void cbSq_Enter(object sender, EventArgs e)
        {
            if (cbSq.Text == "Select secret question")
            {
                cbSq.Text = "";
                cbSq.ForeColor = Color.Black;
            }
        }

        private void cbSq_Leave(object sender, EventArgs e)
        {
            if (cbSq.Text == "")
            {
                cbSq.Text = "Select secret question";
                cbSq.ForeColor = Color.Gray;
            }
        }

        private void txAns_Enter(object sender, EventArgs e)
        {
            if (txAns.Text == "Answer")
            {
                txAns.Text = "";
                txAns.ForeColor = Color.Black;
            }
        }

        private void txAns_Leave(object sender, EventArgs e)
        {
            if (txAns.Text == "")
            {
                txAns.Text = "Answer";
                txAns.ForeColor = Color.Gray;
            }
        }

        private void cbAt_Enter(object sender, EventArgs e)
        {
            if (cbAt.Text == "Select Account type")
            {
                cbAt.Text = "";
                cbAt.ForeColor = Color.Black;
            }
        }

        private void cbAt_Leave(object sender, EventArgs e)
        {
            if (cbAt.Text == "")
            {
                cbAt.Text = "Select Account type";
                cbAt.ForeColor = Color.Gray;
            }
        }

        private void txUn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txMi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            } 
        }

        private void txLn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            } 
        }

        private void AccountNw_Load(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.SendToBack();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.SendToBack();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.SendToBack();
        }

        private void cbSq_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.SendToBack();
        }

        private void cbAt_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.SendToBack();
        }

        private void txPn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txLn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
