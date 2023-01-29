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
        private void reloadChangesInItemGridView()
        {
            var tempItems = context.Items
                       .Include(i => i.Genres)
                       .Include(i => i.ItemType);

            List<ItemDTO> itemsToDisplay = new List<ItemDTO>();
            foreach (var item in tempItems)
            {
                itemsToDisplay.Add(new ItemDTO(item.ItemId, item.Genres.GenresId, item.Genres.Genre, item.ItemType.ItemTypeId, item.ItemType.Type, item.Author, item.Title, item.Price));
            }
            itemsGridView.DataSource = itemsToDisplay;
        }
        private void AdminItemsManagementForm_Load(object sender, EventArgs e)
        {
            items = context.Items.ToList();
            reloadChangesInItemGridView();
        }
        bool checkIfItemDataIsNotNull()
        {
            return genreIdTextBox.Text.Length != 0 && typeIdTextBox.Text.Length != 0 && authorTextBox.Text.Length != 0 && titleTextBox.Text.Length != 0 && priceTextBox.Text.Length != 0;
        }

        bool checkIfEnteredItemIsCorrect()
        {
            items.Sort((item1,item2) => item1.GenresId.CompareTo(item2.GenresId));
            var largestItemByGenreId = items.Last();
            if (!genreIdTextBox.Text.All(Char.IsDigit) 
                ||genreIdTextBox.Text.Length == 0 
                || Int32.Parse(genreIdTextBox.Text) < 0 
                || Int32.Parse(genreIdTextBox.Text) > largestItemByGenreId.GenresId)
            {
                addItemErrorLabel.Text += " wrong genres id";
                return false;
            }
            items.Sort((item1, item2) => item1.ItemTypeId.CompareTo(item2.ItemTypeId));
            var largestItemByTypeId = items.Last();
            if (!typeIdTextBox.Text.All(Char.IsDigit) 
                || Int32.Parse(typeIdTextBox.Text) < 0 
                || Int32.Parse(typeIdTextBox.Text) > largestItemByTypeId.ItemTypeId)
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
            if (!priceTextBox.Text.All(Char.IsDigit) 
                || Int32.Parse(priceTextBox.Text) < 0 
                || Int32.Parse(priceTextBox.Text) > 1000)
            {
                addItemErrorLabel.Text += " wrong price";
                return false;
            }
            return true;
        }
        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (checkIfItemDataIsNotNull())
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
                        MessageBox.Show("Added item successfully", "Success");
                        reloadChangesInItemGridView();
                    }
                }
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (itemIdTextBox.Text.Length != 0)
            {
                Item itemToRemove = context.Items.FirstOrDefault(i => i.ItemId == Int32.Parse(itemIdTextBox.Text));
                if (itemToRemove != null)
                {
                    if (MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Items.Remove(itemToRemove);
                        context.SaveChanges();
                        MessageBox.Show("Removed item successfully", "Success");
                        reloadChangesInItemGridView();
                    }
                    else
                    {
                        MessageBox.Show("Bad item id", "Error");
                    }
                }
            }
        }

        private void itemsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            if(addGenreTextBox.Text.All(Char.IsLetter) && addGenreTextBox.Text.Length > 2)
            {
                if (MessageBox.Show("Are you sure you want to add genre: " + addGenreTextBox.Text + " ? ", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Genres genre = new Genres(addGenreTextBox.Text);
                    context.Genres.Add(genre);
                    context.SaveChanges();
                    MessageBox.Show("Added genre successfully", "Success");
                }
            }
            else
            {
                MessageBox.Show("Bad genre", "Error");
            }
        }

        private void addItemTypeButton_Click(object sender, EventArgs e)
        {
            if(addItemTypeTextBox.Text.All(Char.IsLetter) && addItemTypeTextBox.Text.Length > 2)
            {
                if (MessageBox.Show("Are you sure you want to add item type : " + addItemTypeTextBox.Text + " ? ", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ItemType itemType = new ItemType(addItemTypeTextBox.Text);
                    context.ItemTypes.Add(itemType);
                    context.SaveChanges();
                    MessageBox.Show("Added item type successfully", "Success");
                }
            }
            else
            {
                MessageBox.Show("Bad item type", "Error");
            }
        }
    }
}
