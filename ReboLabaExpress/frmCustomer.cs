using MySql.Data.MySqlClient;
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
    public partial class frmCustomer : Form
    {
        GlobalProcedures globalProcedure;
        string selectedPath;
        public frmCustomer()
        {
            InitializeComponent();

            globalProcedure = new GlobalProcedures();
            globalProcedure.fncConnectToDatabase();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dungeonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPic = new OpenFileDialog();
            ofdPic.Filter = "Image Files (*.jpg;*.gif;*.bmp)|*.jpg;*.gif;*.bmp";

            if (ofdPic.ShowDialog() == DialogResult.OK)
            {
                addPicture.Image = new Bitmap(ofdPic.FileName);
                selectedPath = ofdPic.FileName;
                addPicture.Image = Image.FromFile(selectedPath);

            }
        }

        private void ClearAll()
        {
            txtFullname.Text = "";
            cmbGender.Text = "";
            txtAddress.Text = "";
            txtContactno.Text = "";
            txtEmail.Text = "";
            addPicture.Image = null;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            MySqlCommand sqlCmd = globalProcedure.sqlCommand;

            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "AddCustomer";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_fullname", txtFullname.Text);
                sqlCmd.Parameters.AddWithValue("@p_birthdate", dtBirthdate.Value);
                sqlCmd.Parameters.AddWithValue("@p_gender", cmbGender.Text);
                sqlCmd.Parameters.AddWithValue("@p_address", txtAddress.Text);
                sqlCmd.Parameters.AddWithValue("@p_contactno", txtContactno.Text);
                sqlCmd.Parameters.AddWithValue("@p_emailadd", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@p_cust_photo", selectedPath);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully!");
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed");
            }
        }

        private void addPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
