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
            this.rentalsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalsGridView.Location = new System.Drawing.Point(12, 38);
            this.rentalsGridView.Name = "rentalsGridView";
            this.rentalsGridView.RowTemplate.Height = 25;
            this.rentalsGridView.Size = new System.Drawing.Size(767, 400);
            this.rentalsGridView.TabIndex = 27;
            // 
            // AdminDisplayAllRentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rentalsGridView);
            this.Controls.Add(this.goBackButton);
            this.Name = "AdminDisplayAllRentalsForm";
            this.Text = "AdminDisplayAllRentalsForm";
            this.Load += new System.EventHandler(this.AdminDisplayAllRentalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button goBackButton;
        private DataGridView rentalsGridView;
    }
}