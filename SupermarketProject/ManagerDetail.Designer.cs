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
            label2 = new Label();
            totalsales = new TextBox();
            label4 = new Label();
            givebonusto_ID = new TextBox();
            give_bonus = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(127, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 2;
            label2.Text = "Total Sales";
            // 
            // totalsales
            // 
            totalsales.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalsales.ForeColor = SystemColors.ScrollBar;
            totalsales.Location = new Point(314, 72);
            totalsales.Margin = new Padding(2);
            totalsales.Name = "totalsales";
            totalsales.Size = new Size(203, 27);
            totalsales.TabIndex = 3;
            totalsales.Text = "$$";
            totalsales.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 146);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 28);
            label4.TabIndex = 5;
            label4.Text = "Give bonus to:";
            // 
            // givebonusto_ID
            // 
            givebonusto_ID.ForeColor = SystemColors.ScrollBar;
            givebonusto_ID.Location = new Point(314, 146);
            givebonusto_ID.Margin = new Padding(2);
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
            give_bonus.Location = new Point(372, 239);
            give_bonus.Margin = new Padding(2);
            give_bonus.Name = "give_bonus";
            give_bonus.Size = new Size(130, 33);
            give_bonus.TabIndex = 7;
            give_bonus.Text = "Give Bonus";
            give_bonus.UseVisualStyleBackColor = true;
            give_bonus.Click += give_bonus_Click;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.ForeColor = SystemColors.HotTrack;
            back.Location = new Point(118, 241);
            back.Margin = new Padding(2);
            back.Name = "back";
            back.Size = new Size(119, 29);
            back.TabIndex = 8;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // ManagerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 327);
            Controls.Add(back);
            Controls.Add(give_bonus);
            Controls.Add(givebonusto_ID);
            Controls.Add(label4);
            Controls.Add(totalsales);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "ManagerDetail";
            Text = "Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox totalsales;
        private Label label4;
        private TextBox givebonusto_ID;
        private Button give_bonus;
        private Button back;
    }
}