using System.Windows.Forms;

namespace ContactManager
{
    partial class ContactsManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsManagerForm));
            lblUserName = new Label();
            btnAddContact = new Button();
            checkedListBox1 = new CheckedListBox();
            lblNewUserNome = new Label();
            txtBoxUserName = new TextBox();
            txtBoxPhoneContact = new TextBox();
            lblNewPhoneContact = new Label();
            btnMarkAsContacted = new Button();
            btnSignOutButton = new Button();
            btnResetContacts = new Button();
            btnUnmarkContacts = new Button();
            btnRemoveContact = new Button();
            btnSeeContactInfo = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(631, 9);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(77, 15);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User name";
            // 
            // btnAddContact
            // 
            btnAddContact.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddContact.ForeColor = SystemColors.ControlText;
            btnAddContact.Image = (Image)resources.GetObject("btnAddContact.Image");
            btnAddContact.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddContact.Location = new Point(530, 382);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(39, 33);
            btnAddContact.TabIndex = 2;
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(501, 364);
            checkedListBox1.TabIndex = 4;
            // 
            // lblNewUserNome
            // 
            lblNewUserNome.AutoSize = true;
            lblNewUserNome.Location = new Point(528, 284);
            lblNewUserNome.Name = "lblNewUserNome";
            lblNewUserNome.Size = new Size(39, 15);
            lblNewUserNome.TabIndex = 5;
            lblNewUserNome.Text = "Name";
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Location = new Point(528, 302);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(216, 23);
            txtBoxUserName.TabIndex = 6;
            // 
            // txtBoxPhoneContact
            // 
            txtBoxPhoneContact.Location = new Point(528, 353);
            txtBoxPhoneContact.Name = "txtBoxPhoneContact";
            txtBoxPhoneContact.Size = new Size(216, 23);
            txtBoxPhoneContact.TabIndex = 8;
            // 
            // lblNewPhoneContact
            // 
            lblNewPhoneContact.AutoSize = true;
            lblNewPhoneContact.Location = new Point(528, 335);
            lblNewPhoneContact.Name = "lblNewPhoneContact";
            lblNewPhoneContact.Size = new Size(84, 15);
            lblNewPhoneContact.TabIndex = 7;
            lblNewPhoneContact.Text = "Phone contact";
            // 
            // btnMarkAsContacted
            // 
            btnMarkAsContacted.Image = (Image)resources.GetObject("btnMarkAsContacted.Image");
            btnMarkAsContacted.ImageAlign = ContentAlignment.MiddleLeft;
            btnMarkAsContacted.Location = new Point(530, 48);
            btnMarkAsContacted.Name = "btnMarkAsContacted";
            btnMarkAsContacted.Size = new Size(39, 36);
            btnMarkAsContacted.TabIndex = 10;
            btnMarkAsContacted.UseVisualStyleBackColor = true;
            btnMarkAsContacted.Click += btnMarkAsContacted_Click;
            // 
            // btnSignOutButton
            // 
            btnSignOutButton.BackColor = SystemColors.ControlDarkDark;
            btnSignOutButton.Image = (Image)resources.GetObject("btnSignOutButton.Image");
            btnSignOutButton.Location = new Point(12, 382);
            btnSignOutButton.Name = "btnSignOutButton";
            btnSignOutButton.Size = new Size(75, 59);
            btnSignOutButton.TabIndex = 11;
            btnSignOutButton.UseVisualStyleBackColor = false;
            btnSignOutButton.Click += btnSignOutButton_Click;
            // 
            // btnResetContacts
            // 
            btnResetContacts.Image = (Image)resources.GetObject("btnResetContacts.Image");
            btnResetContacts.Location = new Point(528, 222);
            btnResetContacts.Name = "btnResetContacts";
            btnResetContacts.Size = new Size(39, 35);
            btnResetContacts.TabIndex = 12;
            btnResetContacts.UseVisualStyleBackColor = true;
            btnResetContacts.Click += btnResetContacts_Click;
            // 
            // btnUnmarkContacts
            // 
            btnUnmarkContacts.Image = (Image)resources.GetObject("btnUnmarkContacts.Image");
            btnUnmarkContacts.Location = new Point(530, 102);
            btnUnmarkContacts.Name = "btnUnmarkContacts";
            btnUnmarkContacts.Size = new Size(37, 41);
            btnUnmarkContacts.TabIndex = 13;
            btnUnmarkContacts.UseVisualStyleBackColor = true;
            btnUnmarkContacts.Click += btnUnmarkContacts_Click;
            // 
            // btnRemoveContact
            // 
            btnRemoveContact.Image = (Image)resources.GetObject("btnRemoveContact.Image");
            btnRemoveContact.Location = new Point(528, 164);
            btnRemoveContact.Name = "btnRemoveContact";
            btnRemoveContact.Size = new Size(39, 42);
            btnRemoveContact.TabIndex = 14;
            btnRemoveContact.UseVisualStyleBackColor = true;
            btnRemoveContact.Click += btnRemoveContact_Click;
            // 
            // btnSeeContactInfo
            // 
            btnSeeContactInfo.Location = new Point(598, 48);
            btnSeeContactInfo.Name = "btnSeeContactInfo";
            btnSeeContactInfo.Size = new Size(146, 33);
            btnSeeContactInfo.TabIndex = 15;
            btnSeeContactInfo.Text = "See contact info";
            btnSeeContactInfo.UseVisualStyleBackColor = true;
            btnSeeContactInfo.Click += btnSeeContactInfo_Click;
            // 
            // ContactsManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeeContactInfo);
            Controls.Add(btnRemoveContact);
            Controls.Add(btnUnmarkContacts);
            Controls.Add(btnResetContacts);
            Controls.Add(btnSignOutButton);
            Controls.Add(btnMarkAsContacted);
            Controls.Add(txtBoxPhoneContact);
            Controls.Add(lblNewPhoneContact);
            Controls.Add(txtBoxUserName);
            Controls.Add(lblNewUserNome);
            Controls.Add(checkedListBox1);
            Controls.Add(btnAddContact);
            Controls.Add(lblUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ContactsManagerForm";
            Text = "Contacts Manager";
            Load += ContactsManagerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Button btnAddContact;
        private CheckedListBox checkedListBox1;
        private Label lblNewUserNome;
        private TextBox txtBoxUserName;
        private TextBox txtBoxPhoneContact;
        private Label lblNewPhoneContact;
        private Button btnMarkAsContacted;
        private Button btnSignOutButton;
        private Button btnResetContacts;
        private Button btnUnmarkContacts;
        private Button btnRemoveContact;
        private Button btnSeeContactInfo;
    }
}