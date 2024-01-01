namespace SupermarketProject
{
    partial class OwnerDetail
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
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Login = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(247, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 31);
            textBox1.TabIndex = 4;
            textBox1.Text = "$$";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 57);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 3;
            label1.Text = "rent amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 203);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 5;
            label2.Text = "rent due";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(207, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 31);
            textBox2.TabIndex = 6;
            textBox2.Text = "date";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(443, 55);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 7;
            label3.Text = "will pay";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(560, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 31);
            textBox3.TabIndex = 8;
            textBox3.Text = "$$";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(246, 141);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 31);
            textBox4.TabIndex = 10;
            textBox4.Text = "$$";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 141);
            label4.Name = "label4";
            label4.Size = new Size(61, 32);
            label4.TabIndex = 9;
            label4.Text = "bills";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = SystemColors.ScrollBar;
            textBox5.Location = new Point(247, 280);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(134, 31);
            textBox5.TabIndex = 12;
            textBox5.Text = "$$";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 277);
            label5.Name = "label5";
            label5.Size = new Size(64, 32);
            label5.TabIndex = 11;
            label5.Text = "gain";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 364);
            label6.Name = "label6";
            label6.Size = new Size(191, 32);
            label6.TabIndex = 13;
            label6.Text = "overall rent left";
            // 
            // Login
            // 
            Login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = SystemColors.HotTrack;
            Login.Location = new Point(247, 364);
            Login.Name = "Login";
            Login.Size = new Size(185, 46);
            Login.TabIndex = 14;
            Login.Text = "calculate";
            Login.UseVisualStyleBackColor = true;
            // 
            // OwnerDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "OwnerDetail";
            Text = "OwnerDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private Button Login;
    }
}