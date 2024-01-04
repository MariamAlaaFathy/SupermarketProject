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
            Salary = new TextBox();
            label1 = new Label();
            numofcustomer = new TextBox();
            label2 = new Label();
            label3 = new Label();
            hoursworked = new TextBox();
            DoneButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // Salary
            // 
            Salary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salary.ForeColor = SystemColors.ScrollBar;
            Salary.Location = new Point(262, 57);
            Salary.Margin = new Padding(2);
            Salary.Name = "Salary";
            Salary.Size = new Size(245, 27);
            Salary.TabIndex = 4;
            Salary.Text = "Salay $$";
            Salary.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 56);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 3;
            label1.Text = "Salary";
            // 
            // numofcustomer
            // 
            numofcustomer.ForeColor = SystemColors.ScrollBar;
            numofcustomer.Location = new Point(262, 179);
            numofcustomer.Margin = new Padding(2);
            numofcustomer.Name = "numofcustomer";
            numofcustomer.Size = new Size(245, 27);
            numofcustomer.TabIndex = 6;
            numofcustomer.Text = "number of customers";
            numofcustomer.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 179);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 28);
            label2.TabIndex = 5;
            label2.Text = "Number Of Customers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 281);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 7;
            label3.Text = "Hours Worked";
            // 
            // hoursworked
            // 
            hoursworked.ForeColor = SystemColors.ScrollBar;
            hoursworked.Location = new Point(262, 282);
            hoursworked.Margin = new Padding(2);
            hoursworked.Name = "hoursworked";
            hoursworked.Size = new Size(245, 27);
            hoursworked.TabIndex = 8;
            hoursworked.Text = "hours worked";
            hoursworked.TextAlign = HorizontalAlignment.Center;
            // 
            // DoneButton
            // 
            DoneButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoneButton.ForeColor = SystemColors.HotTrack;
            DoneButton.Location = new Point(317, 346);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(135, 57);
            DoneButton.TabIndex = 26;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = true;
            DoneButton.Click += DoneButton_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.HotTrack;
            BackButton.Location = new Point(93, 345);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(135, 57);
            BackButton.TabIndex = 25;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // PartTimeCashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 429);
            Controls.Add(DoneButton);
            Controls.Add(BackButton);
            Controls.Add(hoursworked);
            Controls.Add(label3);
            Controls.Add(numofcustomer);
            Controls.Add(label2);
            Controls.Add(Salary);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "PartTimeCashier";
            Text = "PartTimeCashier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Salary;
        private Label label1;
        private TextBox numofcustomer;
        private Label label2;
        private Label label3;
        private TextBox hoursworked;
        private Button DoneButton;
        private Button BackButton;
    }
}