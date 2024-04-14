namespace ContactManager
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            fullNameBox = new TextBox();
            label2 = new Label();
            userBox = new TextBox();
            label3 = new Label();
            passwordBox = new TextBox();
            registerButton = new Button();
            phoneNumberBox = new TextBox();
            emailBox = new TextBox();
            phoneNumberLabel = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 0;
            label1.Text = "Type your full name";
            label1.Click += label1_Click;
            // 
            // fullNameBox
            // 
            fullNameBox.BackColor = SystemColors.Window;
            fullNameBox.Location = new Point(12, 27);
            fullNameBox.Name = "fullNameBox";
            fullNameBox.Size = new Size(331, 23);
            fullNameBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Type the user";
            // 
            // userBox
            // 
            userBox.Location = new Point(12, 71);
            userBox.Name = "userBox";
            userBox.Size = new Size(171, 23);
            userBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(249, 15);
            label3.TabIndex = 4;
            label3.Text = "Type the password(It can be anything)";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(12, 115);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(171, 23);
            passwordBox.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.BackColor = SystemColors.ActiveCaption;
            registerButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.Location = new Point(243, 155);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(163, 49);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.Location = new Point(421, 27);
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.Size = new Size(175, 23);
            phoneNumberBox.TabIndex = 7;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(421, 71);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(175, 23);
            emailBox.TabIndex = 8;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberLabel.Location = new Point(421, 10);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(153, 15);
            phoneNumberLabel.TabIndex = 9;
            phoneNumberLabel.Text = "Type your fone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(422, 53);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 10;
            label5.Text = "Type your email";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 253);
            Controls.Add(label5);
            Controls.Add(phoneNumberLabel);
            Controls.Add(emailBox);
            Controls.Add(phoneNumberBox);
            Controls.Add(registerButton);
            Controls.Add(passwordBox);
            Controls.Add(label3);
            Controls.Add(userBox);
            Controls.Add(label2);
            Controls.Add(fullNameBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Text = "User Register";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fullNameBox;
        private Label label2;
        private TextBox userBox;
        private Label label3;
        private TextBox passwordBox;
        private Button registerButton;
        private TextBox phoneNumberBox;
        private TextBox emailBox;
        private Label phoneNumberLabel;
        private Label label5;
    }
}