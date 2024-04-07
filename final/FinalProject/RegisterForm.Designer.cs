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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            registerButton = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 23);
            textBox1.TabIndex = 1;
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
            // textBox2
            // 
            textBox2.Location = new Point(12, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(12, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 5;
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
            // 
            // textBox4
            // 
            textBox4.Location = new Point(421, 27);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(421, 71);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(175, 23);
            textBox5.TabIndex = 8;
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
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(registerButton);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "User Register";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button registerButton;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label phoneNumberLabel;
        private Label label5;
    }
}