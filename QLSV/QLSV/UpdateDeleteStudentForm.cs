using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxID.Text))
            {
                int studentID = Convert.ToInt32(TextBoxID.Text);
                string fname = TextBoxFname.Text;
                string lname = TextBoxLname.Text;
                DateTime bdate = DateTimePicker1.Value;
                string gender = RadioButtonMale.Checked ? "Male" : "Female";
                string phone = TextBoxPhone.Text;
                string address = TextBoxAddress.Text;

                // Convert the picture to a byte array to store in the database
                MemoryStream ms = new MemoryStream();
                PictureBoxStudentImage.Image.Save(ms, PictureBoxStudentImage.Image.RawFormat);
                byte[] picture = ms.ToArray();

                // Construct the confirmation message
                StringBuilder confirmationMessage = new StringBuilder();
                confirmationMessage.AppendLine("Changes:");
                confirmationMessage.AppendLine($"Student ID: {studentID}");
                confirmationMessage.AppendLine($"First Name: {fname}");
                confirmationMessage.AppendLine($"Last Name: {lname}");
                confirmationMessage.AppendLine($"Birth Date: {bdate.ToShortDateString()}");
                confirmationMessage.AppendLine($"Gender: {gender}");
                confirmationMessage.AppendLine($"Phone: {phone}");
                confirmationMessage.AppendLine($"Address: {address}");
                confirmationMessage.AppendLine("Apply these changes?");

                // Show confirmation dialog
                DialogResult result = MessageBox.Show(confirmationMessage.ToString(), "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Apply changes if user confirms
                if (result == DialogResult.Yes)
                {
                    // Update student information
                    STUDENT student = new STUDENT();
                    if (student.UpdateStudent(studentID, fname, lname, bdate, gender, phone, address, new MemoryStream(picture)))
                    {
                        MessageBox.Show("Student information updated successfully.", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error updating student information.", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the Student ID.", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxID.Text))
            {
                int studentID = Convert.ToInt32(TextBoxID.Text);
                STUDENT student = new STUDENT();
                DataTable studentData = student.SearchStudentByID(studentID);

                if (studentData.Rows.Count > 0)
                {
                    // Extract data from the DataTable and display it in the respective controls
                    TextBoxFname.Text = studentData.Rows[0]["fname"].ToString();
                    TextBoxLname.Text = studentData.Rows[0]["lname"].ToString();
                    DateTimePicker1.Value = Convert.ToDateTime(studentData.Rows[0]["bdate"]);
                    if (studentData.Rows[0]["gender"].ToString() == "Male")
                    {
                        RadioButtonMale.Checked = true;
                    }
                    else if (studentData.Rows[0]["gender"].ToString() == "Female")
                    {
                        RadioButtonFemale.Checked = true;
                    }
                    TextBoxPhone.Text = studentData.Rows[0]["phone"].ToString();
                    TextBoxAddress.Text = studentData.Rows[0]["address"].ToString();

                    // Retrieve and display the picture from the database
                    byte[] img = (byte[])studentData.Rows[0]["picture"];
                    MemoryStream ms = new MemoryStream(img);
                    PictureBoxStudentImage.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("Student not found.", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, you can clear the fields if no student is found.
                    TextBoxFname.Clear();
                    TextBoxLname.Clear();
                    DateTimePicker1.Value = DateTime.Now;
                    RadioButtonMale.Checked = false;
                    RadioButtonFemale.Checked = false;
                    TextBoxPhone.Clear();
                    TextBoxAddress.Clear();
                    PictureBoxStudentImage.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Please enter the Student ID.", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxID.Text))
            {
                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int studentID = Convert.ToInt32(TextBoxID.Text);
                    STUDENT student = new STUDENT();

                    if (student.DeleteStudent(studentID))
                    {
                        // Clear the form fields after successful deletion
                        TextBoxFname.Clear();
                        TextBoxLname.Clear();
                        DateTimePicker1.Value = DateTime.Now;
                        RadioButtonMale.Checked = false;
                        RadioButtonFemale.Checked = false;
                        TextBoxPhone.Clear();
                        TextBoxAddress.Clear();
                        PictureBoxStudentImage.Image = null;

                        MessageBox.Show("Student information deleted successfully.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error deleting student information.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the Student ID.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into pictureBox1
                    PictureBoxStudentImage.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
