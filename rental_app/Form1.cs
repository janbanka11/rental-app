using Microsoft.EntityFrameworkCore;
using rental_app.Data;

namespace rental_app
{

    public partial class Form1 : Form
    {
        RentalAppContext context = new RentalAppContext();
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context.Customers.Load();

            this.customerBindingSource.DataSource =
                context.Customers.Local.ToBindingList();
        }
    }
}