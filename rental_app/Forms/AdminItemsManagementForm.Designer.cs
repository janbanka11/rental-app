namespace rental_app.Forms
{
    partial class AdminItemsManagementForm
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
            this.genreIdTextBox = new System.Windows.Forms.TextBox();
            this.typeIdTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addItemErrorLabel = new System.Windows.Forms.Label();
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.addGenreTextBox = new System.Windows.Forms.TextBox();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.addItemTypeTextBox = new System.Windows.Forms.TextBox();
            this.addItemTypeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(1187, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 26;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // genreIdTextBox
            // 
            this.genreIdTextBox.Location = new System.Drawing.Point(120, 51);
            this.genreIdTextBox.MaxLength = 2;
            this.genreIdTextBox.Name = "genreIdTextBox";
            this.genreIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.genreIdTextBox.TabIndex = 27;
            // 
            // typeIdTextBox
            // 
            this.typeIdTextBox.Location = new System.Drawing.Point(120, 102);
            this.typeIdTextBox.MaxLength = 2;
            this.typeIdTextBox.Name = "typeIdTextBox";
            this.typeIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.typeIdTextBox.TabIndex = 28;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(120, 161);
            this.authorTextBox.MaxLength = 35;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorTextBox.TabIndex = 29;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(120, 222);
            this.titleTextBox.MaxLength = 35;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 23);
            this.titleTextBox.TabIndex = 30;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(120, 282);
            this.priceTextBox.MaxLength = 6;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Genre ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Item Type ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Price";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(108, 335);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(112, 23);
            this.addItemButton.TabIndex = 37;
            this.addItemButton.Text = "Add item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(327, 83);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(75, 23);
            this.removeItemButton.TabIndex = 38;
            this.removeItemButton.Text = "Remove item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(315, 54);
            this.itemIdTextBox.MaxLength = 1000;
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.itemIdTextBox.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Item ID";
            // 
            // addItemErrorLabel
            // 
            this.addItemErrorLabel.AutoSize = true;
            this.addItemErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.addItemErrorLabel.Location = new System.Drawing.Point(60, 20);
            this.addItemErrorLabel.Name = "addItemErrorLabel";
            this.addItemErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.addItemErrorLabel.TabIndex = 41;
            // 
            // itemsGridView
            // 
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Location = new System.Drawing.Point(421, 41);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.RowTemplate.Height = 25;
            this.itemsGridView.Size = new System.Drawing.Size(841, 343);
            this.itemsGridView.TabIndex = 42;
            this.itemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGridView_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Genre name";
            // 
            // addGenreTextBox
            // 
            this.addGenreTextBox.Location = new System.Drawing.Point(315, 161);
            this.addGenreTextBox.MaxLength = 25;
            this.addGenreTextBox.Name = "addGenreTextBox";
            this.addGenreTextBox.Size = new System.Drawing.Size(100, 23);
            this.addGenreTextBox.TabIndex = 44;
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(327, 190);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(75, 23);
            this.addGenreButton.TabIndex = 43;
            this.addGenreButton.Text = "Add Genre";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Item type";
            // 
            // addItemTypeTextBox
            // 
            this.addItemTypeTextBox.Location = new System.Drawing.Point(315, 277);
            this.addItemTypeTextBox.MaxLength = 25;
            this.addItemTypeTextBox.Name = "addItemTypeTextBox";
            this.addItemTypeTextBox.Size = new System.Drawing.Size(100, 23);
            this.addItemTypeTextBox.TabIndex = 47;
            // 
            // addItemTypeButton
            // 
            this.addItemTypeButton.Location = new System.Drawing.Point(315, 306);
            this.addItemTypeButton.Name = "addItemTypeButton";
            this.addItemTypeButton.Size = new System.Drawing.Size(96, 23);
            this.addItemTypeButton.TabIndex = 46;
            this.addItemTypeButton.Text = "Add item type";
            this.addItemTypeButton.UseVisualStyleBackColor = true;
            this.addItemTypeButton.Click += new System.EventHandler(this.addItemTypeButton_Click);
            // 
            // AdminItemsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 396);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addItemTypeTextBox);
            this.Controls.Add(this.addItemTypeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addGenreTextBox);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.itemsGridView);
            this.Controls.Add(this.addItemErrorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemIdTextBox);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.typeIdTextBox);
            this.Controls.Add(this.genreIdTextBox);
            this.Controls.Add(this.goBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminItemsManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminItemsManagementForm";
            this.Load += new System.EventHandler(this.AdminItemsManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button goBackButton;
        private TextBox genreIdTextBox;
        private TextBox typeIdTextBox;
        private TextBox authorTextBox;
        private TextBox titleTextBox;
        private TextBox priceTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button addItemButton;
        private Button removeItemButton;
        private TextBox itemIdTextBox;
        private Label label6;
        private Label addItemErrorLabel;
        private DataGridView itemsGridView;
        private Label label7;
        private TextBox addGenreTextBox;
        private Button addGenreButton;
        private Label label8;
        private TextBox addItemTypeTextBox;
        private Button addItemTypeButton;
    }
}