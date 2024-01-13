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
    public partial class Student_Reg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sarangan02\Desktop\Skill123\LoginDatas.mdf;Integrated Security=True;Connect Timeout=30");
        public Student_Reg()
        {
            InitializeComponent();
        }

        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Regno = int.Parse(comboBox1.Text);
                string Firstname = tb1.Text;
                string Lastname = tb2.Text;
                DateTime DateofBirth = dateTimePicker1.Value;
                string Gender; // Declare the gender variable outside the if-else block
                if (radioButton1.Checked)
                {
                    Gender = "Male";
                    MessageBox.Show("Selected Gender: Male");
                    // Perform actions for Male
                }
                else
                {
                    Gender = "Female";
                    MessageBox.Show("Selected Gender: Female");
                    // Perform actions for Female
                }

                // Continue with other details
                string address = tb3.Text;
                string email = tb4.Text;
                int phone = int.Parse(tb5.Text);
                int homePhone = int.Parse(tb6.Text);
                string ParentName = tb7.Text;
                string NICNumber = tb8.Text;
                int ContactNumber = int.Parse(tb9.Text);
                Image imge = pictureBox1.Image;

                string query_insert = "insert into Register values('" + Regno + "','" + Firstname + "','" + Lastname + "','" + DateofBirth + "','" + Gender + "','" + address + "','" + email + "','" + phone + "','" + homePhone + "','" + ParentName + "','" + NICNumber + "','" + ContactNumber + "','" + imge + "')";

                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand command = new SqlCommand(query_insert, con);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Record added", "Registration Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close the connection after executing the query
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    // Handle the error appropriately
                    // Optionally, close the connection in case of an exception
                    if (con.State == ConnectionState.Open) ;

                }


                // Perform actions with the collected information
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Handle the error appropriately
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addStudent_deleteBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                SqlCommand cmd = new SqlCommand("DELETE fROM Register where Regno like '" + comboBox1.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Existing Student  Details Deleted Successfull", "Student  Details Deleted", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //clearMethod();
                con.Close();
            }
        }

        private void addStudent_picture_Click(object sender, EventArgs e)
        {

        }

        private void addStudent_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addStudent_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addEmployee_clearBtn_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Do You Want Clear ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            comboBox1.ResetText();
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
            tb6.Clear();
            tb7.Clear();
            tb8.Clear();
            tb9.Clear();
           
       

        }

        private void addStudent_updateBtn_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do You Want to Update the Data ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Register SET DateofBirth='" + dateTimePicker1.Text + "', Firstname= '" + tb1.Text + "', Lastname= '" + tb2.Text + "',Gender= '" + radioButton1.Text + "',address= '" + tb3.Text + "', email= '" + tb4.Text + "',phone= '" + tb5.Text + "', homephone= '" + tb6.Text + "', ParentName= '" + tb7.Text + "', NICNumber= '" + tb8.Text + "', ContactNumber= '" + tb9.Text + "'  where Regno  = '" + comboBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Success");
                // clearMethod();
                con.Close();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void Student_Reg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDatasDataSet7.Register' table. You can move, or remove it, as needed.
            this.registerTableAdapter2.Fill(this.loginDatasDataSet7.Register);
            // TODO: This line of code loads data into the 'loginDatasDataSet6.Register' table. You can move, or remove it, as needed.
            this.registerTableAdapter1.Fill(this.loginDatasDataSet6.Register);
            // TODO: This line of code loads data into the 'loginDatasDataSet4.Register' table. You can move, or remove it, as needed.
            this.registerTableAdapter.Fill(this.loginDatasDataSet4.Register);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Register  WHERE Regno LIKE '" + comboBox1.Text + "'", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                {
                    MessageBox.Show("Search Scuccess");
                }
                tb1.Text = sdr["Firstname"].ToString();
                dateTimePicker1.Text = sdr["DateofBirth"].ToString();
                tb2.Text = sdr["Lastname"].ToString();
                radioButton1.Text = sdr["Gender"].ToString();
                tb3.Text = sdr["address"].ToString();
                tb4.Text = sdr["email"].ToString();
                tb5.Text = sdr["phone"].ToString();
                tb6.Text = sdr["homephone"].ToString();
                tb7.Text = sdr["ParentName"].ToString();
                tb8.Text = sdr["NICNumber"].ToString();
                tb9.Text = sdr["ContactNumber"].ToString();
            }
            else
            {
                MessageBox.Show("Data Not Found");
            }
            comboBox1.Text = "";
            con.Close();

        }

    }
}