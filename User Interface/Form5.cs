using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace User_Interface
{
    public partial class Form5 : Form
    {
        string[] celsius = new string[] { "15°C" , "20°C" , "25°C" , "30°C" , "35°C" };
        string[] farenheit = new string[] { "59°F", "68°F", "77°F", "86°F", "95°F" };
        string[] temp = new string[] { "temperature1.png", "temperature2.png", "temperature3.png", "temperature4.png", "temperature5.png" };
        int i=0;
        string type = "c";
        Form1 form1;
        public Form5(Form1 f)
        {
            form1= f;
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "/" + temp[i]);
            label1.Text = celsius[i];

        }
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(187, 134, 252), 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i+1 <= 4)
            {
                progressBar1.Value = progressBar1.Value + 1;
                i++;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/" + temp[i]);
                if (type == "c")
                {
                    label1.Text = celsius[i];
                }
                else
                {
                    label1.Text = farenheit[i];
                }
                form1.SetTemp(label1.Text);
            }
            else
            {
                MessageBox.Show("Έχετε φτάσει στη μεγαλύτερη δυνατή Θερμοκρασία");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (type == "c") 
            {
                type = "f";
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "/farenheit.png");
                label1.Text = farenheit[i];
            }
            else
            {
                type = "c";
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "/celsius.png");
                label1.Text = celsius[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i-1 >=0)
            {
                progressBar1.Value = progressBar1.Value - 1;
                i--;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/" + temp[i]);
                if (type == "c")
                {
                    label1.Text = celsius[i];
                }
                else
                {
                    label1.Text = farenheit[i];
                }
                form1.SetTemp(label1.Text);

            }
            else
            {
                MessageBox.Show("Έχετε φτάσει στη μικρότερη δυνατή Θερμοκρασία");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.helpProvider1.HelpNamespace = Application.StartupPath + "/new 5.html";
        }
    }
}
