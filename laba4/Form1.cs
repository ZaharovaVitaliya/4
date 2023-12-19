using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PC new_PC;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Дополните данные");
            }
            if (textBox2.Text != "")
            {
                if (textBox3.Text != "")
                {

                    new_PC = new PC(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    textBox7.Text += new_PC.GetInformation();
                }
            }
        }


    }
}
