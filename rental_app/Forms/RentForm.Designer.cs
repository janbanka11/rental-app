namespace rental_app.Forms
{
    partial class RentForm
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
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.movieSourceButton = new System.Windows.Forms.Button();
            this.audiobookSourceButton = new System.Windows.Forms.Button();
            this.cdDiscSourceButton = new System.Windows.Forms.Button();
            this.currentViewLabel = new System.Windows.Forms.Label();
            this.userRentButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsGridView
            // 
            this.itemsGridView.AllowUserToAddRows = false;
            this.itemsGridView.AllowUserToDeleteRows = false;
            this.itemsGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Location = new System.Drawing.Point(12, 58);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.ReadOnly = true;
            this.itemsGridView.RowTemplate.Height = 25;
            this.itemsGridView.Size = new System.Drawing.Size(503, 242);
            this.itemsGridView.TabIndex = 0;
            // 
            // movieSourceButton
            // 
            this.movieSourceButton.Location = new System.Drawing.Point(50, 339);
            this.movieSourceButton.Name = "movieSourceButton";
            this.movieSourceButton.Size = new System.Drawing.Size(147, 23);
            this.movieSourceButton.TabIndex = 1;
            this.movieSourceButton.Text = "Movie";
            this.movieSourceButton.UseVisualStyleBackColor = true;
            this.movieSourceButton.Click += new System.EventHandler(this.movieSourceButton_Click);
            // 
            // audiobookSourceButton
            // 
            this.audiobookSourceButton.Location = new System.Drawing.Point(203, 339);
            this.audiobookSourceButton.Name = "audiobookSourceButton";
            this.audiobookSourceButton.Size = new System.Drawing.Size(134, 23);
            this.audiobookSourceButton.TabIndex = 2;
            this.audiobookSourceButton.Text = "Audiobook";
            this.audiobookSourceButton.UseVisualStyleBackColor = true;
            this.audiobookSourceButton.Click += new System.EventHandler(this.audiobookSourceButton_Click);
            // 
            // cdDiscSourceButton
            // 
            this.cdDiscSourceButton.Location = new System.Drawing.Point(343, 339);
            this.cdDiscSourceButton.Name = "cdDiscSourceButton";
            this.cdDiscSourceButton.Size = new System.Drawing.Size(147, 23);
            this.cdDiscSourceButton.TabIndex = 3;
            this.cdDiscSourceButton.Text = "CD Disc";
            this.cdDiscSourceButton.UseVisualStyleBackColor = true;
            this.cdDiscSourceButton.Click += new System.EventHandler(this.cdDiscSourceButton_Click);
            // 
            // currentViewLabel
            // 
            this.currentViewLabel.AutoSize = true;
            this.currentViewLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentViewLabel.Location = new System.Drawing.Point(12, 25);
            this.currentViewLabel.Name = "currentViewLabel";
            this.currentViewLabel.Size = new System.Drawing.Size(0, 21);
            this.currentViewLabel.TabIndex = 4;
            // 
            // userRentButton
            // 
            this.userRentButton.Location = new System.Drawing.Point(166, 378);
            this.userRentButton.Name = "userRentButton";
            this.userRentButton.Size = new System.Drawing.Size(208, 52);
            this.userRentButton.TabIndex = 5;
            this.userRentButton.Text = "Rent";
            this.userRentButton.UseVisualStyleBackColor = true;
            this.userRentButton.Click += new System.EventHandler(this.userRentButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(440, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 6;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 442);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.userRentButton);
            this.Controls.Add(this.currentViewLabel);
            this.Controls.Add(this.cdDiscSourceButton);
            this.Controls.Add(this.audiobookSourceButton);
            this.Controls.Add(this.movieSourceButton);
            this.Controls.Add(this.itemsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.RentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridView itemsGridView;
        private Button movieSourceButton;
        private Button audiobookSourceButton;
        private Button cdDiscSourceButton;
        private Label currentViewLabel;
        private Button userRentButton;
        private Button goBackButton;
    }
}