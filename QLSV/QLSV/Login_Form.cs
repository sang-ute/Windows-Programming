using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            this.AcceptButton = btt_Login;
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    pictureBox1.Image = Image.FromFile("../../images/user.png");
        //}

        private void btt_Login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM log_in WHERE username = @User AND password = @Pass", db.getConnection);

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0) )
            {
                //MessageBox.Show("Ok, next time will be go to Main Menu of App");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btt_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
        private void Login_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Simulate a click on the login button
                btt_Login.PerformClick();
            }
        }
    }
}
