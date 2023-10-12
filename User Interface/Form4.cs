using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace User_Interface
{
    public partial class Form4 : Form
    {
        bool form_x=true;
        Form1 f1;
        int to_be_paid;
        public Form4(Form1 form1,int charge)
        {
            to_be_paid = charge;
            f1 = form1;
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyDown(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox4.Text)) // This will prevent exception when textbox is empty   
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                }
            }
        }



        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox2.Text!= "" && textBox1.Text != "" && textBox4.Text!="")
            {
                DialogResult dialogResult = MessageBox.Show("Είστε σίγουροι πως θέλετε να ολοκληρώσετε την πληρωμή σας;", "Προσοχή", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    form_x = false;
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.helpProvider1.HelpNamespace = Application.StartupPath + "/new 4.html";
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (form_x)
            {
                MessageBox.Show("Η συναλλαγή απέτυχε");

            }
            else
            {
                Form1.bill -= to_be_paid;
                f1.BillString(Form1.bill);
                MessageBox.Show("Η συναλλαγή ολοκληρώθηκε");
            }
        }
    }
}
