using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void statisticReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Trần Văn Trí code
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembers f = new frmMembers();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen ;
            f.Show();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts f = new frmProducts();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders f = new frmOrders();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
