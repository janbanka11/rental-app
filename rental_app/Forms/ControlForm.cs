using rental_app.Data;
using rental_app.Models;


namespace rental_app.Forms
{
    public partial class ControlForm : Form
    {
        RentalAppContext context = new RentalAppContext();
        public static Customer currentlyLoggedCustomer;

        public ControlForm()
        {
            InitializeComponent();
            helloLabel.Text += LoginForm.username;
            currentlyLoggedCustomer = context.Customers.First(i => i.Username == LoginForm.username);
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rentForm = new RentForm();
            rentForm.Closed += (s, args) => this.Close();
            rentForm.Show();
        }

        private void rentalsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userRentalsForm = new UserRentalsForm();
            userRentalsForm.Closed += (s, args) => this.Close();
            userRentalsForm.Show();
        }
    }
}
