namespace Exam_StockManagementSystemApp
{
    partial class Welcome_to_Stock_Management
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
            this.StockInButton = new System.Windows.Forms.Button();
            this.StockOutButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StockInButton
            // 
            this.StockInButton.Location = new System.Drawing.Point(96, 24);
            this.StockInButton.Name = "StockInButton";
            this.StockInButton.Size = new System.Drawing.Size(75, 48);
            this.StockInButton.TabIndex = 0;
            this.StockInButton.Text = "Stock In";
            this.StockInButton.UseVisualStyleBackColor = true;
            this.StockInButton.Click += new System.EventHandler(this.StockInButton_Click);
            // 
            // StockOutButton
            // 
            this.StockOutButton.Location = new System.Drawing.Point(96, 78);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(75, 41);
            this.StockOutButton.TabIndex = 1;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.UseVisualStyleBackColor = true;
            this.StockOutButton.Click += new System.EventHandler(this.StockOutButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(96, 137);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 47);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "View Current Stock";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // Welcome_to_Stock_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.StockOutButton);
            this.Controls.Add(this.StockInButton);
            this.Name = "Welcome_to_Stock_Management";
            this.Text = "Welcome_to_Stock_Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StockInButton;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button ViewButton;
    }
}

