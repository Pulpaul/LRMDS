using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LRMDSp
{
    public partial class PersonnelTab : UserControl
    {
        public PersonnelTab()
        {
            InitializeComponent();
        }
        public static Panel panel;
        private void btnAn_Click(object sender, EventArgs e)
        {
            PersonnelNw pn = new PersonnelNw();
            panel = panel2;
            panel2.Controls.Clear();
            panel2.Controls.Add(pn);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PersonnelTab_Load(object sender, EventArgs e)
        {
            PersonnelSrc ps = new PersonnelSrc();
            panel2.Controls.Clear();
            panel2.Controls.Add(ps);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            PersonnelSrc ps = new PersonnelSrc();
            panel2.Controls.Clear();
            panel2.Controls.Add(ps);
        }

        private void btnEd_Click(object sender, EventArgs e)
        {
            PersonnelEdit pe = new PersonnelEdit();
            panel2.Controls.Clear();
            panel2.Controls.Add(pe);
        }
    }
}
