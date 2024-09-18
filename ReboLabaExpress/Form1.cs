using System.Windows.Forms;

namespace ReboLabaExpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Connect Database
            GlobalProcedures proc = new GlobalProcedures();
           // proc.fncConnectToDatabase();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grbName_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblAccLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmDashboard Form1 = new frmDashboard();
            this.Hide();
            Form1.ShowDialog();
            this.Close();

        }
        
    }
}
