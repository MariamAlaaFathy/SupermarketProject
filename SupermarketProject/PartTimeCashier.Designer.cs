namespace SupermarketProject
{
    partial class PartTimeCashier
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
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(327, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 31);
            textBox1.TabIndex = 4;
            textBox1.Text = "Salay $$";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 69);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 3;
            label1.Text = "Salary";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(327, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 31);
            textBox2.TabIndex = 6;
            textBox2.Text = "number of customers";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 223);
            label2.Name = "label2";
            label2.Size = new Size(260, 32);
            label2.TabIndex = 5;
            label2.Text = "number of customers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 353);
            label3.Name = "label3";
            label3.Size = new Size(171, 32);
            label3.TabIndex = 7;
            label3.Text = "hours worked";
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(327, 353);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(305, 31);
            textBox3.TabIndex = 8;
            textBox3.Text = "hours worked";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // PartTimeCashier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PartTimeCashier";
            Text = "PartTimeCashier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
    }
}