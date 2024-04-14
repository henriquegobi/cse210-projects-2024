using System.Threading;


namespace ContactManager
{
    public partial class LoginForm : Form
    {
        Thread tContactsManager;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void signInButton_Click(object sender, EventArgs e)
        {
            var user = Manager.LoginIn(userBox.Text, passwordBox.Text);
            if(user.getId() == -1)
            {
                MessageBox.Show("User or passord is incorrect or does not exist!");
            }
            else
            {
                this.Close();
                tContactsManager = new Thread(() => Application.Run(new ContactsManagerForm(user)));
                //tSignInThread.SetApartmentState(ApartmentState.STA);
                tContactsManager.Start();
            }
        }
        //private void openContactManagerForm(object? obj)
        //{
        //    Application.Run(new ContactsManagerForm());
        //}
        private void openRegisterForm(object? obj)
        {
            Application.Run(new RegisterForm());
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
            this.Show();
        }
    }
}
