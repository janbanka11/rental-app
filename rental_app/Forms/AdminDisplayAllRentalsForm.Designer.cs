namespace rental_app.Forms
{
    partial class AdminDisplayAllRentalsForm
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.rentalsGridView = new System.Windows.Forms.DataGridView();
            this.removeRentalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentalsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(704, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 26;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // rentalsGridView
            // 
            this.rentalsGridView.AllowUserToAddRows = false;
            this.rentalsGridView.AllowUserToDeleteRows = false;
            this.rentalsGridView.BackgroundColor = System.Drawing.Color.White;
            this.rentalsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalsGridView.Location = new System.Drawing.Point(12, 38);
            this.rentalsGridView.Name = "rentalsGridView";
            this.rentalsGridView.ReadOnly = true;
            this.rentalsGridView.RowTemplate.Height = 25;
            this.rentalsGridView.Size = new System.Drawing.Size(767, 400);
            this.rentalsGridView.TabIndex = 27;
            // 
            // removeRentalButton
            // 
            this.removeRentalButton.Location = new System.Drawing.Point(296, 460);
            this.removeRentalButton.Name = "removeRentalButton";
            this.removeRentalButton.Size = new System.Drawing.Size(176, 39);
            this.removeRentalButton.TabIndex = 28;
            this.removeRentalButton.Text = "Remove selected rental";
            this.removeRentalButton.UseVisualStyleBackColor = true;
            this.removeRentalButton.Click += new System.EventHandler(this.removeRentalButton_Click);
            // 
            // AdminDisplayAllRentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.removeRentalButton);
            this.Controls.Add(this.rentalsGridView);
            this.Controls.Add(this.goBackButton);
            this.Name = "AdminDisplayAllRentalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDisplayAllRentalsForm";
            this.Load += new System.EventHandler(this.AdminDisplayAllRentalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button goBackButton;
        private DataGridView rentalsGridView;
        private Button removeRentalButton;
    }
}