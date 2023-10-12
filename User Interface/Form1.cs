using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class Form1 : Form
    {
        string[] pics = new string[] { "1.png", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg", "11.jpg", "12.jpg", "13.jpg", "14.jpg", "15.jpg" };
        string[] switches = new string[] { "switch1.png", "switch2.png" };
        public static int bill=100;
        public static string Poolstatus="empty";
        int sensor = 0;
        int stairs = 0;
        int door = 0;
        public string gps="προαύλιο";
        public int light1 = 0;
        public int light2 = 0;
        public int light3 = 0;
        public int light4 = 0;
        public int tv;
        public int channel;
        public int volume;
        public int actemp=20;
        public int actemp1=0;
        public int ac;
        public string code;
        public string temp;
        string usertype;

        public void SetLocation(string location)
        {
            gps= location;
            if (gps == "προαύλιο")
            {
                labellocation.Text = "Τοποθεσία ίππου: Προαύλιο";
            }
            else
            {
                labellocation.Text = "Τοποθεσία ίππου: Κήποι";
            }
        }
        public void OrderTime(bool food,bool dessert,bool drink)
        {
            int time=0;
            if(food)
            {
                time = 40;
            }
            else if(dessert)
            {
                time = 15;
            }
            else if (drink)
            {
                time=1;
            }
            timer1.Interval = time * 60 * 1000;
            timer1.Enabled = true;
            MessageBox.Show("Η παραγγελία σας θα είναι έτοιμη σε περίπου "+time+" λεπτά");
        }

        public void BillString(int bill)
        {
            labelbill.Text = "Ποσό Λογαριασμού:" + bill + "€";
        }
        public void TVinfo(int tv, int channel, int volume)
        {
            this.tv= tv;
            this.channel = channel;
            this.volume = volume;
            if (tv == 0)
            {
                labeltv.Text = "Η Τηλεόραση είναι κλειστή";
            }
            else
            {
                labeltv.Text = "Τηλεόραση:Volume="+volume+",Channel="+channel;
            }
        }
        public void Lightsinfo(int lights1,int lights2,int lights3,int lights4)
        {
            this.light1 = lights1;
            this.light2 = lights2;
            this.light3 = lights3;
            this.light4 = lights4;
            if (code == "0000")
            {
                if (light1 == 0)
                {
                    labellights1.Text = "Φώτα στη Ρεσεψιόν:κλειστά";
                }
                else
                {
                    labellights1.Text = "Φώτα στη Ρεσεψιόν:ανοιχτά";
                }
                if (light2 == 0)
                {
                    labellights2.Text = "Φώτα Εξωτερικά:κλειστά";
                }
                else
                {
                    labellights2.Text = "Φώτα Εξωτερικά:ανοιχτά";
                }
                if (light3 == 0)
                {
                    labellights3.Text = "Φώτα στη Κουζίνα:κλειστά";
                }
                else
                {
                    labellights3.Text = "Φώτα στη Κουζίνα:ανοιχτά";
                }
                if (light4 == 0)
                {
                    labellights4.Text = "Φώτα στις Τουαλέτες:κλειστά";
                }
                else
                {
                    labellights4.Text = "Φώτα στις Τουαλέτες:ανοιχτά";
                }
            }
            else
            {
                if (light1 == 0)
                {
                    labellights1.Text = "Φώτα στο Υπνοδωμάτιο:κλειστά";
                }
                else
                {
                    labellights1.Text = "Φώτα στη Υπνοδωμάτιο:ανοιχτά";
                }
                if (light2 == 0)
                {
                    labellights2.Text = "Φώτα στην Τουαλέτα:κλειστά";
                }
                else
                {
                    labellights2.Text = "Φώτα στην Τουαλέτα:ανοιχτά";
                }
                if (light3 == 0)
                {
                    labellights3.Text = "Φώτα στη Κουζίνα:κλειστά";
                }
                else
                {
                    labellights3.Text = "Φώτα στη Κουζίνα:ανοιχτά";
                }
                if (light4 == 0)
                {
                    labellights4.Text = "Φώτα στο Σαλόνι:κλειστά";
                }
                else
                {
                    labellights4.Text = "Φώτα στο Σαλόνι:ανοιχτά";
                }
            }
        }
        public void ACinfo(int actemp,int actemp1, int ac)
        {
            this.ac = ac;
            this.actemp = actemp;
            this.actemp1 = actemp1;
            if (ac == 0)
            {
                labelac.Text = "Το Κλιματιστικό είναι κλειστό";
            }
            else
            {
                labelac.Text = "Κλιματιστικό:Θερμοκρασία=" + actemp+"."+actemp1;
            }

        }
        public void SetTemp(String temperature)
        {
            this.temp=temperature;
            labelpool.Text = "Η πισίνα είναι γεμάτη|" + temp;

        }


        public Form1()
        {
            InitializeComponent();
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows Form2
            usertype = Form2.radiobtn;
            code=Form2.code;
            
            if (usertype == "Υπάλληλος")
            {
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "/greek.gif");
                toolStripMenuItem17.Visible= false;

            }
            else
            {
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "/street-view.gif ");
                toolStripMenuItem3.Visible= false;

            }
            if (code == "0000")
            {   
                label1.Text = "Ξενοδοχείο";
                ιδιωτικήToolStripMenuItem.Visible = false;
                ToolStripMenuItem2.Visible = false;
                toolStripMenuItem17.Visible = false;
                toolStripMenuItem27.Visible = false;
                labeldoor.Visible = false;
                labelstairs.Visible = false;
                labellocation.Visible = false;
                labelbill.Visible = false;
                labellights1.Text = "Φώτα στη Ρεσεψιόν:κλειστά";
                labellights2.Text = "Φώτα Εξωτερικά:κλειστά";
                labellights3.Text = "Φώτα στη Κουζίνα:κλειστά";
                labellights4.Text = "Φώτα στις Τουαλέτες:κλειστά";
            }
            else
            {
                toolStripMenuItem3.Visible= false;
                label1.Text = "Δωμάτιο "+code;
                labellights1.Text = "Φώτα στο Υπνοδωμάτιο:κλειστά";
                labellights2.Text = "Φώτα στην Τουαλέτα:κλειστά";
                labellights3.Text = "Φώτα στη Κουζίνα:κλειστά";
                labellights4.Text = "Φώτα στο Σαλόνι:κλειστά";
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "/" + pics[0]);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "/" + switches[0]);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.WhiteSmoke)
            {
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "/" + switches[1]);
                BackColor = Color.FromArgb(32, 32, 32);
                pictureBox1.BackColor = Color.FromArgb(58, 55, 63);
                menuStrip1.BackColor = Color.FromArgb(31, 26, 36);
                label1.ForeColor=Color.FromArgb(187, 134, 252);
                panel1.BackColor= Color.FromArgb(31, 26, 36);
                foreach (Control l in panel1.Controls.OfType<System.Windows.Forms.Label>())
                {
                    l.ForeColor= Color.FromArgb(187, 134, 252);
                }
                foreach (ToolStripMenuItem c in menuStrip1.Items)
                {
                    c.BackColor = Color.FromArgb(58, 55, 63);
                    c.ForeColor = Color.FromArgb(187, 134, 252);
                    foreach (ToolStripMenuItem tl in c.DropDownItems)
                    {
                        tl.BackColor = Color.FromArgb(58, 55, 63);
                        tl.ForeColor = Color.FromArgb(187, 134, 252);
                        foreach (ToolStripMenuItem tl1 in tl.DropDownItems)
                        {
                            tl1.BackColor = Color.FromArgb(58, 55, 63);
                            tl1.ForeColor = Color.FromArgb(187, 134, 252);
                            foreach (ToolStripMenuItem tl2 in tl1.DropDownItems)
                            {
                                tl2.BackColor = Color.FromArgb(58, 55, 63);
                                tl2.ForeColor = Color.FromArgb(187, 134, 252);
                            }
                        }

                    }
                }


            }
            else
            {
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "/" + switches[0]);
                BackColor = Color.WhiteSmoke;
                pictureBox1.BackColor = Color.Goldenrod;
                menuStrip1.BackColor = Color.Goldenrod;
                label1.ForeColor= Color.IndianRed;
                panel1.BackColor = Color.Goldenrod;
                foreach (Control l in panel1.Controls.OfType<System.Windows.Forms.Label>())
                {
                    l.ForeColor = Color.IndianRed;
                }
                foreach (ToolStripMenuItem c in menuStrip1.Items)
                {
                    c.BackColor = Color.Gold;
                    c.ForeColor = Color.IndianRed;
                    foreach (ToolStripMenuItem tl in c.DropDownItems)
                    {
                        tl.BackColor = Color.Gold;
                        tl.ForeColor = Color.IndianRed;
                        foreach (ToolStripMenuItem tl1 in tl.DropDownItems)
                        {
                            tl1.BackColor = Color.Gold;
                            tl1.ForeColor = Color.IndianRed;
                            foreach (ToolStripMenuItem tl2 in tl1.DropDownItems)
                            {
                                tl2.BackColor = Color.Gold;
                                tl2.ForeColor = Color.IndianRed;
                            }
                        }

                    }
                }
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog(); // Shows Form3

        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Συνολικό ποσό:"+bill);
            Form4 f4 = new Form4(this, bill);
            f4.ShowDialog(); // Shows Form4
            bill = 0;
            labelbill.Text = "Ποσό Λογαριασμού:"+bill+"€";
        }


        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Poolstatus == "full")
            {
                DialogResult dialogResult = MessageBox.Show("Είστε σίγουροι ότι θέλετε να αδειάσετε την πισίνα;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labelpool.Text = "Η πισίνα είναι άδεια";
                    Poolstatus = "empty";
                }
            }
            else
            {
                MessageBox.Show("Η πισίνα είναι ήδη άδεια");
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Poolstatus == "full")
            {
                DialogResult dialogResult = MessageBox.Show("Είστε σίγουροι ότι θέλετε να αδειάσετε την πισίνα;","", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labelpool.Text = "Η πισίνα είναι άδεια";
                    Poolstatus = "empty";
                }
            }
            else
            {
                MessageBox.Show("Η πισίνα είναι ήδη άδεια");
            }
        }

        private void γέμισμαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Poolstatus == "full")
            {
                DialogResult dialogResult = MessageBox.Show("Η πισίνα είναι γεμάτη,θέλετε να ρυθμίσετε τη Θερμοκρασία;", " ", MessageBoxButtons.OKCancel); 
                if (dialogResult == DialogResult.OK)
                {
                    Form5 f5 = new Form5(this);
                    f5.ShowDialog(); // Shows Form5
                }
            }
            else 
            {
                labelpool.Text = "Η πισίνα είναι γεμάτη|"+temp;
                Poolstatus = "full";
                Form5 f5 = new Form5(this);
                f5.ShowDialog(); // Shows Form5
            }

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Poolstatus == "full")
            {
                DialogResult dialogResult = MessageBox.Show("Η πισίνα είναι γεμάτη,θέλετε να ρυθμίσετε τη Θερμοκρασία;", " ", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    Form5 f5 = new Form5(this);
                    f5.ShowDialog(); // Shows Form5
                }
            }
            else
            {
                labelpool.Text = "Η πισίνα είναι γεμάτη|"+temp;
                Poolstatus = "full";
                Form5 f5 = new Form5(this);
                f5.ShowDialog(); // Shows Form5
            }
        }

        private void ToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (sensor==0) {
                DialogResult dialogResult = MessageBox.Show("Ο αισθητήρας είναι κλειστός, θα θέλατε να τον ενεργοποιήσετε;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labelsensor.Text = "Ο συναγερμός είναι ανοιχτός";
                    MessageBox.Show("Ο συναγερμός είναι ενεργοποιημένος");
                    sensor= 1;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ο αισθητήρας είναι ανοιχτός, θα θέλατε να τον απενεργοποιήσετε;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labelsensor.Text = "Ο συναγερμός είναι κλειστός";
                    MessageBox.Show("Ο συναγερμός είναι απενεργοποιημένος");
                    sensor = 0;

                }
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (sensor == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Ο αισθητήρας είναι κλειστός, θα θέλατε να τον ενεργοποιήσετε;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Ο συναγερμός είναι ενεργοποιημένος");
                    sensor = 1;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ο αισθητήρας είναι ανοιχτός, θα θέλατε να τον απενεργοποιήσετε;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Ο συναγερμός είναι απενεργοποιημένος");
                    sensor = 0;
                }
            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (stairs == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Θέλετε σίγουρα να ανεβάσετε την σκάλα;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labelstairs.Text = "Η σκάλα είναι ανεβασμένη";
                    MessageBox.Show("Η σκάλα ανέβηκε");
                    stairs = 0;
                }
            }
            else
            {
                MessageBox.Show("Η σκάλα είναι ήδη ανεβασμένη");
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (stairs == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Θέλετε σίγουρα να κατεβάσετε την σκάλα;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labelstairs.Text = "Η σκάλα είναι κατεβασμένη";
                    MessageBox.Show("Η σκάλα κατέβηκε");
                    stairs = 1;
                }
            }
            else
            {
                MessageBox.Show("Η σκάλα είναι ήδη κατεβασμένη");
            }
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (door != 1)
            {
                DialogResult dialogResult = MessageBox.Show("Θέλετε σίγουρα να ανοίξετε την πόρτα;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labeldoor.Text = "Η πόρτα είναι ανοιχτή";
                    MessageBox.Show("Η πόρτα άνοιξε");
                    door = 1;
                }
            }
            else
            {
                MessageBox.Show("Η πόρτα είναι ήδη ανοιχτή");
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (door != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Θέλετε σίγουρα να κλείσετε την πόρτα;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labeldoor.Text = "Η πόρτα είναι κλειστή";
                    MessageBox.Show("Η πόρτα έκλεισε");
                    door = 0;
                }
            }
            else
            {
                MessageBox.Show("Η πόρτα είναι ήδη κλειστή");
            }
        }
       

        private void προαύλιοToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (door != 0)
            {

                MessageBox.Show("Η πόρτα είναι ανοιχτή");
            }
            else if (stairs == 1)
            {
                MessageBox.Show("Η σκάλα είναι κατεβασμένη");
            }
            else if (gps == null)
            {
                MessageBox.Show("Παρακαλώ διαλέξτε προορισμό");
            }
            else
            {
                if (gps!= "προαύλιο")
                {
                    Form9 f9 = new Form9(this); 
                    f9.ShowDialog();

                }
                else
                {
                     MessageBox.Show("Βρίσκεστε ήδη στο προαύλιο");
                }
            }  

        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            if (door != 0)
            {

                MessageBox.Show("Η πόρτα είναι ανοιχτή");
            }
            else if (stairs == 1)
            {
                MessageBox.Show("Η σκάλα είναι κατεβασμένη");
            }
            else if (gps == null)
            {
                MessageBox.Show("Παρακαλώ διαλέξτε προορισμό");
            }
            else
            {
                if (gps != "κήποι")
                {
                    Form9 f9 = new Form9(this);
                    f9.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Βρίσκεστε ήδη στους κήπους");

                }
            }

        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(this);
            f6.ShowDialog(); // Shows Form6
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(this);
            f8.ShowDialog();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(this);
            f7.ShowDialog(); // Shows Form7
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form10 form10=new Form10();
            form10.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/user_manual.pdf";
            Process.Start(path);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (door != 1)
            {
                DialogResult dialogResult = MessageBox.Show("Θέλετε σίγουρα να ανοίξετε την πόρτα;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labeldoor.Text = "Η πόρτα είναι ανοιχτή";
                    MessageBox.Show("Η πόρτα άνοιξε");
                    door = 1;
                }
            }
            else
            {
                MessageBox.Show("Η πόρτα είναι ήδη ανοιχτή");
            }
        }

        private void μισάνοιχτηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (door != 2)
            {
                DialogResult dialogResult = MessageBox.Show("Θέλετε σίγουρα να ανοίξετε λίγο την πόρτα;", " ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    labeldoor.Text = "Η πόρτα είναι μισάνοιχτη";
                    MessageBox.Show("Η πόρτα είναι μισάνοιχτη");
                    door = 2;
                }
            }
            else
            {
                MessageBox.Show("Η πόρτα είναι ήδη μισάνοιχτη");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (usertype == "Πελάτης" || code != "0000")
            {
                this.helpProvider1.HelpNamespace = Application.StartupPath + "/new 2.html";
                this.helpProvider1.SetHelpString(panel1, "You can see the state of your room here!");
            }
            else
            {
                this.helpProvider1.HelpNamespace = Application.StartupPath + "/new 2_employee.html";
                this.helpProvider1.SetHelpString(panel1, "You can see the state of the hotel here!");

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραγγελία σας είναι έτοιμη και έρχεται σε εσάς");
            timer1.Enabled = false;
        }
    }

}
