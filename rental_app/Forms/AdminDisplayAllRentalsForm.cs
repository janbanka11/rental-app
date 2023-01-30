using rental_app.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using rental_app.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace rental_app.Forms
{
    public partial class AdminDisplayAllRentalsForm : Form
    {
        RentalAppContext context = new RentalAppContext();
        public AdminDisplayAllRentalsForm()
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
        private void reloadRentalsGridView()
        {
            List<RentalDTO> rentals = new List<RentalDTO>();

            var r = context.Rentals
                    .Include(i => i.Customer)
                    .Include(i => i.Item).ThenInclude(g => g.ItemType);


            foreach (var rental in r)
            {
                rentals.Add(new RentalDTO(rental.RentalId, rental.Customer.Name, rental.Item.ItemType.Type, rental.Item.Title, rental.RentalStart, rental.RentalEnd, rental.RentalPrice));
            }
            rentalsGridView.DataSource = rentals;
        }
        private void AdminDisplayAllRentalsForm_Load(object sender, EventArgs e)
        {
            reloadRentalsGridView();
        }

        private void removeRentalButton_Click(object sender, EventArgs e)
        {
            var cellValue = rentalsGridView.Rows[rentalsGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Rental rental = context.Rentals.FirstOrDefault(r => r.RentalId == Int32.Parse(cellValue));
            if (rental == null) return;

            if (MessageBox.Show("Are you sure you want to delete rental with id: '" + rental.RentalId + "' ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Rentals.Remove(rental);
                context.SaveChanges();
                MessageBox.Show("Successfully deleted rental", "Success");
                reloadRentalsGridView();
            }
        }
    }
}
