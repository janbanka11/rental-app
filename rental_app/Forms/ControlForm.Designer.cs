namespace rental_app.Forms
{
    partial class ControlForm
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
            this.helloLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rentButton = new System.Windows.Forms.Button();
            this.rentalsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helloLabel.Location = new System.Drawing.Point(12, 9);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(67, 28);
            this.helloLabel.TabIndex = 0;
            this.helloLabel.Text = "Hello, ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.helloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 77);
            this.panel1.TabIndex = 2;
            // 
            // rentButton
            // 
            this.rentButton.Location = new System.Drawing.Point(114, 155);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(209, 89);
            this.rentButton.TabIndex = 3;
            this.rentButton.Text = "Rent";
            this.rentButton.UseVisualStyleBackColor = true;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // rentalsButton
            // 
            this.rentalsButton.Location = new System.Drawing.Point(380, 155);
            this.rentalsButton.Name = "rentalsButton";
            this.rentalsButton.Size = new System.Drawing.Size(200, 89);
            this.rentalsButton.TabIndex = 4;
            this.rentalsButton.Text = "Your rentals";
            this.rentalsButton.UseVisualStyleBackColor = true;
            this.rentalsButton.Click += new System.EventHandler(this.rentalsButton_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 367);
            this.Controls.Add(this.rentalsButton);
            this.Controls.Add(this.rentButton);
            this.Controls.Add(this.panel1);
            this.Name = "ControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label helloLabel;
        private Panel panel1;
        private Button rentButton;
        private Button rentalsButton;
    }
}