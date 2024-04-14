namespace ContactManager
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            userBox = new TextBox();
            passwordBox = new TextBox();
            signInButton = new Button();
            registerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 53);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // userBox
            // 
            userBox.Location = new Point(62, 27);
            userBox.Name = "userBox";
            userBox.Size = new Size(171, 23);
            userBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(62, 71);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(171, 23);
            passwordBox.TabIndex = 3;
            // 
            // signInButton
            // 
            signInButton.BackColor = SystemColors.GradientActiveCaption;
            signInButton.Location = new Point(62, 109);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(75, 23);
            signInButton.TabIndex = 4;
            signInButton.Text = "Login";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(158, 109);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 171);
            Controls.Add(registerButton);
            Controls.Add(signInButton);
            Controls.Add(passwordBox);
            Controls.Add(userBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userBox;
        private TextBox passwordBox;
        private Button signInButton;
        private Button registerButton;
    }
}
