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


namespace Skill123
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sarangan02\Documents\LoginDatas.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();

                        String selectData = "SELECT * FROM ADMIN WHERE USERNAME = @username AND PASSWORD = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, con))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@pass", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Dashboard mForm = new Dashboard();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            login_username.Clear();
            login_password.Clear();
            {
                MessageBox.Show("Clear Done");
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sForm = new Signup();
            sForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Do You Want Exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            Application.Exit();
        }
    }
}
