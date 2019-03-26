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
    public partial class Examination2 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Cherrylaine\Documents\Visual Studio 2013\Projects\LRMDSp\LRMDSp\LrmdsDb.mdf;Integrated Security=True");
        OpenFileDialog openFileDialogCSV = new OpenFileDialog();
        SqlDataAdapter adapt;
        public Examination2()
        {
            InitializeComponent();
        }

        private void Examination2_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    label7.Text = folderDialog.SelectedPath;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label6.Text != "" && label7.Text != "")
            {
                string fp, tb;
                fp = Convert.ToString(label7.Text + "\\");
                tb = Convert.ToString(label6.Text);
                var fileName = openFileDialogCSV.FileName;
                System.IO.File.Copy(tb, Path.Combine(Path.GetDirectoryName(fp), Path.GetFileName(tb)));
                MessageBox.Show("Succesfull download!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }

            else
            {
                MessageBox.Show("Download Failed!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            textBox2.Text = dr.Cells[1].Value.ToString();
            label6.Text = dr.Cells[5].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from LessonPlan where Grade_Level LIKE '%" + "Kindergarten" + "%'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from LessonPlan where Grade_Level LIKE '%" + "Grade 1" + "%'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from LessonPlan where Grade_Level LIKE '%" + "Grade 2" + "%'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from LessonPlan where Grade_Level LIKE '%" + "Grade 3" + "%'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from LessonPlan where Grade_Level LIKE '%" + "Grade 4" + "%'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from LessonPlan where Grade_Level LIKE '%" + "Grade 5" + "%'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from LessonPlan where Grade_Level LIKE '%" + "Grade 6" + "%'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "Select * from LessonPlan where Grade_Level LIKE '%" + textBox1.Text + "%'";
            adapt = new SqlDataAdapter(sql, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }


    }
}
