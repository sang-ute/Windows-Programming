using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class Showstudentlist : Form
    {
        public Showstudentlist()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.stdTableAdapter.Fill(this.my_DBDataSet.std);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            //if (dataGridView1.CurrentRow != null)
            //{
            //    int studentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            //    UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            //    updateDeleteStdF.ShowDialog();
            //}

            UpdateDeleteStudentForm updateDeletStdF = new UpdateDeleteStudentForm();
            // thu tu cua cac cot: id - fname - Inane - bd - gdr - phn - adrs - pic
            updateDeletStdF.TextBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeletStdF.TextBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeletStdF.TextBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeletStdF.DateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            // gender
            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                updateDeletStdF.RadioButtonFemale.Checked = true;
            }
            updateDeletStdF.TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeletStdF.TextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            // code xu ly hinh anh up len version 01 chay OK tim hieu them de code nhe hon
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeletStdF.PictureBoxStudentImage.Image = Image.FromStream(picture);

            updateDeletStdF.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reload data from the database
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            // Clear existing data in the DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            // Load fresh data from the database and bind it to the DataGridView
            DataTable newData = LoadDataFromDatabase(); // Implement this method to fetch data from the database
            dataGridView1.DataSource = newData;
        }

        private DataTable LoadDataFromDatabase()
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            // Assuming you have a query to fetch student data from the database
            string query = "SELECT * FROM Students"; // Update this query as per your database schema

            using (SqlCommand command = new SqlCommand(query, db.getConnection))
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }

            return table;
        }

    }
}
