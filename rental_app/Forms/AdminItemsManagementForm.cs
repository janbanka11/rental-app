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
        List<Genres> genres = new List<Genres>();
        List<ItemType> itemTypes = new List<ItemType>();
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
        private void reloadChangesInGenresGridView()
        {
            genresGridView.DataSource = context.Genres.ToList();
        }
        private void reloadChangesInItemTypesGridView()
        {
            itemTypesGridView.DataSource = context.ItemTypes.ToList();
        }
        private void AdminItemsManagementForm_Load(object sender, EventArgs e)
        {
            items = context.Items.ToList();
            reloadChangesInItemGridView();
            reloadChangesInGenresGridView();
            reloadChangesInItemTypesGridView();
        }
        bool checkIfItemDataIsNotNull()
        {
            return genreIdTextBox.Text.Length != 0 && typeIdTextBox.Text.Length != 0 && authorTextBox.Text.Length != 0 && titleTextBox.Text.Length != 0 && priceTextBox.Text.Length != 0;
        }

        bool checkIfEnteredItemIsCorrect()
        {
            var largestGenreId = context.Genres.OrderBy(i => i.GenresId).Last().GenresId;
            if (!genreIdTextBox.Text.All(Char.IsDigit)
                || genreIdTextBox.Text.Length == 0
                || Int32.Parse(genreIdTextBox.Text) < 0
                || Int32.Parse(genreIdTextBox.Text) > largestGenreId)
            {
                addItemErrorLabel.Text += " wrong genres id";
                return false;
            }

            var largestItemByTypeId = context.ItemTypes.OrderBy(i => i.ItemTypeId).Last().ItemTypeId;

            if (!typeIdTextBox.Text.All(Char.IsDigit)
                || Int32.Parse(typeIdTextBox.Text) < 0
                || Int32.Parse(typeIdTextBox.Text) > largestItemByTypeId)
            {
                addItemErrorLabel.Text += " wrong type id";
                return false;
            }

            if (authorTextBox.Text.Length == 0)
            {
                addItemErrorLabel.Text += " wrong author";
                return false;
            }

            if (titleTextBox.Text.Length == 0)
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
            if (!checkIfItemDataIsNotNull())
            {
                return;
            }
            if (!checkIfEnteredItemIsCorrect())
            {
                return;
            }

            Item item = new Item(
                Int32.Parse(genreIdTextBox.Text),
                Int32.Parse(typeIdTextBox.Text),
                authorTextBox.Text,
                titleTextBox.Text,
                Int32.Parse(priceTextBox.Text));

            if (MessageBox.Show("Are you sure you want to add item " + titleTextBox.Text + " ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Add(item);
                context.SaveChanges();
                MessageBox.Show("Added item successfully", "Success");
                reloadChangesInItemGridView();
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            Rental rental = context.Rentals.Include(r => r.Customer).FirstOrDefault(r => r.ItemId == Int32.Parse(itemIdToRemoveTextBox.Text));
            if(rental != null)
            {
                MessageBox.Show("This item is currently rented by user: " + rental.Customer.Username, "Error");
                return;
            }
            if (itemIdToRemoveTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bad item ID", "Error");
                return;
            }
            Item itemToRemove = context.Items.FirstOrDefault(i => i.ItemId == Int32.Parse(itemIdToRemoveTextBox.Text));
            if (itemToRemove == null)
            {
                MessageBox.Show("Item with id:" + itemIdToRemoveTextBox.Text + " doesn't exist", "Error");
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Items.Remove(itemToRemove);
                context.SaveChanges();
                MessageBox.Show("Removed item successfully", "Success");
                reloadChangesInItemGridView();
            }
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            if (!addGenreTextBox.Text.All(Char.IsLetter) || addGenreTextBox.Text.Length < 2)
            {
                MessageBox.Show("Bad genre", "Error");
                return;
            }
            Genres genre = context.Genres.FirstOrDefault(i => i.Genre == addGenreTextBox.Text);
            if (genre != null)
            {
                MessageBox.Show("Genre already exists", "Error");
                return;
            }

            if (MessageBox.Show("Are you sure you want to add genre: " + addGenreTextBox.Text + " ? ", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Genres resultGenre = new Genres(addGenreTextBox.Text);
                context.Genres.Add(resultGenre);
                context.SaveChanges();
                reloadChangesInGenresGridView();
                MessageBox.Show("Added genre: " + resultGenre.Genre, "Success");
            }

        }

        private void addItemTypeButton_Click(object sender, EventArgs e)
        {
            if (!addItemTypeTextBox.Text.All(Char.IsLetter) || addItemTypeTextBox.Text.Length < 2)
            {
                MessageBox.Show("Bad item type", "Error");
                return;
            }
            ItemType itemType = context.ItemTypes.FirstOrDefault(it => it.Type == addItemTypeTextBox.Text);
            if (itemType != null)
            {
                MessageBox.Show("Item type already exists", "Error");
                return;
            }

            if (MessageBox.Show("Are you sure you want to add item type : " + addItemTypeTextBox.Text + " ? ", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ItemType resultItemType = new ItemType(addItemTypeTextBox.Text);
                context.ItemTypes.Add(resultItemType);
                context.SaveChanges();
                reloadChangesInItemTypesGridView();
                MessageBox.Show("Added item type successfully", "Success");
            }
        }

        private void removeGenreButton_Click(object sender, EventArgs e)
        {
            if (genreIdToRemoveTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bad genre ID", "Error");
                return;
            }
            Genres genreToRemove = context.Genres.FirstOrDefault(g => g.GenresId == Int32.Parse(genreIdToRemoveTextBox.Text));
            if (genreToRemove == null)
            {
                MessageBox.Show("Genre with id:" + genreIdToRemoveTextBox.Text + " doesn't exist", "Error");
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove this genre?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Genres.Remove(genreToRemove);
                context.SaveChanges();
                MessageBox.Show("Removed genre successfully", "Success");
                reloadChangesInGenresGridView();
            }
        }

        private void removeItemTypeButton_Click(object sender, EventArgs e)
        {
            if (itemTypeIdToRemoveTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bad item type ID", "Error");
                return;
            }
            ItemType itemTypeToRemove = context.ItemTypes.FirstOrDefault(it => it.ItemTypeId == Int32.Parse(itemTypeIdToRemoveTextBox.Text));
            if (itemTypeToRemove == null)
            {
                MessageBox.Show("Item type with id:" + itemIdToRemoveTextBox.Text + " doesn't exist", "Error");
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove this item type?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.ItemTypes.Remove(itemTypeToRemove);
                context.SaveChanges();
                MessageBox.Show("Removed item type successfully", "Success");
                reloadChangesInItemTypesGridView();
            }
        }
    }
}
