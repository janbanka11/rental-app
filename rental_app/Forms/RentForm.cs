﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using rental_app.Data;
using rental_app.Models;
using System.Data;
using rental_app.Utils;

namespace rental_app.Forms
{
    public partial class RentForm : Form
    {
        RentalAppContext context = new RentalAppContext();
        List<ItemDTO> moviesList = new List<ItemDTO>();
        List<ItemDTO> audiobooksList = new List<ItemDTO>();
        List<ItemDTO> cdDiscsList = new List<ItemDTO>();
        public RentForm()
        {
            InitializeComponent();
        }
        private List<ItemDTO> getItemsListByType(string type)
        {
            var itemsByType = context.Items
                       .Include(i => i.Genres)
                       .Include(i => i.ItemType).Where(g => g.ItemType.Type == type);

            List<ItemDTO> itemsByTypeList = new List<ItemDTO>();
            foreach (var item in itemsByType)
            {
                itemsByTypeList.Add(new ItemDTO(item.ItemId, item.Genres.Genre, item.ItemType.Type, item.Author, item.Title, item.Price));
            }
            return itemsByTypeList;
        }
        private void updateItemsList()
        {
            context.Items.Load();
            moviesList = getItemsListByType("Movie");
            audiobooksList = getItemsListByType("Audiobook");
            cdDiscsList = getItemsListByType("CD_Disc");
        }
        private void updateDataGridViewSource(List<ItemDTO> items, string currentViewLabelStr)
        {
            itemsGridView.DataSource = items;
            dataGridViewUtils.rentFormColumnHeadersStyle(itemsGridView);
            currentViewLabel.Text = currentViewLabelStr;
        }
        private void RentForm_Load(object sender, EventArgs e)
        {
            updateItemsList();
        }

        private void movieSourceButton_Click(object sender, EventArgs e)
        {
            updateDataGridViewSource(moviesList, "Movies");
        }

        private void audiobookSourceButton_Click(object sender, EventArgs e)
        {
            updateDataGridViewSource(audiobooksList, "Audiobooks");
        }

        private void cdDiscSourceButton_Click(object sender, EventArgs e)
        {
            updateDataGridViewSource(cdDiscsList, "CD Discs");
        }

        private void userRentButton_Click(object sender, EventArgs e)
        {
            var cellValue = itemsGridView.Rows[itemsGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (cellValue.IsNullOrEmpty()) 
            { 
                MessageBox.Show("Select item to rent!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int customerId = ControlForm.currentlyLoggedCustomer.CustomerId;
            int itemId = Int32.Parse(cellValue);
            DateTime startOfRentalDate = DateTime.Now;
            DateTime endOfRentalDate = startOfRentalDate.AddDays(30);
            decimal price = Int32.Parse(itemsGridView.Rows[itemsGridView.CurrentCell.RowIndex].Cells[5].Value.ToString());
            Rental rental = new Rental(
                customerId,
                itemId,
                startOfRentalDate,
                endOfRentalDate,
                price
            );
            context.Add(rental);
            context.SaveChanges();
        }
    }
}
