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

namespace rental_app.Forms
{
    public partial class ControlForm : Form
    {
        RentalAppContext context = new RentalAppContext();
        public ControlForm()
        {
            InitializeComponent();
            helloLabel.Text += LoginForm.username;
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rentForm = new RentForm();
            rentForm.Closed += (s, args) => this.Close();
            rentForm.Show();
        }
    }
}
