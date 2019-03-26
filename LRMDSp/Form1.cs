using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LRMDSp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRS.BackColor = Color.Transparent;
            btnMm.BackColor = Color.Transparent;
            btnMv.BackColor = Color.Transparent;
            btnHy.BackColor = Color.Transparent;
            btnPl.BackColor = Color.Transparent;
            btnAc.BackColor = Color.Transparent;
            btnLh.BackColor = Color.Transparent;
            label2.Text = Login.label00;
            if (label2.Text == "User")
            {
                btnAc.Visible = false;
                btnLh.Visible = false;
            }
           
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            line.Width = btnRS.Width;
            line.Left = btnRS.Left;
            ResourceTab rt = new ResourceTab();
            panel1.Controls.Clear();
            panel1.Controls.Add(rt);

        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            line.Width = btnAc.Width;
            line.Left = btnAc.Left;
            AccountTab at = new AccountTab();
            panel1.Controls.Clear();
            panel1.Controls.Add(at);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void btnPl_Click(object sender, EventArgs e)
        {
            line.Width = btnPl.Width;
            line.Left = btnPl.Left;
            PersonnelTab pt = new PersonnelTab();
            panel1.Controls.Clear();
            panel1.Controls.Add(pt);
        }

        private void btnMm_Click(object sender, EventArgs e)
        {
            line.Width = btnMm.Width;
            line.Left = btnMm.Left;
            MemoTab mt = new MemoTab();
            panel1.Controls.Clear();
            panel1.Controls.Add(mt);

        }

        private void btnMv_Click(object sender, EventArgs e)
        {
            line.Width = btnMv.Width;
            line.Left = btnMv.Left;
        }

        private void btnHy_Click(object sender, EventArgs e)
        {
            line.Width = btnHy.Width;
            line.Left = btnHy.Left;
        }

        private void btnLh_Click(object sender, EventArgs e)
        {
            line.Width = btnLh.Width;
            line.Left = btnLh.Left;
        }
    }
}
