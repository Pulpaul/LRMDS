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
namespace LRMDSp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string label00;
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\LrmdsDb.mdf;Integrated Security=True");
            SqlDataAdapter adapt = new SqlDataAdapter("Select Account_Type from Accounts Where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "' ", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                ((Form)this).Controls["label6"].Text = dt.Rows[0][0].ToString();
                label4.Text = dateTimePicker1.Text;
                label5.Text = dateTimePicker2.Text;
                //string conque = "INSERT INTO HistoryLogin (Username,Date,Time,Type) VALUES('" + textBox1.Text + "','" + label4.Text + "','" + label5.Text + "','" + label6.Text + "' )";
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into HistoryLogin(Username,Date,Time,Type) Values(@uname,@dt,@tm,@ty)", con);
                cmd.Parameters.AddWithValue("@uname", textBox1.Text);
                cmd.Parameters.AddWithValue("@dt", label4.Text);
                cmd.Parameters.AddWithValue("@tm", label5.Text);
                cmd.Parameters.AddWithValue("@ty", label6.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    label7.Text = label6.Text;
                    Form1 fa = new Form1();
                    label00 = label7.Text;
                    fa.Show();
                    con.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Item not save!!");

                }
            }
            else
            {
                MessageBox.Show("Username and password not valid!");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.PasswordChar = '*';
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }
    }
}
