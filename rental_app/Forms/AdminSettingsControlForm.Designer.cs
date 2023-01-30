namespace rental_app.Forms
{
    partial class AdminSettingsControlForm
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
            this.manageItemsButton = new System.Windows.Forms.Button();
            this.displayUserRentalsButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageItemsButton
            // 
            this.manageItemsButton.Location = new System.Drawing.Point(145, 137);
            this.manageItemsButton.Name = "manageItemsButton";
            this.manageItemsButton.Size = new System.Drawing.Size(208, 107);
            this.manageItemsButton.TabIndex = 0;
            this.manageItemsButton.Text = "Manage items";
            this.manageItemsButton.UseVisualStyleBackColor = true;
            this.manageItemsButton.Click += new System.EventHandler(this.manageItemsButton_Click);
            // 
            // displayUserRentalsButton
            // 
            this.displayUserRentalsButton.Location = new System.Drawing.Point(434, 137);
            this.displayUserRentalsButton.Name = "displayUserRentalsButton";
            this.displayUserRentalsButton.Size = new System.Drawing.Size(208, 107);
            this.displayUserRentalsButton.TabIndex = 1;
            this.displayUserRentalsButton.Text = "See users rentals";
            this.displayUserRentalsButton.UseVisualStyleBackColor = true;
            this.displayUserRentalsButton.Click += new System.EventHandler(this.displayUserRentalsButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(643, 38);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 25;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // AdminSettingsControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.displayUserRentalsButton);
            this.Controls.Add(this.manageItemsButton);
            this.Name = "AdminSettingsControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSettingsControlForm";
            this.Load += new System.EventHandler(this.AdminSettingsControlForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button manageItemsButton;
        private Button displayUserRentalsButton;
        private Button goBackButton;
    }
}