namespace SupermarketProject
{
    partial class Buy
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
            youramount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            yes = new Button();
            no = new Button();
            SuspendLayout();
            // 
            // youramount
            // 
            youramount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            youramount.ForeColor = SystemColors.ScrollBar;
            youramount.Location = new Point(289, 98);
            youramount.Margin = new Padding(2, 2, 2, 2);
            youramount.Name = "youramount";
            youramount.Size = new Size(223, 27);
            youramount.TabIndex = 4;
            youramount.Text = " $$";
            youramount.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 3;
            label1.Text = "Your Amount: $";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 186);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(352, 28);
            label2.TabIndex = 5;
            label2.Text = "Are you sure you want to purchase?";
            // 
            // yes
            // 
            yes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yes.ForeColor = SystemColors.HotTrack;
            yes.Location = new Point(366, 182);
            yes.Margin = new Padding(2, 2, 2, 2);
            yes.Name = "yes";
            yes.Size = new Size(90, 37);
            yes.TabIndex = 6;
            yes.Text = "Yes";
            yes.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            no.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            no.ForeColor = SystemColors.HotTrack;
            no.Location = new Point(486, 182);
            no.Margin = new Padding(2, 2, 2, 2);
            no.Name = "no";
            no.Size = new Size(88, 37);
            no.TabIndex = 7;
            no.Text = "No";
            no.UseVisualStyleBackColor = true;
            // 
            // Buy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 293);
            Controls.Add(no);
            Controls.Add(yes);
            Controls.Add(label2);
            Controls.Add(youramount);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Buy";
            Text = "Buy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox youramount;
        private Label label1;
        private Label label2;
        private Button yes;
        private Button no;
    }
}