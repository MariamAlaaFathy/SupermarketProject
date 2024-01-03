namespace SupermarketProject
{
    partial class FullTimeCashier
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
            Salary = new TextBox();
            numofcustomers = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 95);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 0;
            label1.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 233);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 28);
            label2.TabIndex = 1;
            label2.Text = "Number Of Customers";
            // 
            // Salary
            // 
            Salary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salary.ForeColor = SystemColors.ScrollBar;
            Salary.Location = new Point(302, 95);
            Salary.Margin = new Padding(2);
            Salary.Name = "Salary";
            Salary.Size = new Size(223, 27);
            Salary.TabIndex = 2;
            Salary.Text = "Salay $$";
            Salary.TextAlign = HorizontalAlignment.Center;
            // 
            // numofcustomers
            // 
            numofcustomers.ForeColor = SystemColors.ScrollBar;
            numofcustomers.Location = new Point(302, 234);
            numofcustomers.Margin = new Padding(2);
            numofcustomers.Name = "numofcustomers";
            numofcustomers.Size = new Size(232, 27);
            numofcustomers.TabIndex = 3;
            numofcustomers.Text = "number of customers";
            numofcustomers.TextAlign = HorizontalAlignment.Center;
            // 
            // FullTimeCashier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 381);
            Controls.Add(numofcustomers);
            Controls.Add(Salary);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FullTimeCashier";
            Text = "Cashier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Salary;
        private TextBox numofcustomers;
    }
}