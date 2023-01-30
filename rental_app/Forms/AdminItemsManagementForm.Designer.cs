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
            this.itemIdToRemoveTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addItemErrorLabel = new System.Windows.Forms.Label();
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.addGenreTextBox = new System.Windows.Forms.TextBox();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.genresGridView = new System.Windows.Forms.DataGridView();
            this.itemTypesGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.genreIdToRemoveTextBox = new System.Windows.Forms.TextBox();
            this.removeGenreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(1187, 16);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 26;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // genreIdTextBox
            // 
            this.genreIdTextBox.Location = new System.Drawing.Point(94, 180);
            this.genreIdTextBox.MaxLength = 2;
            this.genreIdTextBox.Name = "genreIdTextBox";
            this.genreIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.genreIdTextBox.TabIndex = 27;
            // 
            // typeIdTextBox
            // 
            this.typeIdTextBox.Location = new System.Drawing.Point(94, 231);
            this.typeIdTextBox.MaxLength = 2;
            this.typeIdTextBox.Name = "typeIdTextBox";
            this.typeIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.typeIdTextBox.TabIndex = 28;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(94, 290);
            this.authorTextBox.MaxLength = 35;
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorTextBox.TabIndex = 29;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(94, 351);
            this.titleTextBox.MaxLength = 35;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 23);
            this.titleTextBox.TabIndex = 30;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(94, 411);
            this.priceTextBox.MaxLength = 6;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Genre ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Item Type ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Price";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(82, 464);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(112, 23);
            this.addItemButton.TabIndex = 37;
            this.addItemButton.Text = "Add item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(296, 212);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(75, 23);
            this.removeItemButton.TabIndex = 38;
            this.removeItemButton.Text = "Remove item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // itemIdToRemoveTextBox
            // 
            this.itemIdToRemoveTextBox.Location = new System.Drawing.Point(284, 183);
            this.itemIdToRemoveTextBox.MaxLength = 1000;
            this.itemIdToRemoveTextBox.Name = "itemIdToRemoveTextBox";
            this.itemIdToRemoveTextBox.Size = new System.Drawing.Size(100, 23);
            this.itemIdToRemoveTextBox.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 186);
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
            this.itemsGridView.AllowUserToAddRows = false;
            this.itemsGridView.AllowUserToDeleteRows = false;
            this.itemsGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Location = new System.Drawing.Point(421, 54);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.ReadOnly = true;
            this.itemsGridView.RowTemplate.Height = 25;
            this.itemsGridView.Size = new System.Drawing.Size(841, 343);
            this.itemsGridView.TabIndex = 42;
            this.itemsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGridView_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Genre name";
            // 
            // addGenreTextBox
            // 
            this.addGenreTextBox.Location = new System.Drawing.Point(284, 351);
            this.addGenreTextBox.MaxLength = 25;
            this.addGenreTextBox.Name = "addGenreTextBox";
            this.addGenreTextBox.Size = new System.Drawing.Size(100, 23);
            this.addGenreTextBox.TabIndex = 44;
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(296, 380);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(75, 23);
            this.addGenreButton.TabIndex = 43;
            this.addGenreButton.Text = "Add Genre";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // genresGridView
            // 
            this.genresGridView.AllowUserToAddRows = false;
            this.genresGridView.AllowUserToDeleteRows = false;
            this.genresGridView.BackgroundColor = System.Drawing.Color.White;
            this.genresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresGridView.Location = new System.Drawing.Point(421, 440);
            this.genresGridView.Name = "genresGridView";
            this.genresGridView.ReadOnly = true;
            this.genresGridView.RowTemplate.Height = 25;
            this.genresGridView.Size = new System.Drawing.Size(381, 188);
            this.genresGridView.TabIndex = 49;
            // 
            // itemTypesGridView
            // 
            this.itemTypesGridView.AllowUserToAddRows = false;
            this.itemTypesGridView.AllowUserToDeleteRows = false;
            this.itemTypesGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemTypesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemTypesGridView.Location = new System.Drawing.Point(881, 440);
            this.itemTypesGridView.Name = "itemTypesGridView";
            this.itemTypesGridView.ReadOnly = true;
            this.itemTypesGridView.RowTemplate.Height = 25;
            this.itemTypesGridView.Size = new System.Drawing.Size(381, 188);
            this.itemTypesGridView.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(421, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "All items";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(421, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 52;
            this.label10.Text = "All genres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(881, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 25);
            this.label11.TabIndex = 53;
            this.label11.Text = "All item types";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 56;
            this.label12.Text = "Genre ID";
            // 
            // genreIdToRemoveTextBox
            // 
            this.genreIdToRemoveTextBox.Location = new System.Drawing.Point(284, 270);
            this.genreIdToRemoveTextBox.MaxLength = 1000;
            this.genreIdToRemoveTextBox.Name = "genreIdToRemoveTextBox";
            this.genreIdToRemoveTextBox.Size = new System.Drawing.Size(100, 23);
            this.genreIdToRemoveTextBox.TabIndex = 55;
            // 
            // removeGenreButton
            // 
            this.removeGenreButton.Location = new System.Drawing.Point(296, 299);
            this.removeGenreButton.Name = "removeGenreButton";
            this.removeGenreButton.Size = new System.Drawing.Size(75, 23);
            this.removeGenreButton.TabIndex = 54;
            this.removeGenreButton.Text = "Remove item";
            this.removeGenreButton.UseVisualStyleBackColor = true;
            this.removeGenreButton.Click += new System.EventHandler(this.removeGenreButton_Click);
            // 
            // AdminItemsManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 655);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.genreIdToRemoveTextBox);
            this.Controls.Add(this.removeGenreButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.itemTypesGridView);
            this.Controls.Add(this.genresGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addGenreTextBox);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.itemsGridView);
            this.Controls.Add(this.addItemErrorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemIdToRemoveTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.genresGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesGridView)).EndInit();
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
        private TextBox itemIdToRemoveTextBox;
        private Label label6;
        private Label addItemErrorLabel;
        private DataGridView itemsGridView;
        private Label label7;
        private TextBox addGenreTextBox;
        private Button addGenreButton;
        private DataGridView genresGridView;
        private DataGridView itemTypesGridView;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox genreIdToRemoveTextBox;
        private Button removeGenreButton;
    }
}