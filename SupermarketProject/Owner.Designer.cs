namespace SupermarketProject
{
    partial class OwnerDesign
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
            textBox1 = new TextBox();
            Manag_ID = new Label();
            textBox2 = new TextBox();
            Manag_Pass = new Label();
            Login = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(278, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 39);
            textBox1.TabIndex = 5;
            textBox1.Text = "your id";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Manag_ID
            // 
            Manag_ID.AutoSize = true;
            Manag_ID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_ID.Location = new Point(76, 93);
            Manag_ID.Name = "Manag_ID";
            Manag_ID.Size = new Size(158, 32);
            Manag_ID.TabIndex = 4;
            Manag_ID.Text = "Employee ID";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(267, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 39);
            textBox2.TabIndex = 7;
            textBox2.Text = "your password";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Manag_Pass
            // 
            Manag_Pass.AutoSize = true;
            Manag_Pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manag_Pass.Location = new Point(76, 259);
            Manag_Pass.Name = "Manag_Pass";
            Manag_Pass.Size = new Size(122, 32);
            Manag_Pass.TabIndex = 6;
            Manag_Pass.Text = "Password";
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.HotTrack;
            Login.Location = new Point(325, 371);
            Login.Name = "Login";
            Login.Size = new Size(185, 46);
            Login.TabIndex = 8;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            // 
            // OwnerDesign
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(textBox2);
            Controls.Add(Manag_Pass);
            Controls.Add(textBox1);
            Controls.Add(Manag_ID);
            Name = "OwnerDesign";
            Text = "OwnerDesign";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label Manag_ID;
        private TextBox textBox2;
        private Label Manag_Pass;
        private Button Login;
    }
}