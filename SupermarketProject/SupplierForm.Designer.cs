namespace SupermarketProject
{
    partial class SupplierForm
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
            NameLabel = new Label();
            NameTextBox = new TextBox();
            TypeLabel = new Label();
            StockLabel = new Label();
            TypeTextBox = new TextBox();
            StockTextBox = new TextBox();
            BackButton = new Button();
            DetailsButton = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Akhbar MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 178);
            NameLabel.Location = new Point(116, 62);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(130, 55);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTextBox.ForeColor = SystemColors.ActiveBorder;
            NameTextBox.Location = new Point(350, 69);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(391, 38);
            NameTextBox.TabIndex = 1;
            NameTextBox.Text = "Type your company's name";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Akhbar MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 178);
            TypeLabel.Location = new Point(30, 167);
            TypeLabel.Margin = new Padding(4, 0, 4, 0);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(307, 55);
            TypeLabel.TabIndex = 2;
            TypeLabel.Text = "Type Of Product";
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Font = new Font("Akhbar MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 178);
            StockLabel.Location = new Point(24, 295);
            StockLabel.Margin = new Padding(4, 0, 4, 0);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(319, 55);
            StockLabel.TabIndex = 3;
            StockLabel.Text = "Stock Of Product";
            // 
            // TypeTextBox
            // 
            TypeTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TypeTextBox.ForeColor = SystemColors.ActiveBorder;
            TypeTextBox.Location = new Point(351, 174);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(391, 38);
            TypeTextBox.TabIndex = 4;
            TypeTextBox.Text = "Write your product's type";
            // 
            // StockTextBox
            // 
            StockTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StockTextBox.ForeColor = SystemColors.ActiveBorder;
            StockTextBox.Location = new Point(351, 302);
            StockTextBox.Name = "StockTextBox";
            StockTextBox.Size = new Size(391, 38);
            StockTextBox.TabIndex = 5;
            StockTextBox.Text = "Write how much is in stock";
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.HotTrack;
            BackButton.Location = new Point(128, 416);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(135, 57);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // DetailsButton
            // 
            DetailsButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DetailsButton.ForeColor = SystemColors.HotTrack;
            DetailsButton.Location = new Point(435, 417);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(216, 57);
            DetailsButton.TabIndex = 7;
            DetailsButton.Text = "Product Details";
            DetailsButton.UseVisualStyleBackColor = true;
            DetailsButton.Click += DetailsButton_Click;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 556);
            Controls.Add(DetailsButton);
            Controls.Add(BackButton);
            Controls.Add(StockTextBox);
            Controls.Add(TypeTextBox);
            Controls.Add(StockLabel);
            Controls.Add(TypeLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Name = "SupplierForm";
            Text = "Supplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private TextBox NameTextBox;
        private Label TypeLabel;
        private Label StockLabel;
        private TextBox TypeTextBox;
        private TextBox StockTextBox;
        private Button BackButton;
        private Button DetailsButton;
    }
}