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
    public partial class AdminSettingsControlForm : Form
    {
        public AdminSettingsControlForm()
        {
            InitializeComponent();
        }

        private void displayUserRentalsButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminSettingsControlForm_Load(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var controlForm = new ControlForm();
            controlForm.Closed += (s, args) => this.Close();
            controlForm.Show();
        }

        private void manageItemsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var adminItemsManagementForm = new AdminItemsManagementForm();
            adminItemsManagementForm.Closed += (s, args) => this.Close();
            adminItemsManagementForm.Show();
        }
    }
}
