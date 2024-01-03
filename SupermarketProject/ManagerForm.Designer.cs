namespace SupermarketProject
{
    partial class ManagerForm
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
            Manag_ID = new Label();
            managerID = new TextBox();
            Manag_Pass = new Label();
            ManagerPassword = new TextBox();
            Login = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // Manag_ID
            // 
            Manag_ID.AutoSize = true;
            Manag_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_ID.Location = new Point(52, 66);
            Manag_ID.Margin = new Padding(2, 0, 2, 0);
            Manag_ID.Name = "Manag_ID";
            Manag_ID.Size = new Size(131, 28);
            Manag_ID.TabIndex = 0;
            Manag_ID.Text = "Employee ID";
            // 
            // managerID
            // 
            managerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managerID.ForeColor = SystemColors.ScrollBar;
            managerID.Location = new Point(206, 66);
            managerID.Margin = new Padding(2);
            managerID.Name = "managerID";
            managerID.Size = new Size(262, 34);
            managerID.TabIndex = 1;
            managerID.Text = "your id";
            managerID.TextAlign = HorizontalAlignment.Center;
            // 
            // Manag_Pass
            // 
            Manag_Pass.AutoSize = true;
            Manag_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_Pass.Location = new Point(71, 184);
            Manag_Pass.Margin = new Padding(2, 0, 2, 0);
            Manag_Pass.Name = "Manag_Pass";
            Manag_Pass.Size = new Size(101, 28);
            Manag_Pass.TabIndex = 2;
            Manag_Pass.Text = "Password";
            // 
            // ManagerPassword
            // 
            ManagerPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManagerPassword.ForeColor = SystemColors.ScrollBar;
            ManagerPassword.Location = new Point(206, 178);
            ManagerPassword.Margin = new Padding(2);
            ManagerPassword.Name = "ManagerPassword";
            ManagerPassword.Size = new Size(262, 34);
            ManagerPassword.TabIndex = 3;
            ManagerPassword.Text = "your password";
            ManagerPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.HotTrack;
            Login.Location = new Point(311, 284);
            Login.Margin = new Padding(2);
            Login.Name = "Login";
            Login.Size = new Size(148, 37);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.HotTrack;
            BackButton.Location = new Point(71, 284);
            BackButton.Margin = new Padding(2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(148, 37);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 360);
            Controls.Add(BackButton);
            Controls.Add(Login);
            Controls.Add(ManagerPassword);
            Controls.Add(Manag_Pass);
            Controls.Add(managerID);
            Controls.Add(Manag_ID);
            Margin = new Padding(2);
            Name = "ManagerForm";
            Text = "Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Manag_ID;
        private TextBox managerID;
        private Label Manag_Pass;
        private TextBox ManagerPassword;
        private Button Login;
        private Button BackButton;
    }
}