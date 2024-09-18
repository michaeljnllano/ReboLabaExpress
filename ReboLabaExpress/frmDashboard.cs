using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReboLabaExpress
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.pnlDashboard.Controls.Count > 0)
                this.pnlDashboard.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlDashboard.Controls.Add(f);
            this.pnlDashboard.Tag = f;
            f.Show();

        }

        private void btnPricePackages_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomerMgmt_Click(object sender, EventArgs e)
        {
            loadform(new frmCustomer());
        }
    }
}
