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
    public partial class AccountTab : UserControl
    {
        public AccountTab()
        {
            InitializeComponent();
        }
        public static  Panel panel;
        private void btnAn_Click(object sender, EventArgs e)
        {
            AccountNw anw = new AccountNw();
            panel = panel2;
            panel2.Controls.Clear();
            panel2.Controls.Add(anw);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            AccountSrch src = new AccountSrch();
            panel = panel2;
            panel2.Controls.Clear();
            panel2.Controls.Add(src);
        }

        private void btnEd_Click(object sender, EventArgs e)
        {
            AccountEdit edt = new AccountEdit();
            panel = panel2;
            panel2.Controls.Clear();
            panel2.Controls.Add(edt);
        }

        private void AccountTab_Load(object sender, EventArgs e)
        {
            AccountSrch src = new AccountSrch();
            panel = panel2;
            panel2.Controls.Clear();
            panel2.Controls.Add(src);
        }
    }
}
