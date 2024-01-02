namespace SupermarketProject
{
    partial class CustomerSignUp
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            Firstname = new TextBox();
            Lastname = new TextBox();
            label3 = new Label();
            Email = new TextBox();
            label4 = new Label();
            Password = new TextBox();
            label5 = new Label();
            Age = new TextBox();
            label6 = new Label();
            label7 = new Label();
            Address = new TextBox();
            label8 = new Label();
            Mobile = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(142, 551);
            button1.Name = "button1";
            button1.Size = new Size(170, 46);
            button1.TabIndex = 0;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(498, 551);
            button2.Name = "button2";
            button2.Size = new Size(170, 46);
            button2.TabIndex = 1;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 101);
            label1.Name = "label1";
            label1.Size = new Size(151, 38);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(184, 156);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // Firstname
            // 
            Firstname.ForeColor = SystemColors.ActiveBorder;
            Firstname.Location = new Point(348, 102);
            Firstname.Multiline = true;
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(239, 37);
            Firstname.TabIndex = 5;
            Firstname.Text = "Your first name";
            // 
            // Lastname
            // 
            Lastname.ForeColor = SystemColors.ActiveBorder;
            Lastname.Location = new Point(348, 167);
            Lastname.Multiline = true;
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(239, 37);
            Lastname.TabIndex = 6;
            Lastname.Text = "Your last name";
            Lastname.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(215, 219);
            label3.Name = "label3";
            label3.Size = new Size(83, 38);
            label3.TabIndex = 7;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // Email
            // 
            Email.ForeColor = SystemColors.ActiveBorder;
            Email.Location = new Point(348, 220);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.Size = new Size(239, 37);
            Email.TabIndex = 8;
            Email.Text = "name@example.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(196, 276);
            label4.Name = "label4";
            label4.Size = new Size(132, 38);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // Password
            // 
            Password.ForeColor = SystemColors.ActiveBorder;
            Password.Location = new Point(348, 276);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(239, 37);
            Password.TabIndex = 10;
            Password.Text = "Your password";
            Password.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(230, 342);
            label5.Name = "label5";
            label5.Size = new Size(66, 38);
            label5.TabIndex = 11;
            label5.Text = "Age";
            label5.Click += label5_Click;
            // 
            // Age
            // 
            Age.ForeColor = SystemColors.ActiveBorder;
            Age.Location = new Point(348, 342);
            Age.Multiline = true;
            Age.Name = "Age";
            Age.Size = new Size(239, 37);
            Age.TabIndex = 12;
            Age.Text = "Your age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1585, 356);
            label6.Name = "label6";
            label6.Size = new Size(116, 38);
            label6.TabIndex = 13;
            label6.Text = "Address";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(196, 407);
            label7.Name = "label7";
            label7.Size = new Size(116, 38);
            label7.TabIndex = 14;
            label7.Text = "Address";
            label7.Click += label7_Click;
            // 
            // Address
            // 
            Address.ForeColor = SystemColors.ActiveBorder;
            Address.Location = new Point(348, 407);
            Address.Multiline = true;
            Address.Name = "Address";
            Address.Size = new Size(239, 37);
            Address.TabIndex = 15;
            Address.Text = "ex . 7 Said Zagloul Street";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(177, 474);
            label8.Name = "label8";
            label8.Size = new Size(154, 38);
            label8.TabIndex = 16;
            label8.Text = "Mobile No.";
            // 
            // Mobile
            // 
            Mobile.ForeColor = SystemColors.ActiveBorder;
            Mobile.Location = new Point(348, 474);
            Mobile.Multiline = true;
            Mobile.Name = "Mobile";
            Mobile.Size = new Size(239, 37);
            Mobile.TabIndex = 17;
            Mobile.Text = "Your mobile number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Akhbar MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label9.Location = new Point(252, 25);
            label9.Name = "label9";
            label9.Size = new Size(302, 49);
            label9.TabIndex = 18;
            label9.Text = "Customer Sign up";
            // 
            // CustomerSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 635);
            Controls.Add(label9);
            Controls.Add(Mobile);
            Controls.Add(label8);
            Controls.Add(Address);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Age);
            Controls.Add(label5);
            Controls.Add(Password);
            Controls.Add(label4);
            Controls.Add(Email);
            Controls.Add(label3);
            Controls.Add(Lastname);
            Controls.Add(Firstname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CustomerSignUp";
            Text = "Customer Sign Up";
            Load += CustomerSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox Firstname;
        private TextBox Lastname;
        private Label label3;
        private TextBox Email;
        private Label label4;
        private TextBox Password;
        private Label label5;
        private TextBox Age;
        private Label label6;
        private Label label7;
        private TextBox Address;
        private Label label8;
        private TextBox Mobile;
        private Label label9;
    }
}