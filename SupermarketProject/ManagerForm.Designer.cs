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
            ManagerPAssword = new TextBox();
            Login = new Button();
            SuspendLayout();
            // 
            // Manag_ID
            // 
            Manag_ID.AutoSize = true;
            Manag_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_ID.Location = new Point(65, 82);
            Manag_ID.Margin = new Padding(2, 0, 2, 0);
            Manag_ID.Name = "Manag_ID";
            Manag_ID.Size = new Size(158, 32);
            Manag_ID.TabIndex = 0;
            Manag_ID.Text = "Employee ID";
            Manag_ID.Click += Manag_ID_Click;
            // 
            // managerID
            // 
            managerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managerID.ForeColor = SystemColors.ScrollBar;
            managerID.Location = new Point(258, 82);
            managerID.Margin = new Padding(2);
            managerID.Name = "managerID";
            managerID.Size = new Size(326, 39);
            managerID.TabIndex = 1;
            managerID.Text = "your id";
            managerID.TextAlign = HorizontalAlignment.Center;
            managerID.TextChanged += managerID_TextChanged;
            // 
            // Manag_Pass
            // 
            Manag_Pass.AutoSize = true;
            Manag_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_Pass.Location = new Point(89, 230);
            Manag_Pass.Margin = new Padding(2, 0, 2, 0);
            Manag_Pass.Name = "Manag_Pass";
            Manag_Pass.Size = new Size(122, 32);
            Manag_Pass.TabIndex = 2;
            Manag_Pass.Text = "Password";
            Manag_Pass.Click += Manag_Pass_Click;
            // 
            // ManagerPAssword
            // 
            ManagerPAssword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManagerPAssword.ForeColor = SystemColors.ScrollBar;
            ManagerPAssword.Location = new Point(258, 222);
            ManagerPAssword.Margin = new Padding(2);
            ManagerPAssword.Name = "ManagerPAssword";
            ManagerPAssword.Size = new Size(326, 39);
            ManagerPAssword.TabIndex = 3;
            ManagerPAssword.Text = "your password";
            ManagerPAssword.TextAlign = HorizontalAlignment.Center;
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.HotTrack;
            Login.Location = new Point(239, 355);
            Login.Margin = new Padding(2);
            Login.Name = "Login";
            Login.Size = new Size(185, 46);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 450);
            Controls.Add(Login);
            Controls.Add(ManagerPAssword);
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
        private TextBox ManagerPAssword;
        private Button Login;
    }
}