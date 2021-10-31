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
    public partial class Form3 : Form
        {
        public Form3()
            {
            InitializeComponent();
            listView1.Columns.Add("folder1");
            listView1.Columns.Add("description");
            listView1.Items.Add("folder 1");
            listView1.Items.Add("folder 2");
            listView1.Items.Add("folder 3");
            listView1.Items.Add("folder 4");
            listView1.Items.Add("folder 5");
            listView1.Items.Add("folder 6");
           
            treeView1.Nodes.Add("", "juice", 0, 0);
            treeView1.Nodes[0].Nodes.Add("", "orange juice", 1, 1);
            treeView1.Nodes[0].Nodes.Add("", "lemon juice", 2, 2);

            treeView1.Nodes.Add("", "coffee", 3, 3);
            treeView1.Nodes[1].Nodes.Add("", "cappuccino", 4, 4);
            treeView1.Nodes[1].Nodes.Add("", "Tea", 5, 5);
            treeView1.Nodes.Add("", "esprosso",5,5);
            treeView1.Nodes[2].Nodes.Add("", "milk", 6, 6);
            }

        private void Form3_Load(object sender, EventArgs e)
            {

            }

        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void groupBox1_Enter(object sender, EventArgs e)
            {
             
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

        private void label3_Click(object sender, EventArgs e)
            {

            }

        private void textBox4_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox5_TextChanged(object sender, EventArgs e)
            {

            }

        private void label6_Click(object sender, EventArgs e)
            {

            }

        private void label8_Click(object sender, EventArgs e)
            {

            }

        private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
            {

            }

        private void label4_Click(object sender, EventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
            {

            }

        private void label1_Click_1(object sender, EventArgs e)
            {

            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void label13_Click(object sender, EventArgs e)
            {

            }

        private void textBox11_TextChanged(object sender, EventArgs e)
            {

            }

        private void label11_Click(object sender, EventArgs e)
            {

            }

        private void label49_Click(object sender, EventArgs e)
            {

            }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void button5_Click(object sender, EventArgs e)
            {
            
            }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void comboBoxNat_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
            {

            }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
            {

            }

        private void button1_Click_1(object sender, EventArgs e)
            {
            listBox1.Items.Clear();
            foreach (TreeNode node in treeView1.Nodes)
                {
                if (node.Checked == true)
                    {
                    listBox1.Items.Add(node.Text);
                    }
                }
                for (int i = 0; i < treeView1.Nodes.Count; i++)
                {
                foreach (TreeNode Node in treeView1.Nodes[i].Nodes)
                    {
                    if (Node.Checked == true) {
                        listBox1.Items.Add(Node.Text);
                        }

                    }
                    }     
            
            }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            if (comboBox1.Text == ".LargeIcon")
                {
                listView1.View = View.LargeIcon;
                }
            else if (comboBox1.Text == "Details")
            {
            listView1.View = View.Details;
                }
            else if (comboBox1.Text == "SmallIcom") 
                {
                listView1.View = View.SmallIcon;
                }
            else if (comboBox1.Text == "List")
                {
                listView1.View = View.List;
                }
            else if (comboBox1.Text == "Tile") 
                {
                  listView1.View = View.Tile;
                }
            }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void toolStripButton1_Click(object sender, EventArgs e)
            {

            }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
            {

            }
        }
    }








