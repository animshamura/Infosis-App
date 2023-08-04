namespace Infosis__App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            form.Show();
        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.Show();
        }
    }
}