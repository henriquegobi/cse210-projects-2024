using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class Contact
    {
        private string _contactName;
        private int _phoneNumber;

        public Contact(string contactName, int phoneNumber)
        {
            _contactName = contactName;
            _phoneNumber = phoneNumber;
        }
        public string GetContactName()
        {
            return _contactName;
        }
        public int GetPhoneNumber()
        {
            return _phoneNumber;
        }
        public void SetContactName(string contactName)
        {
            _contactName = contactName;
        }
        public void SetPhoneNumber(int phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }
    }
}
