using Cafe_Management_System.UI;

namespace Cafe_Management_System
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();         
            this.Hide();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            logInPage logInPage = new logInPage();
            logInPage.Show();
            this.Hide();
        }
    }
}
