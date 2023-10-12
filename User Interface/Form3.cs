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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace User_Interface
{
    public partial class Form3 : Form
    {
        private const int V = 0;
        decimal[] food = {0,0,0,0,0,0,0,0,0,0};
        decimal[] dessert = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        decimal[] beverage = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        decimal[] drink = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        decimal Total=0;
        bool food_checked=false;
        bool dessert_checked=false;
        bool drink_checked=false;
        Form1 f1;
        int charge = 0;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            f1= form1;
            toolTip1.SetToolTip(checkBox1,"7€");
            toolTip1.SetToolTip(checkBox2, "6€");
            toolTip1.SetToolTip(checkBox3, "5€");
            toolTip1.SetToolTip(checkBox4, "9€");
            toolTip1.SetToolTip(checkBox5, "11€");
            toolTip1.SetToolTip(checkBox6, "8€");
            toolTip1.SetToolTip(checkBox7, "8€");
            toolTip1.SetToolTip(checkBox8, "9€");
            toolTip1.SetToolTip(checkBox9, "15€");
            toolTip1.SetToolTip(checkBox10, "10€");
            toolTip1.SetToolTip(checkBox50, "8€");
            toolTip1.SetToolTip(checkBox49, "1€");
            toolTip1.SetToolTip(checkBox48, "5€");
            toolTip1.SetToolTip(checkBox47, "4€");
            toolTip1.SetToolTip(checkBox46, "3€");
            toolTip1.SetToolTip(checkBox45, "3€");
            toolTip1.SetToolTip(checkBox44, "5€");
            toolTip1.SetToolTip(checkBox43, "5€");
            toolTip1.SetToolTip(checkBox42, "20€");
            toolTip1.SetToolTip(checkBox41, "3€");
            toolTip1.SetToolTip(checkBox20, "3€");
            toolTip1.SetToolTip(checkBox19, "3€");
            toolTip1.SetToolTip(checkBox18, "3€");
            toolTip1.SetToolTip(checkBox17, "3€");
            toolTip1.SetToolTip(checkBox16, "3€");
            toolTip1.SetToolTip(checkBox15, "3€");
            toolTip1.SetToolTip(checkBox14, "3€");
            toolTip1.SetToolTip(checkBox13, "1€");
            toolTip1.SetToolTip(checkBox12, "3€");
            toolTip1.SetToolTip(checkBox11, "4€");
            toolTip1.SetToolTip(checkBox30, "10€");
            toolTip1.SetToolTip(checkBox29, "10€");
            toolTip1.SetToolTip(checkBox28, "10€");
            toolTip1.SetToolTip(checkBox27, "7€");
            toolTip1.SetToolTip(checkBox26, "7€");
            toolTip1.SetToolTip(checkBox25, "7€");
            toolTip1.SetToolTip(checkBox24, "7€");
            toolTip1.SetToolTip(checkBox23, "7€");
            toolTip1.SetToolTip(checkBox22, "5€");
            toolTip1.SetToolTip(checkBox21, "5€");




        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                if (checkBox1.Checked==false) 
                { 
                    checkBox1.Checked = true;
                    food[0] = numericUpDown1.Value;
                    Total += food[0] * 7;
                    textBox1.Text=Total.ToString();
                }
                else
                {
                    checkBox1.Checked = true;
                    Total -= food[0]*7;
                    food[0] = numericUpDown1.Value;
                    Total += food[0] * 7;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox1.Checked = false;
                Total -= food[0] * 7;
                food[0] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 0)
            {
                if (checkBox2.Checked == false)
                {
                    checkBox2.Checked = true;
                    food[1] = numericUpDown2.Value;
                    Total += food[1] * 6;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox2.Checked = true;
                    Total -= food[1] * 6;
                    food[1] = numericUpDown2.Value;
                    Total += food[1] * 6;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox2.Checked = false;
                Total -= food[1] * 6;
                food[1] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 0)
            {
                if (checkBox3.Checked == false)
                {
                    checkBox3.Checked = true;
                    food[2] = numericUpDown4.Value;
                    Total += food[2] * 5;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox3.Checked = true;
                    Total -= food[2] * 5;
                    food[2] = numericUpDown4.Value;
                    Total += food[2] * 5;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox3.Checked = false;
                Total -= food[2] * 5;
                food[2] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 0)
            {
                if (checkBox4.Checked == false)
                {
                    checkBox4.Checked = true;
                    food[3] = numericUpDown3.Value;
                    Total += food[3] * 9;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox4.Checked = true;
                    Total -= food[3] * 9;
                    food[3] = numericUpDown3.Value;
                    Total += food[3] * 9;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox4.Checked = false;
                Total -= food[3] * 9;
                food[3] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown6.Value > 0)
            {
                if (checkBox5.Checked == false)
                {
                    checkBox5.Checked = true;
                    food[4] = numericUpDown6.Value;
                    Total += food[4] * 11;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox5.Checked = true;
                    Total -= food[4] * 11;
                    food[4] = numericUpDown6.Value;
                    Total += food[4] * 11;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox5.Checked = false;
                Total -= food[4] * 11;
                food[4] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value > 0)
            {
                if (checkBox6.Checked == false)
                {
                    checkBox6.Checked = true;
                    food[5] = numericUpDown5.Value;
                    Total += food[5] * 8;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox6.Checked = true;
                    Total -= food[5] * 8;
                    food[5] = numericUpDown5.Value;
                    Total += food[5] * 8;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox6.Checked = false;
                Total -= food[5] * 8;
                food[5] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown8.Value > 0)
            {
                if (checkBox7.Checked == false)
                {
                    checkBox7.Checked = true;
                    food[6] = numericUpDown8.Value;
                    Total += food[6] * 8;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox7.Checked = true;
                    Total -= food[6] * 8;
                    food[6] = numericUpDown8.Value;
                    Total += food[6] * 8;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox7.Checked = false;
                Total -= food[6] * 8;
                food[6] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown7.Value > 0)
            {
                if (checkBox8.Checked == false)
                {
                    checkBox8.Checked = true;
                    food[7] = numericUpDown7.Value;
                    Total += food[7] * 9;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox8.Checked = true;
                    Total -= food[7] * 9;
                    food[7] = numericUpDown7.Value;
                    Total += food[7] * 9;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox8.Checked = false;
                Total -= food[7] * 9;
                food[7] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown10.Value > 0)
            {
                if (checkBox9.Checked == false)
                {
                    checkBox9.Checked = true;
                    food[8] = numericUpDown10.Value;
                    Total += food[8] * 15;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox9.Checked = true;
                    Total -= food[8] * 15;
                    food[8] = numericUpDown10.Value;
                    Total += food[8] * 15;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox9.Checked = false;
                Total -= food[8] * 15;
                food[8] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown9.Value > 0)
            {
                if (checkBox10.Checked == false)
                {
                    checkBox10.Checked = true;
                    food[9] = numericUpDown9.Value;
                    Total += food[9] * 10;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox10.Checked = true;
                    Total -= food[9] * 10;
                    food[9] = numericUpDown9.Value;
                    Total += food[9] * 10;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox10.Checked = false;
                Total -= food[9] * 10;
                food[9] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown20.Value > 0)
            {
                if (checkBox50.Checked == false)
                {
                    checkBox50.Checked = true;
                    dessert[0] = numericUpDown20.Value;
                    Total += dessert[0] * 8;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox50.Checked = true;
                    Total -= dessert[0] * 8;
                    dessert[0] = numericUpDown20.Value;
                    Total += dessert[0] * 8;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox50.Checked = false;
                Total -= dessert[0] * 8;
                dessert[0] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown19.Value > 0)
            {
                if (checkBox49.Checked == false)
                {
                    checkBox49.Checked = true;
                    dessert[1] = numericUpDown19.Value;
                    Total += dessert[1] * 1;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox49.Checked = true;
                    Total -= dessert[1] * 1;
                    dessert[1] = numericUpDown19.Value;
                    Total += dessert[1] * 1;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox49.Checked = false;
                Total -= dessert[1] * 1;
                dessert[1] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown18.Value > 0)
            {
                if (checkBox48.Checked == false)
                {
                    checkBox48.Checked = true;
                    dessert[2] = numericUpDown18.Value;
                    Total += dessert[2] * 5;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox48.Checked = true;
                    Total -= dessert[2] * 5;
                    dessert[2] = numericUpDown18.Value;
                    Total += dessert[2] * 5;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox48.Checked = false;
                Total -= dessert[2] * 5;
                dessert[2] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown17.Value > 0)
            {
                if (checkBox47.Checked == false)
                {
                    checkBox47.Checked = true;
                    dessert[3] = numericUpDown17.Value;
                    Total += dessert[3] * 4;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox47.Checked = true;
                    Total -= dessert[3] * 4;
                    dessert[3] = numericUpDown17.Value;
                    Total += dessert[3] * 4;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox47.Checked = false;
                Total -= dessert[3] * 4;
                dessert[3] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown16.Value > 0)
            {
                if (checkBox46.Checked == false)
                {
                    checkBox46.Checked = true;
                    dessert[4] = numericUpDown16.Value;
                    Total += dessert[4] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox46.Checked = true;
                    Total -= dessert[4] * 3;
                    dessert[4] = numericUpDown16.Value;
                    Total += dessert[4] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox46.Checked = false;
                Total -= dessert[4] * 3;
                dessert[4] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown15.Value > 0)
            {
                if (checkBox45.Checked == false)
                {
                    checkBox45.Checked = true;
                    dessert[5] = numericUpDown15.Value;
                    Total += dessert[5] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox45.Checked = true;
                    Total -= dessert[5] * 3;
                    dessert[5] = numericUpDown15.Value;
                    Total += dessert[5] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox45.Checked = false;
                Total -= dessert[5] * 3;
                dessert[5] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown14.Value > 0)
            {
                if (checkBox44.Checked == false)
                {
                    checkBox44.Checked = true;
                    dessert[6] = numericUpDown14.Value;
                    Total += dessert[6] * 5;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox44.Checked = true;
                    Total -= dessert[6] * 5;
                    dessert[6] = numericUpDown14.Value;
                    Total += dessert[6] * 5;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox44.Checked = false;
                Total -= dessert[6] * 5;
                dessert[6] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown13.Value > 0)
            {
                if (checkBox43.Checked == false)
                {
                    checkBox43.Checked = true;
                    dessert[7] = numericUpDown13.Value;
                    Total += dessert[7] * 5;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox43.Checked = true;
                    Total -= dessert[7] * 5;
                    dessert[7] = numericUpDown13.Value;
                    Total += dessert[7] * 5;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox43.Checked = false;
                Total -= dessert[7] * 5;
                dessert[7] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown12.Value > 0)
            {
                if (checkBox42.Checked == false)
                {
                    checkBox42.Checked = true;
                    dessert[8] = numericUpDown12.Value;
                    Total += dessert[8] * 20;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox42.Checked = true;
                    Total -= dessert[8] * 20;
                    dessert[8] = numericUpDown12.Value;
                    Total += dessert[8] * 20;
                    textBox1.Text = Total.ToString();
                }
            }
            else
            {
                checkBox42.Checked = false;
                Total -= dessert[8] * 20;
                dessert[8] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown11.Value > 0)
            {
                if (checkBox41.Checked == false)
                {
                    checkBox41.Checked = true;
                    dessert[9] = numericUpDown11.Value;
                    Total += dessert[9] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox41.Checked = true;
                    Total -= dessert[9] * 3;
                    dessert[9] = numericUpDown11.Value;
                    Total += dessert[9] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox41.Checked = false;
                Total -= dessert[9] * 3;
                dessert[9] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown30_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown30.Value > 0)
            {
                if (checkBox20.Checked == false)
                {
                    checkBox20.Checked = true;
                    beverage[0] = numericUpDown30.Value;
                    Total += beverage[0] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox20.Checked = true;
                    Total -= beverage[0] * 3;
                    beverage[0] = numericUpDown30.Value;
                    Total += beverage[0] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox20.Checked = false;
                Total -= beverage[0] * 3;
                beverage[0] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown29_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown29.Value > 0)
            {
                if (checkBox19.Checked == false)
                {
                    checkBox19.Checked = true;
                    beverage[1] = numericUpDown29.Value;
                    Total += beverage[1] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox19.Checked = true;
                    Total -= beverage[1] * 3;
                    beverage[1] = numericUpDown29.Value;
                    Total += beverage[1] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox19.Checked = false;
                Total -= beverage[1] * 3;
                beverage[1] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown28_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown28.Value > 0)
            {
                if (checkBox18.Checked == false)
                {
                    checkBox18.Checked = true;
                    beverage[2] = numericUpDown28.Value;
                    Total += beverage[2] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox18.Checked = true;
                    Total -= beverage[2] * 3;
                    beverage[2] = numericUpDown28.Value;
                    Total += beverage[2] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox18.Checked = false;
                Total -= beverage[2] * 3;
                beverage[2] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown27_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown27.Value > 0)
            {
                if (checkBox17.Checked == false)
                {
                    checkBox17.Checked = true;
                    beverage[3] = numericUpDown27.Value;
                    Total += beverage[3] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox17.Checked = true;
                    Total -= beverage[3] * 3;
                    beverage[3] = numericUpDown27.Value;
                    Total += beverage[3] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox17.Checked = false;
                Total -= beverage[3] * 3;
                beverage[3] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown26_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown26.Value > 0)
            {
                if (checkBox16.Checked == false)
                {
                    checkBox16.Checked = true;
                    beverage[4] = numericUpDown26.Value;
                    Total += beverage[4] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox16.Checked = true;
                    Total -= beverage[4] * 3;
                    beverage[4] = numericUpDown26.Value;
                    Total += beverage[4] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox16.Checked = false;
                Total -= beverage[4] * 3;
                beverage[4] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown25_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown25.Value > 0)
            {
                if (checkBox15.Checked == false)
                {
                    checkBox15.Checked = true;
                    beverage[5] = numericUpDown25.Value;
                    Total += beverage[5] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox15.Checked = true;
                    Total -= beverage[5] * 3;
                    beverage[5] = numericUpDown25.Value;
                    Total += beverage[5] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox15.Checked = false;
                Total -= beverage[5] * 3;
                beverage[5] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown24_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown24.Value > 0)
            {
                if (checkBox14.Checked == false)
                {
                    checkBox14.Checked = true;
                    beverage[6] = numericUpDown24.Value;
                    Total += beverage[6] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox14.Checked = true;
                    Total -= beverage[6] * 3;
                    beverage[6] = numericUpDown24.Value;
                    Total += beverage[6] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox14.Checked = false;
                Total -= beverage[6] * 3;
                beverage[6] = 0;
                textBox1.Text = Total.ToString();
            }
        }


        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown23.Value > 0)
            {
                if (checkBox13.Checked == false)
                {
                    checkBox13.Checked = true;
                    beverage[7] = numericUpDown23.Value;
                    Total += beverage[7] * 1;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox13.Checked = true;
                    Total -= beverage[7] * 1;
                    beverage[7] = numericUpDown23.Value;
                    Total += beverage[7] * 1;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox13.Checked = false;
                Total -= beverage[7] * 1;
                beverage[7] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown22_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown22.Value > 0)
            {
                if (checkBox12.Checked == false)
                {
                    checkBox12.Checked = true;
                    beverage[8] = numericUpDown22.Value;
                    Total += beverage[8] * 3;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox12.Checked = true;
                    Total -= beverage[8] * 3;
                    beverage[8] = numericUpDown22.Value;
                    Total += beverage[8] * 3;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox12.Checked = false;
                Total -= beverage[8] * 3;
                beverage[8] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown21.Value > 0)
            {
                if (checkBox11.Checked == false)
                {
                    checkBox11.Checked = true;
                    beverage[9] = numericUpDown21.Value;
                    Total += beverage[9] * 4;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox11.Checked = true;
                    Total -= beverage[9] * 4;
                    beverage[9] = numericUpDown21.Value;
                    Total += beverage[9] * 4;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox11.Checked = false;
                Total -= beverage[9] * 4;
                beverage[9] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown40_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown40.Value > 0)
            {
                if (checkBox30.Checked == false)
                {
                    checkBox30.Checked = true;
                    drink[0] = numericUpDown40.Value;
                    Total += drink[0] * 10;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox30.Checked = true;
                    Total -= drink[0] * 10;
                    drink[0] = numericUpDown40.Value;
                    Total += drink[0] * 10;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox30.Checked = false;
                Total -= drink[0] * 10;
                drink[0] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown39_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown39.Value > 0)
            {
                if (checkBox29.Checked == false)
                {
                    checkBox29.Checked = true;
                    drink[1] = numericUpDown39.Value;
                    Total += drink[1] * 10;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox29.Checked = true;
                    Total -= drink[1] * 10;
                    food[1] = numericUpDown39.Value;
                    Total += drink[1] * 10;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox29.Checked = false;
                Total -= drink[1] * 10;
                drink[1] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown38_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown38.Value > 0)
            {
                if (checkBox28.Checked == false)
                {
                    checkBox28.Checked = true;
                    drink[2] = numericUpDown38.Value;
                    Total += drink[2] * 10;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox28.Checked = true;
                    Total -= drink[2] * 10;
                    drink[2] = numericUpDown38.Value;
                    Total += drink[2] * 10;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox28.Checked = false;
                Total -= drink[2] * 10;
                drink[2] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown37_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown37.Value > 0)
            {
                if (checkBox27.Checked == false)
                {
                    checkBox27.Checked = true;
                    drink[3] = numericUpDown37.Value;
                    Total += drink[3] * 7;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox27.Checked = true;
                    Total -= drink[3] * 7;
                    drink[3] = numericUpDown37.Value;
                    Total += drink[3] * 7;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox27.Checked = false;
                Total -= drink[3] * 7;
                drink[3] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown36_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown36.Value > 0)
            {
                if (checkBox26.Checked == false)
                {
                    checkBox26.Checked = true;
                    drink[4] = numericUpDown36.Value;
                    Total += drink[4] * 7;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox26.Checked = true;
                    Total -= drink[4] * 7;
                    drink[4] = numericUpDown36.Value;
                    Total += drink[4] * 7;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox26.Checked = false;
                Total -= drink[4] * 7;
                drink[4] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown35_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown35.Value > 0)
            {
                if (checkBox25.Checked == false)
                {
                    checkBox25.Checked = true;
                    drink[5] = numericUpDown35.Value;
                    Total += drink[5] * 7;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox25.Checked = true;
                    Total -= drink[5] * 7;
                    drink[5] = numericUpDown35.Value;
                    Total += drink[5] * 7;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox25.Checked = false;
                Total -= drink[5] * 7;
                drink[5] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown34_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown34.Value > 0)
            {
                if (checkBox24.Checked == false)
                {
                    checkBox24.Checked = true;
                    drink[6] = numericUpDown34.Value;
                    Total += drink[6] * 7;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox24.Checked = true;
                    Total -= drink[6] * 7;
                    drink[6] = numericUpDown34.Value;
                    Total += drink[6] * 7;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox24.Checked = false;
                Total -= drink[6] * 7;
                drink[6] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown33_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown33.Value > 0)
            {
                if (checkBox23.Checked == false)
                {
                    checkBox23.Checked = true;
                    drink[7] = numericUpDown33.Value;
                    Total += drink[7] * 7;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox23.Checked = true;
                    Total -= drink[7] * 7;
                    drink[7] = numericUpDown33.Value;
                    Total += drink[7] * 7;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox23.Checked = false;
                Total -= drink[7] * 7;
                drink[7] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown32_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown32.Value > 0)
            {
                if (checkBox22.Checked == false)
                {
                    checkBox22.Checked = true;
                    drink[8] = numericUpDown32.Value;
                    Total += drink[8] * 5;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox22.Checked = true;
                    Total -= drink[8] * 5;
                    drink[8] = numericUpDown32.Value;
                    Total += drink[8] * 5;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox22.Checked = false;
                Total -= drink[8] * 5;
                drink[8] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void numericUpDown31_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown31.Value > 0)
            {
                if (checkBox21.Checked == false)
                {
                    checkBox21.Checked = true;
                    drink[9] = numericUpDown31.Value;
                    Total += drink[9] * 5;
                    textBox1.Text = Total.ToString();
                }
                else
                {
                    checkBox21.Checked = true;
                    Total -= drink[9] * 5;
                    drink[9] = numericUpDown31.Value;
                    Total += drink[9] * 5;
                    textBox1.Text = Total.ToString();

                }
            }
            else
            {
                checkBox21.Checked = false;
                Total -= drink[9] * 5;
                drink[9] = 0;
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Value = 1;
            }
            else
            {
                numericUpDown1.Value = 0;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown2.Value = 1;
            }
            else
            {
                numericUpDown2.Value = 0;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                numericUpDown4.Value = 1;
            }
            else
            {
                numericUpDown4.Value = 0;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                numericUpDown3.Value = 1;
            }
            else
            {
                numericUpDown3.Value = 0;
            }
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                numericUpDown6.Value = 1;
            }
            else
            {
                numericUpDown6.Value = 0;
            }
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                numericUpDown5.Value = 1;
            }
            else
            {
                numericUpDown5.Value = 0;
            }
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                numericUpDown8.Value = 1;
            }
            else
            {
                numericUpDown8.Value = 0;
            }
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                numericUpDown7.Value = 1;
            }
            else
            {
                numericUpDown7.Value = 0;
            }
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                numericUpDown10.Value = 1;
            }
            else
            {
                numericUpDown10.Value = 0;
            }
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                numericUpDown9.Value = 1;
            }
            else
            {
                numericUpDown9.Value = 0;
            }
        }

        private void checkBox50_Click(object sender, EventArgs e)
        {
            if (checkBox50.Checked)
            {
                numericUpDown20.Value = 1;
            }
            else
            {
                numericUpDown20.Value = 0;
            }
        }

        private void checkBox49_Click(object sender, EventArgs e)
        {
            if (checkBox50.Checked)
            {
                numericUpDown19.Value = 1;
            }
            else
            {
                numericUpDown19.Value = 0;
            }
        }

        private void checkBox48_Click(object sender, EventArgs e)
        {
            if (checkBox48.Checked)
            {
                numericUpDown18.Value = 1;
            }
            else
            {
                numericUpDown18.Value = 0;
            }
        }

        private void checkBox47_Click(object sender, EventArgs e)
        {
            if (checkBox47.Checked)
            {
                numericUpDown17.Value = 1;
            }
            else
            {
                numericUpDown17.Value = 0;
            }
        }

        private void checkBox46_Click(object sender, EventArgs e)
        {
            if (checkBox46.Checked)
            {
                numericUpDown16.Value = 1;
            }
            else
            {
                numericUpDown16.Value = 0;
            }
        }

        private void checkBox45_Click(object sender, EventArgs e)
        {
            if (checkBox45.Checked)
            {
                numericUpDown15.Value = 1;
            }
            else
            {
                numericUpDown15.Value = 0;
            }
        }

        private void checkBox44_Click(object sender, EventArgs e)
        {
            if (checkBox44.Checked)
            {
                numericUpDown14.Value = 1;
            }
            else
            {
                numericUpDown14.Value = 0;
            }
        }

        private void checkBox43_Click(object sender, EventArgs e)
        {
            if (checkBox43.Checked)
            {
                numericUpDown13.Value = 1;
            }
            else
            {
                numericUpDown13.Value = 0;
            }
        }

        private void checkBox42_Click(object sender, EventArgs e)
        {
            if (checkBox42.Checked)
            {
                numericUpDown12.Value = 1;
            }
            else
            {
                numericUpDown12.Value = 0;
            }
        }

        private void checkBox41_Click(object sender, EventArgs e)
        {
            if (checkBox41.Checked)
            {
                numericUpDown11.Value = 1;
            }
            else
            {
                numericUpDown11.Value = 0;
            }
        }

        private void checkBox20_Click(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                numericUpDown30.Value = 1;
            }
            else
            {
                numericUpDown30.Value = 0;
            }
        }

        private void checkBox19_Click(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                numericUpDown29.Value = 1;
            }
            else
            {
                numericUpDown29.Value = 0;
            }
        }

        private void checkBox18_Click(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                numericUpDown28.Value = 1;
            }
            else
            {
                numericUpDown28.Value = 0;
            }
        }

        private void checkBox17_Click(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                numericUpDown27.Value = 1;
            }
            else
            {
                numericUpDown27.Value = 0;
            }
        }

        private void checkBox16_Click(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                numericUpDown26.Value = 1;
            }
            else
            {
                numericUpDown26.Value = 0;
            }
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                numericUpDown25.Value = 1;
            }
            else
            {
                numericUpDown25.Value = 0;
            }
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                numericUpDown24.Value = 1;
            }
            else
            {
                numericUpDown24.Value = 0;
            }
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                numericUpDown23.Value = 1;
            }
            else
            {
                numericUpDown23.Value = 0;
            }
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                numericUpDown22.Value = 1;
            }
            else
            {
                numericUpDown22.Value = 0;
            }
        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                numericUpDown21.Value = 1;
            }
            else
            {
                numericUpDown21.Value = 0;
            }
        }

        private void checkBox30_Click(object sender, EventArgs e)
        {
            if (checkBox30.Checked)
            {
                numericUpDown40.Value = 1;
            }
            else
            {
                numericUpDown40.Value = 0;
            }
        }

        private void checkBox29_Click(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
            {
                numericUpDown39.Value = 1;
            }
            else
            {
                numericUpDown39.Value = 0;
            }
        }

        private void checkBox28_Click(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
            {
                numericUpDown38.Value = 1;
            }
            else
            {
                numericUpDown38.Value = 0;
            }
        }

        private void checkBox27_Click(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                numericUpDown37.Value = 1;
            }
            else
            {
                numericUpDown37.Value = 0;
            }
        }

        private void checkBox26_Click(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                numericUpDown36.Value = 1;
            }
            else
            {
                numericUpDown36.Value = 0;
            }
        }

        private void checkBox25_Click(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                numericUpDown35.Value = 1;
            }
            else
            {
                numericUpDown35.Value = 0;
            }
        }

        private void checkBox24_Click(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                numericUpDown34.Value = 1;
            }
            else
            {
                numericUpDown34.Value = 0;
            }
        }

        private void checkBox23_Click(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
            {
                numericUpDown33.Value = 1;
            }
            else
            {
                numericUpDown33.Value = 0;
            }
        }

        private void checkBox22_Click(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                numericUpDown32.Value = 1;
            }
            else
            {
                numericUpDown32.Value = 0;
            }
        }

        private void checkBox21_Click(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                numericUpDown31.Value = 1;
            }
            else
            {
                numericUpDown31.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderPlacement();
            charge = Int32.Parse(textBox1.Text);
            Form1.bill = Form1.bill + charge;
            int finalbill = Form1.bill;
            f1.BillString(finalbill);
            Form4 f4 = new Form4(f1,charge);;
            f4.ShowDialog(); // Shows Form4
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderPlacement();
            charge = Int32.Parse(textBox1.Text);
            Form1.bill = Form1.bill + charge;
            int finalbill = Form1.bill;
            f1.BillString(finalbill);
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.helpProvider1.HelpNamespace = Application.StartupPath + "/new 3.html";
        }  
        
        private void OrderPlacement()
        {
            // Iterate through all controls in the form
            foreach (Control control in this.mains.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    food_checked=true; break;
                }
            }
            foreach (Control control in this.desserts.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    dessert_checked = true; break;
                }
            }
            foreach (Control control in this.drinks.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    drink_checked = true; break;
                }
            }

            f1.OrderTime(food_checked,dessert_checked,drink_checked);
        }

    }
}
