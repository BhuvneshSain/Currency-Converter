using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CurrencyConvertor
{
    public partial class Form1 : Form
    {
        double us, inr, dir, temp;
        double us1, inr1, dir1, temp1;
        public Form1()
        {
            InitializeComponent();
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox2.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enabled = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            if (temp == us && temp1 == inr1)
                temp1 = us * 69.83;
            else if (temp == us && temp1 == dir)
                temp1 = us * 0.27;
            else if (temp == inr && temp1 == us1)
                temp1 = inr / 69.83;
            else if (temp == inr && temp1 == dir)
                temp1 = inr / 0.053;
            else if (temp == dir && temp1 == inr1)
                temp1 = dir * 0.053;
            else if (temp == dir && temp1 == us1)
                temp1 = dir / 0.27;
            else
                MessageBox.Show("Error!! Something Wrong"); 
            textBox2.Text = "" + temp;
            textBox3.Text = "" + temp1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.RemoveAt(0);
                us = Convert.ToDouble(textBox1.Text);
                temp = us;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.RemoveAt(1);
                inr = Convert.ToDouble(textBox1.Text);
                temp = inr;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.RemoveAt(2);
                dir = Convert.ToDouble(textBox1.Text);
                temp = dir;
            }
             comboBox1.Enabled = false;
             comboBox2.Enabled = true;


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
                temp1 = us1;
            else if (comboBox2.SelectedIndex == 2)
                temp1 = inr1;
            else if (comboBox2.SelectedIndex == 3)
                temp1 = dir1;
            comboBox2.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This window Application is developed by Bhuvnesh Sain. All Rights Reserved");
        }

        private void contectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For any query mail us at:  bhuvnesh.sain2016@rnbglobal.ac.in");
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

     
            
    }
}
