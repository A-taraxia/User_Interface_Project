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
    public partial class Form2 : Form
    {
        public static string radiobtn;
        public static string code;
        int done = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool isChecked = radioButton1.Checked;
            string value="";
            if (isChecked)
                value = radioButton1.Text;
            else
                value = radioButton2.Text;

            radiobtn= value;
            code= textBox1.Text;
            if (value != "" && (textBox1.Text != "Room Code" || textBox1.Text != "")){
                done = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία");
            }
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Room Code")
            {
                textBox1.Text = string.Empty;
            }

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(done==0)
            {
                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.helpProvider1.HelpNamespace = Application.StartupPath + "/new 1.html";
        }
    }
}
