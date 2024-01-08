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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            will_pay = new TextBox();
            label4 = new Label();
            label6 = new Label();
            rent_left = new Button();
            RentLeft = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            GainLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 3;
            label1.Text = "Rent Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 166);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 5;
            label2.Text = "Rent Due";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(354, 44);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 7;
            label3.Text = "Will Pay";
            // 
            // will_pay
            // 
            will_pay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            will_pay.ForeColor = SystemColors.ScrollBar;
            will_pay.Location = new Point(477, 47);
            will_pay.Margin = new Padding(2);
            will_pay.Name = "will_pay";
            will_pay.Size = new Size(108, 27);
            will_pay.TabIndex = 8;
            will_pay.Text = "$$";
            will_pay.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 113);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 9;
            label4.Text = "Bills";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(93, 298);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(173, 28);
            label6.TabIndex = 13;
            label6.Text = "Overall Rent Left";
            // 
            // rent_left
            // 
            rent_left.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rent_left.ForeColor = SystemColors.HotTrack;
            rent_left.Location = new Point(354, 362);
            rent_left.Margin = new Padding(2);
            rent_left.Name = "rent_left";
            rent_left.Size = new Size(148, 37);
            rent_left.TabIndex = 14;
            rent_left.Text = "Calculate";
            rent_left.UseVisualStyleBackColor = true;
            rent_left.Click += rent_left_Click;
            // 
            // RentLeft
            // 
            RentLeft.AutoSize = true;
            RentLeft.Font = new Font("Akhbar MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            RentLeft.Location = new Point(416, 300);
            RentLeft.Name = "RentLeft";
            RentLeft.Size = new Size(28, 33);
            RentLeft.TabIndex = 15;
            RentLeft.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Akhbar MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label8.Location = new Point(229, 115);
            label8.Name = "label8";
            label8.Size = new Size(67, 33);
            label8.TabIndex = 16;
            label8.Text = "1000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Akhbar MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label9.Location = new Point(216, 48);
            label9.Name = "label9";
            label9.Size = new Size(80, 33);
            label9.TabIndex = 17;
            label9.Text = "10000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Akhbar MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label10.Location = new Point(200, 168);
            label10.Name = "label10";
            label10.Size = new Size(129, 33);
            label10.TabIndex = 18;
            label10.Text = "01/01/2024";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 224);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 28);
            label5.TabIndex = 11;
            label5.Text = "Gain";
            // 
            // GainLabel
            // 
            GainLabel.AutoSize = true;
            GainLabel.Font = new Font("Akhbar MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            GainLabel.Location = new Point(239, 226);
            GainLabel.Name = "GainLabel";
            GainLabel.Size = new Size(28, 33);
            GainLabel.TabIndex = 19;
            GainLabel.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(93, 362);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(148, 37);
            button1.TabIndex = 20;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OwnerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 428);
            Controls.Add(button1);
            Controls.Add(GainLabel);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(RentLeft);
            Controls.Add(rent_left);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(will_pay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "OwnerDetail";
            Text = "OwnerDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox will_pay;
        private Label label4;
        private Label label6;
        private Button rent_left;
        private Label RentLeft;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label5;
        private Label GainLabel;
        private Button button1;
    }
}