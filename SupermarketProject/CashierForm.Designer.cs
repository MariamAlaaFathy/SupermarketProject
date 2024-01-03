namespace SupermarketProject
{
    partial class CashierForm
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
            CashierID = new TextBox();
            Manag_ID = new Label();
            CashierPassword = new TextBox();
            Manag_Pass = new Label();
            Login = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // CashierID
            // 
            CashierID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierID.ForeColor = SystemColors.ScrollBar;
            CashierID.Location = new Point(210, 67);
            CashierID.Margin = new Padding(2);
            CashierID.Name = "CashierID";
            CashierID.Size = new Size(254, 34);
            CashierID.TabIndex = 3;
            CashierID.Text = "your id";
            CashierID.TextAlign = HorizontalAlignment.Center;
            // 
            // Manag_ID
            // 
            Manag_ID.AutoSize = true;
            Manag_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_ID.Location = new Point(49, 67);
            Manag_ID.Margin = new Padding(2, 0, 2, 0);
            Manag_ID.Name = "Manag_ID";
            Manag_ID.Size = new Size(131, 28);
            Manag_ID.TabIndex = 2;
            Manag_ID.Text = "Employee ID";
            // 
            // CashierPassword
            // 
            CashierPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CashierPassword.ForeColor = SystemColors.ScrollBar;
            CashierPassword.Location = new Point(210, 183);
            CashierPassword.Margin = new Padding(2);
            CashierPassword.Name = "CashierPassword";
            CashierPassword.Size = new Size(254, 34);
            CashierPassword.TabIndex = 5;
            CashierPassword.Text = "your password";
            CashierPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // Manag_Pass
            // 
            Manag_Pass.AutoSize = true;
            Manag_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_Pass.Location = new Point(65, 183);
            Manag_Pass.Margin = new Padding(2, 0, 2, 0);
            Manag_Pass.Name = "Manag_Pass";
            Manag_Pass.Size = new Size(101, 28);
            Manag_Pass.TabIndex = 4;
            Manag_Pass.Text = "Password";
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.HotTrack;
            Login.Location = new Point(289, 287);
            Login.Margin = new Padding(2);
            Login.Name = "Login";
            Login.Size = new Size(148, 37);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.HotTrack;
            BackButton.Location = new Point(89, 287);
            BackButton.Margin = new Padding(2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(148, 37);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 360);
            Controls.Add(BackButton);
            Controls.Add(Login);
            Controls.Add(CashierPassword);
            Controls.Add(Manag_Pass);
            Controls.Add(CashierID);
            Controls.Add(Manag_ID);
            Margin = new Padding(2);
            Name = "CashierForm";
            Text = "Cashier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CashierID;
        private Label Manag_ID;
        private TextBox CashierPassword;
        private Label Manag_Pass;
        private Button Login;
        private Button BackButton;
    }
}