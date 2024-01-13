using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill123
{
    public partial class Student_Data : Form
    {
        public Student_Data()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void About_btc_Click(object sender, EventArgs e)
        {
            Dashboard lForm = new Dashboard();
            lForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Reg lForm = new Student_Reg();
            lForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
          Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }

        private void Student_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDatasDataSet3.Register' table. You can move, or remove it, as needed.
            this.registerTableAdapter2.Fill(this.loginDatasDataSet3.Register);
            // TODO: This line of code loads data into the 'loginDatasDataSet2.Register' table. You can move, or remove it, as needed.
            this.registerTableAdapter1.Fill(this.loginDatasDataSet2.Register);
            // TODO: This line of code loads data into the 'loginDatasDataSet1.Register' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'loginDatasDataSet.Register' table. You can move, or remove it, as needed.
          //  this.registerTableAdapter.Fill(this.loginDatasDataSet.Register);

        }
    }
}
