using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class Form6 : Form
    {
        int i;
        int j;
        int s=0;
        string[] switches = new string[] { "switch-off.png","switch-on.png" };
        Form1 form1;

        public Form6(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            i = f.actemp;
            j= f.actemp1;
            s = f.ac;
            pictureBox4.Image = Image.FromFile(Application.StartupPath + "/" + switches[s]);
            label1.Text = i.ToString() + "." + j.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (s == 0)
            {
                s++;
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "/" + switches[s]);
            }
            else
            {
                s--;
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "/" + switches[s]);
            }
            form1.ACinfo(i, j, s);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (j + 1 > 9)
            {
                i++;
                j = 0;
                label1.Text=i.ToString() +"."+j.ToString();
            }
            else
            {
                j++;
                label1.Text = i.ToString() + "." + j.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (j - 1 < 0)
            {
                i--;
                j = 9;
                label1.Text = i.ToString() + "." + j.ToString();
            }
            else
            {
                j--;
                label1.Text = i.ToString() + "." + j.ToString();
            }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            form1.ACinfo(i, j, s);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.helpProvider1.HelpNamespace = Application.StartupPath + "/new 6.html";
        }
    }
}
