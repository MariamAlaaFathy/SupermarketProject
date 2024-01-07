namespace SupermarketProject
{
    partial class CustomerLogin
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
            customerID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Password2 = new TextBox();
            label3 = new Label();
            BackButton = new Button();
            showbutton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(561, 410);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(225, 62);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // customerID
            // 
            customerID.ForeColor = SystemColors.ActiveBorder;
            customerID.Location = new Point(459, 168);
            customerID.Margin = new Padding(4, 4, 4, 4);
            customerID.Multiline = true;
            customerID.Name = "customerID";
            customerID.Size = new Size(298, 45);
            customerID.TabIndex = 1;
            customerID.Text = "enter your email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 168);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 45);
            label1.TabIndex = 2;
            label1.Text = "email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(266, 284);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 45);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Password2
            // 
            Password2.ForeColor = SystemColors.ActiveBorder;
            Password2.Location = new Point(459, 284);
            Password2.Margin = new Padding(4, 4, 4, 4);
            Password2.Multiline = true;
            Password2.Name = "Password2";
            Password2.Size = new Size(298, 45);
            Password2.TabIndex = 4;
            Password2.Text = "your password";
            Password2.TextChanged += Password2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.Location = new Point(345, 58);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(261, 38);
            label3.TabIndex = 5;
            label3.Text = "Customer Login";
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.HotTrack;
            BackButton.Location = new Point(241, 410);
            BackButton.Margin = new Padding(4, 4, 4, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(225, 62);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // showbutton
            // 
            showbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            showbutton.ForeColor = SystemColors.HotTrack;
            showbutton.Location = new Point(791, 284);
            showbutton.Margin = new Padding(2);
            showbutton.Name = "showbutton";
            showbutton.Size = new Size(111, 46);
            showbutton.TabIndex = 20;
            showbutton.Text = "show";
            showbutton.UseVisualStyleBackColor = true;
            showbutton.Click += showbutton_Click;
            // 
            // CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(showbutton);
            Controls.Add(BackButton);
            Controls.Add(label3);
            Controls.Add(Password2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customerID);
            Controls.Add(button1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CustomerLogin";
            Text = "Customer Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox customerID;
        private Label label1;
        private Label label2;
        private TextBox Password2;
        private Label label3;
        private Button BackButton;
        private Button showbutton;
    }
}