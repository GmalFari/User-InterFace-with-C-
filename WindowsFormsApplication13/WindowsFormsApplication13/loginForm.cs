using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication13
{
    
    public partial class loginForm : Form
    {

        string path = @"Data Source=DESKTOP-6UPRCPV\SQLEXPRESS;Initial Catalog=JAMAL;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public loginForm()
        {
            InitializeComponent();
            conn = new SqlConnection(path);


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text == "jamal" && txtPassword.Text == "123")
            {

                Form1 frm1 = new Form1();
                frm1.Show();
                
            }
               
            else
            {
                MessageBox.Show("username or password error");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string new_pass = txtNewpass.Text;
            string retry_pass= txtRetrypass.Text;
           
            try
            {
                if (new_pass == retry_pass)
                {



                    conn.Open();
                    cmd = new SqlCommand("insert into users(usernames,passwords,retry_pass) values('" + txtNewUser.Text + "','" + txtNewpass.Text + "','"+txtRetrypass.Text+"' )", conn);
                   cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User was added to database");
                }
                else
                {
                    MessageBox.Show("Your password not the same");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
