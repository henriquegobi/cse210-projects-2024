using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ContactManager
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(fullNameBox.Text == "" || userBox.Text == ""|| passwordBox.Text == "" || emailBox.Text == "" || phoneNumberBox.Text == "")
            {
                MessageBox.Show("There are blank fields, please fill in all fields before registering!");
            }
            else
            {
                User user = new User(fullNameBox.Text, userBox.Text, passwordBox.Text, emailBox.Text, phoneNumberBox.Text);
                Manager.RegisterUser(user);
                this.Close();
            }
        }
    }
}
