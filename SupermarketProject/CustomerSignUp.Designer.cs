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
            showbutton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(631, 698);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(212, 58);
            button1.TabIndex = 0;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.HotTrack;
            button2.Location = new Point(178, 698);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(212, 58);
            button2.TabIndex = 1;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 126);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 45);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 195);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 45);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // Firstname
            // 
            Firstname.ForeColor = SystemColors.ActiveBorder;
            Firstname.Location = new Point(435, 128);
            Firstname.Margin = new Padding(4);
            Firstname.Multiline = true;
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(298, 45);
            Firstname.TabIndex = 5;
            Firstname.Text = "Your first name";
            Firstname.TextChanged += Firstname_TextChanged;
            // 
            // Lastname
            // 
            Lastname.ForeColor = SystemColors.ActiveBorder;
            Lastname.Location = new Point(435, 209);
            Lastname.Margin = new Padding(4);
            Lastname.Multiline = true;
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(298, 45);
            Lastname.TabIndex = 6;
            Lastname.Text = "Your last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(269, 274);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 45);
            label3.TabIndex = 7;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // Email
            // 
            Email.ForeColor = SystemColors.ActiveBorder;
            Email.Location = new Point(435, 275);
            Email.Margin = new Padding(4);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.Size = new Size(298, 45);
            Email.TabIndex = 8;
            Email.Text = "name@example.com";
            Email.TextChanged += Email_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(245, 345);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(155, 45);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // Password
            // 
            Password.ForeColor = SystemColors.ActiveBorder;
            Password.Location = new Point(435, 345);
            Password.Margin = new Padding(4);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.Size = new Size(298, 45);
            Password.TabIndex = 10;
            Password.Text = "Your password";
            Password.TextChanged += Password_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(288, 428);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 45);
            label5.TabIndex = 11;
            label5.Text = "Age";
            label5.Click += label5_Click;
            // 
            // Age
            // 
            Age.ForeColor = SystemColors.ActiveBorder;
            Age.Location = new Point(435, 428);
            Age.Margin = new Padding(4);
            Age.Multiline = true;
            Age.Name = "Age";
            Age.Size = new Size(298, 45);
            Age.TabIndex = 12;
            Age.Text = "Your age";
            Age.TextChanged += Age_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1981, 445);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 45);
            label6.TabIndex = 13;
            label6.Text = "Address";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(245, 509);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(135, 45);
            label7.TabIndex = 14;
            label7.Text = "Address";
            label7.Click += label7_Click;
            // 
            // Address
            // 
            Address.ForeColor = SystemColors.ActiveBorder;
            Address.Location = new Point(435, 509);
            Address.Margin = new Padding(4);
            Address.Multiline = true;
            Address.Name = "Address";
            Address.Size = new Size(298, 45);
            Address.TabIndex = 15;
            Address.Text = "ex . 7 Said Zagloul Street";
            Address.TextChanged += Address_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(221, 592);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(181, 45);
            label8.TabIndex = 16;
            label8.Text = "Mobile No.";
            // 
            // Mobile
            // 
            Mobile.ForeColor = SystemColors.ActiveBorder;
            Mobile.Location = new Point(435, 592);
            Mobile.Margin = new Padding(4);
            Mobile.Multiline = true;
            Mobile.Name = "Mobile";
            Mobile.Size = new Size(298, 45);
            Mobile.TabIndex = 17;
            Mobile.Text = "Your mobile number";
            Mobile.TextChanged += Mobile_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label9.Location = new Point(315, 31);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(294, 38);
            label9.TabIndex = 18;
            label9.Text = "Customer Sign up";
            // 
            // showbutton
            // 
            showbutton.Location = new Point(758, 356);
            showbutton.Name = "showbutton";
            showbutton.Size = new Size(112, 34);
            showbutton.TabIndex = 19;
            showbutton.Text = "show";
            showbutton.UseVisualStyleBackColor = true;
            showbutton.Click += showbutton_Click;
            // 
            // CustomerSignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1000, 794);
            Controls.Add(showbutton);
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
            Margin = new Padding(4);
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
        private Button showbutton;
    }
}