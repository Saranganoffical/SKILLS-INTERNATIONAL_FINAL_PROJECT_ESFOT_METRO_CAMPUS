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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void greet_user_Click(object sender, EventArgs e)
        {

        }

        private void About_btc_Click(object sender, EventArgs e)
        {
            About lForm = new About();
            lForm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Student_Reg lForm = new Student_Reg();
            lForm.Show();
            this.Hide();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            Student_Data lForm = new Student_Data();
            lForm.Show();
            this.Hide();
        }

        private void Contact_btn_Click(object sender, EventArgs e)
        {
            Contact lForm = new Contact();
            lForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
