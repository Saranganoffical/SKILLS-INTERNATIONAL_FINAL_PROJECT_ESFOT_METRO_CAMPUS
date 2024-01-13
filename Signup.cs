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
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sarangan02\Documents\LoginDatas.mdf;Integrated Security=True;Connect Timeout=30");
        public Signup()
        {
            InitializeComponent();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPass.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_email.Text == "" || signup_username.Text == ""
               || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username = '"
                            + signup_username.Text.Trim() + "'"; // admin is our table name

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, con))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (EMAIL, USERNAME, PASSWORD, DATE_CREATED) " +
                                    "VALUES(@email, @username, @pass, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, con))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // TO SWITCH THE FORM 
                                    Login lForm = new Login();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }

            }
        }

        private void Loginhere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lForm = new Login();
            lForm.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }
    }
}
