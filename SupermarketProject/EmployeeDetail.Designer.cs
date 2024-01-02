namespace SupermarketProject
{
    partial class ManagerDetail
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
            numofemployees = new TextBox();
            label2 = new Label();
            totalsalary = new TextBox();
            label4 = new Label();
            givebonusto_ID = new TextBox();
            give_bonus = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 28);
            label1.TabIndex = 0;
            label1.Text = "Number Of Employees";
            // 
            // numofemployees
            // 
            numofemployees.ForeColor = SystemColors.ScrollBar;
            numofemployees.Location = new Point(266, 50);
            numofemployees.Margin = new Padding(2, 2, 2, 2);
            numofemployees.Name = "numofemployees";
            numofemployees.Size = new Size(203, 27);
            numofemployees.TabIndex = 1;
            numofemployees.Text = "number of Employees";
            numofemployees.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 131);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 2;
            label2.Text = "Total Salary";
            // 
            // totalsalary
            // 
            totalsalary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalsalary.ForeColor = SystemColors.ScrollBar;
            totalsalary.Location = new Point(266, 132);
            totalsalary.Margin = new Padding(2, 2, 2, 2);
            totalsalary.Name = "totalsalary";
            totalsalary.Size = new Size(203, 27);
            totalsalary.TabIndex = 3;
            totalsalary.Text = "salary $$";
            totalsalary.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 205);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 28);
            label4.TabIndex = 5;
            label4.Text = "Give bonus to:";
            // 
            // givebonusto_ID
            // 
            givebonusto_ID.ForeColor = SystemColors.ScrollBar;
            givebonusto_ID.Location = new Point(266, 206);
            givebonusto_ID.Margin = new Padding(2, 2, 2, 2);
            givebonusto_ID.Name = "givebonusto_ID";
            givebonusto_ID.Size = new Size(203, 27);
            givebonusto_ID.TabIndex = 6;
            givebonusto_ID.Text = "put the ID";
            givebonusto_ID.TextAlign = HorizontalAlignment.Center;
            // 
            // give_bonus
            // 
            give_bonus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            give_bonus.ForeColor = SystemColors.HotTrack;
            give_bonus.Location = new Point(116, 294);
            give_bonus.Margin = new Padding(2, 2, 2, 2);
            give_bonus.Name = "give_bonus";
            give_bonus.Size = new Size(130, 33);
            give_bonus.TabIndex = 7;
            give_bonus.Text = "Give Bonus";
            give_bonus.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.ForeColor = SystemColors.HotTrack;
            back.Location = new Point(369, 298);
            back.Margin = new Padding(2, 2, 2, 2);
            back.Name = "back";
            back.Size = new Size(119, 29);
            back.TabIndex = 8;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            // 
            // ManagerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(back);
            Controls.Add(give_bonus);
            Controls.Add(givebonusto_ID);
            Controls.Add(label4);
            Controls.Add(totalsalary);
            Controls.Add(label2);
            Controls.Add(numofemployees);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ManagerDetail";
            Text = "Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numofemployees;
        private Label label2;
        private TextBox totalsalary;
        private Label label4;
        private TextBox givebonusto_ID;
        private Button give_bonus;
        private Button back;
    }
}