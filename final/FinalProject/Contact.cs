using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact
    {
        private string _contactName;
        private string _phoneNumber = "0";
        private bool _isContacted = false;

        public Contact(string contactName, string phoneNumber, bool isContacted)
        {
            _contactName = contactName;
            _phoneNumber = phoneNumber;
            if(isContacted)
            {
                _isContacted = true;
            }
        }
        public string GetName(){ return _contactName;}
        public string GetPhoneNumber(){return _phoneNumber;}
        public bool GetIsContacted(){return _isContacted;}
        public void SetIsContacted(bool isContacted){_isContacted = isContacted;}
        public void SetContactName(string contactName){_contactName = contactName;}
        public void SetPhoneNumber(string phoneNumber){_phoneNumber = phoneNumber;}
    }
}
