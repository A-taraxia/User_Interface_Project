using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class Form7 : Form
    {
        int tv;
        int channel;
        int vol;
        int pr_ch = 1;
        Form1 form1;
        public Form7(Form1 f)
        {
            InitializeComponent();
            form1=f;
            tv=f.tv; 
            channel=f.channel;
            vol = f.volume;
            label3.Text=channel.ToString();
            label4.Text=vol.ToString();
            if(tv==0)
            {
                label5.Text = "OFF";
            }
            else
            {
                label5.Text = "ON";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tv == 0)
            {
                tv = 1;
                label5.Text = "ON";
            }
            else
            {
                tv=0;
                label5.Text = "OFF";   

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pr_ch= channel;
            channel = 1;
            label3.Text=channel.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pr_ch = channel;
            channel = 2;
            label3.Text = channel.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pr_ch = channel;
            channel = 3;
            label3.Text = channel.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pr_ch = channel;
            channel = 4;
            label3.Text = channel.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pr_ch = channel;
            channel = 5;
            label3.Text = channel.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pr_ch = channel;
            channel = 6;
            label3.Text = channel.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pr_ch = channel;
            channel = 7;
            label3.Text = channel.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pr_ch = channel;
            channel = 8;
            label3.Text = channel.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pr_ch = channel;
            channel = 9;
            label3.Text = channel.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (channel < 30)
            {
                pr_ch = channel;
                channel++;
                label3.Text = channel.ToString();
            }
            else
            {
                pr_ch = channel;
                channel = 1;
                label3.Text = channel.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (channel > 1)
            {
                pr_ch = channel;
                channel--;
                label3.Text = channel.ToString();
            }
            else
            {
                pr_ch = channel;
                channel = 30;
                label3.Text = channel.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (vol < 100)
            {
                vol++;
                label4.Text = vol.ToString();

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (vol > 0)
            {
                vol--;
                label4.Text = vol.ToString();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int temp=pr_ch;
            pr_ch = channel;
            channel = temp;
            label3.Text = channel.ToString();
        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            form1.TVinfo(tv, channel, vol);
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            form1.TVinfo(tv, channel, vol);
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            form1.TVinfo(tv, channel, vol);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.helpProvider1.HelpNamespace = Application.StartupPath + "/new 7.html";
        }
    }
}
