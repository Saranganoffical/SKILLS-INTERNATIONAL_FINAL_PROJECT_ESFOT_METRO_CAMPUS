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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void About_btc_Click(object sender, EventArgs e)
        {
            Dashboard lForm = new Dashboard();
            lForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }
    }
}
