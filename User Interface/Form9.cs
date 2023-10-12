using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class Form9 : Form
    {
        string location;
        int new_Y;
        int new_X;
        Form1 f;
        public Form9(Form1 form1)
        {
            f = form1;
            InitializeComponent();
            location = form1.gps;
            if (location == "προαύλιο")
            {
                pictureBox1.Location = new System.Drawing.Point(575 , 350);
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/trojan-horse - Copy.png");
            }
            else
            {
                pictureBox1.Location = new System.Drawing.Point(20, 75);
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/trojan-horse.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (location == "προαύλιο")
            {
                if (pictureBox1.Location.Y > 75)
                {
                    new_Y= pictureBox1.Location.Y - 5;
                    pictureBox1.Location=new Point(pictureBox1.Location.X, new_Y);
                }
                else if (pictureBox1.Location.X>15)
                {
                    new_X= pictureBox1.Location.X - 5;
                    pictureBox1.Location=new Point(new_X, pictureBox1.Location.Y);
                }
                else if(pictureBox1.Location.X==15 && pictureBox1.Location.Y == 75)
                { 
                    timer1.Enabled = false;
                    f.SetLocation(location);
                    MessageBox.Show("Φτάσατε στον προορισμό σας!");
                    this.Close();
                }

            }
            else
            {
                if (pictureBox1.Location.X < 575)
                {   
                    new_X = pictureBox1.Location.X + 5;
                    pictureBox1.Location = new Point(new_X, pictureBox1.Location.Y);
                }
                else if (pictureBox1.Location.Y < 350)
                {
                    new_Y = pictureBox1.Location.Y + 5;
                    pictureBox1.Location = new Point(pictureBox1.Location.X, new_Y);
                }
                else if (pictureBox1.Location.X == 575 && pictureBox1.Location.Y == 350)
                {
                    timer1.Enabled = false;
                    f.SetLocation(location);
                    MessageBox.Show("Φτάσατε στον προορισμό σας!");
                    this.Close();
                }
            }

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.helpProvider1.HelpNamespace = Application.StartupPath + "/new 9.html";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
            if (location == "προαύλιο")
            {
                location = "κήποι";
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/trojan-horse.png");
            }
            else
            {
                location = "προαύλιο";
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/trojan-horse - Copy.png");
            }
            timer1.Enabled=true;
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
