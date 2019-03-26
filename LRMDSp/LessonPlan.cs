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
    public partial class LessonPlan : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\LrmdsDb.mdf;Integrated Security=True");
        OpenFileDialog ofd = new OpenFileDialog();
        public LessonPlan()
        {
            InitializeComponent();
        }

        private void LessonPlan_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Refresh();
            display();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        void display()
        {

           
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from LessonPlan", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fileName = ofd.FileName;
            System.IO.File.Copy(fileName, Path.Combine(Path.GetDirectoryName(@"C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\bin\Debug\Files\"), Path.GetFileName(fileName)));
            SqlCommand cmd = new SqlCommand("Insert into LessonPlan(Title,Language,Resource_Type,Subject,Grade_Level,Location_Path) Values(@tl,@lg,@rt,@sj,@gl,@lp)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@tl", textBox1.Text);
            cmd.Parameters.AddWithValue("@lg", textBox2.Text);
            cmd.Parameters.AddWithValue("@rt", textBox3.Text);
            cmd.Parameters.AddWithValue("@sj", comboBox1.Text);
            cmd.Parameters.AddWithValue("@lp", label6.Text);
            cmd.Parameters.AddWithValue("@gl", comboBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Upload successfull!");
            display();

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofd.Title = "Find docx";
            ofd.Filter = "All files|*.*";
            ofd.InitialDirectory = @"C:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = "" + ofd.SafeFileName + "";
                textBox4.Text = "" + ofd.FileName + "";
                label6.Text = @"C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\bin\Debug\Files\" + ofd.SafeFileName;
            }
        }
        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "Select";
            comboBox2.Text = "Select";
            
        }
    }
}
