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
    public partial class MainForm01 : Form
    {
        public MainForm01()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Showstudentlist showlist = new Showstudentlist();
            showlist.Show(this);
        }


        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm Update1 = new UpdateDeleteStudentForm();
            Update1.Show(this);
        }
    }
}
