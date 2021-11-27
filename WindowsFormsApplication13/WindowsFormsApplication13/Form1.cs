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
using System.Data.SqlClient;
namespace WindowsFormsApplication13
    {
    public partial class Form1 : Form
        {
        string path = @"Data Source=DESKTOP-6UPRCPV\SQLEXPRESS;Initial Catalog=JAMAL;User ID=jamal;password=jemo";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
            {
            InitializeComponent();
            conn = new SqlConnection(path);

          
           groupBoxJob.Visible = false;
           groupBoxMain.Visible = false;
           groupBoxComunication.Visible = false;
           panelSalary.Visible = false;
           panelLinkAccounts.Visible = false;
            //Default selected item
           comboBoxEmpAffairs.SelectedIndex = 0;
           comboBoxFav.SelectedIndex = 0;
           comboBoxSitting.SelectedIndex = 0;
           comboBoxAttendance.SelectedIndex = 0;
           comboBoxPerformace.SelectedIndex = 0;
           comboBoxsalaryRallies.SelectedIndex = 0;
            

           groupBoxSearch.Visible = false;
           groupBoxEmpFile.Visible = false;
            
            }

        private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
            {

            }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
            {

            }

        private void labelEmpName_Click(object sender, EventArgs e)
            {

            }

        private void label2_Click(object sender, EventArgs e)
            {

            }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void listBox2_Click(object sender, EventArgs e)
            {

            }

        private void groupBox4_Enter(object sender, EventArgs e)
            {

            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            

            }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
            }

               private void Form1_Load(object sender, EventArgs e)
            {
                toolStripButton1.Tag = "notification.png";
                toolStripButton1.Image = new Bitmap(Path.Combine("Logos\\Images", toolStripButton1.Tag.ToString()));
            
            comboBoxNat.Items.Add("yemen");
            comboBoxNat.Items.Add("Saudi");
            comboBoxNat.Items.Add("Egyption");
            comboBoxNat.Items.Add("Palastine");
            comboBoxNat.Items.Add("Syria");




            }

        private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void button3_Click(object sender, EventArgs e)
            {
            Form3 frm3 = new Form3();
            frm3.Show();
            }

        private void button4_Click(object sender, EventArgs e)
            {

            }

        private void button2_Click_1(object sender, EventArgs e)
            {


            }

        private void button10_Click(object sender, EventArgs e)
            {
            groupBoxComunication.Visible = true;
            groupBoxComunication.Width = 900;
            groupBoxComunication.Height = 325;
            if (groupBoxComunication.Enabled)
                {
                groupBoxJob.Visible = false;
                groupBoxMain.Visible = false;
                panelSalary.Visible = false;
                panelLinkAccounts.Visible = false;
                }
            }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Environment.Exit(0);
            }

        private void button1_Click(object sender, EventArgs e)
            {
                
            }

        private void textBox11_TextChanged(object sender, EventArgs e)
            {

            }

        private void groupBox6_Enter(object sender, EventArgs e)
            {

            }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void button6_Click(object sender, EventArgs e)
            {
           //groupBox6.Visible = true;
            }

        private void groupBox5_Enter(object sender, EventArgs e)
            {
            
            }

        private void button5_Click(object sender, EventArgs e)
            {
            
            groupBoxMain.Visible = true;
            groupBoxMain.Width = 900;
            groupBoxMain.Height = 325;
            if (btnjobData.Enabled)
                {
                groupBoxJob.Visible = false;
                groupBoxComunication.Visible = false;
                panelSalary.Visible = false;
                panelLinkAccounts.Visible = false;
                }
            
            }

        private void groupBox6_Enter_1(object sender, EventArgs e)
            {
            
            }

        private void button6_Click_1(object sender, EventArgs e)
            {
            
            
           
            }

        private void button9_Click(object sender, EventArgs e)
            {
            
            }

        private void button6_Click_2(object sender, EventArgs e)
            {
            groupBoxJob.Visible = true;
            groupBoxJob.Width = 900;
            groupBoxJob.Height = 325;
            if (groupBoxJob.Enabled)
                {
                
                groupBoxMain.Visible = false;
                groupBoxComunication.Visible = false;
                panelSalary.Visible = false;
                panelLinkAccounts.Visible = false;
                }

            
            }

        private void label17_Click(object sender, EventArgs e)
            {

            }

        private void button7_Click(object sender, EventArgs e)
            {

            }

        private void button7_Click_1(object sender, EventArgs e)
            {
            panelSalary.Visible = true;
            panelSalary.Width = 900;
            panelSalary.Height = 325;
            if (btnjobData.Enabled)
                {
                
                groupBoxJob.Visible = false;
                groupBoxMain.Visible = false;
                groupBoxComunication.Visible = false;
                panelLinkAccounts.Visible = false;
                }  
            }

        private void button14_Click(object sender, EventArgs e)
            {
            panelLinkAccounts.Visible = true;
            panelLinkAccounts.Width = 900;
            panelLinkAccounts.Height = 210;
            if (panelLinkAccounts.Enabled) 
                {
                groupBoxJob.Visible = false;
                groupBoxMain.Visible = false;
                groupBoxComunication.Visible = false;
                panelSalary.Visible = false;
                }

            }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
            
           



        }

        private void btnSaveMainGroupBox_Click(object sender, EventArgs e)
        {

            try
            {
                string gender;
                if (rbtnMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                conn.Open();
                cmd = new SqlCommand("insert into emp_mainData values('" + textBoxSocialStatus.Text + "','" + textBox_ProductNatCardDate.Text + "','" + textBoxCardIssuer.Text + "','" + textBoxCardIssuer.Text + "','" + textBox_ExpireNatCardDate.Text + "','" + comboBoxGob.Text + "','" + gender + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your data has been added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into contactData values('"+textBoxWorkPhone.Text+"','"+textBoxPhone.Text+"','"+textBoxAddress.Text+"','"+textBoxEmail.Text+"','"+textBoxCode.Text+"')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your Data has been added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSaveJobData_Click(object sender, EventArgs e)
        {
            try
            {
                string typeEmp;
                if (rbtnEmp.Checked)
                {
                    typeEmp = "Employee";
                }
                else
                {
                    typeEmp = "Manager";
                }
                
                cmd = new SqlCommand("Insert into job_data values ('"+textBoxSubDept.Text+"','"+comboBoxQualification.Text+"','"+comboBoxStatus.Text+"','"+textBoxHireDate.Text+"','"+textBoxProgram.Text+"','"+textBoxDeptOrSect.Text+"','"+typeEmp+"','"+textBoxDirctMngr.Text+"','"+comboBoxJobName.Text+"','"+comboBoxspeciality.Text+"','"+comboBoxProject.Text+"')",conn);
                conn.Open();
                //cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your data has been Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label30_Click(object sender, EventArgs e)
        {

        }
        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestaure.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaure_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaure.Visible = false;
            btnMaximize.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBoxEmpAffairs.SelectedIndex == 0)
            {
                groupBoxSearch.Visible = true;
                groupBoxEmpFile.Visible = true;
            }
            else
            {
                groupBoxEmpFile.Visible = false;
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEmpAffairs_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }

        private void groupBoxSearch_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_Click(object sender, EventArgs e)
        {

            this.FormBorderStyle = 0;
            string imgPath = "C:\\Users\\Dell\\Documents\\mis_level3\\CsharpWithShaima\\";
            toolStripButtonNotification.Image.Dispose();
            toolStripButtonNotification.Tag = ((toolStripButtonNotification.Tag == "notification.png") ? "notification.png" : "notification_sub.png");
            Bitmap bm = new Bitmap(Path.Combine(imgPath, toolStripButtonNotification.Tag.ToString()));
            toolStripButtonNotification.Image = bm;

            if (toolStripButtonNotification.Enabled == true)
            {
                this.toolStripButtonNotification.Image = new Bitmap("C:\\Users\\Dell\\Documents\\mis_level3\\CsharpWithShaima\\notification_sub.png");
            }
           
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("Insert into about_emp(emp_no,emp_name,emp_nationality,emp_managment,emp_natCard) values('" + txtNumEmp.Text + "','" + txtEmpName.Text + "','" + txtBoxNatCard.Text + "','" + comboBoxNat.Text + "','" + comboBoxManagment.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your Data has been added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
             
        }

        private void txtNumEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNatCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select emp_no,emp_name,emp_nationality , emp_managment,emp_natCard from about_emp where emp_no ='" + toolStripTextBoxSearch.Text + "'", conn);
                conn.Open();
                dr = cmd.ExecuteReader();

                
                    if (dr.ToString() != null)
                    {
                        dr.Read();
                        txtNumEmp.Text = dr["emp_no"].ToString();
                        txtBoxNatCard.Text = dr["emp_natCard"].ToString();
                        txtEmpName.Text = dr["emp_name"].ToString();
                        comboBoxManagment.Text = dr["emp_managment"].ToString();
                        comboBoxNat.Text = dr["emp_nationality"].ToString();
                        toolStripTextBoxSearch.Clear();

                    }
                    else
                    {
                        MessageBox.Show("There are no employee has this number");
                        toolStripTextBoxSearch.Clear();

                    }
                    dr.Close();
                    conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtNumEmp.Text = "";
            txtBoxNatCard.Text = "";
            txtEmpName.Text = "";
            comboBoxManagment.Text = "";
            comboBoxNat.Text = "";
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Update about_emp set emp_name='" + txtEmpName.Text + "',emp_natCard='" + txtBoxNatCard.Text + "',emp_nationality ='" + comboBoxNat.Text + "',emp_managment='" + comboBoxManagment.Text + "' where emp_no='" + txtNumEmp.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تم التحديث");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

            this.FormBorderStyle = 0;
            string imgPath = "C:\\Users\\Dell\\Documents\\mis_level3\\CsharpWithShaima\\";
            toolStripButtonNotification.Image.Dispose();
            toolStripButtonNotification.Tag = ((toolStripButtonNotification.Tag == "notification.png") ? "notification_sub.png" : "notification.png");
            Bitmap bm = new Bitmap(Path.Combine(imgPath, toolStripButtonNotification.Tag.ToString()));
            toolStripButtonNotification.Image = bm;

            if (toolStripButton1.Enabled)
            {
                this.toolStripButton1.Image = new Bitmap("C:\\Users\\Dell\\Documents\\mis_level3\\CsharpWithShaima\\notification_sub.png");
            }
        

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("delete from about_emp where emp_no='" + txtNumEmp.Text+ "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         

       

        
        }
    }
