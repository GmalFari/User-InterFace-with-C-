using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
    {
    public partial class Form1 : Form
        {
        public Form1()
            {
            InitializeComponent();
            
            
           groupBoxJob.Visible = false;
           groupBoxMain.Visible = false;
           groupBoxComunication.Visible = false;
           panelSalary.Visible = false;
           panelLinkAccounts.Visible = false;
            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

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
            comboBoxNat.Items.Add("yemen");
            comboBoxNat.Items.Add("Saudi");
            comboBoxNat.Items.Add("Egyption");
            comboBoxNat.Items.Add("Palastine");
            comboBoxNat.Items.Add("Syria");

            
            

            }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
            {

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
            if (buttonjob.Enabled)
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
            if (buttonjob.Enabled)
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

        
        }
    }
