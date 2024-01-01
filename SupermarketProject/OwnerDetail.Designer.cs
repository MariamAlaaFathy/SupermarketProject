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
            rent_amount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            rent_due = new TextBox();
            label3 = new Label();
            will_pay = new TextBox();
            bills = new TextBox();
            label4 = new Label();
            gain = new TextBox();
            label5 = new Label();
            label6 = new Label();
            rent_left = new Button();
            SuspendLayout();
            // 
            // rent_amount
            // 
            rent_amount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rent_amount.ForeColor = SystemColors.ScrollBar;
            rent_amount.Location = new Point(247, 57);
            rent_amount.Name = "rent_amount";
            rent_amount.Size = new Size(134, 31);
            rent_amount.TabIndex = 4;
            rent_amount.Text = "$$";
            rent_amount.TextAlign = HorizontalAlignment.Center;
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
            // rent_due
            // 
            rent_due.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rent_due.ForeColor = SystemColors.ScrollBar;
            rent_due.Location = new Point(207, 203);
            rent_due.Name = "rent_due";
            rent_due.Size = new Size(221, 31);
            rent_due.TabIndex = 6;
            rent_due.Text = "date";
            rent_due.TextAlign = HorizontalAlignment.Center;
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
            // will_pay
            // 
            will_pay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            will_pay.ForeColor = SystemColors.ScrollBar;
            will_pay.Location = new Point(560, 58);
            will_pay.Name = "will_pay";
            will_pay.Size = new Size(134, 31);
            will_pay.TabIndex = 8;
            will_pay.Text = "$$";
            will_pay.TextAlign = HorizontalAlignment.Center;
            // 
            // bills
            // 
            bills.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bills.ForeColor = SystemColors.ScrollBar;
            bills.Location = new Point(246, 141);
            bills.Name = "bills";
            bills.Size = new Size(134, 31);
            bills.TabIndex = 10;
            bills.Text = "$$";
            bills.TextAlign = HorizontalAlignment.Center;
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
            // gain
            // 
            gain.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gain.ForeColor = SystemColors.ScrollBar;
            gain.Location = new Point(247, 280);
            gain.Name = "gain";
            gain.Size = new Size(134, 31);
            gain.TabIndex = 12;
            gain.Text = "$$";
            gain.TextAlign = HorizontalAlignment.Center;
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
            // rent_left
            // 
            rent_left.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rent_left.ForeColor = SystemColors.HotTrack;
            rent_left.Location = new Point(247, 364);
            rent_left.Name = "rent_left";
            rent_left.Size = new Size(185, 46);
            rent_left.TabIndex = 14;
            rent_left.Text = "calculate";
            rent_left.UseVisualStyleBackColor = true;
            // 
            // OwnerDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rent_left);
            Controls.Add(label6);
            Controls.Add(gain);
            Controls.Add(label5);
            Controls.Add(bills);
            Controls.Add(label4);
            Controls.Add(will_pay);
            Controls.Add(label3);
            Controls.Add(rent_due);
            Controls.Add(label2);
            Controls.Add(rent_amount);
            Controls.Add(label1);
            Name = "OwnerDetail";
            Text = "OwnerDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox rent_amount;
        private Label label1;
        private Label label2;
        private TextBox rent_due;
        private Label label3;
        private TextBox will_pay;
        private TextBox bills;
        private Label label4;
        private TextBox gain;
        private Label label5;
        private Label label6;
        private Button rent_left;
    }
}