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
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsGridView
            // 
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Location = new System.Drawing.Point(56, 117);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.RowTemplate.Height = 25;
            this.itemsGridView.Size = new System.Drawing.Size(671, 217);
            this.itemsGridView.TabIndex = 0;
            // 
            // movieSourceButton
            // 
            this.movieSourceButton.Location = new System.Drawing.Point(440, 340);
            this.movieSourceButton.Name = "movieSourceButton";
            this.movieSourceButton.Size = new System.Drawing.Size(75, 23);
            this.movieSourceButton.TabIndex = 1;
            this.movieSourceButton.Text = "movie";
            this.movieSourceButton.UseVisualStyleBackColor = true;
            this.movieSourceButton.Click += new System.EventHandler(this.movieSourceButton_Click);
            // 
            // audiobookSourceButton
            // 
            this.audiobookSourceButton.Location = new System.Drawing.Point(543, 340);
            this.audiobookSourceButton.Name = "audiobookSourceButton";
            this.audiobookSourceButton.Size = new System.Drawing.Size(75, 23);
            this.audiobookSourceButton.TabIndex = 2;
            this.audiobookSourceButton.Text = "audiobook";
            this.audiobookSourceButton.UseVisualStyleBackColor = true;
            this.audiobookSourceButton.Click += new System.EventHandler(this.audiobookSourceButton_Click);
            // 
            // cdDiscSourceButton
            // 
            this.cdDiscSourceButton.Location = new System.Drawing.Point(651, 340);
            this.cdDiscSourceButton.Name = "cdDiscSourceButton";
            this.cdDiscSourceButton.Size = new System.Drawing.Size(75, 23);
            this.cdDiscSourceButton.TabIndex = 3;
            this.cdDiscSourceButton.Text = "cd disc";
            this.cdDiscSourceButton.UseVisualStyleBackColor = true;
            this.cdDiscSourceButton.Click += new System.EventHandler(this.cdDiscSourceButton_Click);
            // 
            // currentViewLabel
            // 
            this.currentViewLabel.AutoSize = true;
            this.currentViewLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentViewLabel.Location = new System.Drawing.Point(56, 58);
            this.currentViewLabel.Name = "currentViewLabel";
            this.currentViewLabel.Size = new System.Drawing.Size(0, 45);
            this.currentViewLabel.TabIndex = 4;
            // 
            // userRentButton
            // 
            this.userRentButton.Location = new System.Drawing.Point(301, 386);
            this.userRentButton.Name = "userRentButton";
            this.userRentButton.Size = new System.Drawing.Size(139, 41);
            this.userRentButton.TabIndex = 5;
            this.userRentButton.Text = "Rent";
            this.userRentButton.UseVisualStyleBackColor = true;
            this.userRentButton.Click += new System.EventHandler(this.userRentButton_Click);
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userRentButton);
            this.Controls.Add(this.currentViewLabel);
            this.Controls.Add(this.cdDiscSourceButton);
            this.Controls.Add(this.audiobookSourceButton);
            this.Controls.Add(this.movieSourceButton);
            this.Controls.Add(this.itemsGridView);
            this.Name = "RentForm";
            this.Text = "RentForm";
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
    }
}