using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Edlix_David_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=int.Parse(textBox1.Text);
            int b=int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "Added = "+c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "Subtracted = " + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = "Multiplied = " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "Divided = " + c.ToString();
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label4.Text = "Mod = " + c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }
    }
}
