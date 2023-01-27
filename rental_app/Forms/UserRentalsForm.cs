using Microsoft.EntityFrameworkCore;
using rental_app.Data;
using rental_app.Models;
using rental_app.Utils;

namespace rental_app.Forms
{
    public partial class UserRentalsForm : Form
    {
        RentalAppContext context = new RentalAppContext();
        List<RentalDTO> rentals = new List<RentalDTO>();
        public UserRentalsForm()
        {
            InitializeComponent();
        }
        private void initGridViewWithRentalInfo()
        {
            var r = context.Rentals
                    .Include(i => i.Customer).Where(g => g.Customer.Username == ControlForm.currentlyLoggedCustomer.Username)
                    .Include(i => i.Item).ThenInclude(g => g.ItemType);


            foreach (var rental in r)
            {
                rentals.Add(new RentalDTO(rental.RentalId, rental.Customer.Name, rental.Item.ItemType.Type, rental.Item.Title, rental.RentalStart, rental.RentalEnd, rental.RentalPrice));
            }
            itemsGridView.DataSource = rentals;
            dataGridViewUtils.userRentalFormColumnHeadersStyle(itemsGridView);
        }
        private decimal getSumPriceOfItemsByType(string type)
        {
            decimal sum = 0;

            foreach (var rental in rentals)
            {
                if (rental.ItemType == type)
                {
                    sum += rental.RentalPrice;
                }
            }

            return sum;
        }
        private void initSumLabels()
        {
            decimal movieSum = 0, audiobookSum = 0, cdDiscSum = 0, totalSum = 0;
            movieSum = getSumPriceOfItemsByType("Movie");
            audiobookSum = getSumPriceOfItemsByType("Audiobook");
            cdDiscSum = getSumPriceOfItemsByType("CD_Disc");
            totalSum = movieSum + audiobookSum + cdDiscSum;


            audiobookBillLabel.Text += audiobookSum + " zł";
            moviesBillLabel.Text += movieSum + " zł";
            cdDiscBillLabel.Text += cdDiscSum + " zł";
            sumBillLabel.Text += totalSum + " zł";
        }

        private RentalDTO findFirstEndDate()
        {
            var tempRentalDTO = rentals;
            tempRentalDTO.Sort();
            return tempRentalDTO.First();
        }
        public void initSoonToBeReturnedLabels()
        {
            var rental = findFirstEndDate();
            endDateLabel.Text += rental.RentalEnd;
            titleLabel.Text += rental.ItemTitle;
        }

        private void UserRentalsForm_Load(object sender, EventArgs e)
        {
            initGridViewWithRentalInfo();
            if (rentals.Count != 0)
            {
                initSumLabels();
                initSoonToBeReturnedLabels();
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var controlForm = new ControlForm();
            controlForm.Closed += (s, args) => this.Close();
            controlForm.Show();
        }
    }
}
