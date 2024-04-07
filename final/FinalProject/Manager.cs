using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class Manager
    {
        public void SaveContactInfo(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException();
            }
            else
            {

            }
        }
        public void DeleteContactInfo(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException();
            }
            else
            {

            }
        }
        public void LoadContactsFile(string fileName)
        {

        }
        public void RegisterUser(User user) { }
        public void LoginIn(string username, string password) { }
        public void openContactManagerForm(object? obj)
        {
            Application.Run(new ContactsManagerForm());
        }
        public void openRegisterForm(object? obj)
        {
            Application.Run(new RegisterForm());
        }
        public void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }
    }
}
