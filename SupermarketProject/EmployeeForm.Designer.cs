﻿namespace SupermarketProject
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
            Cashier = new Button();
            Manager = new Button();
            Owner = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Cashier
            // 
            Cashier.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cashier.ForeColor = SystemColors.HotTrack;
            Cashier.Location = new Point(257, 115);
            Cashier.Name = "Cashier";
            Cashier.Size = new Size(189, 64);
            Cashier.TabIndex = 0;
            Cashier.Text = "Cashier";
            Cashier.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            Manager.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manager.ForeColor = SystemColors.HotTrack;
            Manager.Location = new Point(257, 226);
            Manager.Name = "Manager";
            Manager.Size = new Size(195, 77);
            Manager.TabIndex = 1;
            Manager.Text = "Manager";
            Manager.UseVisualStyleBackColor = true;
            // 
            // Owner
            // 
            Owner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Owner.ForeColor = SystemColors.HotTrack;
            Owner.Location = new Point(253, 357);
            Owner.Name = "Owner";
            Owner.Size = new Size(199, 61);
            Owner.TabIndex = 2;
            Owner.Text = "Owner";
            Owner.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 18);
            label1.Name = "label1";
            label1.Size = new Size(565, 65);
            label1.TabIndex = 3;
            label1.Text = "Employee account page";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Owner);
            Controls.Add(Manager);
            Controls.Add(Cashier);
            Name = "EmployeeForm";
            Text = "EmployeeDesign";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cashier;
        private Button Manager;
        private Button Owner;
        private Label label1;
    }
}
