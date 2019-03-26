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
using System.IO;


namespace LRMDSp
{
    public partial class Examination : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\LrmdsDb.mdf;Integrated Security=True");
        SqlCommand cmd;
    
        OpenFileDialog ofd = new OpenFileDialog();
        public Examination()
        {
            InitializeComponent();
        }

        private void Examination_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Refresh();
            display();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        void display()
        {

          
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from Examination", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            dataGridView1.DataSource = dt;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ofd.Title = "Find docx";
            ofd.Filter = "All files|*.*";
            ofd.InitialDirectory = @"C:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = "" + ofd.SafeFileName + "";
                textBox2.Text = "" + ofd.FileName + "";
                label1.Text = @"C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\bin\Debug\Files\" + ofd.SafeFileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fileName = ofd.FileName;
            System.IO.File.Copy(fileName, Path.Combine(Path.GetDirectoryName(@"C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\bin\Debug\Files\"), Path.GetFileName(fileName)));
            cmd = new SqlCommand("insert into Examination(Exam_name,Quarter,Grade_Level,Subject,Location_Path) Values(@em,@qr,@gr,@sb,@lt)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@em", textBox1.Text);
            cmd.Parameters.AddWithValue("@qr", comboBox1.Text);
            cmd.Parameters.AddWithValue("@gr", comboBox2.Text);
            cmd.Parameters.AddWithValue("@sb", comboBox3.Text);
            cmd.Parameters.AddWithValue("@lt", label1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Upload Successfull!");
            display();
            con.Close();


        }
    }
}
