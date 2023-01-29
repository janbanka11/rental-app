using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rental_app.Models;
using Microsoft.EntityFrameworkCore;
using rental_app.Data;
using Microsoft.IdentityModel.Tokens;

namespace rental_app.Forms
{
    public partial class AdminItemsManagementForm : Form
    {
        RentalAppContext context = new RentalAppContext();
        List<Item> items = new List<Item>();
        public AdminItemsManagementForm()
        {
            InitializeComponent();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminSettingsControlForm = new AdminSettingsControlForm();
            adminSettingsControlForm.Closed += (s, args) => this.Close();
            adminSettingsControlForm.Show();
        }
        bool checkIfEnteredItemIsCorrect()
        {
            items.Sort((item1,item2) => item1.GenresId.CompareTo(item2.GenresId));
            var largestItemByGenreId = items.Last();
            if(genreIdTextBox.Text.Length == 0 || Int32.Parse(genreIdTextBox.Text) < 0 || Int32.Parse(genreIdTextBox.Text) > largestItemByGenreId.GenresId)
            {
                var b = genreIdTextBox.Text;
                var c = genreIdTextBox.Text.Length;
                var d = Int32.Parse(genreIdTextBox.Text);
                var e = Int32.Parse(genreIdTextBox.Text);
                var f = largestItemByGenreId.GenresId;
                addItemErrorLabel.Text += " wrong genres id";
                return false;
            }
            items.Sort((item1, item2) => item1.ItemTypeId.CompareTo(item2.ItemTypeId));
            var largestItemByTypeId = items.Last();
            if (Int32.Parse(typeIdTextBox.Text) < 0 || Int32.Parse(typeIdTextBox.Text) > largestItemByTypeId.ItemTypeId)
            {
                addItemErrorLabel.Text += " wrong type id";
                return false;
            }
            if(authorTextBox.Text.Length == 0 )
            {
                addItemErrorLabel.Text += " wrong author";
                return false;
            }
            if(titleTextBox.Text.Length == 0 )
            {
                addItemErrorLabel.Text += " wrong title";
                return false;
            }
            if (Int32.Parse(priceTextBox.Text) < 0 || Int32.Parse(priceTextBox.Text) > 1000)
            {
                addItemErrorLabel.Text += " wrong price";
                return false;
            }
            return true;
        }
        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (checkIfEnteredItemIsCorrect())
            {
                Item item = new Item(
                    Int32.Parse(genreIdTextBox.Text),
                    Int32.Parse(typeIdTextBox.Text),
                    authorTextBox.Text,
                    titleTextBox.Text,
                    Int32.Parse(priceTextBox.Text)
                    );

                if (MessageBox.Show("Are you sure you want to add item " + titleTextBox.Text + " ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.Add(item);
                    context.SaveChanges();
                }
            }
           
        }

        private void AdminItemsManagementForm_Load(object sender, EventArgs e)
        {
            items = context.Items.ToList();
        }
    }
}
