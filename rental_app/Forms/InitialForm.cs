using Microsoft.EntityFrameworkCore;
using rental_app.Data;

namespace rental_app
{

    public partial class InitialForm : Form
    {
        RentalAppContext context = new RentalAppContext();
        public InitialForm()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //context.Customers.Load();

            //this.customerBindingSource.DataSource =
            //    context.Customers.Local.ToBindingList();
        }
    }
}