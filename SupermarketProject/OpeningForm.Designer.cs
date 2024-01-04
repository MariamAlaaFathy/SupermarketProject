namespace SupermarketProject
{
    partial class OpeningForm
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
            SupplierButton = new Button();
            CustomerButton = new Button();
            EmployeeButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // SupplierButton
            // 
            SupplierButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SupplierButton.ForeColor = SystemColors.HotTrack;
            SupplierButton.Location = new Point(134, 113);
            SupplierButton.Name = "SupplierButton";
            SupplierButton.Size = new Size(147, 56);
            SupplierButton.TabIndex = 0;
            SupplierButton.Text = "Supplier";
            SupplierButton.UseVisualStyleBackColor = true;
            SupplierButton.Click += SupplierButton_Click;
            // 
            // CustomerButton
            // 
            CustomerButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerButton.ForeColor = SystemColors.HotTrack;
            CustomerButton.Location = new Point(125, 216);
            CustomerButton.Name = "CustomerButton";
            CustomerButton.Size = new Size(165, 64);
            CustomerButton.TabIndex = 1;
            CustomerButton.Text = "Customer";
            CustomerButton.UseVisualStyleBackColor = true;
            CustomerButton.Click += CustomerButton_Click;
            // 
            // EmployeeButton
            // 
            EmployeeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeButton.ForeColor = SystemColors.HotTrack;
            EmployeeButton.Location = new Point(125, 330);
            EmployeeButton.Name = "EmployeeButton";
            EmployeeButton.Size = new Size(163, 62);
            EmployeeButton.TabIndex = 2;
            EmployeeButton.Text = "Employee";
            EmployeeButton.UseVisualStyleBackColor = true;
            EmployeeButton.Click += EmployeeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.Location = new Point(33, 37);
            label1.Name = "label1";
            label1.Size = new Size(320, 36);
            label1.TabIndex = 3;
            label1.Text = "Supermarket Account";
            // 
            // OpeningForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 438);
            Controls.Add(label1);
            Controls.Add(EmployeeButton);
            Controls.Add(CustomerButton);
            Controls.Add(SupplierButton);
            Name = "OpeningForm";
            Text = "Supermarket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SupplierButton;
        private Button CustomerButton;
        private Button EmployeeButton;
        private Label label1;
    }
}
