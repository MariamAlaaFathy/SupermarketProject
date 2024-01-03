namespace SupermarketProject
{
    partial class OwnerForm
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
            ownerID = new TextBox();
            Manag_ID = new Label();
            ownerPassword = new TextBox();
            Manag_Pass = new Label();
            Login = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // ownerID
            // 
            ownerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ownerID.ForeColor = SystemColors.ScrollBar;
            ownerID.Location = new Point(222, 74);
            ownerID.Margin = new Padding(2);
            ownerID.Name = "ownerID";
            ownerID.Size = new Size(254, 34);
            ownerID.TabIndex = 5;
            ownerID.Text = "your id";
            ownerID.TextAlign = HorizontalAlignment.Center;
            // 
            // Manag_ID
            // 
            Manag_ID.AutoSize = true;
            Manag_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_ID.Location = new Point(61, 74);
            Manag_ID.Margin = new Padding(2, 0, 2, 0);
            Manag_ID.Name = "Manag_ID";
            Manag_ID.Size = new Size(131, 28);
            Manag_ID.TabIndex = 4;
            Manag_ID.Text = "Employee ID";
            // 
            // ownerPassword
            // 
            ownerPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ownerPassword.ForeColor = SystemColors.ScrollBar;
            ownerPassword.Location = new Point(222, 207);
            ownerPassword.Margin = new Padding(2);
            ownerPassword.Name = "ownerPassword";
            ownerPassword.Size = new Size(254, 34);
            ownerPassword.TabIndex = 7;
            ownerPassword.Text = "your password";
            ownerPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // Manag_Pass
            // 
            Manag_Pass.AutoSize = true;
            Manag_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_Pass.Location = new Point(79, 207);
            Manag_Pass.Margin = new Padding(2, 0, 2, 0);
            Manag_Pass.Name = "Manag_Pass";
            Manag_Pass.Size = new Size(101, 28);
            Manag_Pass.TabIndex = 6;
            Manag_Pass.Text = "Password";
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.HotTrack;
            Login.Location = new Point(316, 293);
            Login.Margin = new Padding(2);
            Login.Name = "Login";
            Login.Size = new Size(148, 37);
            Login.TabIndex = 8;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(79, 293);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(148, 37);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OwnerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 360);
            Controls.Add(button1);
            Controls.Add(Login);
            Controls.Add(ownerPassword);
            Controls.Add(Manag_Pass);
            Controls.Add(ownerID);
            Controls.Add(Manag_ID);
            Margin = new Padding(2);
            Name = "OwnerForm";
            Text = "Owner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ownerID;
        private Label Manag_ID;
        private TextBox ownerPassword;
        private Label Manag_Pass;
        private Button Login;
        private Button button1;
    }
}