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
            label1.Location = new Point(89, 84);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 0;
            label1.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 256);
            label2.Name = "label2";
            label2.Size = new Size(260, 32);
            label2.TabIndex = 1;
            label2.Text = "number of customers";
            // 
            // Salary
            // 
            Salary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salary.ForeColor = SystemColors.ScrollBar;
            Salary.Location = new Point(327, 84);
            Salary.Name = "Salary";
            Salary.Size = new Size(278, 31);
            Salary.TabIndex = 2;
            Salary.Text = "Salay $$";
            Salary.TextAlign = HorizontalAlignment.Center;
            // 
            // numofcustomers
            // 
            numofcustomers.ForeColor = SystemColors.ScrollBar;
            numofcustomers.Location = new Point(327, 257);
            numofcustomers.Name = "numofcustomers";
            numofcustomers.Size = new Size(289, 31);
            numofcustomers.TabIndex = 3;
            numofcustomers.Text = "number of customers";
            numofcustomers.TextAlign = HorizontalAlignment.Center;
            // 
            // FullTimeCashier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numofcustomers);
            Controls.Add(Salary);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FullTimeCashier";
            Text = "FullTimeCashier";
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