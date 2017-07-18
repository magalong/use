using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ch = true;
        int times;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ch)
            {
                button1.Text = "click!";
                timer1.Enabled = true;
                ch = !ch;
            }
            else
            {
                times += 1;
                label2.Text = times.ToString();

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt16(label1.Text) - 1).ToString();
            
            if(label1.Text == "0")
            {
               
                timer1.Enabled = false;
                MessageBox.Show("times out you have" + times.ToString() + "clicks");
                button1.Text = "start";
                label1.Text = "60";
                ch = !ch;
            }


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar == 'w')
            {
              

            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
         


        }
    }
}
