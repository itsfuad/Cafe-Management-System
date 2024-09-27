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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //later implement
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            //later implement
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //later implement
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            logInPage logInPage = new logInPage();
            logInPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done!");
        }
    }
}
