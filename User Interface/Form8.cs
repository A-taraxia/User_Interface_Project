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
    public partial class Form8 : Form
    {
        int bedroom1_light = 0, kitchen_light = 0, wc_light = 0, living_light = 0,reception_light=0,outside_light=0;
        Form1 form1;
        private void SetLights()
        {
            if (form1.code == "0000")
            {
                form1.Lightsinfo(reception_light,outside_light,kitchen_light, wc_light);
            }
            else
            {
                form1.Lightsinfo(bedroom1_light,wc_light,kitchen_light,living_light);
            }
        }
        public Form8(Form1 f)
        {
            InitializeComponent();
            form1=f;
            if (f.code != "0000")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Bedroom");
                comboBox1.Items.Add("WC");
                comboBox1.Items.Add("Kitchen");
                comboBox1.Items.Add("Living Room");
                bedroom1_light = f.light1;
                wc_light= f.light2;
                kitchen_light = f.light3;
                living_light = f.light4;
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Reception");
                comboBox1.Items.Add("Outside");
                comboBox1.Items.Add("Kitchen");
                comboBox1.Items.Add("WC");
                reception_light= f.light1;
                outside_light= f.light2;
                kitchen_light= f.light3;
                wc_light= f.light4;
            }
            this.Controls.Add(comboBox1);
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bedroom")
            {
                pictureBox1.Image = Properties.Resources.bedroom1_off;
                bedroom1_light = 0;
            }
            else if (comboBox1.Text == "Kitchen")
            {
                pictureBox1.Image = Properties.Resources.kitchen_off;
                kitchen_light = 0;
            }
            else if (comboBox1.Text == "WC")
            {
                pictureBox1.Image = Properties.Resources.wc_off;
                wc_light = 0;
            }
            else if (comboBox1.Text == "Living Room")
            {
                pictureBox1.Image = Properties.Resources.living_room_off;
                living_light = 0;
            }
            else if(comboBox1.Text == "Reception")
            {
                pictureBox1.Image = Properties.Resources.reception_off;
                reception_light = 0;
            }
            else if (comboBox1.Text == "Outside")
            {
                pictureBox1.Image = Properties.Resources.outside_off;
                outside_light = 0;
            }
            button2.Enabled = false;
            button1.Enabled = true;
            SetLights();

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.helpProvider1.HelpNamespace = Application.StartupPath + "/new 8.html";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bedroom")
            {
                pictureBox1.Image = Properties.Resources.bedroom1;
                bedroom1_light = 1;
            }
            else if (comboBox1.Text == "Kitchen")
            {
                pictureBox1.Image = Properties.Resources.kitchen;
                kitchen_light = 1;
            }
            else if (comboBox1.Text == "WC")
            {
                pictureBox1.Image = Properties.Resources.wc;
                wc_light = 1;
            }
            else if (comboBox1.Text == "Living Room")
            {
                pictureBox1.Image = Properties.Resources.living_room;
                living_light = 1;
            }
            else if (comboBox1.Text == "Reception")
            {
                pictureBox1.Image = Properties.Resources.reception;
                reception_light = 1;
            }
            else if (comboBox1.Text == "Outside")
            {
                pictureBox1.Image = Properties.Resources.outside;
                outside_light = 1;
            }
            SetLights();
            button1.Enabled = false;
            button2.Enabled = true;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (comboBox1.Text == "Bedroom")
            {
                if (bedroom1_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.bedroom1;
                    button2.Enabled = true;
                }
                else if (bedroom1_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.bedroom1_off;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Kitchen")
            {
                if (kitchen_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.kitchen;
                    button2.Enabled = true;
                }
                else if (kitchen_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.kitchen_off;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "WC")
            {
                if (wc_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.wc;
                    button2.Enabled = true;
                }
                else if (wc_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.wc_off;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Living Room")
            {
                if (living_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.living_room;
                    button2.Enabled = true;
                }
                else if (living_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.living_room_off;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Reception")
            {
                if (reception_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.reception;
                    button2.Enabled = true;
                }
                else if (reception_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.reception_off;
                    button1.Enabled = true;
                }
            }
            else if (comboBox1.Text == "Outside")
            {
                if (outside_light == 1)
                {
                    pictureBox1.Image = Properties.Resources.outside;
                    button2.Enabled = true;
                }
                else if (outside_light == 0)
                {
                    pictureBox1.Image = Properties.Resources.outside_off;
                    button1.Enabled = true;
                }
            }
            SetLights();

        }
    }
}
