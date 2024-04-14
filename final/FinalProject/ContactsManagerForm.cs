using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class ContactsManagerForm : Form
    {
        User _localUser;
        List<Contact> contacts;
        private ToolTip _tpAddContactButton = new ToolTip();
        private ToolTip _tpMarkAsContactedButton = new ToolTip();
        private ToolTip _tpRemoveContactButton = new ToolTip();
        private ToolTip _tpResetContactButton = new ToolTip();
        private ToolTip _tpUnmakContactButton = new ToolTip();
        private ToolTip _tpSignOutButton = new ToolTip();

        Thread tLoginForm;
        public ContactsManagerForm(User user)
        {
            InitializeComponent();
            lblUserName.Text = user.GetFullName();
            _localUser = user;
        }

        private void LoadContactsForm()
        {
            _tpAddContactButton.SetToolTip(btnAddContact, "Click here to add a contact");
            _tpMarkAsContactedButton.SetToolTip(btnMarkAsContacted, "Click here to mark  contacts");
            _tpResetContactButton.SetToolTip(btnResetContacts, "Click here to reset contacts(This will unmark all your contacts)");
            _tpUnmakContactButton.SetToolTip(btnUnmarkContacts, "Click here to unmark contacts");
            _tpRemoveContactButton.SetToolTip(btnRemoveContact, "Click to remove only one marked contact");
            _tpSignOutButton.SetToolTip(btnSignOutButton, "Click to sign out");

            this.checkedListBox1.Items.Clear();
            contacts = Manager.LoadContactsFile(_localUser);
            foreach (var contact in contacts)
            {
                if (contact.GetIsContacted() == false)
                {
                    this.checkedListBox1.Items.Add(contact.GetName());
                }
                else
                {
                    this.checkedListBox1.Items.Add("[OK]" + contact.GetName());
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if(txtBoxUserName.Text == "" || txtBoxPhoneContact.Text == "")
            {
                MessageBox.Show("Please, fill all the blank fields to add a contact!");
            }
            else
            {
                Manager.SaveContactInfo(_localUser, txtBoxUserName.Text, txtBoxPhoneContact.Text);
                txtBoxUserName.Clear();
                txtBoxPhoneContact.Clear();
                LoadContactsForm();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ContactsManagerForm_Load(object sender, EventArgs e)
        {
            LoadContactsForm();
        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            tLoginForm = new Thread(() => Application.Run(new LoginForm()));
            tLoginForm.Start();
        }

        private void btnMarkAsContacted_Click(object sender, EventArgs e)
        {
            var markedContacts = this.checkedListBox1.CheckedItems;

            foreach (var mkContact in markedContacts)
            {
                foreach (var contact in contacts)
                {
                    if (contact.GetName() == mkContact)
                    {
                        contact.SetIsContacted(true);
                    }
                }
            }
            Manager.SaveContacts(_localUser, contacts);
            LoadContactsForm();
        }

        private void btnResetContacts_Click(object sender, EventArgs e)
        {
            foreach (var contact in contacts)
            {
                contact.SetIsContacted(false);
            }
            Manager.SaveContacts(_localUser, contacts);
            LoadContactsForm();
        }

        private void btnUnmarkContacts_Click(object sender, EventArgs e)
        {
            var markedContacts = this.checkedListBox1.CheckedItems;

            foreach (var mkContact in markedContacts)
            {
                string newString = mkContact.ToString();
                newString = newString.Replace("[OK]", "");

                foreach (var contact in contacts)
                {
                    if (contact.GetName() == newString)
                    {
                        contact.SetIsContacted(false);
                    }
                }
            }
            Manager.SaveContacts(_localUser, contacts);
            LoadContactsForm();
        }

        private void btnRemoveContact_Click(object sender, EventArgs e)
        {
            var markedContacts = this.checkedListBox1.CheckedItems;

            foreach (var mkContact in markedContacts)
            {
                string newString = mkContact.ToString();
                newString = newString.Replace("[OK]", "");


                for (int i = contacts.Count - 1; i >= 0; i--)
                {   
                    if (contacts[i].GetName() == newString)
                    {
                        contacts.RemoveAt(i);
                    }
                }
            }
            Manager.SaveContacts(_localUser, contacts);
            LoadContactsForm();
        }

        private void btnSeeContactInfo_Click(object sender, EventArgs e)
        {
            StringBuilder infoContacts = new StringBuilder();
            var markedContacts = this.checkedListBox1.CheckedItems;
            if(markedContacts.Count > 0)
            {
                foreach (var mkContact in markedContacts)
                {
                    string newString = mkContact.ToString();
                    newString = newString.Replace("[OK]", "");

                    foreach (var contact in contacts)
                    {
                        if (contact.GetName() == newString)
                        {
                            infoContacts.Append(contact.GetName() + " " + " " + contact.GetPhoneNumber() + "\n");
                        }
                    }
                }
                MessageBox.Show(infoContacts.ToString());
            }
            else
            {
                MessageBox.Show("No contact marked");
            }
        }
    }
}
