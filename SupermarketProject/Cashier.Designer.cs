namespace SupermarketProject
{
    partial class CashierDesign
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
            cashier_ID = new TextBox();
            Manag_ID = new Label();
            cashier_PAssword = new TextBox();
            Manag_Pass = new Label();
            Login = new Button();
            SuspendLayout();
            // 
            // cashier_ID
            // 
            cashier_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashier_ID.ForeColor = SystemColors.ScrollBar;
            cashier_ID.Location = new Point(263, 84);
            cashier_ID.Name = "cashier_ID";
            cashier_ID.Size = new Size(316, 39);
            cashier_ID.TabIndex = 3;
            cashier_ID.Text = "your id";
            cashier_ID.TextAlign = HorizontalAlignment.Center;
            // 
            // Manag_ID
            // 
            Manag_ID.AutoSize = true;
            Manag_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_ID.Location = new Point(61, 84);
            Manag_ID.Name = "Manag_ID";
            Manag_ID.Size = new Size(158, 32);
            Manag_ID.TabIndex = 2;
            Manag_ID.Text = "Employee ID";
            // 
            // cashier_PAssword
            // 
            cashier_PAssword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashier_PAssword.ForeColor = SystemColors.ScrollBar;
            cashier_PAssword.Location = new Point(252, 229);
            cashier_PAssword.Name = "cashier_PAssword";
            cashier_PAssword.Size = new Size(327, 39);
            cashier_PAssword.TabIndex = 5;
            cashier_PAssword.Text = "your password";
            cashier_PAssword.TextAlign = HorizontalAlignment.Center;
            // 
            // Manag_Pass
            // 
            Manag_Pass.AutoSize = true;
            Manag_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_Pass.Location = new Point(61, 229);
            Manag_Pass.Name = "Manag_Pass";
            Manag_Pass.Size = new Size(122, 32);
            Manag_Pass.TabIndex = 4;
            Manag_Pass.Text = "Password";
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.HotTrack;
            Login.Location = new Point(293, 366);
            Login.Name = "Login";
            Login.Size = new Size(185, 46);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            // 
            // CashierDesign
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(cashier_PAssword);
            Controls.Add(Manag_Pass);
            Controls.Add(cashier_ID);
            Controls.Add(Manag_ID);
            Name = "CashierDesign";
            Text = "CashierDesign";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cashier_ID;
        private Label Manag_ID;
        private TextBox cashier_PAssword;
        private Label Manag_Pass;
        private Button Login;
    }
}