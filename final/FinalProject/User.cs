using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class User
    {
        private int _id;
        private string _name;
        private string _user;
        private string _password;

        public User(int id, string name, string user, string password)
        {
            _id = id;
            _name = name;
            _user = user;
            _password = password;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetUser(){
            return _user;
        }
        public string GetPassword()
        {
            return _password;
        }
        public int getId()
        {
            return _id;
        }
        public void setName(string name)
        {
            _name = name;
        }
        public void SetUser(string user)
        {
            _user = user;
        }
        public void SetPassword(string password)
        {
            _password = password;
        }
        public void setId(int id)
        {
            _id = id;
        }
    }
}
