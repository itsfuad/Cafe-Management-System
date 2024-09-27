using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System.UI
{
    public partial class logInPage : Form
    {
        public logInPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            homePage homePage = new homePage();
            homePage.Show();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Username")
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //later implement
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Password")
            {
                textBox2.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
