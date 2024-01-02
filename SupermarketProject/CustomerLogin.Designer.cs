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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(322, 330);
            button1.Name = "button1";
            button1.Size = new Size(180, 50);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // customerID
            // 
            customerID.ForeColor = SystemColors.ActiveBorder;
            customerID.Location = new Point(367, 134);
            customerID.Multiline = true;
            customerID.Name = "customerID";
            customerID.Size = new Size(239, 37);
            customerID.TabIndex = 1;
            customerID.Text = "Your customer ID";
            customerID.TextChanged += customerID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 133);
            label1.Name = "label1";
            label1.Size = new Size(44, 38);
            label1.TabIndex = 2;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(213, 227);
            label2.Name = "label2";
            label2.Size = new Size(128, 37);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Password2
            // 
            Password2.ForeColor = SystemColors.ActiveBorder;
            Password2.Location = new Point(367, 227);
            Password2.Multiline = true;
            Password2.Name = "Password2";
            Password2.Size = new Size(239, 37);
            Password2.TabIndex = 4;
            Password2.Text = "your password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Akhbar MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.Location = new Point(276, 46);
            label3.Name = "label3";
            label3.Size = new Size(272, 49);
            label3.TabIndex = 5;
            label3.Text = "Customer Login";
            label3.Click += label3_Click;
            // 
            // CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(Password2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customerID);
            Controls.Add(button1);
            Name = "CustomerLogin";
            Text = "your Customer ID";
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
    }
}