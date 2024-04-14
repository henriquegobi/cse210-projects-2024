using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    static public class Manager
    {
        const string _userFileName = "ContactManagerUsers.txt";
        const string _contactsFileName = "ContactManagerContacts.txt";
        public static void SaveContactInfo(User user, string contactName, string phoneNumber)
        {
            if (contactName == null || phoneNumber == "0")
            {
                MessageBox.Show("Missing name or phone in this contact");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(_contactsFileName, true))
                {
                    writer.WriteLine($"{user.getId()};;{contactName};;{phoneNumber};;{false}");
                }
            }

        }

        public static void SaveContacts(User user, List<Contact> contacts)
        {
            if(contacts.Count > 0)
            {
                File.WriteAllText(_contactsFileName, string.Empty);
                using (StreamWriter writer = new StreamWriter(_contactsFileName, true))
                {
                    foreach(var contact in contacts)
                    {
                        writer.WriteLine($"{user.getId()};;{contact.GetName()};;{contact.GetPhoneNumber()};;{contact.GetIsContacted()}");
                    }
                }
            }
        }

        public static void RemoveContactInfo(string contactName, int phoneNumber = 0)
        {
            if (contactName == null || phoneNumber == 0)
            {
                
            }
            else
            {

            }
        }
        public static List<Contact> LoadContactsFile(User user)
        {
            List<Contact> contactsList = new List<Contact>();
            if (File.Exists(_contactsFileName))
            {
                var contacts = System.IO.File.ReadLines(_contactsFileName);

                if (contacts.Count() > 0)
                {
                    foreach (var contact in contacts)
                    {
                        var line = contact.Split(";;");
                        if (int.Parse(line[0]) == user.getId())
                        {
                            var name = line[1];
                            var phone = line[2];
                            var isContacted = bool.Parse(line[3]);
                            contactsList.Add(new Contact(name, phone, isContacted));
                        }
                    }
                }
            }
            return contactsList;
        }
        public static void RegisterUser(User user) 
        {
            const int _firstId = 1; //First ID

            if (File.Exists(_userFileName)) //Checks if the file already exist
            {
                using (StreamReader reader = new StreamReader(_userFileName))
                {
                    string line;
                    string lastLine = null;
                    int newId;

                    while ((line = reader.ReadLine()) != null)
                    {
                        // Atualiza a última linha a cada iteração
                        lastLine = line;

                        if (reader.EndOfStream)
                        {
                            var splittedLine = lastLine.Split(";;");
                            newId = int.Parse(splittedLine[0]) + 1;
                            reader.Close();
                            using (StreamWriter writer = new StreamWriter(_userFileName, true))
                            {
                                writer.WriteLine($"{newId};;{user.GetFullName()};;{user.GetUser()};;{user.GetPassword()};;{user.GetPhone()};;{user.GetEmail()}");
                                break;
                            }
                        }
                    }
                }
            }
            else //if don't, then create it
            {
                using (StreamWriter outputfile = new StreamWriter(_userFileName))
                {
                    outputfile.WriteLine($"{_firstId};;{user.GetFullName()};;{user.GetUser()};;{user.GetPassword()};;{user.GetPhone()};;{user.GetEmail()}");
                }
            }
        }
        public static User LoginIn(string userName, string password) 
        {
            User user = new User();
            bool isUser = false;

            if (File.Exists(_userFileName))
            {
                using (StreamReader reader = new StreamReader(_userFileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var readLine = line.Split(";;");
                        if (readLine[2] == userName)
                        {
                            if (readLine[3] == password)
                            {
                                isUser = true;

                                user = new User(int.Parse(readLine[0]), readLine[1], readLine[2], readLine[3], readLine[5], readLine[4]);
                            }
                        }
                    }
                }
            }
            if(!isUser)
            {
               User userNotFound = new User();
                return userNotFound;
            }
            else
            {
                return user;
            }

        }
    }
}
