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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(62, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 3;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(62, 109);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(75, 23);
            signInButton.TabIndex = 4;
            signInButton.Text = "Sign in";
            signInButton.UseVisualStyleBackColor = true;
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
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button signInButton;
        private Button registerButton;
    }
}
