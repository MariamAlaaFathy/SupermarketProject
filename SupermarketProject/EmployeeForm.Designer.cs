namespace SupermarketProject
{
    partial class EmployeeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CashierButton = new Button();
            ManagerButton = new Button();
            OwnerButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // CashierButton
            // 
            CashierButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CashierButton.ForeColor = SystemColors.HotTrack;
            CashierButton.Location = new Point(300, 114);
            CashierButton.Margin = new Padding(2);
            CashierButton.Name = "CashierButton";
            CashierButton.Size = new Size(189, 64);
            CashierButton.TabIndex = 0;
            CashierButton.Text = "Cashier";
            CashierButton.UseVisualStyleBackColor = true;
            CashierButton.Click += CashierButton_Click;
            // 
            // ManagerButton
            // 
            ManagerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManagerButton.ForeColor = SystemColors.HotTrack;
            ManagerButton.Location = new Point(300, 225);
            ManagerButton.Margin = new Padding(2);
            ManagerButton.Name = "ManagerButton";
            ManagerButton.Size = new Size(195, 78);
            ManagerButton.TabIndex = 1;
            ManagerButton.Text = "Manager";
            ManagerButton.UseVisualStyleBackColor = true;
            ManagerButton.Click += ManagerButton_Click;
            // 
            // OwnerButton
            // 
            OwnerButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OwnerButton.ForeColor = SystemColors.HotTrack;
            OwnerButton.Location = new Point(295, 356);
            OwnerButton.Margin = new Padding(2);
            OwnerButton.Name = "OwnerButton";
            OwnerButton.Size = new Size(199, 61);
            OwnerButton.TabIndex = 2;
            OwnerButton.Text = "Owner";
            OwnerButton.UseVisualStyleBackColor = true;
            OwnerButton.Click += OwnerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(571, 65);
            label1.TabIndex = 3;
            label1.Text = "Employee Account Page";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(OwnerButton);
            Controls.Add(ManagerButton);
            Controls.Add(CashierButton);
            Margin = new Padding(2);
            Name = "EmployeeForm";
            Text = "Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CashierButton;
        private Button ManagerButton;
        private Button OwnerButton;
        private Label label1;
    }
}
