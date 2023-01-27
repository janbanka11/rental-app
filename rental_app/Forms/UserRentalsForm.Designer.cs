namespace rental_app.Forms
{
    partial class UserRentalsForm
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
            this.nothingToShowLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.yourTotalLabel = new System.Windows.Forms.Label();
            this.moviesBillLabel = new System.Windows.Forms.Label();
            this.audiobookBillLabel = new System.Windows.Forms.Label();
            this.cdDiscBillLabel = new System.Windows.Forms.Label();
            this.sumBillLabel = new System.Windows.Forms.Label();
            this.closestDateLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nothingToShowLabel
            // 
            this.nothingToShowLabel.AutoSize = true;
            this.nothingToShowLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nothingToShowLabel.Location = new System.Drawing.Point(36, 8);
            this.nothingToShowLabel.Name = "nothingToShowLabel";
            this.nothingToShowLabel.Size = new System.Drawing.Size(0, 25);
            this.nothingToShowLabel.TabIndex = 28;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(537, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 24;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // itemsGridView
            // 
            this.itemsGridView.AllowUserToAddRows = false;
            this.itemsGridView.AllowUserToDeleteRows = false;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Location = new System.Drawing.Point(39, 37);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.ReadOnly = true;
            this.itemsGridView.RowTemplate.Height = 25;
            this.itemsGridView.Size = new System.Drawing.Size(573, 242);
            this.itemsGridView.TabIndex = 23;
            // 
            // yourTotalLabel
            // 
            this.yourTotalLabel.AutoSize = true;
            this.yourTotalLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yourTotalLabel.Location = new System.Drawing.Point(39, 287);
            this.yourTotalLabel.Name = "yourTotalLabel";
            this.yourTotalLabel.Size = new System.Drawing.Size(127, 28);
            this.yourTotalLabel.TabIndex = 29;
            this.yourTotalLabel.Text = "Your bills are:";
            // 
            // moviesBillLabel
            // 
            this.moviesBillLabel.AutoSize = true;
            this.moviesBillLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moviesBillLabel.Location = new System.Drawing.Point(69, 331);
            this.moviesBillLabel.Name = "moviesBillLabel";
            this.moviesBillLabel.Size = new System.Drawing.Size(67, 21);
            this.moviesBillLabel.TabIndex = 30;
            this.moviesBillLabel.Text = "Movies: ";
            // 
            // audiobookBillLabel
            // 
            this.audiobookBillLabel.AutoSize = true;
            this.audiobookBillLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.audiobookBillLabel.Location = new System.Drawing.Point(36, 393);
            this.audiobookBillLabel.Name = "audiobookBillLabel";
            this.audiobookBillLabel.Size = new System.Drawing.Size(100, 21);
            this.audiobookBillLabel.TabIndex = 31;
            this.audiobookBillLabel.Text = "Audiobooks: ";
            // 
            // cdDiscBillLabel
            // 
            this.cdDiscBillLabel.AutoSize = true;
            this.cdDiscBillLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cdDiscBillLabel.Location = new System.Drawing.Point(58, 362);
            this.cdDiscBillLabel.Name = "cdDiscBillLabel";
            this.cdDiscBillLabel.Size = new System.Drawing.Size(78, 21);
            this.cdDiscBillLabel.TabIndex = 32;
            this.cdDiscBillLabel.Text = "CD Discs: ";
            // 
            // sumBillLabel
            // 
            this.sumBillLabel.AutoSize = true;
            this.sumBillLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sumBillLabel.Location = new System.Drawing.Point(83, 424);
            this.sumBillLabel.Name = "sumBillLabel";
            this.sumBillLabel.Size = new System.Drawing.Size(56, 21);
            this.sumBillLabel.TabIndex = 33;
            this.sumBillLabel.Text = "Total: ";
            // 
            // closestDateLabel
            // 
            this.closestDateLabel.AutoSize = true;
            this.closestDateLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closestDateLabel.Location = new System.Drawing.Point(273, 287);
            this.closestDateLabel.Name = "closestDateLabel";
            this.closestDateLabel.Size = new System.Drawing.Size(234, 28);
            this.closestDateLabel.TabIndex = 34;
            this.closestDateLabel.Text = "Item soon to be returned:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(366, 362);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 21);
            this.titleLabel.TabIndex = 35;
            this.titleLabel.Text = "Title: ";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.endDateLabel.Location = new System.Drawing.Point(335, 331);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(77, 21);
            this.endDateLabel.TabIndex = 36;
            this.endDateLabel.Text = "End date: ";
            // 
            // UserRentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 467);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closestDateLabel);
            this.Controls.Add(this.sumBillLabel);
            this.Controls.Add(this.cdDiscBillLabel);
            this.Controls.Add(this.audiobookBillLabel);
            this.Controls.Add(this.moviesBillLabel);
            this.Controls.Add(this.yourTotalLabel);
            this.Controls.Add(this.nothingToShowLabel);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.itemsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserRentalsForm";
            this.Text = "UserRentalsForm";
            this.Load += new System.EventHandler(this.UserRentalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nothingToShowLabel;
        private Button goBackButton;
        private DataGridView itemsGridView;
        private Label yourTotalLabel;
        private Label moviesBillLabel;
        private Label audiobookBillLabel;
        private Label cdDiscBillLabel;
        private Label sumBillLabel;
        private Label closestDateLabel;
        private Label titleLabel;
        private Label endDateLabel;
    }
}