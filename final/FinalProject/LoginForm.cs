using System.Threading;


namespace ContactManager
{
    public partial class LoginForm : Form
    {
        Manager manager = new Manager();
        Thread tSignInThread;
        Thread tRegisterThread;

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
            this.Close();
            tSignInThread = new Thread(openContactManagerForm);
            tSignInThread.SetApartmentState(ApartmentState.STA);
            tSignInThread.Start();
            //this.Hide();
            //ContactsForm contactsForm = new ContactsForm();
            //contactsForm.ShowDialog();
        }
        private void openContactManagerForm(object? obj)
        {
            Application.Run(new ContactsManagerForm());
        }
        private void openRegisterForm(object? obj)
        {
            Application.Run(new RegisterForm());
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Show();
            //tRegisterThread = new Thread(openRegisterForm);
            //tRegisterThread.SetApartmentState(ApartmentState.STA);
            //tRegisterThread.Start();
        }
    }
}
