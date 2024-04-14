using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class User
    {
        private int _id;
        private string _fullName;
        private string _user;
        private string _password;
        private string _email;
        private string _phone;
        public User() 
        {
            _id = -1;
        }
        //Contructor without ID
        public User(string fullName, string user, string password, string email, string phone)
        {
            _fullName = fullName;
            _user = user;
            _password = password;
            _email = email;
            _phone = phone;
        }
        //Constructor with ID
        public User(int id, string fullName, string user, string password, string email, string phone)
        {
            _id = id;
            _fullName = fullName;
            _user = user;
            _password = password;
            _email = email;
            _phone = phone;
        }

        public int getId(){return _id;}
        public string GetFullName(){return _fullName;}
        public string GetUser(){return _user;}
        public string GetPassword(){return _password;}
        public string GetEmail() { return _email;}
        public string GetPhone() { return _phone;}
        public void setName(string name){_fullName = name;}
        public void SetUser(string user){_user = user;}
        public void SetPassword(string password){_password = password;}
        public void setId(int id){_id = id;}
    }
}
