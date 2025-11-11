using ThriftEase;

namespace ThriftEase
{
    public partial class LoginForm : Form
    {
        // ✅ This is your constructor — already correct
        public LoginForm()
        {
            InitializeComponent();
        }

        // ✅ This is your login button click method
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid username or password.";
                lblError.Visible = true;
            }
        }
    }
}
